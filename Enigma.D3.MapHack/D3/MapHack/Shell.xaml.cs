using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Enigma.D3.MapHack.Markers;

namespace Enigma.D3.MapHack
{
	public partial class Shell : Window, INotifyPropertyChanged
	{
		private static readonly Lazy<Shell> _lazyInstance = new Lazy<Shell>(() => new Shell());

		public static Shell Instance { get { return _lazyInstance.Value; } }

		private bool _isAttached;

		public MapMarkerOptions Options { get; private set; }
		public bool IsAttached { get { return _isAttached; } set { if (_isAttached != value) { _isAttached = value; Refresh("IsAttached"); } } }

		public Shell()
		{
			Options = MapMarkerOptions.Instance;
			DataContext = this;
			InitializeComponent();
		}

		public event PropertyChangedEventHandler PropertyChanged = delegate { };

		private void Refresh(string propertyName)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
