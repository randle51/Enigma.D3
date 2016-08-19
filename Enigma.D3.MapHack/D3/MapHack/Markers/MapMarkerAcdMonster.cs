using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Enigma.D3.Enums;

namespace Enigma.D3.MapHack.Markers
{
	public class MapMarkerAcdMonster : MapMarkerAcd
	{
		public MapMarkerAcdMonster(ActorCommonData monster, Func<ActorCommonData, bool> isValid)
			: base(monster, isValid)
		{
			ZIndex = (int)Acd.x0B8_MonsterQuality;
		}

		public override object CreateControl()
		{
			if (!MapMarkerOptions.Instance.ShowMonsters)
				return null;

			var strokeThickness = 1;
			var diameter = Acd.x0DC_Radius * 10;

			switch (Acd.x0B8_MonsterQuality)
			{
				default:
				case MonsterQuality.Normal:
					if (IsTreasureGoblin())
					{
						return ControlHelper.CreateCircle(15, Brushes.Green, Brushes.White, 3)
							.AnimateScale(0.8, 1.2, 0.5)
							.BindVisibilityTo(MapMarkerOptions.Instance, a => a.ShowMonsters);
					}
					else
					{
						return ControlHelper
							.CreateCircle(diameter, Brushes.White, Brushes.Black, strokeThickness)
							.SetOpacity(Math.Max(0.3, 1 - 0.06 * diameter))
							.BindVisibilityTo(MapMarkerOptions.Instance, a => a.ShowMonsters);
					}

				case MonsterQuality.Champion:
					return ControlHelper
						.CreateCircle(diameter, Brushes.Blue, Brushes.SkyBlue, strokeThickness)
						.SetOpacity(Math.Max(0.4, 1 - 0.06 * diameter))
						.If(diameter < 15.0d, a => a
							.AnimateScale(1, 15.0d / diameter, 1.0d / 3.0))
						.BindVisibilityTo(MapMarkerOptions.Instance, a => a.ShowMonsters);

				case MonsterQuality.Minion:
					return ControlHelper
						.CreateCircle(diameter, Brushes.Orange, Brushes.Yellow, strokeThickness)
						.SetOpacity(0.4)
						.If(diameter < 15.0d, a => a
							.AnimateScale(1, 15.0d / diameter, 1.0d / 3.0))
						.BindVisibilityTo(MapMarkerOptions.Instance, a => a.ShowMonsters);

				case MonsterQuality.Rare:
					return ControlHelper
						.CreateCircle(diameter, Brushes.Yellow, Brushes.Black, strokeThickness)
						.AnimateOpacity(0.4, 1, 0.3)
						.If(diameter < 15.0d, a => a
							.AnimateScale(1, 15.0d / diameter, 1.0d / 3.0))
						.BindVisibilityTo(MapMarkerOptions.Instance, a => a.ShowMonsters);

				case MonsterQuality.Unique:
				case MonsterQuality.Boss:
					var animatedFill = ControlHelper.CreateAnimatedBrush(Colors.Purple, Colors.DarkOrange, 0.5);
					return ControlHelper
						.CreateCircle(diameter, animatedFill, Brushes.Pink, strokeThickness)
						.If(diameter < 15.0d, a => a
							.AnimateScale(1, 15.0d / diameter, 1.0d / 3.0))
						.BindVisibilityTo(MapMarkerOptions.Instance, a => a.ShowMonsters);
			}
		}

		private bool IsTreasureGoblin()
		{
			switch (Acd.x090_ActorSnoId)
			{
				case 0x00001760: // treasureGoblin_A
				case 0x00001761: // treasureGoblin_B
				case 0x00001763: // treasureGoblin_C
				case 0x00001764: // treasureGoblin_D
					return true;

				default:
					return false;
			}
		}
	}
}
