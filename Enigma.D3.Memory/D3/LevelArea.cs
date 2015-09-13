using Enigma.Memory;
using System;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.UI;

namespace Enigma.D3
{
	public partial class LevelArea : MemoryObject
	{
		// 2.0.1.22044
		public const int SizeOf = 0x680; // 1664

		public Ptr<ListB> x000_PtrListB_AttachmentList { get { return ReadPointer<ListB>(0x000); } }
		public Ptr<Map<int, Marker>> x004_PtrEtcMarkersMap { get { return ReadPointer<Map<int, Marker>>(0x004); } }
		public Ptr<Map<int, Marker>> x008_PtrQuestMarkersMap { get { return ReadPointer<Map<int, Marker>>(0x008); } }
		public int x00C_AnimationFrame { get { return Read<int>(0x00C); } }
		public ListPack<SceneRevealInfo> x010_ListPack_Allocator_10x68Bytes_RevealedScenes { get { return Read<ListPack<SceneRevealInfo>>(0x010); } }
		public float x040_LabelOpacity { get { return Read<float>(0x040); } }
		public int x044_SnoId { get { return Read<int>(0x044); } }
		public int x048_LoadingSnoId { get { return Read<int>(0x048); } }
		public int x04C_LabelState { get { return Read<int>(0x04C); } } // 0 = Not visible, 1 = Partially visible, 2 = Fully visible
		public int x050 { get { return Read<int>(0x050); } }
		public int x054_Neg1 { get { return Read<int>(0x054); } }
		public int x058_IsMinimapVisible { get { return Read<int>(0x058); } }
		public int x05C { get { return Read<int>(0x05C); } }
		public int x060_Flags { get { return Read<int>(0x060); } }
		public int _x064 { get { return Read<int>(0x064); } }
		public UIReference x068_UIReference_MinimapDialog { get { return Read<UIReference>(0x068); } }
		public UIReference x270_UIReference_MinimapMain { get { return Read<UIReference>(0x270); } }
		public UIReference x478_UIReference_MinimapArrowRegion { get { return Read<UIReference>(0x478); } }
	}

	public partial class LevelArea
	{
		public static LevelArea Instance { get { return Engine.Current.LevelArea; } }

		public static string Name { get { return Engine.Current.LevelAreaName; } }
	}
}
