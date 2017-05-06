using Enigma.D3.MemoryModel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Enigma.D3.MapHack.Markers
{
	public class MapMarkerAcdCursedChest : MapMarkerAcd
	{
		public MapMarkerAcdCursedChest(ACD item, Func<ACD, bool> isValid)
			: base(item, isValid) { }

		public override object CreateControl()
		{
			return ControlHelper.CreateCircle(20, Brushes.Brown, Brushes.White, 3)
				.AnimateScale(0.8, 1.2, 0.5)
				.BindVisibilityTo(MapMarkerOptions.Instance, a => a.ShowChests);
		}
	}
}
