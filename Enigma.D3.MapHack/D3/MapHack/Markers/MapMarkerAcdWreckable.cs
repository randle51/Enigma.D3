using Enigma.D3.MemoryModel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Enigma.D3.MapHack.Markers
{
	public class MapMarkerAcdWreckable : MapMarkerAcd
	{
		public MapMarkerAcdWreckable(ACD item, Func<ACD, bool> isValid)
			: base(item, isValid) { }

		public override object CreateControl()
		{
			return ControlHelper.CreateCross(6, Brushes.Red, 1)
				.BindVisibilityTo(MapMarkerOptions.Instance, a => a.ShowWreckables);
		}
	}
}
