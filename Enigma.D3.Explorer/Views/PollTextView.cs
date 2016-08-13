using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.Explorer.Views
{
	internal class PollTextView : PollView
	{
		private Func<string> _getText;

		public PollTextView(Func<object> getValue)
		{
			_getText = () => getValue.Invoke().ToString();
		}

		public PollTextView(Func<string> getText)
		{
			_getText = getText;
		}

		public PollTextView(Func<IEnumerable<string>> getText)
		{
			_getText = () => string.Join(Environment.NewLine, getText());
		}

		public override void Refresh()
		{
			Content = _getText.Invoke();
		}
	}
}
