using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;
using Enigma.D3.Enums;
using Enigma.D3.MemoryModel.Core;
using Enigma.D3.AttributeModel;

namespace Enigma.D3.MapHack.Markers
{
    public static class MapMarkerFactory
    {
        public static IMapMarker Create(ACD acd, out bool ignore)
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

        private static bool TryCreateMonster(ACD acd, out IMapMarker item, ref bool interested)
        {
            item = null;
            if (acd.ActorType == ActorType.Monster)
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

        private static bool TryCreateChest(ACD acd, out IMapMarker item, ref bool interested)
        {
            item = null;
            if (acd.GizmoType == GizmoType.Chest)
            {
                interested = true;
                if (IsValidGizmoChest(acd))
                {
                    item = new MapMarkerAcdChest(acd, IsValidGizmoChest);
                    return true;
                }
            }
            else if (acd.GizmoType == GizmoType.LoreChest)
            {
                interested = true;
                if (IsValidGizmoLoreChest(acd))
                {
                    item = new MapMarkerAcdChest(acd, IsValidGizmoLoreChest);
                    return true;
                }
            }
            else if (acd.GizmoType == GizmoType.Switch)
            {
                interested = true;
                switch ((int)acd.ActorSNO)
                {
                    case 0x0005900F: // x1_Global_Chest_CursedChest
                    case 0x00059229: // x1_Global_Chest_CursedChest_B
                        item = new MapMarkerAcdCursedChest(acd, IsValidSwitchCursedChest);
                        return true;
                }
            }
            return false;
        }

        private static bool TryCreateWreckable(ACD acd, out IMapMarker item, ref bool interested)
        {
            item = null;
            if (acd.GizmoType == GizmoType.BreakableChest ||
                acd.GizmoType == GizmoType.BreakableDoor ||
                acd.GizmoType == GizmoType.DestroyableObject)
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

        private static bool IsValidMonster(ACD acd)
        {
            return acd.Hitpoints > 0.00001 &&
                (acd.ObjectFlags & 1) == 0 &&
                acd.TeamID == 10;
        }

        private static bool IsValidGizmoChest(ACD acd)
        {
            return (acd.CollisionFlags & 0x400) == 0 &&
                Attributes.ChestOpen.GetValue(AttributeReader.Instance, acd.FastAttribGroupID) != 1;
        }

        private static bool IsValidGizmoLoreChest(ACD acd)
        {
            return Attributes.ChestOpen.GetValue(AttributeReader.Instance, acd.FastAttribGroupID, 0xA0000) != 1;
        }

        private static bool IsValidGizmoWreckableObject(ACD acd)
        {
            return acd.Hitpoints == 0.001f;
        }

        private static bool IsValidSwitchCursedChest(ACD acd)
        {
            return true;
        }
    }
}
