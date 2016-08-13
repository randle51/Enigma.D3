using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Enigma.D3.Explorer.Utilities
{
	/// <summary>
	/// Interaction logic for MemoryObjectClassGeneratorDialog.xaml
	/// </summary>
	public partial class MemoryObjectClassGeneratorDialog : Window
	{
		public string HeaderText
		{
			get { return (string)GetValue(HeaderTextProperty); }
			set { SetValue(HeaderTextProperty, value); }
		}

		// Using a DependencyProperty as the backing store for HeaderText.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty HeaderTextProperty =
			DependencyProperty.Register("HeaderText", typeof(string), typeof(MemoryObjectClassGeneratorDialog), new PropertyMetadata(""));

		public string StatusText
		{
			get { return (string)GetValue(StatusTextProperty); }
			set { SetValue(StatusTextProperty, value); }
		}

		// Using a DependencyProperty as the backing store for StatusText.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty StatusTextProperty =
			DependencyProperty.Register("StatusText", typeof(string), typeof(MemoryObjectClassGeneratorDialog), new PropertyMetadata(""));

		public double ProgressPercentage
		{
			get { return (double)GetValue(ProgressPercentageProperty); }
			set { SetValue(ProgressPercentageProperty, value); }
		}

		// Using a DependencyProperty as the backing store for ProgressPercent.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty ProgressPercentageProperty =
			DependencyProperty.Register("ProgressPercentage", typeof(double), typeof(MemoryObjectClassGeneratorDialog), new PropertyMetadata(0.0d));

		public MemoryObjectClassGeneratorDialog()
		{
			InitializeComponent();
			LayoutRoot.DataContext = this;
		}

		private void OnCancelClicked(object sender, RoutedEventArgs e)
		{
			DialogResult = false;
		}
	}
}
