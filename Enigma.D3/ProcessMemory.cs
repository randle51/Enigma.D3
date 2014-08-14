using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.IO;
using Microsoft.Win32.SafeHandles;

namespace Enigma
{
	public class ProcessMemory : MemoryBase, IDisposable
	{
		private readonly Process _process;
		private readonly uint _minValidAddress;
		private readonly uint _maxValidAddress;

		// Assume this is the same for all applications.
		internal const uint MinApplicationAddress = 0x00010000;
		internal const uint MaxApplicationAddress = 0x7FFEFFFF;
		internal const uint MaxApplicationAddressLargeAddressAware = 0xBFFF0000;

		public ProcessMemory(Process process)
		{
			if (process == null)
				throw new ArgumentNullException("process");
			_process = process;

			_minValidAddress = MinApplicationAddress;
			_maxValidAddress = _process.IsLargeAddressAware() ? MaxApplicationAddressLargeAddressAware : MaxApplicationAddress;
		}

		public Process Process { get { return _process; } }

		public override bool IsValid { get { return !_process.HasExited; } }

		public override uint MinValidAddress { get { return _minValidAddress; } }

		public override uint MaxValidAddress { get { return _maxValidAddress; } }

		public int NativeCalls { get; private set; }

		public override void ReadBytes(int address, byte[] buffer)
		{
			if (!IsValidAddress(address))
				throw new ArgumentOutOfRangeException("address");
			if (buffer == null)
				throw new ArgumentNullException("buffer");
			if (buffer.Length == 0)
				return;

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
				}
				else
				{
					throw new Win32Exception();
				}
			}
			catch (Exception exception)
			{
				OnReadException(address, exception);
			}
		}

		public override void ReadBytes(int address, byte[] buffer, int offset, int count)
		{
			if (!IsValidAddress(address))
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
				NativeCalls++;
				int numberOfBytesRead;
				int bytesToRead = count != 0 ? count : (buffer.Length - offset);
				if (Win32.ReadProcessMemory(
					_process.Handle,
					address,
					handle.AddrOfPinnedObject() + offset,
					bytesToRead,
					out numberOfBytesRead))
				{
					ValidateNumberOfBytesRead(address, numberOfBytesRead, bytesToRead);
				}
				else
				{
					throw new Win32Exception();
				}
			}
			catch (Exception exception)
			{
				OnReadException(address, exception);
			}
			finally
			{
				handle.Free();
			}
		}

		public void CreateMiniDump(string filePath, bool overwrite = false)
		{
			if (string.IsNullOrEmpty(filePath))
				throw new ArgumentNullException("filePath");
			if (_process.HasExited)
				throw new InvalidOperationException("Process has exited.");

			Debug.WriteLine("Creating minidump...");
			var stopwatch = System.Diagnostics.Stopwatch.StartNew();

			var fileMode = overwrite ? FileMode.Create : FileMode.CreateNew;
			using (var file = new FileStream(filePath, fileMode, FileAccess.Write, FileShare.None, 64 * 1024, FileOptions.SequentialScan))
			{
				const int MiniDumpWithFullMemory = 0x00000002;
				if (!Win32.MiniDumpWriteDump(_process.Handle, _process.Id, file.SafeFileHandle, MiniDumpWithFullMemory,
					IntPtr.Zero, IntPtr.Zero, IntPtr.Zero))
					throw new Win32Exception();
			}

			stopwatch.Stop();
			Debug.WriteLine("Creating minidump took " + stopwatch.Elapsed.TotalMilliseconds.ToString("0.00") + "ms.");
		}

		public override void Dispose()
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
			private const string DbgHelp = "DbgHelp.dll";

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
			
			[DllImport(Kernel32)]
			public static extern void GetSystemInfo(ref SystemInfo systemInfo);

			[DllImport(DbgHelp, SetLastError = true)]
			public static extern bool MiniDumpWriteDump(
				IntPtr processHandle,
				int processId,
				SafeFileHandle fileHandle,
				int dumpType,
				IntPtr exceptionParam,
				IntPtr userStreamParam,
				IntPtr callbackParam);

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
		}
		#endregion
	}
}
