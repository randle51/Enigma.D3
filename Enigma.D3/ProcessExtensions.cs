using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
