using Enigma.Memory;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.MemoryManagement
{
    public class Allocator<T> : MemoryObject
    {
        private static bool X86 => SymbolTable.Current.Platform == Platform.X86;

        public static int SizeOf = X86 ? 0x1C : 0x30; // 4 byte alignment padding

        public int ElementSize => Read<int>(0x00);
        public int Limit => Read<int>(0x04);
        public SinglyLinkedList Blocks => Read<SinglyLinkedList>(0x08);
        public int Flags => Read<int>(X86 ? 0x10 : 0x18);
        public Ptr MemVT => Read<Ptr>(X86 ? 0x14 : 0x20);
        public int GoodFood => Read<int>(X86 ? 0x18 : 0x28); // 0xFEEDFACE when disposed.

        public class SinglyLinkedList : MemoryObject, IEnumerable<Block>
        {
            public static int SizeOf => X86 ? 0x08 : 0x10;

            public int Count => Read<int>(0x00);
            public Ptr<Node> First => Read<Ptr<Node>>(X86 ? 0x04 : 0x08);

            public IEnumerator<Block> GetEnumerator()
            {
                var node = First.Dereference();
                while (node != null)
                {
                    yield return node.Element;
                    node = node.Next.Dereference();
                }
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

            public class Node : MemoryObject
            {
                public static readonly int SizeOf = GetSizeOf();
                private static int GetSizeOf()
                {
                    int sizeOf = MemoryContext.Current.Memory.Reader.PointerSize;
                    if (TypeHelper<T>.IsMemoryPointerType)
                        sizeOf += sizeOf;
                    else sizeOf += TypeHelper<T>.SizeOf;

                    return sizeOf;
                }

                public Ptr<Node> Next => Read<Ptr<Node>>(0x00);
                public Block Element => Read<Block>(X86 ? 0x04 : 0x08);
            }
        }

        public class Block : MemoryObject
        {
            public static int SizeOf = X86 ? 0x30 : 0x3C;

            public Ptr<T> PtrElements => Read<Ptr<T>>(0x00);
            public Ptr<T> NextFreeElement => Read<Ptr<T>>(X86 ? 0x04 : 0x08);
            public int Limit => Read<int>(X86 ? 0x08 : 0x10);
            public int ElementSize => Read<int>(X86 ? 0x0C : 0x14);
            public int ElementCount => Read<int>(X86 ? 0x10 : 0x18);
            public int FreeCount => Read<int>(X86 ? 0x1C : 0x24);
            public BitArray FreeSpaceBitmap => new BitArray(Read<Ptr<byte>>(X86 ? 0x24 : 0x30).ToArray((Limit + 7) / 8));
            public int GoodFood => Read<int>(X86 ? 0x2C : 0x3C);
        }
    }
}
