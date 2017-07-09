using Enigma.Memory.PE;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Memory
{
	public class MiniDumpMemoryReader : MemoryReader, IHasMainModuleVersion
	{
		private readonly FileStream _fileStream;
		private readonly MemoryAddress _minValidAddress;
		private readonly MemoryAddress _maxValidAddress;
		private readonly List<Page> _pages;
		private readonly List<ulong> _pageStarts;
		private readonly int _pointerSize;
		private readonly MiniDump.Thread[] _threads;

		public MiniDumpMemoryReader(string path)
		{
			if (string.IsNullOrWhiteSpace(path))
				throw new ArgumentNullException("path");

			_fileStream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read);

			var mem = new FileMemoryReader(path);
			var header = mem.Read<MiniDump.Header>(0x00);
			var dirs = mem.Read<MiniDump.Directory>(header.StreamDirectoryRva, (int)header.NumberOfStreams);

			var moduleList = dirs.SingleOrDefault(a => a.StreamType == MiniDump.StreamType.ModuleListStream);
			if (moduleList.StreamType != MiniDump.StreamType.ModuleListStream)
				throw new InvalidOperationException("The minidump file does not contain a module list.");
			var modules = mem.Read<MiniDump.List<MiniDump.Module>>(moduleList.Location.Rva).Items;

			var threadList = dirs.SingleOrDefault(x => x.StreamType == MiniDump.StreamType.ThreadListStream);
			if (threadList.StreamType == MiniDump.StreamType.ThreadListStream)
				_threads = mem.Read<MiniDump.List<MiniDump.Thread>>(threadList.Location.Rva).Items;

			var mainModule = modules.FirstOrDefault(a => a.VersionInfo.FileType == 1);
			MainModuleVersion = mainModule.VersionInfo.FileVersion;
			ImageBase = mainModule.BaseOfImage;

			var memory64ListDir = dirs.SingleOrDefault(a => a.StreamType == MiniDump.StreamType.Memory64ListStream);
			if (memory64ListDir.StreamType != MiniDump.StreamType.Memory64ListStream)
				throw new InvalidOperationException("The minidump file does not contain a full memory dump.");
			var memory64List = mem.Read<MiniDump.Memory64List>(memory64ListDir.Location.Rva);

			var rva = memory64List.BaseRva;
			var ranges = memory64List.MemoryRanges;
			var pages = new List<Page>();
			for (int i = 0; i < ranges.Length; i++)
			{
				pages.Add(new Page
				{
					StartOfMemoryRange = ranges[i].StartOfMemoryRange,
					DataSize = ranges[i].DataSize,
					Rva = rva
				});
				rva += ranges[i].DataSize;
			}

			_pages = pages;
			_pageStarts = _pages.Select(a => a.StartOfMemoryRange).ToList();
			_minValidAddress = _pages[0].StartOfMemoryRange;
			_maxValidAddress = _pages[_pages.Count - 1].StartOfMemoryRange + _pages[_pages.Count - 1].DataSize;

			var pe = new PEHeaderReader(ReadBytes(ImageBase, 2048));
			_pointerSize = pe.Is32BitHeader ? 4 : 8;
		}

		public override MemoryAddress MinValidAddress { get { return _minValidAddress; } }

		public override MemoryAddress MaxValidAddress { get { return _maxValidAddress; } }

		public MemoryAddress MinUsedAddress { get { return _pages[0].StartOfMemoryRange; } }

		public MemoryAddress MaxUsedAddress { get { return _pages[_pages.Count - 1].StartOfMemoryRange + _pages[_pages.Count - 1].DataSize; } }

		public override bool IsValid { get { return !_fileStream.SafeFileHandle.IsInvalid; } }

		public override int PointerSize { get { return _pointerSize; } }

		public MemoryAddress ImageBase { get; private set; }

		public Version MainModuleVersion { get; private set; }

		public string Path { get { return _fileStream.Name; } }

		public MiniDump.Thread[] Threads => _threads;
        
        protected override void UnsafeReadBytesCore(MemoryAddress address, byte[] buffer, int offset, int count)
        {
            var pageFrom = GetPageIndex(address);
			var pageTo = GetPageIndex(address + (ulong)count);

			if (pageFrom == pageTo)
			{
				_fileStream.Position = (long)_pages[pageFrom].TranslateToRva(address);
				_fileStream.Read(buffer, offset, count);
			}
			else
			{
				var read = 0;
				var remaining = count - read;

				for (int i = pageFrom; i <= pageTo; i++)
				{
					_fileStream.Position = (long)_pages[i].TranslateToRva(address);
					read += _fileStream.Read(buffer, read, Math.Min(remaining, (int)_pages[i].DataSize));
					remaining = count - read;
					address += _pages[i].DataSize;
				}

				if (remaining != 0)
					throw new InvalidDataException("Pages did not contain all bytes.");
			}
        }

		public bool TryReadByte(MemoryAddress address, out byte b)
		{
			int page;
			if (TryGetPageIndex(address, out page))
			{
				_fileStream.Position = (long)_pages[page].TranslateToRva(address);
				b = (byte)_fileStream.ReadByte();
				return true;
			}
			b = 0;
			return false;
		}

		private bool TryGetPageIndex(MemoryAddress address, out int index)
		{
			index = _pageStarts.BinarySearch(address);
			if (index < 0)
			{
				int closest = ~index - 1;
				if (_pages[closest].Contains(address))
				{
					index = closest;
					return true;
				}
				else
				{
					if (closest + 1 < _pages.Count &&
						_pages[closest + 1].Contains(address))
					{
						index = closest + 1;
						return true;
					}
					else
					{
						return false;
					}
				}
			}
			return true;
		}

		private int GetPageIndex(MemoryAddress address)
		{
			int index = _pageStarts.BinarySearch(address);
			if (index < 0)
			{
				int closest = ~index - 1;
				if (_pages[closest].Contains(address))
				{
					return closest;
				}
				else
				{
					if (closest + 1 < _pages.Count &&
						_pages[closest + 1].Contains(address))
					{
						return closest + 1;
					}
					else
					{
						throw new ArgumentException("address");
					}
				}
			}
			return index;
		}

		public override void Dispose()
		{
			_fileStream.Dispose();
		}

		private struct Page
		{
			public ulong StartOfMemoryRange;
			public ulong DataSize;
			public ulong Rva;

			public bool Contains(MemoryAddress address)
			{
				return unchecked((ulong)address >= StartOfMemoryRange && (ulong)address < StartOfMemoryRange + DataSize);
			}

			public ulong TranslateToRva(MemoryAddress address)
			{
				return unchecked(Rva + address - StartOfMemoryRange);
			}
		}

#pragma warning disable 0649 // Disable compiler warnings about unassigned fields (they're marshalled).
		#region MiniDump
		public static class MiniDump
		{
			public struct Header
			{
				private uint _Signature;
				public uint Version;
				public uint NumberOfStreams;
				public uint StreamDirectoryRva;
				public uint CheckSum;
				private uint _TimeDateStamp;
				public Type Flags;

				public string Signature { get { return Encoding.ASCII.GetString(BitConverter.GetBytes(_Signature), 0, 4); } }
				public DateTime TimeDateStamp { get { return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(_TimeDateStamp); } }
			}

			[DebuggerDisplay("{StreamType} RVA {Location.Rva}, Size: {Location.DataSize}")]
			public struct Directory
			{
				public StreamType StreamType;
				public LocationDescriptor Location;
			}

			public struct LocationDescriptor
			{
				public uint DataSize;
				public uint Rva; // RelativeVirtualAddress, begins at file start
			}

			public class List<T> : MemoryObject
			{
				public uint NumberOfItems { get { return Read<uint>(0x00); } }
				public T[] Items { get { return Read<T>(0x04, (int)NumberOfItems); } }
			}

			[StructLayout(LayoutKind.Sequential, Pack = 4)]
			public struct Module
			{
				public ulong BaseOfImage;
				public uint SizeOfImage;
				public uint CheckSum;
				public uint _TimeDateStamp;
				public uint ModuleNameRva;
				public FixedFileInfo VersionInfo;
				public LocationDescriptor CvRecord;
				public LocationDescriptor MiscRecord;
				public ulong Reserved0;
				public ulong Reserved1;

				public DateTime TimeDateStamp { get { return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(_TimeDateStamp); } }
			}

			public struct FixedFileInfo
			{
				public int Signature;
				public int StrucVersion;
				public int FileVersionMS;
				public int FileVersionLS;
				public int ProductVersionMS;
				public int ProductVersionLS;
				public int FileFlagsMask;
				public int FileFlags;
				public int FileOS;
				public int FileType;
				public int FileSubtype;
				public int FileDateMS;
				public int FileDateLS;

				public Version FileVersion { get { return new Version(FileVersionMS >> 16, FileVersionMS & 0xFFFF, FileVersionLS >> 16, FileVersionLS & 0xFFFF); } }
			}

			public struct Thread
			{
				public uint ThreadId;
				public uint SuspendCount;
				public uint PriorityClass;
				public uint Priority;
				public ulong Teb;
				public MemoryDescriptor Stack;
				public LocationDescriptor ThreadContext;
			}

			public class Memory64List : MemoryObject
			{
				public ulong NumberOfMemoryRanges { get { return Read<ulong>(0x00); } }
				public ulong BaseRva { get { return Read<ulong>(0x08); } }
				public MemoryDescriptor64[] MemoryRanges { get { return Read<MemoryDescriptor64>(0x10, (int)NumberOfMemoryRanges); } }
			}

			public struct MemoryDescriptor
			{
				public ulong StartOfMemoryRange;
				public LocationDescriptor Memory;
			}

			public struct MemoryDescriptor64
			{
				public ulong StartOfMemoryRange;
				public ulong DataSize;
			}

			public enum StreamType : uint
			{
				UnusedStream = 0,
				ReservedStream0 = 1,
				ReservedStream1 = 2,
				ThreadListStream = 3,
				ModuleListStream = 4,
				MemoryListStream = 5,
				ExceptionStream = 6,
				SystemInfoStream = 7,
				ThreadExListStream = 8,
				Memory64ListStream = 9,
				CommentStreamA = 10,
				CommentStreamW = 11,
				HandleDataStream = 12,
				FunctionTableStream = 13,
				UnloadedModuleListStream = 14,
				MiscInfoStream = 15,
				MemoryInfoListStream = 16,
				ThreadInfoListStream = 17,
				HandleOperationListStream = 18,
				LastReservedStream = 0xffff
			}

			[Flags]
			public enum Type : ulong
			{
				MiniDumpNormal = 0x00000000,
				MiniDumpWithDataSegs = 0x00000001,
				MiniDumpWithFullMemory = 0x00000002,
				MiniDumpWithHandleData = 0x00000004,
				MiniDumpFilterMemory = 0x00000008,
				MiniDumpScanMemory = 0x00000010,
				MiniDumpWithUnloadedModules = 0x00000020,
				MiniDumpWithIndirectlyReferencedMemory = 0x00000040,
				MiniDumpFilterModulePaths = 0x00000080,
				MiniDumpWithProcessThreadData = 0x00000100,
				MiniDumpWithPrivateReadWriteMemory = 0x00000200,
				MiniDumpWithoutOptionalData = 0x00000400,
				MiniDumpWithFullMemoryInfo = 0x00000800,
				MiniDumpWithThreadInfo = 0x00001000,
				MiniDumpWithCodeSegs = 0x00002000,
				MiniDumpWithoutAuxiliaryState = 0x00004000,
				MiniDumpWithFullAuxiliaryState = 0x00008000,
				MiniDumpWithPrivateWriteCopyMemory = 0x00010000,
				MiniDumpIgnoreInaccessibleMemory = 0x00020000,
				MiniDumpWithTokenInformation = 0x00040000,
				MiniDumpWithModuleHeaders = 0x00080000,
				MiniDumpFilterTriage = 0x00100000,
				MiniDumpValidTypeFlags = 0x001fffff
			}
		}
		#endregion
#pragma warning restore 0649
	}
}
