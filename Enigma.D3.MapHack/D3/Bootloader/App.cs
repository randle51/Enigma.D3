using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Controls;
using Enigma.Wpf;
using Enigma.D3.MapHack;
using Enigma.D3.MemoryModel;
using System.Diagnostics;
using Enigma.Memory;

namespace Enigma.D3.Bootloader
{
    internal class App : Application
    {
        [STAThread]
        public static void Main() => new App().Run();

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = Shell.Instance;
            MainWindow.Show();
            ShutdownMode = ShutdownMode.OnMainWindowClose;

            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    using (var ctx = CreateMemoryContext())
                    using (var watcher = new WatcherThread(ctx))
                    {
                        Shell.Instance.IsAttached = true;
                        Minimap minimap = null;
                        OverlayWindow overlay = null;
                        Execute.OnUIThread(() =>
                        {
                            Canvas canvas = new Canvas();
                            overlay = OverlayWindow.Create((ctx.Memory.Reader as ProcessMemoryReader).Process, canvas);
                            overlay.Show();
                            minimap = new Minimap(canvas);
                        });
                        watcher.AddTask(minimap.Update);
                        watcher.Start();
                        (ctx.Memory.Reader as ProcessMemoryReader).Process.WaitForExit();
                        Execute.OnUIThread(() => overlay.Close());
                    }
                    Shell.Instance.IsAttached = false;
                }
            }, TaskCreationOptions.LongRunning);
        }

        private MemoryContext CreateMemoryContext()
        {
            var ctx = default(MemoryContext);

            // Wait for process attachment.
            while ((ctx = MemoryContext.FromProcess()) == null)
                Thread.Sleep(1000);

            // Wait for full initialization.
            while (ctx.DataSegment.ApplicationLoopCount == 0)
                Thread.Sleep(1000);

            return ctx;
        }
    }
}
