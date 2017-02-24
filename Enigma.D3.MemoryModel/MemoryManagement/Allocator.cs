using Enigma.Memory;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.MemoryManagement
{
	// TODO: Other offsets for 32-bit?
	public class Allocator<T> : MemoryObject
	{
		public const int SizeOf = 0x2C;

		public int x00_ElementSize => Read<int>(0x00);
		public int x04_Limit => Read<int>(0x04);
		public SinglyLinkedList x08_Blocks => Read<SinglyLinkedList>(0x08);
		public int x18_Flags => Read<int>(0x18);
		public int x1C_Padding => Read<int>(0x1C);
		public Ptr x20_MemVT => Read<Ptr>(0x20);
		public int x28_GoodFood => Read<int>(0x28); // 0xFEEDFACE when disposed.

		public class SinglyLinkedList : MemoryObject
		{
			public const int SizeOf = 0x10;

			public int x00_Count => Read<int>(0x00);
			public int x04_Padding => Read<int>(0x04);
			public Ptr<Node> x08_First => Read<Ptr<Node>>(0x08);

			public class Node : MemoryObject
			{
				public static readonly int SizeOf = GetSizeOf();
				private static int GetSizeOf()
				{
					int sizeOf = 8;
					sizeOf += TypeHelper<T>.IsMemoryPointerType ? 8 : TypeHelper<T>.SizeOf;
					return sizeOf;
				}

				public Ptr<Node> x00_Next => Read<Ptr<Node>>(0x00);
				public Block x08_Element => Read<Block>(0x08);
			}
		}

		public class Block : MemoryObject
		{
			public const int SizeOf = 0x3C;

			public Ptr<T> x00_PtrElements => Read<Ptr<T>>(0x00);
			public Ptr<T> x08_NextFreeElement => Read<Ptr<T>>(0x08);
			public int x10_Limit => Read<int>(0x10);
			public int x14_ElementSize => Read<int>(0x14);
			public int x18_ElementCount => Read<int>(0x18);
			public int x1C => Read<int>(0x1C);
			public int x20 => Read<int>(0x20);
			public int x24_FreeCount => Read<int>(0x24);
			public int x28 => Read<int>(0x28);
			public int x2C_Padding => Read<int>(0x2C);
			public BitArray x30_FreeSpaceBitmap => new BitArray(Read<Ptr<byte>>(0x30).ToArray((x10_Limit + 7) / 8));
			public int x38 => Read<int>(0x34);
			public int x3C_GoodFood => Read<int>(0x3C);
		}
	}
}
