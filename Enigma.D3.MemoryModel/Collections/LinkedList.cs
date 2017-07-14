using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Enigma.D3.MemoryModel.MemoryManagement;

namespace Enigma.D3.MemoryModel.Collections
{
    public class LinkedList<T> : MemoryObject, IReadOnlyCollection<T>
    {
        public static int SizeOf = SymbolTable.Current.Platform == Platform.X86 ? 0x10 : 0x20;

        public Ptr<LinkedListNode<T>> First => Read<Ptr<LinkedListNode<T>>>(0x00);
        public Ptr<LinkedListNode<T>> Last => this.PlatformRead<Ptr<LinkedListNode<T>>>(0x04, 0x08);
        public int Count => this.PlatformRead<int>(0x08, 0x10);
        // 0x14: 64-bit padding
        public Ptr<Allocator<LinkedListNode<T>>> PtrAllocator => this.PlatformRead<Ptr<Allocator<LinkedListNode<T>>>>(0x0C, 0x18);

        public IEnumerator<T> GetEnumerator()
        {
            var ptr = First;
            while (!ptr.IsInvalid)
            {
                var node = ptr.Dereference();
                yield return node.Value;
                ptr = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class LinkedListB<T> : LinkedList<T>
    {
        public new static int SizeOf => SymbolTable.Current.Platform == Platform.X86 ? 0x14 : 0x28;

        public int P86_x10_Boolean { get { return Read<int>(0x10); } }

        public int P64_x20_Boolean => Read<int>(0x20);
        public int P64_x24_Padding => Read<int>(0x24);
    }

    public class LinkedListNode<T> : MemoryObject
    {
        private static int _sizeOfValue => AlignedSize(TypeHelper<T>.SizeOf, TypeHelper<Ptr>.SizeOf); // align to 4 or 8 bytes
        public static int SizeOf => _sizeOfValue + TypeHelper<Ptr>.SizeOf * 2;

        public T Value { get { return Read<T>(0x00); } }
        public Ptr<LinkedListNode<T>> Previous { get { return Read<Ptr<LinkedListNode<T>>>(_sizeOfValue); } }
        public Ptr<LinkedListNode<T>> Next { get { return Read<Ptr<LinkedListNode<T>>>(_sizeOfValue + TypeHelper<Ptr>.SizeOf); } }
    }

    public class LinkedListWithAllocator<T> : LinkedList<T>
    {
        public new static int SizeOf => SymbolTable.Current.Platform == Platform.X86 ? 0x2C : 0x50;

        public Allocator<LinkedListNode<T>> Allocator => this.PlatformRead<Allocator<LinkedListNode<T>>>(0x10, 0x20);
    }

    public class LinkedListWithAllocatorB<T> : LinkedListWithAllocator<T>
    {
        public new static int SizeOf => SymbolTable.Current.Platform == Platform.X86 ? 0x30 : 0x58;
        
        public int P86_x2C_Boolean => Read<int>(0x2C);
        public int P64_x50_Boolean => Read<int>(0x50);
        public int P64_x54_Padding => Read<int>(0x54);
    }
}
