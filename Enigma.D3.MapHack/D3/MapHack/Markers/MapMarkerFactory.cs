using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;
using Enigma.D3.Enums;
using Enigma.D3.Helpers;

namespace Enigma.D3.MapHack.Markers
{
	public static class MapMarkerFactory
	{
		public static IMapMarker Create(ActorCommonData acd, out bool ignore)
		{
			IMapMarker item;
			bool interested = false;

			if (TryCreateMonster(acd, out item, ref interested) ||
				TryCreateChest(acd, out item, ref interested) ||
				TryCreateWreckable(acd, out item, ref interested))
			{
				// Successfull!
			}

			ignore = !interested;
			return item;
		}

		private static bool TryCreateMonster(ActorCommonData acd, out IMapMarker item, ref bool interested)
		{
			item = null;
			if (acd.x17C_ActorType == ActorType.Monster)
			{
				interested = true;
				if (IsValidMonster(acd))
				{
					item = new MapMarkerAcdMonster(acd, IsValidMonster);
					return true;
				}
			}
			return false;
		}

		private static bool TryCreateChest(ActorCommonData acd, out IMapMarker item, ref bool interested)
		{
			item = null;
			if (acd.x178_GizmoType == GizmoType.Chest)
			{
				interested = true;
				if (IsValidGizmoChest(acd))
				{
					item = new MapMarkerAcdChest(acd, IsValidGizmoChest);
					return true;
				}
			}
			else if (acd.x178_GizmoType == GizmoType.LoreChest)
			{
				interested = true;
				if (IsValidGizmoLoreChest(acd))
				{
					item = new MapMarkerAcdChest(acd, IsValidGizmoLoreChest);
					return true;
				}
			}
			else if (acd.x178_GizmoType== GizmoType.Switch)
			{
				interested = true;
				switch (acd.x090_ActorSnoId)
				{
					case 0x0005900F: // x1_Global_Chest_CursedChest
					case 0x00059229: // x1_Global_Chest_CursedChest_B
						item = new MapMarkerAcdCursedChest(acd, IsValidSwitchCursedChest);
						return true;
				}
			}
			return false;
		}

		private static bool TryCreateWreckable(ActorCommonData acd, out IMapMarker item, ref bool interested)
		{
			item = null;
			if (acd.x178_GizmoType == GizmoType.BreakableChest ||
				acd.x178_GizmoType == GizmoType.BreakableDoor ||
				acd.x178_GizmoType == GizmoType.DestroyableObject)
			{
				interested = true;
				if (IsValidGizmoWreckableObject(acd))
				{
					item = new MapMarkerAcdWreckable(acd, IsValidGizmoWreckableObject);
					return true;
				}
			}
			return false;
		}

		private static bool IsValidMonster(ActorCommonData acd)
		{
			return acd.x180_Hitpoints > 0.00001 &&
				(acd.x190_Flags_Is_Trail_Proxy_Etc & 1) == 0 &&
				acd.x188_TeamId == 10;
		}

		private static bool IsValidGizmoChest(ActorCommonData acd)
		{
			return (acd.x240_CollisionFlags & 0x400) == 0 &&
				Attributes.ChestOpen.GetValue(acd) != 1;
		}

		private static bool IsValidGizmoLoreChest(ActorCommonData acd)
		{
			return Attributes.ChestOpen.GetValue(acd, 0xA0000) != 1;
		}

		private static bool IsValidGizmoWreckableObject(ActorCommonData acd)
		{
			return acd.x180_Hitpoints == 0.001f;
		}

		private static bool IsValidSwitchCursedChest(ActorCommonData acd)
		{
			return true;
		}
	}
}
