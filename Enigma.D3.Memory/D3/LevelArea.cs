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
		public const int SizeOf = 0x938; // 2360

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
		public int _x068 { get { return Read<int>(0x064); } }
		public int _x06C { get { return Read<int>(0x064); } }
		public UIReference x070_UIReference_MinimapDialog { get { return Read<UIReference>(0x070); } }
		public UIReference x278_UIReference_MinimapMain { get { return Read<UIReference>(0x278); } }
		public UIReference x480_UIReference_MinimapArrowRegion { get { return Read<UIReference>(0x480); } }
		public float x688_float { get { return Read<float>(0x688); } }
		public float x68C_float { get { return Read<float>(0x68C); } }
		public float x690_float { get { return Read<float>(0x690); } } 
		public int _x694 { get { return Read<int>(0x694); } }
		public int _x698 { get { return Read<int>(0x698); } }
		public int _x69C { get { return Read<int>(0x69C); } }
		public int _x6A0 { get { return Read<int>(0x6A0); } }
		public int _x6A4 { get { return Read<int>(0x6A4); } }
		public int _x6A8 { get { return Read<int>(0x6A8); } }
		public int _x6AC { get { return Read<int>(0x6AC); } }
		public int _x6B0 { get { return Read<int>(0x6B0); } }
		public int _x6B4 { get { return Read<int>(0x6B4); } }
		public int _x6B8 { get { return Read<int>(0x6B8); } }
		public int _x6BC { get { return Read<int>(0x6BC); } }			 
		public float x6C0_float { get { return Read<float>(0x6C0); } }
		public int _x6C4 { get { return Read<int>(0x6C4); } }
		public int _x6C8 { get { return Read<int>(0x6C8); } }
		public int _x6CC { get { return Read<int>(0x6CC); } }
		public int _x6D0 { get { return Read<int>(0x6D0); } }
		public int _x6D4 { get { return Read<int>(0x6D4); } }
		public int _x6D8 { get { return Read<int>(0x6D8); } }
		public int _x6DC { get { return Read<int>(0x6DC); } }
		public int _x6E0 { get { return Read<int>(0x6E0); } }
		public int _x6E4 { get { return Read<int>(0x6E4); } }
		public int _x6E8 { get { return Read<int>(0x6E8); } }
		public int _x6EC { get { return Read<int>(0x6EC); } }
		public int _x6F0 { get { return Read<int>(0x6F0); } }
		public int _x6F4 { get { return Read<int>(0x6F4); } }
		public int _x6F8 { get { return Read<int>(0x6F8); } }
		public int _x6FC { get { return Read<int>(0x6FC); } }
		public int _x700 { get { return Read<int>(0x700); } }
		public int _x704 { get { return Read<int>(0x704); } }
		public int _x708 { get { return Read<int>(0x708); } }
		public int _x70C { get { return Read<int>(0x70C); } }
		public int _x710 { get { return Read<int>(0x710); } }
		public int _x714 { get { return Read<int>(0x714); } }
		public int _x718 { get { return Read<int>(0x718); } }
		public int _x71C { get { return Read<int>(0x71C); } }
		public UIReference x720_UIReference_BoostStackWrapper { get { return Read<UIReference>(0x720); } }
		public int _x928 { get { return Read<int>(0x928); } }
		public int _x92C { get { return Read<int>(0x92C); } }
		public int _x930 { get { return Read<int>(0x930); } }
		public int _x934 { get { return Read<int>(0x934); } }		  
	}

	public partial class LevelArea
	{
		public static LevelArea Instance { get { return Engine.Current.LevelArea; } }

		public static string Name { get { return Engine.Current.LevelAreaName; } }
	}
}
