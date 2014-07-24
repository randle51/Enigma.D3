using System;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.UI;

namespace Enigma.D3
{
	public class Marker : MemoryObject
	{
		public const int SizeOf = 72;

		public Marker(MemoryBase memory, int address)
			: base(memory, address) { }

		public WorldPosition x00_WorldPosition { get { return Field<WorldPosition>(0x00); } }
		public int x10_TextureSnoId { get { return Field<int>(0x10); } }
		public int _x14 { get { return Field<int>(0x14); } }
		public int _x18 { get { return Field<int>(0x18); } }
		public int x1C_StringListSnoId { get { return Field<int>(0x1C); } }
		public int _x20 { get { return Field<int>(0x20); } }
		public int x24_QuestSnoId { get { return Field<int>(0x24); } }
		public int _x28 { get { return Field<int>(0x28); } }
		public int _x2C { get { return Field<int>(0x2C); } }
		public int _x30 { get { return Field<int>(0x30); } }
		public float x34 { get { return Field<float>(0x34); } }
		public float x38 { get { return Field<float>(0x38); } }
		public float x3C { get { return Field<float>(0x3C); } }
		public int _x40 { get { return Field<int>(0x40); } }
		public int _x44 { get { return Field<int>(0x44); } }
	}

	public class LevelArea : MemoryObject
	{
		// 2.0.1.22044
		public const int SizeOf = 0x680; // 1664

		public LevelArea(MemoryBase memory, int address)
			: base(memory, address) { }

		public ListB x000_ListB_AttachmentList_ { get { return Dereference<ListB>(0x000); } }
		public Map<int, Marker> x004_MapEx_ItemSize80_MapMarkerInfo_ { get { return Dereference<Map<int, Marker>>(0x004); } }
		public Map<int, Marker> x008_MapEx_ItemSize80_MapMarkerInfo_ { get { return Dereference<Map<int, Marker>>(0x008); } }
		public int x00C_AnimationFrame { get { return Field<int>(0x00C); } }
		public ListPack<SceneRevealInfo> x010_ListPack_Allocator_10x68Bytes_RevealedScenes { get { return Field<ListPack<SceneRevealInfo>>(0x010); } }
		public float x040_LabelOpacity { get { return Field<float>(0x040); } }
		public int x044_SnoId { get { return Field<int>(0x044); } }
		public int x048_LoadingSnoId { get { return Field<int>(0x048); } }
		public int x04C_LabelState { get { return Field<int>(0x04C); } } // 0 = Not visible, 1 = Partially visible, 2 = Fully visible
		public int x050 { get { return Field<int>(0x050); } }
		public int x054_Neg1 { get { return Field<int>(0x054); } }
		public int x058_IsMinimapVisible { get { return Field<int>(0x058); } }
		public int x05C { get { return Field<int>(0x05C); } }
		public int x060_Flags { get { return Field<int>(0x060); } }
		public int _x064 { get { return Field<int>(0x064); } }
		public UIReference x068_UIReference_MinimapDialog { get { return Field<UIReference>(0x068); } }
		public UIReference x270_UIReference_MinimapMain { get { return Field<UIReference>(0x270); } }
		public UIReference x478_UIReference_MinimapArrowRegion { get { return Field<UIReference>(0x478); } }
	}
}
