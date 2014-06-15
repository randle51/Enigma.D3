using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Enigma.D3.MapHack.Markers
{
	public class MapMarkerAcdChest : MapMarkerAcd
	{
		public MapMarkerAcdChest(ActorCommonData item, Func<ActorCommonData, bool> isValid)
			: base(item, isValid) { }

		public override object CreateControl()
		{
			var brush = Acd.x180_GizmoType == Enums.GizmoType.LoreChest ?
				Brushes.Purple : Brushes.DarkGreen;

			return ControlHelper.CreateCross(8, brush, 2)
				.AnimateScale(0.5, 2, 0.5)
				.SpinRight(0.5)
				.BindVisibilityTo(MapMarkerOptions.Instance, a => a.ShowChests);
		}
	}
}
