using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.UI;

namespace Enigma.D3
{
	public class ObjectManager : MemoryObject
	{
		// 2.0.4.23119
		public const int SizeOf = 0x9C8;

		public ObjectManager(ProcessMemory memory, int address)
			: base(memory, address) { }

		public Time x000_Time { get { return Field<Time>(0x000); } }
		public int _x00C { get { return Field<int>(0x00C); } }
		public int _x010 { get { return Field<int>(0x010); } }
		public int _x014 { get { return Field<int>(0x014); } }
		public int x018 { get { return Field<int>(0x018); } }
		public int x01C { get { return Field<int>(0x01C); } }
		public Time x020_StructStart_Min24Bytes_Time_ { get { return Field<Time>(0x020); } }
		public int _x02C { get { return Field<int>(0x02C); } }
		public int _x030 { get { return Field<int>(0x030); } }
		public int _x034 { get { return Field<int>(0x034); } }
		public int x038_Counter_CurrentFrame { get { return Field<int>(0x038); } }
		public int x03C { get { return Field<int>(0x03C); } }
		public GameGlobals x040_GameGlobals { get { return Field<GameGlobals>(0x040); } }
		public GameGlobals x3E0_GameGlobals { get { return Field<GameGlobals>(0x3E0); } }
		// Next.Field: 0x780

		public Struct790 x790 { get { return Dereference<Struct790>(0x790); } }

		public Storage x798_Storage { get { return Field<Storage>(0x798); } }

		public ExpandableContainer<Actor> x910_RActors { get { return Dereference<ExpandableContainer<Actor>>(0x910); } }
		public ActorManager x914_ActorManager { get { return Dereference<ActorManager>(0x914); } }

		public UIManager x984_UI { get { return Dereference<UIManager>(0x984); } }

		public Container<World> x98C_CWorlds { get { return Dereference<Container<World>>(0x98C); } }

		public Player x994_Player { get { return Dereference<Player>(0x994); } }

		public class Struct790 : MemoryObject
		{
			// 2.0.0.21962
			public const int SizeOf = 0x11C; // 284

			public Struct790(ProcessMemory memory, int address)
				: base(memory, address) { }

			// 0x1000: Rendering?
			// 0x0200: Paused?
			// 0x0010: InGame?
			public int x000_Flags { get { return Field<int>(0x000); } }
			public int _x004 { get { return Field<int>(0x004); } }
			public int _x008 { get { return Field<int>(0x008); } }
			public int _x00C { get { return Field<int>(0x00C); } }
			public int _x010 { get { return Field<int>(0x010); } }
			public int _x014 { get { return Field<int>(0x014); } }
			public int _x018 { get { return Field<int>(0x018); } }
			public int _x01C { get { return Field<int>(0x01C); } }
			public int _x020 { get { return Field<int>(0x020); } }
			public int _x024 { get { return Field<int>(0x024); } }
			public int _x028 { get { return Field<int>(0x028); } }
			public int _x02C { get { return Field<int>(0x02C); } }
			public int _x030 { get { return Field<int>(0x030); } }
			public int _x034 { get { return Field<int>(0x034); } }
			public int x038_WorldId_ { get { return Field<int>(0x038); } }
			public int _x03C { get { return Field<int>(0x03C); } }
			// 0x01: Loading?
			// 0x00: Loaded?
			public int x040_Flag { get { return Field<int>(0x040); } }
			public int _x044 { get { return Field<int>(0x044); } }
			public int _x048 { get { return Field<int>(0x048); } }
			public int _x04C { get { return Field<int>(0x04C); } }
			public int _x050 { get { return Field<int>(0x050); } }
			public int x054_FrameCount { get { return Field<int>(0x054); } }
			public int x058_FrameTimestamp { get { return Field<int>(0x058); } }
			public int _x05C { get { return Field<int>(0x05C); } }
			public int x060_Flag { get { return Field<int>(0x060); } }
			public int _x064 { get { return Field<int>(0x064); } }
			public int _x068 { get { return Field<int>(0x068); } }
			public int _x06C { get { return Field<int>(0x06C); } }
			public int _x070 { get { return Field<int>(0x070); } }
			public int _x074 { get { return Field<int>(0x074); } }
			public int _x078 { get { return Field<int>(0x078); } }
			public int _x07C { get { return Field<int>(0x07C); } }
			public float _x080 { get { return Field<float>(0x080); } }
			public float _x084 { get { return Field<float>(0x084); } }
			public float _x088 { get { return Field<float>(0x088); } }
			public float _x08C { get { return Field<float>(0x08C); } }
			public float _x090 { get { return Field<float>(0x090); } }
			public float _x094 { get { return Field<float>(0x094); } }
			public int _x098 { get { return Field<int>(0x098); } }
			public float _x09C { get { return Field<float>(0x09C); } }
			public float _x0A0 { get { return Field<float>(0x0A0); } }
			public float _x0A4 { get { return Field<float>(0x0A4); } }
			public int _x0A8 { get { return Field<int>(0x0A8); } }
			public float _x0AC { get { return Field<float>(0x0AC); } }
			public float _x0B0 { get { return Field<float>(0x0B0); } }
			public float _x0B4 { get { return Field<float>(0x0B4); } }
			public float _x0B8 { get { return Field<float>(0x0B8); } }
			public float _x0BC { get { return Field<float>(0x0BC); } }
			public float _x0C0 { get { return Field<float>(0x0C0); } }
			public float _x0C4 { get { return Field<float>(0x0C4); } }
			public int _x0C8 { get { return Field<int>(0x0C8); } }
			public float _x0CC { get { return Field<float>(0x0CC); } }
			public int _x0D0 { get { return Field<int>(0x0D0); } }
			public int _x0D4 { get { return Field<int>(0x0D4); } }
			public int _x0D8 { get { return Field<int>(0x0D8); } }
			public int _x0DC { get { return Field<int>(0x0DC); } }
			public int _x0E0 { get { return Field<int>(0x0E0); } }
			public int _x0E4 { get { return Field<int>(0x0E4); } }
			public int _x0E8 { get { return Field<int>(0x0E8); } }
			public int _x0EC { get { return Field<int>(0x0EC); } }
			public int _x0F0 { get { return Field<int>(0x0F0); } }
			public int _x0F4 { get { return Field<int>(0x0F4); } }
			public int _x0F8 { get { return Field<int>(0x0F8); } }
			public int _x0FC { get { return Field<int>(0x0FC); } }
			public int _x100 { get { return Field<int>(0x100); } }
			public int _x104 { get { return Field<int>(0x104); } }
			public int _x108 { get { return Field<int>(0x108); } }
			public int _x10C { get { return Field<int>(0x10C); } }
			public int _x110 { get { return Field<int>(0x110); } }
			public int _x114 { get { return Field<int>(0x114); } }
			public int _x118 { get { return Field<int>(0x118); } }
		}



		// ABOVE ARE FROM BUILD 21806
		// BELOW ARE FROM BUILD 20874

		public Time x000_Time_build20874 { get { return Field<Time>(0x000); } }
		//public int _x00C_build20874 { get{ return Field<int>(0x00C); } }
		//public int _x010_build20874 { get{ return Field<int>(0x010); } }
		//public int _x014_build20874 { get{ return Field<int>(0x014); } }
		//public int x018_build20874 { get{ return Field<int>(0x018); } }
		//public int _x01C_build20874 { get{ return Field<int>(0x01C); } }
		//public int x020_StructStart_12Bytes_Time__build20874 { get{ return Field<int>(0x020); } }
		//public int _x024_build20874 { get{ return Field<int>(0x024); } }
		//public int _x028_build20874 { get{ return Field<int>(0x028); } }
		//public int _x02C_build20874 { get{ return Field<int>(0x02C); } }
		//public int _x030_build20874 { get{ return Field<int>(0x030); } }
		//public int _x034_build20874 { get{ return Field<int>(0x034); } }
		//public int x038_KJ_CurrentFrame_build20874 { get{ return Field<int>(0x038); } }
		//public int _x03C_build20874 { get{ return Field<int>(0x03C); } }
		public GameGlobals x040_GameGlobals_build20874 { get { return Field<GameGlobals>(0x040); } }
		//public int x3F8_GameGlobals_build20874 { get{ return Field<int>(0x3F8); } }
		//public int _x7B0_build20874 { get{ return Field<int>(0x7B0); } }
		//public int x7B4_build20874 { get{ return Field<int>(0x7B4); } }
		//public int x7B8_build20874 { get{ return Field<int>(0x7B8); } }
		//public int x7BC_Ptr_7684Bytes_NetStat_build20874 { get{ return Field<int>(0x7BC); } }
		//public int x7C0_Ptr_284Bytes_build20874 { get{ return Field<int>(0x7C0); } }
		//public int _x7C4_build20874 { get{ return Field<int>(0x7C4); } }
		//public int x7C8_StructStart_Storage_build20874 { get{ return Field<int>(0x7C8); } }
		//public int _x7CC_build20874 { get{ return Field<int>(0x7CC); } }
		//public int _x7D0_build20874 { get{ return Field<int>(0x7D0); } }
		//public int _x7D4_build20874 { get{ return Field<int>(0x7D4); } }
		//public int _x7D8_build20874 { get{ return Field<int>(0x7D8); } }
		//public int _x7DC_build20874 { get{ return Field<int>(0x7DC); } }
		//public int _x7E0_build20874 { get{ return Field<int>(0x7E0); } }
		//public int _x7E4_build20874 { get{ return Field<int>(0x7E4); } }
		//public int _x7E8_build20874 { get{ return Field<int>(0x7E8); } }
		//public int _x7EC_build20874 { get{ return Field<int>(0x7EC); } }
		//public int _x7F0_build20874 { get{ return Field<int>(0x7F0); } }
		//public int _x7F4_build20874 { get{ return Field<int>(0x7F4); } }
		//public int _x7F8_build20874 { get{ return Field<int>(0x7F8); } }
		//public int _x7FC_build20874 { get{ return Field<int>(0x7FC); } }
		//public int _x800_build20874 { get{ return Field<int>(0x800); } }
		//public int _x804_build20874 { get{ return Field<int>(0x804); } }
		//public int _x808_build20874 { get{ return Field<int>(0x808); } }
		//public int _x80C_build20874 { get{ return Field<int>(0x80C); } }
		//public int _x810_build20874 { get{ return Field<int>(0x810); } }
		//public int _x814_build20874 { get{ return Field<int>(0x814); } }
		//public int _x818_build20874 { get{ return Field<int>(0x818); } }
		//public int _x81C_build20874 { get{ return Field<int>(0x81C); } }
		//public int _x820_build20874 { get{ return Field<int>(0x820); } }
		//public int _x824_build20874 { get{ return Field<int>(0x824); } }
		//public int _x828_build20874 { get{ return Field<int>(0x828); } }
		//public int _x82C_build20874 { get{ return Field<int>(0x82C); } }
		//public int _x830_build20874 { get{ return Field<int>(0x830); } }
		//public int _x834_build20874 { get{ return Field<int>(0x834); } }
		//public int _x838_build20874 { get{ return Field<int>(0x838); } }
		//public int _x83C_build20874 { get{ return Field<int>(0x83C); } }
		//public int _x840_build20874 { get{ return Field<int>(0x840); } }
		//public int _x844_build20874 { get{ return Field<int>(0x844); } }
		//public int _x848_build20874 { get{ return Field<int>(0x848); } }
		//public int _x84C_build20874 { get{ return Field<int>(0x84C); } }
		//public int _x850_build20874 { get{ return Field<int>(0x850); } }
		//public int _x854_build20874 { get{ return Field<int>(0x854); } }
		//public int _x858_build20874 { get{ return Field<int>(0x858); } }
		//public int _x85C_build20874 { get{ return Field<int>(0x85C); } }
		//public int _x860_build20874 { get{ return Field<int>(0x860); } }
		//public int _x864_build20874 { get{ return Field<int>(0x864); } }
		//public int _x868_build20874 { get{ return Field<int>(0x868); } }
		//public int _x86C_build20874 { get{ return Field<int>(0x86C); } }
		//public int _x870_build20874 { get{ return Field<int>(0x870); } }
		//public int _x874_build20874 { get{ return Field<int>(0x874); } }
		//public int _x878_build20874 { get{ return Field<int>(0x878); } }
		//public int _x87C_build20874 { get{ return Field<int>(0x87C); } }
		//public int _x880_build20874 { get{ return Field<int>(0x880); } }
		//public int _x884_build20874 { get{ return Field<int>(0x884); } }
		//public int _x888_build20874 { get{ return Field<int>(0x888); } }
		//public int _x88C_build20874 { get{ return Field<int>(0x88C); } }
		//public int _x890_build20874 { get{ return Field<int>(0x890); } }
		//public int _x894_build20874 { get{ return Field<int>(0x894); } }
		//public int _x898_build20874 { get{ return Field<int>(0x898); } }
		//public int _x89C_build20874 { get{ return Field<int>(0x89C); } }
		//public int _x8A0_build20874 { get{ return Field<int>(0x8A0); } }
		//public int _x8A4_build20874 { get{ return Field<int>(0x8A4); } }
		//public int _x8A8_build20874 { get{ return Field<int>(0x8A8); } }
		//public int _x8AC_build20874 { get{ return Field<int>(0x8AC); } }
		//public int _x8B0_build20874 { get{ return Field<int>(0x8B0); } }
		//public int _x8B4_build20874 { get{ return Field<int>(0x8B4); } }
		//public int _x8B8_build20874 { get{ return Field<int>(0x8B8); } }
		//public int _x8BC_build20874 { get{ return Field<int>(0x8BC); } }
		//public int _x8C0_build20874 { get{ return Field<int>(0x8C0); } }
		//public int _x8C4_build20874 { get{ return Field<int>(0x8C4); } }
		//public int _x8C8_build20874 { get{ return Field<int>(0x8C8); } }
		//public int _x8CC_build20874 { get{ return Field<int>(0x8CC); } }
		//public int _x8D0_build20874 { get{ return Field<int>(0x8D0); } }
		//public int _x8D4_build20874 { get{ return Field<int>(0x8D4); } }
		//public int _x8D8_build20874 { get{ return Field<int>(0x8D8); } }
		//public int _x8DC_build20874 { get{ return Field<int>(0x8DC); } }
		//public int _x8E0_build20874 { get{ return Field<int>(0x8E0); } }
		//public int _x8E4_build20874 { get{ return Field<int>(0x8E4); } }
		//public int _x8E8_build20874 { get{ return Field<int>(0x8E8); } }
		//public int _x8EC_build20874 { get{ return Field<int>(0x8EC); } }
		//public int _x8F0_build20874 { get{ return Field<int>(0x8F0); } }
		//public int _x8F4_build20874 { get{ return Field<int>(0x8F4); } }
		//public int _x8F8_build20874 { get{ return Field<int>(0x8F8); } }
		//public int _x8FC_build20874 { get{ return Field<int>(0x8FC); } }
		//public int _x900_build20874 { get{ return Field<int>(0x900); } }
		//public int _x904_build20874 { get{ return Field<int>(0x904); } }
		//public int _x908_build20874 { get{ return Field<int>(0x908); } }
		//public int _x90C_build20874 { get{ return Field<int>(0x90C); } }
		//public int _x910_build20874 { get{ return Field<int>(0x910); } }
		//public int _x914_build20874 { get{ return Field<int>(0x914); } }
		//public int _x918_build20874 { get{ return Field<int>(0x918); } }
		//public int _x91C_build20874 { get{ return Field<int>(0x91C); } }
		//public int _x920_build20874 { get{ return Field<int>(0x920); } }
		//public int _x924_build20874 { get{ return Field<int>(0x924); } }
		//public int _x928_build20874 { get{ return Field<int>(0x928); } }
		//public int x92C_Ptr_908Bytes_Physics_build20874 { get{ return Field<int>(0x92C); } }
		//public int _x930_build20874 { get{ return Field<int>(0x930); } }
		//public int _x934_build20874 { get{ return Field<int>(0x934); } }
		//public int x938_Cutscenes_build20874 { get{ return Dereference<int>(0x938); } }
		//public int _x93C_build20874 { get{ return Field<int>(0x93C); } }
		public ExpandableContainer x940_RActors_build20874 { get { return Dereference<ExpandableContainer>(0x940); } }
		//public int x944_Ptr_856Bytes_RActors_build20874 { get{ return Field<int>(0x944); } }
		//public int x948_ClothManager_build20874 { get{ return Dereference<int>(0x948); } }
		//public int x94C_Ptr_40972Bytes_Explosions_build20874 { get{ return Field<int>(0x94C); } }
		//public int _x950_build20874 { get{ return Field<int>(0x950); } }
		//public int _x954_build20874 { get{ return Field<int>(0x954); } }
		//public int _x958_build20874 { get{ return Field<int>(0x958); } }
		//public int _x95C_build20874 { get{ return Field<int>(0x95C); } }
		//public int _x960_build20874 { get{ return Field<int>(0x960); } }
		//public int x964_Ptr_252Bytes_Cinematography_build20874 { get{ return Field<int>(0x964); } }
		//public int _x968_build20874 { get{ return Field<int>(0x968); } }
		//public int _x96C_build20874 { get{ return Field<int>(0x96C); } }
		//public int x970_Ptr_4Bytes_Attachments_build20874 { get{ return Dereference<int>(0x970); } }
		//public int x974_Ptr_456Bytes_ParentObjects_build20874 { get{ return Field<int>(0x974); } }
		//public int _x978_build20874 { get{ return Field<int>(0x978); } }
		//public int x97C_Ptr_56Bytes_DebugText_build20874 { get{ return Dereference<int>(0x97C); } }
		//public int _x980_build20874 { get{ return Field<int>(0x980); } }
		//public int x984_Scenes_build20874 { get{ return Field<int>(0x984); } }
		//public int x988_Ptr_1288Bytes_build20874 { get{ return Field<int>(0x988); } }
		//public int _x98C_build20874 { get{ return Field<int>(0x98C); } }
		//public int _x990_build20874 { get{ return Field<int>(0x990); } }
		//public int _x994_build20874 { get{ return Field<int>(0x994); } }
		//public int _x998_build20874 { get{ return Field<int>(0x998); } }
		//public int _x99C_build20874 { get{ return Field<int>(0x99C); } }
		//public int x9A0_Ptr_4Bytes_Sky_build20874 { get{ return Field<int>(0x9A0); } }
		//public int x9A4_Ptr_64Bytes_Wind_build20874 { get{ return Field<int>(0x9A4); } }
		//public int _x9A8_build20874 { get{ return Field<int>(0x9A8); } }
		//public int _x9AC_build20874 { get{ return Field<int>(0x9AC); } }
		//public int x9B0_Ptr_436Bytes_SubObjectGfx_build20874 { get{ return Field<int>(0x9B0); } }
		// X public UIManager x9B4_UI_build20874 { get{ return Dereference<UIManager>(0x9B4); } }
		//public int x9B8_Ptr_10096Bytes_CameraManager_build20874 { get{ return Field<int>(0x9B8); } }
		//public int x9BC_CWorlds_build20874 { get{ return Dereference<int>(0x9BC); } }
		//public int x9C0_Ptr_80Bytes_CWorlds_build20874 { get{ return Field<int>(0x9C0); } }
		//public int x9C4_Ptr_107400Bytes_build20874 { get{ return Field<int>(0x9C4); } }
		//public int x9C8_Ptr_92Bytes_build20874 { get{ return Field<int>(0x9C8); } }
		//public int x9CC_Ptr_1068_PostFX_build20874 { get{ return Field<int>(0x9CC); } }
		//public int x9D0_Ptr_64Bytes_Cutscenes_build20874 { get{ return Field<int>(0x9D0); } }
		//public int _x9D4_build20874 { get{ return Field<int>(0x9D4); } }
		//public int _x9D8_build20874 { get{ return Field<int>(0x9D8); } }
		//public int _x9DC_build20874 { get{ return Field<int>(0x9DC); } }
		//public int x9E0_EffectGroup_build20874 { get{ return Dereference<int>(0x9E0); } }
		//public int _x9E4_build20874 { get{ return Field<int>(0x9E4); } }
		//public int x9E8_Ptr_28Bytes_TextAnim_build20874 { get{ return Dereference<int>(0x9E8); } }
		//public int x9EC_Ptr_48Bytes_CTimedEvents_build20874 { get{ return Field<int>(0x9EC); } }
		//public int x9F0_Ptr_8Bytes_CActTransitions_build20874 { get{ return Field<int>(0x9F0); } }
		//public int x9F4_Ptr_28Bytes_ActorMovement_build20874 { get{ return Field<int>(0x9F4); } }
	}
}
