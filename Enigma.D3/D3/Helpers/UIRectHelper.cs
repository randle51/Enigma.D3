using Enigma.Memory;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Enigma.D3.UI;

namespace Enigma.D3.Helpers
{
	public static class UIRectHelper
	{
		public static UIRect TranslateToClientRect(this UIRect rect, Process process)
		{
			return rect.TranslateToClientRect(process.MainWindowHandle);
		}

		public static UIRect TranslateToClientRect(this UIRect rect, ProcessMemoryReader processMemory)
		{
			return rect.TranslateToClientRect(processMemory.Process.MainWindowHandle);
		}

		public static UIRect TranslateToClientRect(this UIRect rect)
		{
			var processMemory = Engine.Current.Memory.Reader as ProcessMemoryReader;
			if (processMemory != null)
			{
				return rect.TranslateToClientRect(processMemory.Process.MainWindowHandle);
			}
			return rect.TranslateToClientRect(IntPtr.Zero);
		}

		public static UIRect TranslateToClientRect(this UIRect rect, IntPtr windowHandle)
		{
			if (windowHandle != IntPtr.Zero)
			{
				Win32.Rect client;
				if (!Win32.GetClientRect(windowHandle, out client))
					throw new Win32Exception();
				return rect.TranslateToClientRect(client.Width, client.Height);
			}
			return rect;
		}

		private static class Win32
		{
			private const string User32 = "user32.dll";

			[DllImport(User32, SetLastError = true)]
			internal static extern bool GetClientRect(IntPtr windowHandle, out Rect clientRect);

			internal struct Rect
			{
				public int X;
				public int Y;
				public int Width;
				public int Height;
			}
		}
	}
}
