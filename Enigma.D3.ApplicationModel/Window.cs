using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Enigma.D3.ApplicationModel
{
    public class Window
    {
        public IntPtr Handle { get; internal set; }

        public Int32Rect ClientRect { get; internal set; }

        internal static Int32Rect GetClientRect(IntPtr windowHandle)
        {
            Int32Rect clientRect;
            Win32.GetClientRect(windowHandle, out clientRect);
            Win32.ClientToScreen(windowHandle, ref clientRect);
            return clientRect;
        }

        private static class Win32
        {
            private const string User32 = "user32.dll";

            [DllImport(User32)]
            internal static extern bool GetClientRect(IntPtr windowHandle, out Int32Rect clientRect);

            [DllImport(User32)]
            internal static extern bool ClientToScreen(IntPtr windowHandle, ref Int32Rect point);
        }
    }
}
