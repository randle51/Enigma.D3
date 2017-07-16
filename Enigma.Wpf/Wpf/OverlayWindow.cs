using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Media;
using System.Windows.Interop;
using System.Windows.Threading;
using System.Windows.Controls;

namespace Enigma.Wpf
{
    public class OverlayWindow : Window
    {
        public static OverlayWindow Create(Process process, object content)
        {
            if (process == null)
                throw new ArgumentNullException("process");

            Panel root;
            if (content is Panel)
            {
                root = (Panel)content;
            }
            else
            {
                var grid = new Grid();
                if (content != null)
                {
                    grid.Children.Add(new ContentPresenter() { Content = content });
                }
                root = grid;
            }

            var window = new OverlayWindow(process, root);
            return window;
        }

        private Process _process;
        private IntPtr _parentHandle;
        private DispatcherTimer _refreshTimer;
        private Panel _root;

        private OverlayWindow(Process process, Panel root)
        {
            _process = process;
            SetParentHandle(process.MainWindowHandle);

            ResizeMode = ResizeMode.NoResize;
            WindowStyle = WindowStyle.None;
            ShowInTaskbar = false;
            AllowsTransparency = true;
            Background = Brushes.Transparent;
            SnapsToDevicePixels = true;
            SizeToContent = SizeToContent.WidthAndHeight;

            _root = root;
            Content = root;

            _refreshTimer = new DispatcherTimer();
            _refreshTimer.Tick += OnRefreshTick;
            _refreshTimer.Interval = TimeSpan.FromMilliseconds(10);
            _refreshTimer.Start();
        }

        private void SetParentHandle(IntPtr parentHandle)
        {
            _parentHandle = parentHandle;
            //new WindowInteropHelper(this).Owner = parentHandle;
            Topmost = true;
        }

        private void OnRefreshTick(object sender, EventArgs e)
        {
            if (!_refreshTimer.IsEnabled)
                return; // Avoid triggers after timer is disabled.

            OnRefreshLayout();
        }

        private void OnRefreshLayout()
        {
            Int32Rect clientRect = GetClientRect(_parentHandle);
            if (clientRect.IsEmpty)
            {
                _process.Refresh();
                try
                {
                    if (!_process.HasExited && _process.MainWindowHandle != _parentHandle)
                    {
                        SetParentHandle(_process.MainWindowHandle);
                    }
                }
                catch (InvalidOperationException)
                {
                    // There is a chance that _process is disposed but timer triggers late.
                }
            }
            
            var fromDeviceX = PresentationSource.FromVisual(this).CompositionTarget.TransformFromDevice.M11;
            var fromDeviceY = PresentationSource.FromVisual(this).CompositionTarget.TransformFromDevice.M22;
            
            _root.Width = fromDeviceX * clientRect.Width;
            _root.Height = fromDeviceY * clientRect.Height;
            Left = fromDeviceX * clientRect.X;
            Top = fromDeviceY * clientRect.Y;
        }

        private Int32Rect GetClientRect(IntPtr windowHandle)
        {
            Int32Rect clientRect;
            Win32.GetClientRect(windowHandle, out clientRect);
            Win32.ClientToScreen(windowHandle, ref clientRect);
            return clientRect;
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            IntPtr windowHandle = new WindowInteropHelper(this).Handle;
            SetWindowStyleTransparent(windowHandle);
            base.OnSourceInitialized(e);
        }

        private void SetWindowStyleTransparent(IntPtr windowHandle)
        {
            const int WS_EX_TRANSPARENT = 0x00000020;
            const int GWL_EXSTYLE = -20;

            var exStyle = Win32.GetWindowLong(windowHandle, GWL_EXSTYLE);
            Win32.SetWindowLong(windowHandle, GWL_EXSTYLE, exStyle | WS_EX_TRANSPARENT);
        }

        protected override void OnClosed(EventArgs e)
        {
            _refreshTimer.Stop();
            _refreshTimer.Tick -= OnRefreshTick;
            base.OnClosed(e);
        }

        private static class Win32
        {
            private const string User32 = "user32.dll";

            [DllImport(User32)]
            internal static extern bool GetClientRect(IntPtr windowHandle, out Int32Rect clientRect);

            [DllImport(User32)]
            internal static extern bool ClientToScreen(IntPtr windowHandle, ref Int32Rect point);

            [DllImport(User32)]
            internal static extern int GetWindowLong(IntPtr windowHandle, int index);

            [DllImport(User32)]
            internal static extern int SetWindowLong(IntPtr windowHandle, int index, int newStyle);
        }
    }
}
