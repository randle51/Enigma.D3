using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.IO;

namespace Enigma
{
	public class ProcessMemory : IDisposable
	{
		private readonly Process _process;

		public ProcessMemory(Process process)
		{
			if (process == null)
				throw new ArgumentNullException("process");
			_process = process;
		}

		public Process Process { get { return _process; } }

		public bool IsValid { get { return !_process.HasExited; } }

		public int NativeCalls { get; private set; }

		public T Read<T>(int address)
		{
			if (TypeHelper<T>.IsMemoryObject)
			{
				return (T)MemoryObject.UnsafeCreate(typeof(T), this, address);
			}
			else
			{
				byte[] buffer = ReadBytes(address, StructHelper<T>.SizeOf);
				return StructHelper<T>.Read(buffer, 0);
			}
		}

		public T[] Read<T>(int address, int count)
		{
			var type = typeof(T);
			int sizeOf = TypeHelper<T>.SizeOf;

			T[] array = new T[count];
			if (TypeHelper<T>.IsMemoryObject)
			{
				for (int i = 0; i < count; i++)
				{
					array[i] = (T)MemoryObject.UnsafeCreate(type, this, address + i * sizeOf);
				}
			}
			else
			{
				byte[] buffer = ReadBytes(address, sizeOf * count);
				for (int i = 0; i < count; i++)
				{
					array[i] = StructHelper<T>.Read(buffer, i * sizeOf);
				}
			}
			return array;
		}

		public byte[] ReadBytes(int address, int count)
		{
			if (address < 0)
				throw new ArgumentOutOfRangeException("address");
			if (count < 0)
				throw new ArgumentOutOfRangeException("count");

			byte[] buffer = new byte[count];
			return ReadBytes(address, buffer);
		}

		public byte[] ReadBytes(int address, byte[] buffer)
		{
			if (address < 0)
				throw new ArgumentOutOfRangeException("address");
			if (buffer == null)
				throw new ArgumentNullException("buffer");
			if (buffer.Length == 0)
				return buffer;

			int numberOfBytesRead;
			try
			{
				NativeCalls++;
				if (Win32.ReadProcessMemory(
					_process.Handle,
					address,
					buffer,
					buffer.Length,
					out numberOfBytesRead))
				{
					ValidateNumberOfBytesRead(address, numberOfBytesRead, buffer.Length);
					return buffer;
				}
				else
				{
					throw new Win32Exception();
				}
			}
			catch (Exception exception)
			{
				OnReadException(address, exception);
				return buffer;
			}
		}

		public byte[] ReadBytes(int address, byte[] buffer, int offset, int count)
		{
			if (address < 0)
				throw new ArgumentOutOfRangeException("address");
			if (buffer == null)
				throw new ArgumentNullException("buffer");
			if (offset < 0)
				throw new ArgumentOutOfRangeException("offset");
			if (count < 0)
				throw new ArgumentOutOfRangeException("count");
			if (offset + count > buffer.Length)
				throw new ArgumentOutOfRangeException();

			var handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
			try
			{
				int numberOfBytesRead;
				try
				{
					NativeCalls++;
					int bytesToRead = count != 0 ? count : (buffer.Length - offset);
					if (Win32.ReadProcessMemory(
						_process.Handle,
						address,
						handle.AddrOfPinnedObject() + offset,
						bytesToRead,
						out numberOfBytesRead))
					{
						ValidateNumberOfBytesRead(address, numberOfBytesRead, bytesToRead);
						return buffer;
					}
					else
					{
						throw new Win32Exception();
					}
				}
				catch (Exception exception)
				{
					OnReadException(address, exception);
					return buffer;
				}
			}
			finally
			{
				handle.Free();
			}
		}

		public void CreateDump(string filePath, bool overwrite = false)
		{
			if (string.IsNullOrEmpty(filePath))
				throw new ArgumentNullException("filePath");
			if (_process.HasExited)
				throw new InvalidOperationException("Process has exited.");

			Debug.WriteLine("Dumping process memory.");
			var stopwatch = System.Diagnostics.Stopwatch.StartNew();

			Win32.MemoryBasicInfo info;
			int infoSize = Marshal.SizeOf(typeof(Win32.MemoryBasicInfo));
			List<Win32.MemoryBasicInfo> infoList = new List<Win32.MemoryBasicInfo>();

			var fileMode = overwrite ? FileMode.Create : FileMode.CreateNew;
			using (var file = new FileStream(filePath, fileMode, FileAccess.Write, FileShare.None, 64 * 1024, FileOptions.SequentialScan))
			using (var writer = new StreamWriter(file))
			{
				_process.Suspend();
				try
				{
					int address = 0;
					while (address >= 0 && Win32.VirtualQueryEx(_process.Handle, address, out info, infoSize) == infoSize)
					{
						infoList.Add(info);
						address += info.RegionSize;
					}

					writer.WriteLine("Stored,BaseAddress,AllocationBase,AllocationProtect,RegionSize,State,Protect,Type");
					foreach (var item in infoList)
					{
						const string hex = "X8";
						writer.WriteLine(string.Join(",",
							item.ShouldStore,
							"0x" + item.BaseAddress.ToString(hex),
							"0x" + item.AllocationBase.ToString(hex),
							"0x" + ((int)item.AllocationProtect).ToString(hex),
							"0x" + item.RegionSize.ToString(hex),
							"0x" + ((int)item.State).ToString(hex),
							"0x" + ((int)item.Protect).ToString(hex),
							"0x" + ((int)item.Type).ToString(hex)));
					}
					writer.Flush();
					file.WriteByte(0);

					foreach (var item in infoList.Where(a => a.ShouldStore))
					{
						byte[] buffer = ReadBytes(item.BaseAddress, item.RegionSize);
						file.Write(buffer, 0, buffer.Length);
					}
				}
				finally
				{
					_process.Resume();
				}
			}

			stopwatch.Stop();
			Debug.WriteLine("Dumping process memory took " + stopwatch.ElapsedMilliseconds + "ms.");
		}

		public void Dispose()
		{
			_process.Dispose();
		}

		[Conditional("DEBUG")]
		private void ValidateNumberOfBytesRead(int address, int numberOfBytesRead, int numberOfBytesExpected)
		{
			if (numberOfBytesRead != numberOfBytesExpected)
			{
				Debug.WriteLine("{0}({1:X8}): numberOfBytesRead ({2}) != size ({3})",
					address, numberOfBytesRead, numberOfBytesExpected);
			}
		}

		[Conditional("DEBUG")]
		private void OnReadException(int address, Exception exception)
		{
			Debug.WriteLine("{0}({1:X8}): {2}", "ProcessMemory.Read", address, exception.Message);
		}

		#region Win32
		private static class Win32
		{
			private const string Kernel32 = "kernel32.dll";

			[DllImport(Kernel32, SetLastError = true)]
			public static extern bool ReadProcessMemory(
				IntPtr processHandle,
				int baseAddress,
				IntPtr bufferPtr,
				int size,
				out int numberOfBytesRead);

			[DllImport(Kernel32, SetLastError = true)]
			public static extern bool ReadProcessMemory(
				IntPtr processHandle,
				int baseAddress,
				byte[] buffer,
				int size,
				out int numberOfBytesRead);

			[DllImport(Kernel32, SetLastError = true)]
			public static extern int VirtualQueryEx(
				IntPtr processHandle,
				int address,
				out MemoryBasicInfo memoryBasicInfo,
				int size);

			[DllImport(Kernel32)]
			public static extern void GetSystemInfo(ref SystemInfo systemInfo);

			public struct SystemInfo
			{
				public int OemId;
				public int PageSize;
				public int MinimumApplicationAddress;
				public int MaximumApplicationAddress;
				public int ActiveProcessorMask;
				public int NumberOfProcessors;
				public int ProcessorType;
				public int AllocationGranularity;
				public short ProcessorLevel;
				public short ProcessorRevision;
			}

			public struct MemoryBasicInfo
			{
				public int BaseAddress;
				public int AllocationBase;
				public AllocationProtect AllocationProtect;
				public int RegionSize;
				public AllocationType State;
				public AllocationProtect Protect;
				public AllocationType Type;

				public bool ShouldStore
				{
					get
					{
						return !Protect.HasFlag(Win32.AllocationProtect.PageGuard) &&
							State == Win32.AllocationType.MemCommit &&
							Type == Win32.AllocationType.MemPrivate;
					}
				}
			}

			[Flags]
			public enum AllocationProtect : uint
			{
				PageNoAccess = 0x00000001,
				PageReadOnly = 0x00000002,
				PageReadWrite = 0x00000004,
				PageWriteCopy = 0x00000008,
				PageExecute = 0x00000010,
				PageExecuteRead = 0x00000020,
				PageExecuteReadWrite = 0x00000040,
				PageExecuteReadCopy = 0x00000080,
				PageGuard = 0x00000100,
				PageNoCache = 0x00000200,
				PageWriteCombine = 0x00000400
			}

			[Flags]
			public enum AllocationType : uint
			{
				MemCommit = 0x00001000,
				MemReserve = 0x00002000,
				MemFree = 0x00010000,
				MemPrivate = 0x00020000,
				MemMapped = 0x00040000,
				MemReset = 0x00080000,
				MemImage = 0x01000000,
			}
		}
		#endregion
	}
}
