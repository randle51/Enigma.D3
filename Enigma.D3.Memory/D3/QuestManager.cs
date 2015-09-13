using Enigma.Memory;
using System;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3
{
	public class QuestManager : MemoryObject
	{
		public const int SizeOf = 0x450; // 1104

		public Allocator x0000_Allocator_ListNode_Quest_Size_0x170 { get { return Read<Allocator>(0x000); } }
		public LinkedList<Quest> x001C_Quests { get { return Read<LinkedList<Quest>>(0x01C); } }
		public int _x002C { get { return Read<int>(0x02C); } }
		public int x0030 { get { return Read<int>(0x030); } }
		public int _x0034 { get { return Read<int>(0x034); } }
		public int x0038_Neg1 { get { return Read<int>(0x038); } }
		public int x003C { get { return Read<int>(0x03C); } }
		[ArraySize(10)]
		public X0040[] x0040_Array { get { return Read<X0040>(0x040, 10); } }
		public int x03B0 { get { return Read<int>(0x3B0); } }
		public int x03B4 { get { return Read<int>(0x3B4); } }
		public int x03B8 { get { return Read<int>(0x3B8); } }
		public int x03BC { get { return Read<int>(0x3BC); } }
		public int x03C0 { get { return Read<int>(0x3C0); } }
		public int x03C4 { get { return Read<int>(0x3C4); } }
		public int x03C8 { get { return Read<int>(0x3C8); } }
		public int x03CC { get { return Read<int>(0x3CC); } }
		public int x03D0 { get { return Read<int>(0x3D0); } }
		public int x03D4 { get { return Read<int>(0x3D4); } }
		public int x03D8 { get { return Read<int>(0x3D8); } }
		public int x03DC { get { return Read<int>(0x3DC); } }
		public int x03E0 { get { return Read<int>(0x3E0); } }
		public int x03E4 { get { return Read<int>(0x3E4); } }
		public int x03E8 { get { return Read<int>(0x3E8); } }
		public int x03EC { get { return Read<int>(0x3EC); } }
		public int x03F0 { get { return Read<int>(0x3F0); } }
		public int x03F4 { get { return Read<int>(0x3F4); } }
		public int x03F8 { get { return Read<int>(0x3F8); } }
		public int x03FC { get { return Read<int>(0x3FC); } }
		public int x0400 { get { return Read<int>(0x400); } }
		public int x0404 { get { return Read<int>(0x404); } }
		public int x0408 { get { return Read<int>(0x408); } }
		public int x040C { get { return Read<int>(0x40C); } }
		public int x0410 { get { return Read<int>(0x410); } }
		public int x0414 { get { return Read<int>(0x414); } }
		public int x0418 { get { return Read<int>(0x418); } }
		public int x041C { get { return Read<int>(0x41C); } }
		public int x0420 { get { return Read<int>(0x420); } }
		public int x0424 { get { return Read<int>(0x424); } }
		public ListB<Quest> x0428_Quests { get { return Read<ListB<Quest>>(0x428); } }
		public ListB<Quest> x043C_Quests { get { return Read<ListB<Quest>>(0x43C); } }

		public class X0040 : MemoryObject
		{
			public const int SizeOf = 88;

			public int _x00 { get { return Read<int>(0x00); } }
			public int x04_Id_Neg1 { get { return Read<int>(0x04); } }
			public int _x08 { get { return Read<int>(0x08); } }
			public int _x0C { get { return Read<int>(0x0C); } }
			public int _x10 { get { return Read<int>(0x10); } }
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
		}
	}
}
