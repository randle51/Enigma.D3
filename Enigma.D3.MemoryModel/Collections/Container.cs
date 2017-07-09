using Enigma.Memory;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Collections
{
    // TODO: Other offsets for 32-bit?
    public class Container<T> : MemoryObject, IReadOnlyList<T>
    {
        public const int SizeOf = 0x130; // TODO: Lower size in 32-bit?

        public string Name => ReadString(0x000, 256, Encoding.ASCII);
        public int Capacity => Read<int>(0x100);
        public int ItemSize => Read<int>(0x104);
        public int MaxIndex => Read<int>(0x108);
        public int Count => Read<int>(0x10C);
        public short NextHash => Read<short>(0x110); // Incremented by 1 for each new item, starts as a Djb hash (using base 0) of Name.
        public short NextIndex => Read<short>(0x112); // Incremented by 1 for each new item.
        public int Free => Read<int>(0x114);
        public int NeedsToExpand => Read<int>(0x118);
        public virtual IAllocator Allocator => Read<_Allocator>(SymbolTable.Current.Platform == Platform.X64 ? 0x120 : 0x11C);

        public virtual T this[int index]
            => (Allocator as _Allocator).Items[index];

        public interface IAllocator { }

        private class _Allocator : MemoryObject, IAllocator
        {
            public const int SizeOf = 0x10;

            public Ptr<T> Items => Read<Ptr<T>>(0x00);
            public Ptr VT => Read<Ptr>(0x08); // 0 (NULL).
        }

        public virtual MemorySegment[] GetAllocatedBytes(ref byte[] buffer)
        {
            var size = Capacity * ItemSize;
            if (buffer.Length != size)
                Array.Resize(ref buffer, size);
            var address = (Allocator as _Allocator).Items.ValueAddress;
            Memory.Reader.ReadBytes(address, buffer, 0, (MaxIndex + 1) * ItemSize);
            return new[] { new MemorySegment { Address = address, Size = (ulong)size } };
        }

        public virtual IEnumerator<T> GetEnumerator()
        {
            short maxIndex = (short)MaxIndex;
            if (maxIndex < 0)
                yield break;

            foreach (var item in (Allocator as _Allocator).Items.ToArray(maxIndex + 1))
                yield return item;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public override string ToString() => Name;
    }
}
