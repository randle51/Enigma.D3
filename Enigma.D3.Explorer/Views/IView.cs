using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Enigma.D3.Explorer.Views
{
	internal interface IView
	{
		object Content { get; }
		MenuItem[] ContextMenuItems { get; }

		void Enter();
		void Leave();
	}
}
