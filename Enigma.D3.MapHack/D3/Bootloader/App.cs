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

namespace Enigma.D3.Bootloader
{
	internal class App : Application
	{
		[STAThread]
		public static void Main()
		{
			var app = new App();
			app.Run();
		}

		protected override void OnStartup(StartupEventArgs e)
		{
			MainWindow = Shell.Instance;
			MainWindow.Show();
			ShutdownMode = ShutdownMode.OnMainWindowClose;

			Task.Factory.StartNew(() =>
			{
				while (true)
				{
					using (var engine = CreateEngine())
					using (var watcher = new WatcherThread(engine))
					{
						Shell.Instance.IsAttached = true;
						Minimap minimap = null;
						OverlayWindow overlay = null;
						Execute.OnUIThread(() =>
						{
							Canvas canvas = new Canvas();
							overlay = OverlayWindow.Create(engine.Process, canvas);
							overlay.Show();
							minimap = new Minimap(canvas);
						});
						watcher.AddTask(minimap.Update);
						watcher.Start();
						engine.Process.WaitForExit();
						Execute.OnUIThread(() => overlay.Close());
					}
					Shell.Instance.IsAttached = false;
					//Execute.OnUIThread(() => MainWindow.Close());
				}
			}, TaskCreationOptions.LongRunning);
		}

		private Engine CreateEngine()
		{
			Engine engine = Engine.Create();
			while (engine == null)
			{
				Thread.Sleep(1000);
				engine = Engine.Create();
			}
			while (engine.ApplicationLoopCount == 0)
			{
				Thread.Sleep(1000);
			}
			return engine;
		}
	}
}
