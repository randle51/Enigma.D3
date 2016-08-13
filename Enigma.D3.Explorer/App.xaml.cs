using Enigma.Memory;
using Enigma.Wpf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Enigma.D3.Explorer
{
	public partial class App : Application
	{
		private static Task _attachEngineTask;
		private static ManualResetEvent _abortSignal = new ManualResetEvent(false);

		public static event Action<Engine> CurrentEngineChanged;

		protected override void OnStartup(StartupEventArgs e)
		{
			ShutdownMode = ShutdownMode.OnMainWindowClose;
			MainWindow = new MainWindow();

			if (e.Args.Length > 0 &&
				File.Exists(Environment.ExpandEnvironmentVariables(e.Args[0])))
			{
				AttachMiniDump(Environment.ExpandEnvironmentVariables(e.Args[0]));
			}
			else
			{
				BeginAttachEngine();
			}

			MainWindow.Show();
		}

		internal static void BeginAttachEngine()
		{
			OnCurrentEngineChanged(null);
			Engine.Unload();
			Execute.OnUIThread(() => Current.MainWindow.Title = "Enigma.D3.Explorer - Attaching to process...");
			var engine = Engine.Create();
			if (engine != null)
			{
				OnCurrentEngineChanged(engine);
				Execute.OnUIThread(() => Current.MainWindow.Title = "Enigma.D3.Explorer - PID " + engine.Process.Id);
			}
			else
			{
				_abortSignal.Reset();
				_attachEngineTask = Task.Factory.StartNew(() =>
				{
					while (!_abortSignal.WaitOne(0))
					{
						if (engine == null || !engine.Memory.Reader.IsValid)
						{
							engine = Engine.Create();
							if (engine != null)
							{
								OnCurrentEngineChanged(engine);
								Execute.OnUIThread(() => Current.MainWindow.Title = "Enigma.D3.Explorer - PID " + engine.Process.Id);
							}
						}
						_abortSignal.WaitOne(1000);
					}
				});
			}
		}

		private static void EndAttachEngine()
		{
			_abortSignal.Set();

			_attachEngineTask?.Wait();
			_attachEngineTask?.Dispose();
			_attachEngineTask = null;
		}

		internal static void AttachMiniDump(string path)
		{
			try
			{
				var minidump = new MiniDumpMemoryReader(path);
				EndAttachEngine();
				OnCurrentEngineChanged(new Engine(new ReadOnlyMemory(minidump)));
				Execute.OnUIThread(() => Current.MainWindow.Title = "Enigma.D3.Explorer - " + minidump.Path);
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
				BeginAttachEngine();
			}
		}

		private static void OnCurrentEngineChanged(Engine engine)
		{
			CurrentEngineChanged?.Invoke(engine);
		}
	}
}
