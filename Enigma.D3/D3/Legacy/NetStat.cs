using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class NetStat : MemoryObject
	{
		public const int SizeOf = 0x1924; // 1.0.8.16603 : [00E8EAC0] ObjectManager::Create

		public NetStat(ProcessMemory memory, int address)
			: base(memory, address) { }

		public Allocator x0000_Allocator_Size1C { get { return Field<Allocator>(0x0000); } }
		public LinkedList<Node> x001C_OutMessageList { get { return Field<LinkedList<Node>>(0x001C); } } // capacity = 10240?
		public int _x002C { get { return Field<int>(0x002C); } }
		public int _x0030 { get { return Field<int>(0x0030); } }
		public int _x0034 { get { return Field<int>(0x0034); } }
		public int _x0038 { get { return Field<int>(0x0038); } }
		public LinkedList<Node> x003C_InMessageList { get { return Field<LinkedList<Node>>(0x003C); } } // capacity = 10240?
		public int _x004C { get { return Field<int>(0x004C); } }
		public int _x0050 { get { return Field<int>(0x0050); } }
		public int _x0054 { get { return Field<int>(0x0054); } }
		public int _x0058 { get { return Field<int>(0x0058); } }
		public int x005C { get { return Field<int>(0x005C); } }
		public int x0060_Timestamp_ { get { return Field<int>(0x0060); } }
		public int x0064 { get { return Field<int>(0x0064); } }
		public int x0068 { get { return Field<int>(0x0068); } }
		//
		// --> start of a structure
		public int x006C_OutCounterOrSize { get { return Field<int>(0x006C); } }
		public int x0070_OutCounter { get { return Field<int>(0x0070); } }
		// Most likely a buffer area (0xA8 / 168)
		public int x0118_OutCounterOrSize { get { return Field<int>(0x0118); } }
		public int x011C_OutCounter { get { return Field<int>(0x11C); } }
		public Tuple<int, int>[] x0120_OutItems { get { return Field<Tuple<int, int>>(0x0120, 373); } } // (see sub_BA0B90).
		// <--- end of structure
		//
		// --> start of a structure
		public int x0CC8_InCounterOrSize { get { return Field<int>(0x0CC8); } }
		public int x0CCC_InCounter { get { return Field<int>(0x0CCC); } }
		// Most likely a buffer area (0xA8 / 168)
		public int x0D74_InCounterOrSize { get { return Field<int>(0x0D74); } }
		public int x0D78_InCounter { get { return Field<int>(0x0D78); } }
		public Tuple<int, int>[] x0D7C_InItems { get { return Field<Tuple<int, int>>(0x0D7C, 373); } } // (see sub_BA0B90).
		// <-- end of a structure
		//


		public class Node : MemoryObject
		{
			public const int SizeOf = 20; // = 0x14

			public Node(ProcessMemory memory, int address)
				: base(memory, address) { }

			public Message x00_Message { get { return Field<Message>(0x00); } }
			public LinkedListNode<Node> x0C_Previous { get { return Dereference<LinkedListNode<Node>>(0x0C); } }
			public LinkedListNode<Node> x10_Next { get { return Dereference<LinkedListNode<Node>>(0x10); } }
		}



		public class Message : MemoryObject
		{
			public const int SizeOf = 12; // = 0x0C

			public Message(ProcessMemory memory, int address)
				: base(memory, address) { }

			public int x00_MessageType { get { return Field<int>(0x00); } }
			public int x04_Frame { get { return Field<int>(0x04); } }
			public int x08 { get { return Field<int>(0x08); } }
		}
	}
}
