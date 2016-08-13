using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Enigma.D3.Explorer.Views
{
	internal abstract class CustomContentView<T> : PollView
	{
		private bool _creationRequired = true;
		protected T Context { get; private set; }
		protected ConcurrentBag<Action> Refreshers { get; private set; }

		public CustomContentView()
		{
			Refreshers = new ConcurrentBag<Action>();
		}

		public override void Enter()
		{
			base.Enter();
			try
			{
				CreateContentIfRequired();
			}
			catch (Exception exception)
			{
				Content = new TextBlock { Text = exception.ToString() };
			}
		}

		public override void Refresh()
		{
			base.Refresh();
			if (!CreateContentIfRequired())
			{
				Context = CreateContext();
				foreach (var refresher in Refreshers)
					refresher.Invoke();
			}
		}

		private bool CreateContentIfRequired()
		{
			var engine = GetEngine();
			if (_creationRequired)
			{
				Context = CreateContext();
				if (Context == null)
					return false;
				Content = CreateContent();
				_creationRequired = false;
				return true;
			}
			return false;
		}

		protected abstract object CreateContent();

		protected abstract T CreateContext();

		protected TValue Dynamic<TValue>(TValue value, Action<TValue> action)
		{
			Refreshers.Add(() => action(value));
			return Using(value, action);
		}

		protected TValue Using<TValue>(TValue value, Action<TValue> action)
		{
			action(value);
			return value;
		}
	}
}
