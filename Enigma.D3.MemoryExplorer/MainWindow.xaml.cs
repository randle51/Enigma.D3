using Enigma.D3.MemoryModel;
using Enigma.D3.MemoryModel.MemoryManagement;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Enigma.D3.MemoryExplorer
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private Stack<Segment> _history = new Stack<Segment>();
		private MemoryContext _ctx;
		private NodeIndex _idx;

		public MainWindow()
		{
			InitializeComponent();

			var path = Environment.ExpandEnvironmentVariables(@"%TEMP%\Diablo III.DMP");
			_ctx = new MemoryContext(new MiniDumpMemoryReader(path).Memory);

			var heap = _ctx.DataSegment.MemoryManager.LocalHeap as LocalHeap;
			var nodes = heap.MainBlocks.Concat(heap.SmallBlocks).ToArray();
			_idx = new NodeIndex(nodes);

			UXAddress.Text = (_ctx.DataSegment.ObjectManager as MemoryObject).Address.ToString();
			UXSize.Text = "0x" + TypeHelper.SizeOf(_ctx.DataSegment.ObjectManager.GetType()).ToString("X");
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Analyze(false);
		}

		private void Link_Click(object sender, RoutedEventArgs e)
		{
			var state = ((sender as FrameworkContentElement).Tag as Segment);
			_history.Push(GetCurrentState());
			ChangeState(state);
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			if (_history.Count == 0)
				return;

			var state = _history.Pop();
			ChangeState(state);
		}

		private void ChangeState(Segment state)
		{
			UXAddress.Text = "0x" + state.Start.ToString("X");
			UXSize.Text = "0x" + state.Size.ToString("X");
			Button_Click(null, new RoutedEventArgs());
		}

		private Segment GetCurrentState()
		{
			var address = (MemoryAddress)ulong.Parse(UXAddress.Text.Replace("0x", ""), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
			var size = int.Parse(UXSize.Text.Replace("0x", ""), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
			return new Segment(address, (uint)size);
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			Analyze(true);
		}

		private void Analyze(bool full)
		{
			var state = GetCurrentState();
			var viewer = new ScrollViewer();
			var panel = new VirtualizingStackPanel();
			viewer.Content = panel;
			UXHeader.Text = $"{"Address",20} {"Offset",10} {(full ? $"{"Value",10}" : "")}{"Blk",26} {"Blk.Ofs",10} {"Blk.Size",10}";
			HeapNode blk = null;
			for (int i = 0; i < (int)state.Size; i += (full && blk == null) ? 4 : _ctx.Memory.Reader.PointerSize)
			{
				var ptr = _ctx.Memory.Reader.Read<Ptr>(state.Start + i);
				blk = i % _ctx.Memory.Reader.PointerSize == 0 ? _idx.FindNode(ptr.ValueAddress) : null;
				var line = "";

				if (blk != null || full)
				{
					line += $"{state.Start + i,26:X16} {i,10:X3}";
					if (full)
						line += $" {_ctx.Memory.Reader.Read<int>(state.Start + i),10:X} ({new string(_ctx.Memory.Reader.Read<byte>(state.Start + i, 4).Select(b => (char)b).Select(c => c >= 0x20 && c <= 0x7E ? c : ' ').ToArray()),4})";
				}
				if (blk != null)
				{
					var offset = (int)(ptr.ValueAddress - blk.Data.ValueAddress);
					line += $" {blk.Address.ToString(),26} {offset,10:X} {blk.Size,10}";
					if (ptr.ValueAddress >= state.Start && ptr.ValueAddress < state.Start + state.Size)
						line += $" this+{ptr.ValueAddress - state.Start:X}";

					var link = new Hyperlink(new Run { Text = line });
					link.Tag = new Segment(blk.Data.ValueAddress, blk.Size);
					link.Click += Link_Click;
					panel.Children.Add(new TextBlock(link) { FontFamily = new FontFamily("Consolas") });
				}
				else if (full)
				{
					panel.Children.Add(new TextBlock { Text = line, FontFamily = new FontFamily("Consolas") });
				}
			}

			UXView.Content = viewer;
		}
	}
}
