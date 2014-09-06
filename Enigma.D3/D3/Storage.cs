using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;

namespace Enigma.D3
{
	public partial class Storage : MemoryObject
	{
		// 2.1.0.26451
		// NOTE: Fields might not be fully accurate since struct was taken from last version.
		public const int SizeOf = 0x174; // 372 // Unsure about full size

		public int x000 { get { return Read<int>(0x000); } }
		public int x004 { get { return Read<int>(0x004); } }
		public int x008 { get { return Read<int>(0x008); } }
		public int x00C { get { return Read<int>(0x00C); } }
		public int x010 { get { return Read<int>(0x010); } }
		public int x014 { get { return Read<int>(0x014); } }
		public int _x018 { get { return Read<int>(0x018); } }
		public int x01C { get { return Read<int>(0x01C); } }
		public int _x020 { get { return Read<int>(0x020); } }
		public int x024 { get { return Read<int>(0x024); } }
		public int x028_Flags { get { return Read<int>(0x028); } }
		public int x02C { get { return Read<int>(0x02C); } }
		public int x030 { get { return Read<int>(0x030); } }
		public int x034 { get { return Read<int>(0x034); } }
		public int x038 { get { return Read<int>(0x038); } }
		public int x03C_Neg1 { get { return Read<int>(0x03C); } }
		public int x040_Neg1 { get { return Read<int>(0x040); } }
		public int x044_Neg1 { get { return Read<int>(0x044); } }
		public int x048_Neg1 { get { return Read<int>(0x048); } }
		public int x04C_Neg1 { get { return Read<int>(0x04C); } }
		public int _x50 { get { return Read<int>(0x50); } }//NEW
		public int _x54 { get { return Read<int>(0x54); } }//NEW
		public int _x58 { get { return Read<int>(0x58); } }//NEW
		public int _x5C { get { return Read<int>(0x5C); } }//NEW
		public int _x60 { get { return Read<int>(0x60); } }//NEW
		public int _x64 { get { return Read<int>(0x64); } }//NEW
		public int _x068 { get { return Read<int>(0x068); } }
		public int _x06C { get { return Read<int>(0x06C); } }
		public int _x070 { get { return Read<int>(0x070); } }
		public int _x074 { get { return Read<int>(0x074); } }
		public int _x078 { get { return Read<int>(0x078); } }
		public int _x07C { get { return Read<int>(0x07C); } }
		public int _x080 { get { return Read<int>(0x080); } }
		public int _x084 { get { return Read<int>(0x084); } }
		public int _x088 { get { return Read<int>(0x088); } }
		public int _x08C { get { return Read<int>(0x08C); } }
		public int x090 { get { return Read<int>(0x090); } }
		public int x094 { get { return Read<int>(0x094); } }
		public int x098 { get { return Read<int>(0x098); } }
		public int x09C { get { return Read<int>(0x09C); } }
		public int x0A0 { get { return Read<int>(0x0A0); } }
		public int x0A4 { get { return Read<int>(0x0A4); } }
		public int x0A8 { get { return Read<int>(0x0A8); } }
		public int x0AC { get { return Read<int>(0x0AC); } }
		public int x0B0 { get { return Read<int>(0x0B0); } }
		public int x0B4 { get { return Read<int>(0x0B4); } }
		public int x0B8_Neg1 { get { return Read<int>(0x0B8); } }
		public int x0BC_Neg1 { get { return Read<int>(0x0BC); } }
		public int x0C0 { get { return Read<int>(0x0C0); } }
		public int x0C4 { get { return Read<int>(0x0C4); } }
		public int x0C8 { get { return Read<int>(0x0C8); } }
		public int x0CC { get { return Read<int>(0x0CC); } }
		public int x0D0_StructStart_Min12Bytes { get { return Read<int>(0x0D0); } }
		public int _x0D4 { get { return Read<int>(0x0D4); } }
		public int _x0D8 { get { return Read<int>(0x0D8); } }
		public int _x0DC { get { return Read<int>(0x0DC); } }
		public int _x0E0 { get { return Read<int>(0x0E0); } }
		public int _x0E4 { get { return Read<int>(0x0E4); } }
		public int x0E8_GameTick { get { return Read<int>(0x0E8); } }
		public int x0EC { get { return Read<int>(0x0EC); } }
		public int x0F0 { get { return Read<int>(0x0F0); } }
		public int x0F4_Ptr_12Bytes_Markers { get { return Read<int>(0x0F4); } }
		public int x0F8_Ptr_368Bytes_InactiveMarkers { get { return Read<int>(0x0F8); } }
		public PlayerDataManager x0FC_PlayerDataCollection { get { return Dereference<PlayerDataManager>(0x0FC); } }
		public SceneAllocators x100_Ptr_116Bytes_SceneAllocators { get { return Dereference<SceneAllocators>(0x100); } }
		public int x104_Ptr_112Bytes_Items { get { return Read<int>(0x104); } }
		public int x108_Ptr_88Bytes { get { return Read<int>(0x108); } }
		public Allocator x10C_PtrAllocator_20x28Bytes { get { return Dereference<Allocator>(0x10C); } }
		public int _x110 { get { return Read<int>(0x110); } }
		public int _x114 { get { return Read<int>(0x114); } }
		public int _x118 { get { return Read<int>(0x118); } }
		public FastAttrib x11C_FastAttrib { get { return Dereference<FastAttrib>(0x11C); } }
		public int x120_Teams { get { return Read<int>(0x120); } }
		public int _x124 { get { return Read<int>(0x124); } }
		public ActorCommonDataManager x128_ActorCommonDataManager { get { return Dereference<ActorCommonDataManager>(0x128); } }
		public Allocator x12C_PtrAllocator_1000x64Bytes { get { return Dereference<Allocator>(0x12C); } }
		public Allocator x130_PtrAllocator_8x64Bytes { get { return Dereference<Allocator>(0x130); } }
		public Allocator x134_PtrAllocator_1024x16Bytes_GameBalance { get { return Dereference<Allocator>(0x134); } }
		public QuestManager x138_Ptr_5864Bytes_Quests { get { return Dereference<QuestManager>(0x138); } }
		public Allocator x13C_PtrAllocator_256x220Bytes { get { return Dereference<Allocator>(0x13C); } }
		public int _x140 { get { return Read<int>(0x140); } }
		public int x144_Ptr_16Bytes_NavCellPath { get { return Dereference<int>(0x144); } }
		public int x148_Ptr_96Bytes_ActorInventory { get { return Read<int>(0x148); } }
		public Allocator x14C_PtrAllocator_16x256Bytes_VisualInventory { get { return Dereference<Allocator>(0x14C); } }
		public Allocator x150_PtrAllocator_64x12Bytes_Portals { get { return Dereference<Allocator>(0x150); } }
		public int x154 { get { return Read<int>(0x154); } }
		public int x158_Ptr_320Bytes { get { return Read<int>(0x158); } }
		public int x15C_Ptr_288Bytes { get { return Read<int>(0x15C); } }
		public int _x160 { get { return Read<int>(0x160); } }
		public ActManager x164_Ptr_56Bytes_Acts { get { return Dereference<ActManager>(0x164); } }
		public int x168 { get { return Read<int>(0x168); } }
		public int _x16C { get { return Read<int>(0x16C); } }
		public int x170_GameType { get { return Read<int>(0x170); } }
	}

	public partial class Storage
	{
		public static Storage Instance { get { return ObjectManager.Instance.IfNotNull(a => a.x798_Storage); } }

		public int GetGameTick()
		{
			return Instance.x0E8_GameTick;
		}
	}
}
