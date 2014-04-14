using System;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3
{
	public class NetworkManager : MemoryObject
	{
		// 2.0.0.20874
		public const int SizeOf = 0x134; // = 308

		public NetworkManager(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int _x000 { get { return Field<int>(0x000); } }
		public int x004_SocketHandle { get { return Field<int>(0x004); } }
		public int x008_IsClosed { get { return Field<int>(0x008); } }
		public int x00C_Ptr_32768Bytes { get { return Field<int>(0x00C); } }
		public int x010 { get { return Field<int>(0x010); } }
		public int x014_Ptr_32768Bytes { get { return Field<int>(0x014); } }
		public int x018 { get { return Field<int>(0x018); } }
		public int x01C { get { return Field<int>(0x01C); } }
		public int x020 { get { return Field<int>(0x020); } }
		public int x024 { get { return Field<int>(0x024); } }
		public int x028_IsConnected__ { get { return Field<int>(0x028); } }
		public int x02C { get { return Field<int>(0x02C); } }
		public int _x030 { get { return Field<int>(0x030); } }
		public int _x034 { get { return Field<int>(0x034); } }
		public int x038 { get { return Field<int>(0x038); } }
		public int x03C_Method { get { return Field<int>(0x03C); } }
		public int x040 { get { return Field<int>(0x040); } }
		public int x044 { get { return Field<int>(0x044); } }
		public int x048 { get { return Field<int>(0x048); } }
		public int x04C_Method { get { return Field<int>(0x04C); } }
		public LinkedList<Pointer<NetworkMessage>> x050_OutMessageList { get { return Field<LinkedList<Pointer<NetworkMessage>>>(0x050); } }
		public int _x060 { get { return Field<int>(0x060); } }
		public LinkedList<Pointer<NetworkMessage>> x064_InMessageList { get { return Field<LinkedList<Pointer<NetworkMessage>>>(0x064); } }
		public int _x074 { get { return Field<int>(0x074); } }
		public int x078_Ptr_168Bytes_MessageAllocators { get { return Dereference<int>(0x078); } }
		public Allocator x07C_Allocator_10x12Bytes_ListNode { get { return Field<Allocator>(0x07C); } }
		public int x098 { get { return Field<int>(0x098); } }
		public int x09C { get { return Field<int>(0x09C); } }
		public int x0A0 { get { return Field<int>(0x0A0); } }
		public int x0A4 { get { return Field<int>(0x0A4); } }
		public int _x0A8 { get { return Field<int>(0x0A8); } }
		public int _x0AC { get { return Field<int>(0x0AC); } }
		public int _x0B0 { get { return Field<int>(0x0B0); } }
		public int _x0B4 { get { return Field<int>(0x0B4); } }
		public int _x0B8 { get { return Field<int>(0x0B8); } }
		public int _x0BC { get { return Field<int>(0x0BC); } }
		public int _x0C0 { get { return Field<int>(0x0C0); } }
		public int _x0C4 { get { return Field<int>(0x0C4); } }
		public int _x0C8 { get { return Field<int>(0x0C8); } }
		public int _x0CC { get { return Field<int>(0x0CC); } }
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
		public int _x11C { get { return Field<int>(0x11C); } }
		public int _x120 { get { return Field<int>(0x120); } }
		public int _x124 { get { return Field<int>(0x124); } }
		public int _x128 { get { return Field<int>(0x128); } }
		public int _x12C { get { return Field<int>(0x12C); } }
		public int _x130 { get { return Field<int>(0x130); } }
	}
}
