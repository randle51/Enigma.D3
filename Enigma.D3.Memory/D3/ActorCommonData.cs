using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.Enums;
using Enigma.D3.Memory;
using Enigma.D3.DataTypes;

namespace Enigma.D3
{
	public partial class ActorCommonData : MemoryObject
	{
		// 2.0.0.20874
		public const int SizeOf = 0x2F8; // = 760

		public int x000_Id { get { return Read<int>(0x000); } }
		public string x004_Name { get { return ReadString(0x004, 128); } }
		public int x084_ChestRelated { get { return Read<int>(0x084); } }
		public int x088_AnnId { get { return Read<int>(0x088); } }
		public int x08C_ActorId { get { return Read<int>(0x08C); } }
		public int x090_ActorSnoId { get { return Read<int>(0x090); } }
		public int x094_StructStart_Min8Bytes { get { return Read<int>(0x094); } }
		public int x098_MonsterSnoId { get { return Read<int>(0x098); } }
		public int x09C { get { return Read<int>(0x09C); } }
		public int x0A0 { get { return Read<int>(0x0A0); } }
		public int x0A4_GameTick { get { return Read<int>(0x0A4); } }
		public int x0A8_GameTick { get { return Read<int>(0x0A8); } }
		public int x0AC_GameTick { get { return Read<int>(0x0AC); } }
		public GBType x0B0_GameBalanceType { get { return (GBType)Read<int>(0x0B0); } }
		public int x0B4_GameBalanceId { get { return Read<int>(0x0B4); } }
		public MonsterQuality x0B8_MonsterQuality { get { return (MonsterQuality)Read<int>(0x0B8); } }
		public int x0BC_IsItem_StructStart_Min100Bytes { get { return Read<int>(0x0BC); } }
		public int x0C0_StructStart_Min80bytes { get { return Read<int>(0x0C0); } }
		public int _x0C4 { get { return Read<int>(0x0C4); } }
		public float x0C8_Direction { get { return Read<float>(0x0C8); } }
		public float x0CC_Direction { get { return Read<float>(0x0CC); } }
		public float x0D0_WorldPosX { get { return Read<float>(0x0D0); } }
		public float x0D4_WorldPosY { get { return Read<float>(0x0D4); } }
		public float x0D8_WorldPosZ { get { return Read<float>(0x0D8); } }
		public float x0DC_Radius { get { return Read<float>(0x0DC); } }
		public float _x0E0 { get { return Read<float>(0x0E0); } }
		public float _x0E4 { get { return Read<float>(0x0E4); } }
		public float _x0E8 { get { return Read<float>(0x0E8); } }
		public float _x0EC { get { return Read<float>(0x0EC); } }
		public float _x0F0 { get { return Read<float>(0x0F0); } }
		public float _x0F4 { get { return Read<float>(0x0F4); } }
		public float _x0F8 { get { return Read<float>(0x0F8); } }
		public float x0FC_Height { get { return Read<float>(0x0FC); } }
		public float x100 { get { return Read<float>(0x100); } }
		public int _x104 { get { return Read<int>(0x104); } }
		public int x108_WorldId { get { return Read<int>(0x108); } }
		public int x10C_SceneId { get { return Read<int>(0x10C); } }
		public int x110_ItemSocketHostAcdId_StructStart_Min16Bytes { get { return Read<int>(0x110); } }
		public ItemLocation x114_ItemLocation { get { return (ItemLocation)Read<int>(0x114); } }
		public int x118_ItemSlotX { get { return Read<int>(0x118); } }
		public int x11C_ItemSlotY { get { return Read<int>(0x11C); } }
		public int x120_FastAttribGroupId { get { return Read<int>(0x120); } }
		public int x124_Id_FastAttribGroupId { get { return Read<int>(0x124); } }
		public int x128_Id_FastAttribGroupContainerId { get { return Read<int>(0x128); } }
		public int x12C_Id_FastAttribGroupContainerId { get { return Read<int>(0x12C); } }
		public int x130_Ptr_184Bytes_ActorInventory { get { return Read<int>(0x130); } }
		public int x134_Ptr_256Bytes_VisualInventory { get { return Read<int>(0x134); } }
		public long x138_RelatedTo_ItemAssignedHero { get { return Read<long>(0x138); } }
		public long x140_RelatedTo_ItemAssignedHeroId { get { return Read<long>(0x140); } }
		public ListB<int> x148_ListB_ItemRelated_Affixes_NodeSize12Bytes { get { return Read<ListB<int>>(0x148); } } // AffixList GBIDs
		public ListB<int> x15C_ListB_ItemRelated_AttributesOrSockets_NodeSize12Bytes { get { return Read<ListB<int>>(0x15C); } }
		public int x170_RareItemPrefixOrSuffix_ { get { return Read<int>(0x170); } }
		public int x174_Neg1_RareItemStringList_ { get { return Read<int>(0x174); } }
		public int x178_Neg1_RareItemStringListIndex_ { get { return Read<int>(0x178); } }
		public int x17C_Neg1_RareItemOtherListIndex_ { get { return Read<int>(0x17C); } }
		public GizmoType x180_GizmoType { get { return (GizmoType)Read<int>(0x180); } }
		public ActorType x184_ActorType { get { return (ActorType)Read<int>(0x184); } }
		public float x188_Hitpoints { get { return Read<float>(0x188); } }
		public int x18C_TeamIdOverride { get { return Read<int>(0x18C); } }
		public int x190_TeamId { get { return Read<int>(0x190); } }
		public int _x194 { get { return Read<int>(0x194); } }
		public int x198_Flags_Is_Trail_Proxy_Etc { get { return Read<int>(0x198); } }
		public int x19C_FollowPlayerIndex { get { return Read<int>(0x19C); } } // 7 = None
		public int x1A0_Flags_1IsFollower_4HasHP { get { return Read<int>(0x1A0); } }
		//public int x1A4 { get { return Read<int>(0x1A4); } }
		//public int x1A8_Flags { get { return Read<int>(0x1A8); } }
		public int x1A4_Neg1_MonsterAffixId_StructStart_Min8Bytes { get { return Read<int>(0x1A4); } }
		public int x1A8_Neg1_MonsterAffixId { get { return Read<int>(0x1A8); } }
		public int x1AC_Neg1_MonsterAffixId { get { return Read<int>(0x1AC); } }
		public int x1B0_Neg1_MonsterAffixId { get { return Read<int>(0x1B0); } }
		public int x1B4_Neg1_MonsterAffixId { get { return Read<int>(0x1B4); } }
		public int x1B8_Neg1_MonsterAffixId { get { return Read<int>(0x1B8); } }
		public int x1BC_Neg1_MonsterAffixId { get { return Read<int>(0x1BC); } }
		public int x1C0_Neg1_MonsterAffixId { get { return Read<int>(0x1C0); } }
		public int x1C4_Neg1_MonsterAffixId { get { return Read<int>(0x1C4); } }
		public int x1C8_Neg1_MonsterAffixId { get { return Read<int>(0x1C8); } }
		public int _x1CC { get { return Read<int>(0x1CC); } }
		public int x1D0 { get { return Read<int>(0x1D0); } }
		public ListB x1D4_ListB_NodeSize52Bytes { get { return Read<ListB>(0x1D4); } }
		public ListB x1E8_ListB { get { return Read<ListB>(0x1E8); } }
		public ListB x1FC_ListB { get { return Read<ListB>(0x1FC); } }
		public Ptr<Animation> x210_Ptr_220Bytes_Animation { get { return ReadPointer<Animation>(0x210); } }
		public int x214_Ptr_12Bytes_Portals { get { return Read<int>(0x214); } }
		public int x218 { get { return Read<int>(0x218); } }
		public int x21C_Neg1 { get { return Read<int>(0x21C); } }
		public int x220 { get { return Read<int>(0x220); } }
		public int x224 { get { return Read<int>(0x224); } }
		public int x228 { get { return Read<int>(0x228); } }
		public int x22C_Neg1 { get { return Read<int>(0x22C); } }
		public int x230 { get { return Read<int>(0x230); } }
		public int x234_Neg1 { get { return Read<int>(0x234); } }
		public int x238 { get { return Read<int>(0x238); } }
		public int x23C_StructStart_Min16Bytes { get { return Read<int>(0x23C); } }
		public int x240_EffectiveTeamId { get { return Read<int>(0x240); } }
		public int _x244 { get { return Read<int>(0x244); } }
		public int x248_CollisionFlags { get { return Read<int>(0x248); } }
		public float x24C { get { return Read<float>(0x24C); } }
		public float x250 { get { return Read<float>(0x250); } }
		public float x254 { get { return Read<float>(0x254); } }
		public float x258 { get { return Read<float>(0x258); } }
		public float x25C { get { return Read<float>(0x25C); } }
		public float x260 { get { return Read<float>(0x260); } }
		public float x264 { get { return Read<float>(0x264); } }
		public float x268 { get { return Read<float>(0x268); } }
		public int x26C { get { return Read<int>(0x26C); } }
		public int x270 { get { return Read<int>(0x270); } }
		public int x274_WorldRelated_SphereNode { get { return Read<int>(0x274); } }
		public int x278_WorldRelated { get { return Read<int>(0x278); } }
		public int x27C_WorldId { get { return Read<int>(0x27C); } }
		public int _x280 { get { return Read<int>(0x280); } }
		public Map x284_Map { get { return Read<Map>(0x284); } }
		public int _x2F4 { get { return Read<int>(0x2F4); } }
	}

	public class Animation : MemoryObject
	{
		public const int SizeOf = 220;

		public int _x00 { get { return Read<int>(0x00); } }
		public SNO x04_AnimSNO { get { return Read<SNO>(0x04); } }
		public int x08_AnimTag { get { return Read<int>(0x08); } }
		public int _x0C { get { return Read<int>(0x0C); } }			
		public float x10_Speed { get { return Read<float>(0x10); } }
		public int _x14 { get { return Read<int>(0x14); } }
		public int _x18 { get { return Read<int>(0x18); } }
		public int _x1C { get { return Read<int>(0x1C); } }
		public int _x20 { get { return Read<int>(0x20); } }
		public int _x24 { get { return Read<int>(0x24); } }
		public int _x28 { get { return Read<int>(0x28); } }
		public int _x2C { get { return Read<int>(0x2C); } }
		public int _x30 { get { return Read<int>(0x30); } }
		public int _x34 { get { return Read<int>(0x34); } }
		public int _x38 { get { return Read<int>(0x38); } }
		public int _x3C { get { return Read<int>(0x3C); } }
		public int _x40 { get { return Read<int>(0x40); } }
		public int _x44 { get { return Read<int>(0x44); } }
		public int _x48 { get { return Read<int>(0x48); } }
		public int _x4C { get { return Read<int>(0x4C); } }
		public int _x50 { get { return Read<int>(0x50); } }
		public int _x54 { get { return Read<int>(0x54); } }
		public int _x58 { get { return Read<int>(0x58); } }
		public int _x5C { get { return Read<int>(0x5C); } }
		public int _x60 { get { return Read<int>(0x60); } }
		public int _x64 { get { return Read<int>(0x64); } }
		public int _x68 { get { return Read<int>(0x68); } }
		public int _x6C { get { return Read<int>(0x6C); } }
		public int _x70 { get { return Read<int>(0x70); } }
		public int _x74 { get { return Read<int>(0x74); } }
		public int _x78 { get { return Read<int>(0x78); } }
		public int _x7C { get { return Read<int>(0x7C); } }
		public int _x80 { get { return Read<int>(0x80); } }
		public int _x84 { get { return Read<int>(0x84); } }
		public int _x88 { get { return Read<int>(0x88); } }
		public int _x8C { get { return Read<int>(0x8C); } }
		public int _x90 { get { return Read<int>(0x90); } }
		public int _x94 { get { return Read<int>(0x94); } }
		public int _x98 { get { return Read<int>(0x98); } }
		public int _x9C { get { return Read<int>(0x9C); } }
		public int _xA0 { get { return Read<int>(0xA0); } }
		public int _xA4 { get { return Read<int>(0xA4); } }
		public int _xA8 { get { return Read<int>(0xA8); } }
		public int _xAC { get { return Read<int>(0xAC); } }
		public int _xB0 { get { return Read<int>(0xB0); } }
		public int _xB4 { get { return Read<int>(0xB4); } }
		public int _xB8 { get { return Read<int>(0xB8); } }
		public int _xBC { get { return Read<int>(0xBC); } }
		public int _xC0 { get { return Read<int>(0xC0); } }
		public int _xC4 { get { return Read<int>(0xC4); } }
		public int _xC8 { get { return Read<int>(0xC8); } }
		public int _xCC { get { return Read<int>(0xCC); } }
		public int _xD0 { get { return Read<int>(0xD0); } }
		public int _xD4 { get { return Read<int>(0xD4); } }
		public int _xD8 { get { return Read<int>(0xD8); } }			
	}
	
	public partial class ActorCommonData
	{
		public static ActorCommonData Local { get { return Enigma.D3.Helpers.ActorCommonDataHelper.GetLocalAcd(); } }

		public static ActorCommonData Gold { get { return Enigma.D3.Helpers.ActorCommonDataHelper.GetGoldAcd(); } }

		public static ExpandableContainer<ActorCommonData> Container { get { return ActorCommonDataManager.Instance.IfNotNull(a => a.x00_ActorCommonData); } }

		public SNO GetAnimSNO()
		{
			var ptr = x210_Ptr_220Bytes_Animation;
			if (ptr.IsInvalid)
				return SNO.NONE;
			return ptr.Dereference().x04_AnimSNO;
		}

		public int GetAnimTag()
		{
			var ptr = x210_Ptr_220Bytes_Animation;
			if (ptr.IsInvalid)
				return -1;
			return ptr.Dereference().x08_AnimTag;
		}
	}
}
