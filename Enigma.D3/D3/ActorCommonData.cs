using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.Enums;
using Enigma.D3.Memory;

namespace Enigma.D3
{
	public class ActorCommonData : MemoryObject
	{
		// 2.0.0.20874
		public const int SizeOf = 0x2F8; // = 760

		public ActorCommonData(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x000_Id { get { return Field<int>(0x000); } }
		public string x004_Name { get { return Field(0x004, 128); } }
		public int x084_ChestRelated { get { return Field<int>(0x084); } }
		public int x088_AnnId { get { return Field<int>(0x088); } }
		public int x08C_ActorId { get { return Field<int>(0x08C); } }
		public int x090_ActorSnoId { get { return Field<int>(0x090); } }
		public int x094_StructStart_Min8Bytes { get { return Field<int>(0x094); } }
		public int x098_MonsterSnoId { get { return Field<int>(0x098); } }
		public int x09C { get { return Field<int>(0x09C); } }
		public int x0A0 { get { return Field<int>(0x0A0); } }
		public int x0A4_GameTick { get { return Field<int>(0x0A4); } }
		public int x0A8_GameTick { get { return Field<int>(0x0A8); } }
		public int x0AC_GameTick { get { return Field<int>(0x0AC); } }
		public GameBalanceType x0B0_GameBalanceType { get { return (GameBalanceType)Field<int>(0x0B0); } }
		public int x0B4_GameBalanceId { get { return Field<int>(0x0B4); } }
		public int x0B8_MonsterQualityLevel { get { return Field<int>(0x0B8); } }
		public int x0BC_IsItem_StructStart_Min100Bytes { get { return Field<int>(0x0BC); } }
		public int x0C0_StructStart_Min80bytes { get { return Field<int>(0x0C0); } }
		public int _x0C4 { get { return Field<int>(0x0C4); } }
		public float x0C8_Direction { get { return Field<float>(0x0C8); } }
		public float x0CC_Direction { get { return Field<float>(0x0CC); } }
		public float x0D0_WorldPosX { get { return Field<float>(0x0D0); } }
		public float x0D4_WorldPosY { get { return Field<float>(0x0D4); } }
		public float x0D8_WorldPosZ { get { return Field<float>(0x0D8); } }
		public float x0DC_Radius { get { return Field<float>(0x0DC); } }
		public float _x0E0 { get { return Field<float>(0x0E0); } }
		public float _x0E4 { get { return Field<float>(0x0E4); } }
		public float _x0E8 { get { return Field<float>(0x0E8); } }
		public float _x0EC { get { return Field<float>(0x0EC); } }
		public float _x0F0 { get { return Field<float>(0x0F0); } }
		public float _x0F4 { get { return Field<float>(0x0F4); } }
		public float _x0F8 { get { return Field<float>(0x0F8); } }
		public float x0FC_Height { get { return Field<float>(0x0FC); } }
		public float x100 { get { return Field<float>(0x100); } }
		public int _x104 { get { return Field<int>(0x104); } }
		public int x108_WorldId { get { return Field<int>(0x108); } }
		public int x10C_SceneId { get { return Field<int>(0x10C); } }
		public int x110_ItemSocketHostAcdId_StructStart_Min16Bytes { get { return Field<int>(0x110); } }
		public ItemLocation x114_ItemLocation { get { return (ItemLocation)Field<int>(0x114); } }
		public int x118_ItemSlotX { get { return Field<int>(0x118); } }
		public int x11C_ItemSlotY { get { return Field<int>(0x11C); } }
		public int x120_FastAttribGroupId { get { return Field<int>(0x120); } }
		public int x124_Id_FastAttribGroupId { get { return Field<int>(0x124); } }
		public int x128_Id_FastAttribGroupContainerId { get { return Field<int>(0x128); } }
		public int x12C_Id_FastAttribGroupContainerId { get { return Field<int>(0x12C); } }
		public int x130_Ptr_184Bytes_ActorInventory { get { return Field<int>(0x130); } }
		public int x134_Ptr_256Bytes_VisualInventory { get { return Field<int>(0x134); } }
		public long x138_RelatedTo_ItemAssignedHero { get { return Field<long>(0x138); } }
		public long x140_RelatedTo_ItemAssignedHeroId { get { return Field<long>(0x140); } }
		public ListB x148_ListB_ItemRelated_Affixes_NodeSize12Bytes { get { return Field<ListB>(0x148); } }
		public ListB x15C_ListB_ItemRelated_AttributesOrSockets_NodeSize12Bytes { get { return Field<ListB>(0x15C); } }
		public int x170_RareItemPrefixOrSuffix_ { get { return Field<int>(0x170); } }
		public int x174_Neg1_RareItemStringList_ { get { return Field<int>(0x174); } }
		public int x178_Neg1_RareItemStringListIndex_ { get { return Field<int>(0x178); } }
		public int x17C_Neg1_RareItemOtherListIndex_ { get { return Field<int>(0x17C); } }
		public GizmoType x180_GizmoType { get { return (GizmoType)Field<int>(0x180); } }
		public ActorType x184_ActorType { get { return (ActorType)Field<int>(0x184); } }
		public float x188_Hitpoints { get { return Field<float>(0x188); } }
		public int x18C_TeamIdOverride { get { return Field<int>(0x18C); } }
		public int x190_TeamId { get { return Field<int>(0x190); } }
		public int x194_Flags_Is_Trail_Proxy_Etc { get { return Field<int>(0x194); } }
		public int x198_FollowPlayerIndex { get { return Field<int>(0x198); } } // 7 = None
		public int x19C_Flags_1IsFollower_4HasHP { get { return Field<int>(0x19C); } }
		public int x1A0 { get { return Field<int>(0x1A0); } }
		public int x1A4_Flags { get { return Field<int>(0x1A4); } }
		public int x1A8_Neg1_MonsterAffixId_StructStart_Min8Bytes { get { return Field<int>(0x1A8); } }
		public int x1AC_Neg1_MonsterAffixId { get { return Field<int>(0x1AC); } }
		public int x1B0_Neg1_MonsterAffixId { get { return Field<int>(0x1B0); } }
		public int x1B4_Neg1_MonsterAffixId { get { return Field<int>(0x1B4); } }
		public int x1B8_Neg1_MonsterAffixId { get { return Field<int>(0x1B8); } }
		public int x1BC_Neg1_MonsterAffixId { get { return Field<int>(0x1BC); } }
		public int x1C0_Neg1_MonsterAffixId { get { return Field<int>(0x1C0); } }
		public int x1C4_Neg1_MonsterAffixId { get { return Field<int>(0x1C4); } }
		public int x1C8_Neg1_MonsterAffixId { get { return Field<int>(0x1C8); } }
		public int x1CC_Neg1_MonsterAffixId { get { return Field<int>(0x1CC); } }
		public int _x1D0 { get { return Field<int>(0x1D0); } }
		public int x1D4 { get { return Field<int>(0x1D4); } }
		public ListB x1D8_ListB_NodeSize52Bytes { get { return Field<ListB>(0x1D8); } }
		public ListB x1EC_ListB { get { return Field<ListB>(0x1EC); } }
		public ListB x200_ListB { get { return Field<ListB>(0x200); } }
		public int x214_Ptr_220Bytes_Animation { get { return Field<int>(0x214); } }
		public int x218_Ptr_12Bytes_Portals { get { return Field<int>(0x218); } }
		public int x21C { get { return Field<int>(0x21C); } }
		public int x220_Neg1 { get { return Field<int>(0x220); } }
		public int x224 { get { return Field<int>(0x224); } }
		public int x228 { get { return Field<int>(0x228); } }
		public int x22C { get { return Field<int>(0x22C); } }
		public int x230_Neg1 { get { return Field<int>(0x230); } }
		public int x234 { get { return Field<int>(0x234); } }
		public int x238_Neg1 { get { return Field<int>(0x238); } }
		public int x23C { get { return Field<int>(0x23C); } }
		public int x240_StructStart_Min16Bytes { get { return Field<int>(0x240); } }
		public int x244_EffectiveTeamId { get { return Field<int>(0x244); } }
		public int _x248 { get { return Field<int>(0x248); } }
		public int x24C_Flags { get { return Field<int>(0x24C); } }
		public float x250 { get { return Field<float>(0x250); } }
		public float x254 { get { return Field<float>(0x254); } }
		public float x258 { get { return Field<float>(0x258); } }
		public float x25C { get { return Field<float>(0x25C); } }
		public float x260 { get { return Field<float>(0x260); } }
		public float x264 { get { return Field<float>(0x264); } }
		public float x268 { get { return Field<float>(0x268); } }
		public float x26C { get { return Field<float>(0x26C); } }
		public int x270 { get { return Field<int>(0x270); } }
		public int x274 { get { return Field<int>(0x274); } }
		public int x278_WorldRelated_SphereNode { get { return Field<int>(0x278); } }
		public int x27C_WorldRelated { get { return Field<int>(0x27C); } }
		public int x280_WorldId { get { return Field<int>(0x280); } }
		public int _x284 { get { return Field<int>(0x284); } }
		public Map x288_Map { get { return Field<Map>(0x288); } }
	}
}
