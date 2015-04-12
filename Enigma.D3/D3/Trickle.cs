using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.Memory;

namespace Enigma.D3
{
	public class Trickle : MemoryObject
	{
		public const int SizeOf = 0x5C;

		// "MarkerCorpse"
		// "MarkerDungeonEntranceBoss"
		// "MarkerExit"
		// "MarkerHostilePlayer"
		// "MarkerFriendlyPlayer"
		// "Marker_Player_Combat"
		// "Marker_NPC_CombatElite"
		// "Marker_NPC_TreasureGoblin"
		// "Marker_Guide"
		// "Marker_Guide_Combat"
		// "Marker_Guide_CombatElite"
		// "Marker_Guide_TreasureGoblin"

		public int x00_Id { get { return Read<int>(0x00); } } // Match against PlayerData.xE2A8; Could be float
		public int _x04 { get { return Read<int>(0x04); } }
		public float x08_WorldPosX { get { return Read<float>(0x08); } }
		public float x0C_WorldPosY { get { return Read<float>(0x0C); } }
		public float x10_WorldPosZ { get { return Read<float>(0x10); } }
		public int x14_WorldId { get { return Read<int>(0x14); } }
		public int _x18 { get { return Read<int>(0x18); } } // PlayerIndex?
		public int x1C_LevelArea { get { return Read<int>(0x1C); } }
		public int _x20 { get { return Read<int>(0x20); } } // Health? 0..1f
		public int _x24 { get { return Read<int>(0x24); } }
		public int _x28 { get { return Read<int>(0x28); } }
		public int _x2C { get { return Read<int>(0x2C); } }
		public int _x30 { get { return Read<int>(0x30); } }
		public int x34_StringList { get { return Read<int>(0x34); } }
		public int _x38 { get { return Read<int>(0x38); } }
		public int _x3C { get { return Read<int>(0x3C); } }
		public int _x40 { get { return Read<int>(0x40); } }
		public int _x44 { get { return Read<int>(0x44); } }
		public int _x48 { get { return Read<int>(0x48); } }
		public int _x4C { get { return Read<int>(0x4C); } }
		public int _x50 { get { return Read<int>(0x50); } }
		public int _x54 { get { return Read<int>(0x54); } }
		public int _x58 { get { return Read<int>(0x58); } }
	}
}
