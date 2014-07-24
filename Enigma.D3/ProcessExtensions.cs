using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Enigma
{
	public static class ProcessExtensions
	{
		public static Version GetFileVersion(this Process process)
		{
			var fileVersionInfo = FileVersionInfo.GetVersionInfo(process.MainModule.FileName);
			return new Version(
				fileVersionInfo.FileMajorPart,
				fileVersionInfo.FileMinorPart,
				fileVersionInfo.FileBuildPart,
				fileVersionInfo.FilePrivatePart);
		}

		public static bool IsLargeAddressAware(this Process process)
		{
			// Source:
			// http://stackoverflow.com/questions/9054469/how-to-check-if-exe-is-set-as-largeaddressaware

			const int IMAGE_FILE_LARGE_ADDRESS_AWARE = 0x20;

			using (var file = File.Open(process.MainModule.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			using (var reader = new BinaryReader(file))
			{
				if (reader.ReadInt16() != 0x5A4D)
					return false; // No MZ header.

				file.Position = 0x3C;
				var peHeaderLocation = reader.ReadInt32();

				file.Position = peHeaderLocation;
				if (reader.ReadInt32() != 0x4550)
					return false; // No PE header.

				file.Position += 0x12;
				return (reader.ReadInt16() & IMAGE_FILE_LARGE_ADDRESS_AWARE) != 0;
			}
		}

		public static void Suspend(this Process process)
		{
			foreach (ProcessThread thread in process.Threads)
			{
				IntPtr threadHandle = thread.OpenSuspendResume();
				if (threadHandle == IntPtr.Zero)
					continue;

				Check(Win32.SuspendThread(threadHandle), -1);
			}
		}

		public static void Resume(this Process process)
		{
			foreach (ProcessThread thread in process.Threads)
			{
				IntPtr threadHandle = thread.OpenSuspendResume();
				if (threadHandle == IntPtr.Zero)
					continue;

				Check(Win32.ResumeThread(threadHandle), -1);
			}
		}

		// Create a thread handle with access to Suspend/Resume methods.
		private static IntPtr OpenSuspendResume(this ProcessThread thread)
		{
			return Check(Win32.OpenThread(Win32.ThreadAccess.SUSPEND_RESUME, false, (uint)thread.Id), IntPtr.Zero);
		}

		private static T Check<T>(T result, T error)
		{
			if (result.Equals(error))
				throw new Win32Exception();
			return result;
		}

		#region Win32
		private class Win32
		{
			private const string Kernel32 = "kernel32.dll";

			[Flags]
			public enum ThreadAccess : int
			{
				TERMINATE = (0x0001),
				SUSPEND_RESUME = (0x0002),
				GET_CONTEXT = (0x0008),
				SET_CONTEXT = (0x0010),
				SET_INFORMATION = (0x0020),
				QUERY_INFORMATION = (0x0040),
				SET_THREAD_TOKEN = (0x0080),
				IMPERSONATE = (0x0100),
				DIRECT_IMPERSONATION = (0x0200)
			}

			[DllImport(Kernel32, SetLastError = true)]
			public static extern IntPtr OpenThread(
				ThreadAccess desiredAccess,
				bool inheritHandle,
				uint threadId);

			[DllImport(Kernel32, SetLastError = true)]
			public static extern int SuspendThread(
				IntPtr threadHandle);

			[DllImport(Kernel32, SetLastError = true)]
			public static extern int ResumeThread(
				IntPtr threadHandle);
		}
		#endregion
	}
}
