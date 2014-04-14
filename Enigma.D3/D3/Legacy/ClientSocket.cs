using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class ClientSocket : MemoryObject
	{
		public const int SizeOf = 0x134; // 1.0.8.16603 (see 00B60090)

		public ClientSocket(ProcessMemory memory, int address)
			: base(memory, address) { }

		// D452A0 suggests that the 0x40 (64) first bytes are a CNetwork type

		public int _x000 { get { return Field<int>(0x000); } }
		public int x004_SocketHandle { get { return Field<int>(0x004); } }
		public int x008 { get { return Field<int>(0x008); } }
		public int x00C_Ptr { get { return Field<int>(0x00C); } }
		public int _x010 { get { return Field<int>(0x010); } }
		public int x014_Ptr { get { return Field<int>(0x014); } }
		public int _x018 { get { return Field<int>(0x018); } }
		public int _x01C { get { return Field<int>(0x01C); } }
		public int _x020 { get { return Field<int>(0x020); } }
		public int _x024 { get { return Field<int>(0x024); } }
		public int x028_IsConnected { get { return Field<int>(0x028); } }
		public int x02C { get { return Field<int>(0x02C); } }
		public int x030 { get { return Field<int>(0x030); } }
		public int _x034_MessageIdReceiveCount { get { return Field<int>(0x034); } }
		public int x038 { get { return Field<int>(0x038); } }
		public int x03C_Method_ { get { return Field<int>(0x03C); } }
		public int x040 { get { return Field<int>(0x040); } }
		public int _x044 { get { return Field<int>(0x044); } }
		public int x048 { get { return Field<int>(0x048); } }
		public int _x04C { get { return Field<int>(0x04C); } }
		public int x050 { get { return Field<int>(0x050); } }
		public int x054 { get { return Field<int>(0x054); } }
		public int x058 { get { return Field<int>(0x058); } }
		public Allocator x05C_PtrAllocator_x07C { get { return Dereference<Allocator>(0x05C); } }
		public int _x060 { get { return Field<int>(0x060); } }
		public LinkedList<MemoryObject> x064_MessageList { get { return Field<LinkedList<MemoryObject>>(0x064); } }
		public int _x074 { get { return Field<int>(0x074); } }
		public MessageAllocators x078_MessageAllocators { get { return Dereference<MessageAllocators>(0x078); } }
		public Allocator x07C_Allocator_10x12 { get { return Field<Allocator>(0x07C); } }
		public int x098 { get { return Field<int>(0x098); } }

		// Circular buffer containing the last 10(+1) message ids received. This history is dumped after getting a corrupt message.
		public int x09C_MessageIdBufferStart { get { return Field<int>(0x09C); } }
		public int x0A0_MessageIdBufferEnd { get { return Field<int>(0x0A0); } }
		public int x0A4_MessageIdBufferSize { get { return Field<int>(0x0A4); } }
		public int[] x0A8_MessageIdBuffer { get { return Field<int>(0x0A8, 11); } }
		public int _00 { get { return Field<int>(0x0A8 + 0); } }
		public int _01 { get { return Field<int>(0x0A8 + 4); } }
		public int _02 { get { return Field<int>(0x0A8 + 8); } }
		public int _03 { get { return Field<int>(0x0A8 + 12); } }
		public int _04 { get { return Field<int>(0x0A8 + 16); } }
		public int _05 { get { return Field<int>(0x0A8 + 20); } }
		public int _06 { get { return Field<int>(0x0A8 + 24); } }
		public int _07 { get { return Field<int>(0x0A8 + 28); } }
		public int _08 { get { return Field<int>(0x0A8 + 32); } }
		public int _09 { get { return Field<int>(0x0A8 + 36); } }
		public int _10 { get { return Field<int>(0x0A8 + 40); } }

		public int _x0D4 { get { return Field<int>(0x0D4); } }
		public int x0D8 { get { return Field<int>(0x0D8); } }
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
		public int x108 { get { return Field<int>(0x108); } }
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

		public class MessageAllocators : MemoryObject
		{
			public const int SizeOf = 0xA8; // 1.0.8.16603 (see sub_FE8F60)

			public MessageAllocators(ProcessMemory memory, int address)
				: base(memory, address) { }

			// All elements created by these allocators are in the following format:
			//  0x00 : int Size
			//  0x04 : ???
			//  0x08 : byte[Size] Data;
			public Allocator x00_Allocator_Size8 { get { return Field<Allocator>(0x00); } }
			public Allocator x1C_Allocator_Size32 { get { return Field<Allocator>(0x1C); } }
			public Allocator x38_Allocator_Size128 { get { return Field<Allocator>(0x38); } }
			public Allocator x54_Allocator_Size512 { get { return Field<Allocator>(0x54); } }
			public Allocator x70_Allocator_Size1024 { get { return Field<Allocator>(0x70); } }
			public Allocator x8C_Allocator_Size32768 { get { return Field<Allocator>(0x8C); } }
		}
	}
}
