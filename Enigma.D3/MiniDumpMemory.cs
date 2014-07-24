using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Enigma
{
	public class MiniDumpMemory : MemoryBase
	{
		private struct Page
		{
			public uint StartOfMemoryRange;
			public uint DataSize;
			public uint Rva;

			public bool Contains(int address)
			{
				return address >= StartOfMemoryRange && address < StartOfMemoryRange + DataSize;
			}

			public int TranslateToRva(int address)
			{
				return (int)(Rva + address - StartOfMemoryRange);
			}
		}

		private readonly FileStream _file;
		private readonly List<Page> _pages;
		private readonly List<int> _pageStarts;
		private readonly uint _minValidAddress;
		private readonly uint _maxValidAddress;

		public MiniDumpMemory(string path)
		{
			Path = path;
			_file = File.OpenRead(path);

			var mem = new FileMemory(path);

			var header = mem.Read<MiniDumpHeader>(0x00);
			var dirs = mem.Read<MiniDumpDirectory>((int)header.StreamDirectoryRva, (int)header.NumberOfStreams);

			var moduleList = dirs.SingleOrDefault(a => a.StreamType == MiniDumpStreamType.ModuleListStream);
			var modules = mem.Read<MiniDumpList<MiniDumpModule>>((int)moduleList.Location.Rva).Items;

			var mainModule = modules.FirstOrDefault(a => a.VersionInfo.FileType == 1);
			var mainModuleName = GetModuleName(mem, mainModule);
			var mainModuleVersion = mainModule.VersionInfo.FileVersion;
			MainModuleVersion = mainModuleVersion;

			//var memoryInfoListDir = dirs.SingleOrDefault(a => a.StreamType == MiniDumpStreamType.MemoryInfoListStream);
			//if (memoryInfoListDir.StreamType == MiniDumpStreamType.MemoryInfoListStream)
			//{
			//	var memoryInfoList = mem.Read<MiniDumpMemoryInfoList>((int)memoryInfoListDir.Location.Rva);
			//	var memoryInfos = mem.Read<MiniDumpMemoryInfo>((int)memoryInfoListDir.Location.Rva + (int)memoryInfoList.SizeOfHeader, (int)memoryInfoList.NumberOfEntries);
			//	var size = memoryInfos.Sum(a => (long)a.RegionSize);
			//}

			var memory64ListDir = dirs.SingleOrDefault(a => a.StreamType == MiniDumpStreamType.Memory64ListStream);
			if (memory64ListDir.StreamType != MiniDumpStreamType.Memory64ListStream)
				throw new InvalidOperationException("The minidump file does not contain a full memory dump.");
			var memory64List = mem.Read<MiniDumpMemory64List>((int)memory64ListDir.Location.Rva);
			var rva = memory64List.BaseRva;
			var ranges = memory64List.MemoryRanges;
			var mappings = new List<Page>();
			for (int i = 0; i < ranges.Length; i++)
			{
				var mapping = new Page
				{
					StartOfMemoryRange = (uint)ranges[i].StartOfMemoryRange,
					DataSize = (uint)ranges[i].DataSize,
					Rva = (uint)rva
				};
				mappings.Add(mapping);
				rva += ranges[i].DataSize;
			}

			_pages = mappings;
			_pageStarts = _pages.Select(a => (int)a.StartOfMemoryRange).ToList();
			_minValidAddress = _pages[0].StartOfMemoryRange;
			_maxValidAddress = _pages.Select(a => a.StartOfMemoryRange + a.DataSize).Last();
		}

		public string Path { get; private set; }

		public Version MainModuleVersion { get; private set; }

		private string GetModuleName(MemoryBase memory, MiniDumpModule module)
		{
			var length = memory.Read<int>((int)module.ModuleNameRva);
			var buffer = memory.ReadBytes((int)module.ModuleNameRva + sizeof(int), length);
			return Encoding.Unicode.GetString(buffer);
		}

		protected override uint MinValidAddress { get { return _minValidAddress; } }

		protected override uint MaxValidAddress { get { return _maxValidAddress; } }

		public override bool IsValid { get { return _file.CanRead; } }

		public override byte[] ReadBytes(int address, byte[] buffer, int offset, int count)
		{
			var pageFrom = GetPageIndex(address);
			var pageTo = GetPageIndex(address + count);

			if (pageFrom == pageTo) // contained in 1 page
			{
				_file.Position = _pages[pageFrom].TranslateToRva(address);
				_file.Read(buffer, offset, count);
				return buffer;
			}
			else
			{
				throw new NotImplementedException();
			}
		}

		private int GetPageIndex(int address)
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
			_file.Dispose();
		}

		#region MiniDump Structures/Enums
		internal struct MiniDumpHeader
		{
			private uint _Signature;
			public uint Version;
			public uint NumberOfStreams;
			public uint StreamDirectoryRva;
			public uint CheckSum;
			private uint _TimeDateStamp;
			public MiniDumpType Flags;

			public string Signature { get { return Encoding.ASCII.GetString(BitConverter.GetBytes(_Signature), 0, 4); } }
			public DateTime TimeDateStamp { get { return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(_TimeDateStamp); } }
		}

		internal struct MiniDumpDirectory
		{
			public MiniDumpStreamType StreamType;
			public MiniDumpLocationDescriptor Location;
		}

		internal struct MiniDumpLocationDescriptor
		{
			public uint DataSize;
			public uint Rva; // RelativeVirtualAddress, begins at file start
		}

		internal class MiniDumpMemory64List : MemoryObject
		{
			public ulong NumberOfMemoryRanges { get { return Field<ulong>(0x00); } }
			public ulong BaseRva { get { return Field<ulong>(0x08); } }
			public MiniDumpMemoryDescriptor64[] MemoryRanges { get { return Field<MiniDumpMemoryDescriptor64>(0x10, (int)NumberOfMemoryRanges); } }
		}

		internal struct MiniDumpMemoryDescriptor64
		{
			public ulong StartOfMemoryRange;
			public ulong DataSize;
		}

		internal struct MiniDumpMemoryInfoList
		{
			public uint SizeOfHeader;
			public uint SizeOfEntry;
			public ulong NumberOfEntries;
		}

		internal struct MiniDumpMemoryInfo
		{
			public ulong BaseAddress;
			public ulong AllocationBase;
			public uint AllocationProtect;
			public uint __alignment1;
			public ulong RegionSize;
			public uint State;
			public uint Protect;
			public uint Type;
			public uint __alignment2;
		}

		internal class MiniDumpList<T> : MemoryObject
		{
			public uint NumberOfItems { get { return Field<uint>(0x00); } }
			public T[] Items { get { return Field<T>(0x04, (int)NumberOfItems); } }
		}

		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		internal struct MiniDumpModule
		{
			public ulong BaseOfImage;
			public uint SizeOfImage;
			public uint CheckSum;
			public uint _TimeDateStamp;
			public uint ModuleNameRva;
			public FixedFileInfo VersionInfo;
			public MiniDumpLocationDescriptor CvRecord;
			public MiniDumpLocationDescriptor MiscRecord;
			public ulong Reserved0;
			public ulong Reserved1;

			public DateTime TimeDateStamp { get { return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(_TimeDateStamp); } }
		}

		internal struct FixedFileInfo
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

		internal enum MiniDumpStreamType : uint
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
		internal enum MiniDumpType : ulong
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
		#endregion
	}
}
