using Enigma.D3.MemoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Enigma.D3.Bootloader
{
	internal class WatcherThread : IDisposable
	{
		private MemoryContext _ctx;
		private Timer _timer;
		private readonly object _timerLock = new object();
		private const int _defaultUpdateInterval = 10;
		private List<Action<MemoryContext>> _tasks = new List<Action<MemoryContext>>();
		private readonly object _tasksLock = new object();

		public WatcherThread(MemoryContext ctx)
			: this(ctx, _defaultUpdateInterval) { }

		public WatcherThread(MemoryContext ctx, int updateInterval)
		{
			_ctx = ctx;
			_timer = new Timer(OnTick, null, Timeout.Infinite, updateInterval);
		}

		public void Start()
		{
			_timer.Change(0, _defaultUpdateInterval);
		}

		public void Stop()
		{
			_timer.Change(Timeout.Infinite, _defaultUpdateInterval);
		}

		public void Dispose()
		{
			Stop();
			_timer.Dispose();
		}

		private void OnTick(object state)
		{
			// Do not execute if already running.
			if (Monitor.TryEnter(_timerLock))
			{
				try
				{
					Refresh();
				}
				finally
				{
					Monitor.Exit(_timerLock);
				}
			}
		}

		private void Refresh()
		{
			lock (_tasksLock)
			{
				foreach (var task in _tasks)
				{
					task.Invoke(_ctx);
				}
			}
		}

		public void AddTask(Action<MemoryContext> task)
		{
			lock (_tasksLock)
			{
				_tasks.Add(task);
			}
		}
	}
}
