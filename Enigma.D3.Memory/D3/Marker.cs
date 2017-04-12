using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.D3.Collections;
using Enigma.Memory;

namespace Enigma.D3
{
	public partial class Marker : MemoryObject
	{
		public const int SizeOf = 72;

		public WorldPosition x00_WorldPosition { get { return Read<WorldPosition>(0x00); } }
		public int x10_TextureSnoId { get { return Read<int>(0x10); } }
		public int _x14 { get { return Read<int>(0x14); } }
		public int _x18 { get { return Read<int>(0x18); } }
		public int x1C_StringListSnoId { get { return Read<int>(0x1C); } }
		public int _x20 { get { return Read<int>(0x20); } }
		public int x24_QuestSnoId { get { return Read<int>(0x24); } }
		public int _x28 { get { return Read<int>(0x28); } }
		public int _x2C { get { return Read<int>(0x2C); } }
		public int _x30 { get { return Read<int>(0x30); } }
		public float x34 { get { return Read<float>(0x34); } }
		public float x38 { get { return Read<float>(0x38); } }
		public float x3C { get { return Read<float>(0x3C); } }
		public int _x40 { get { return Read<int>(0x40); } }
		public int _x44 { get { return Read<int>(0x44); } }
	}

	public partial class Marker
	{
		public static Map<int, Marker> NonQuestMarkers { get { return LevelArea.Instance?.x004_PtrEtcMarkersMap?.Dereference(); } }

		public static Map<int, Marker> QuestMarkers { get { return LevelArea.Instance?.x008_PtrQuestMarkersMap?.Dereference(); } }
	}
}
