using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Enigma.D3.Explorer.Views
{
	public abstract class PollView : IView
	{
		private DispatcherTimer _timer;
		private ContentControl _root = new ContentControl();
		private object _content = null;
		private object _error = null;

		public PollView()
		{
			App.CurrentEngineChanged += UpdateTimerBasedOnMemoryType;
		}

		private void UpdateTimerBasedOnMemoryType(Engine engine)
		{
			var timer = _timer;
			if (timer != null)
			{
				timer.Interval = TimeSpan.FromSeconds(1);
				if (engine != null)
				{
					if (engine.Memory.Reader is ProcessMemoryReader)
					{
						timer.Interval = TimeSpan.FromMilliseconds(1);
					}
					else if (engine.Memory.Reader is MiniDumpMemoryReader)
					{
						timer.IsEnabled = false;
						OnTimerTick(timer, EventArgs.Empty); // trigger a single update
						return;
					}
				}
				timer.IsEnabled = true;
			}
		}

		public object Content
		{
			get
			{
				return _root;
			}
			protected set
			{
				_content = value;
			}
		}

		public MenuItem[] ContextMenuItems { get; protected set; }

		public object ErrorContent
		{
			get { return _error; }
			protected set
			{
				_error = value;
				if (_error == null)
				{
					// Clear Error
					_root.Content = _content;
				}
				else if (_root.Content != value)
				{
					// Set Error
					_root.Content = value;
				}
			}
		}

		public virtual void Enter()
		{
			if (_timer == null)
			{
				_timer = new DispatcherTimer();
				_timer.Interval = TimeSpan.Zero;
				_timer.Tick += OnTimerTick;
			}
			_timer.Start();
			UpdateTimerBasedOnMemoryType(Engine.Current);
		}

		private void OnTimerTick(object sender, EventArgs e)
		{
			try
			{
				Refresh();
				ErrorContent = null;
			}
			catch (Exception exception)
			{
				var engine = Engine.Current;
				if (engine == null || !engine.Memory.Reader.IsValid)
				{
					ErrorContent = "Diablo III does not appear to be running.";
				}
				else
				{
					ErrorContent = exception.ToString();
				}
			}
		}

		public virtual void Leave()
		{
			_timer.Stop();
		}

		public virtual void Refresh() { }

		protected Engine GetEngine()
		{
			var engine = Engine.Current;
			if (engine == null || !engine.Memory.Reader.IsValid)
			{
				throw new InvalidOperationException("Diablo III does not appear to be running.");
			}
			return engine;
		}
	}
}
