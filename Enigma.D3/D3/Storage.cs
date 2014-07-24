using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;

namespace Enigma.D3
{
	public class Storage : MemoryObject
	{
		// 2.0.0.21962
		// NOTE: Fields might not be fully accurate since struct was taken from last version.
		public const int SizeOf = 0; // Unsure about full size

		public Storage(MemoryBase memory, int address)
			: base(memory, address) { }

		public int x000 { get { return Field<int>(0x000); } }
		public int x004 { get { return Field<int>(0x004); } }
		public int x008 { get { return Field<int>(0x008); } }
		public int x00C { get { return Field<int>(0x00C); } }
		public int x010 { get { return Field<int>(0x010); } }
		public int x014 { get { return Field<int>(0x014); } }
		public int _x018 { get { return Field<int>(0x018); } }
		public int x01C { get { return Field<int>(0x01C); } }
		public int _x020 { get { return Field<int>(0x020); } }
		public int x024 { get { return Field<int>(0x024); } }
		public int x028_Flags { get { return Field<int>(0x028); } }
		public int x02C { get { return Field<int>(0x02C); } }
		public int x030 { get { return Field<int>(0x030); } }
		public int x034 { get { return Field<int>(0x034); } }
		public int x038 { get { return Field<int>(0x038); } }
		public int x03C_Neg1 { get { return Field<int>(0x03C); } }
		public int x040_Neg1 { get { return Field<int>(0x040); } }
		public int x044_Neg1 { get { return Field<int>(0x044); } }
		public int x048_Neg1 { get { return Field<int>(0x048); } }
		public int x04C_Neg1 { get { return Field<int>(0x04C); } }
		public int _x050 { get { return Field<int>(0x050); } }
		public int _x054 { get { return Field<int>(0x054); } }
		public int _x058 { get { return Field<int>(0x058); } }
		public int _x05C { get { return Field<int>(0x05C); } }
		public int _x060 { get { return Field<int>(0x060); } }
		public int _x064 { get { return Field<int>(0x064); } }
		public int _x068 { get { return Field<int>(0x068); } }
		public int _x06C { get { return Field<int>(0x06C); } }
		public int _x070 { get { return Field<int>(0x070); } }
		public int _x074 { get { return Field<int>(0x074); } }
		public int x078 { get { return Field<int>(0x078); } }
		public int x07C { get { return Field<int>(0x07C); } }
		public int x080 { get { return Field<int>(0x080); } }
		public int x084 { get { return Field<int>(0x084); } }
		public int x088 { get { return Field<int>(0x088); } }
		public int x08C { get { return Field<int>(0x08C); } }
		public int x090 { get { return Field<int>(0x090); } }
		public int x094 { get { return Field<int>(0x094); } }
		public int x098 { get { return Field<int>(0x098); } }
		public int x09C { get { return Field<int>(0x09C); } }
		public int x0A0_Neg1 { get { return Field<int>(0x0A0); } }
		public int x0A4_Neg1 { get { return Field<int>(0x0A4); } }
		public int x0A8 { get { return Field<int>(0x0A8); } }
		public int x0AC { get { return Field<int>(0x0AC); } }
		public int x0B0 { get { return Field<int>(0x0B0); } }
		public int x0B4 { get { return Field<int>(0x0B4); } }
		public int x0B8_StructStart_Min12Bytes { get { return Field<int>(0x0B8); } }
		public int _x0BC { get { return Field<int>(0x0BC); } }
		public int _x0C0 { get { return Field<int>(0x0C0); } }
		public int _x0C4 { get { return Field<int>(0x0C4); } }
		public int _x0C8 { get { return Field<int>(0x0C8); } }
		public int _x0CC { get { return Field<int>(0x0CC); } }
		public int x0D0_KJ_GameTick { get { return Field<int>(0x0D0); } }
		public int x0D4 { get { return Field<int>(0x0D4); } }
		public int x0D8 { get { return Field<int>(0x0D8); } }
		public int x0DC_Ptr_12Bytes_Markers { get { return Field<int>(0x0DC); } }
		public int x0E0_Ptr_368Bytes_InactiveMarkers { get { return Field<int>(0x0E0); } }
		public PlayerDataManager x0E4_PlayerDataCollection { get { return Dereference<PlayerDataManager>(0x0E4); } }
		public SceneAllocators x0E8_Ptr_116Bytes_SceneAllocators { get { return Dereference<SceneAllocators>(0x0E8); } }
		public int x0EC_Ptr_112Bytes_Items { get { return Field<int>(0x0EC); } }
		public int x0F0_Ptr_88Bytes { get { return Field<int>(0x0F0); } }
		public Allocator x0F4_PtrAllocator_20x28Bytes { get { return Dereference<Allocator>(0x0F4); } }
		public int _x0F8 { get { return Field<int>(0x0F8); } }
		public int _x0FC { get { return Field<int>(0x0FC); } }
		public int _x100 { get { return Field<int>(0x100); } }
		public FastAttrib x104_FastAttrib { get { return Dereference<FastAttrib>(0x104); } }
		public int x108_Teams { get { return Field<int>(0x108); } }
		public int _x10C { get { return Field<int>(0x10C); } }
		public ActorCommonDataManager x110_ActorCommonDataManager { get { return Dereference<ActorCommonDataManager>(0x110); } }
		public Allocator x114_PtrAllocator_1000x64Bytes { get { return Dereference<Allocator>(0x114); } }
		public Allocator x118_PtrAllocator_8x64Bytes { get { return Dereference<Allocator>(0x118); } }
		public Allocator x11C_PtrAllocator_1024x16Bytes_GameBalance { get { return Dereference<Allocator>(0x11C); } }
		public QuestManager x120_Ptr_5864Bytes_Quests { get { return Dereference<QuestManager>(0x120); } }
		public Allocator x124_PtrAllocator_256x220Bytes { get { return Dereference<Allocator>(0x124); } }
		public int _x128 { get { return Field<int>(0x128); } }
		public int x12C_Ptr_16Bytes_NavCellPath { get { return Dereference<int>(0x12C); } }
		public int x130_Ptr_96Bytes_ActorInventory { get { return Field<int>(0x130); } }
		public Allocator x134_PtrAllocator_16x256Bytes_VisualInventory { get { return Dereference<Allocator>(0x134); } }
		public Allocator x138_PtrAllocator_64x12Bytes_Portals { get { return Dereference<Allocator>(0x138); } }
		public int x13C { get { return Field<int>(0x13C); } }
		public int x140_Ptr_320Bytes { get { return Field<int>(0x140); } }
		public int x144_Ptr_288Bytes { get { return Field<int>(0x144); } }
		public int _x148 { get { return Field<int>(0x148); } }
		public ActManager x14C_Ptr_56Bytes_Acts { get { return Dereference<ActManager>(0x14C); } }
		public int x150 { get { return Field<int>(0x150); } }
		public int _x154 { get { return Field<int>(0x154); } }
		public int x158_GameType { get { return Field<int>(0x158); } }
	}
}
