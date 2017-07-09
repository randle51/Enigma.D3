using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Collections
{
    public class ExpandableContainer<T> : Container<T>
    {
        public new const int SizeOf = 0x170; // 0x168 for 32-bit

        public override IAllocator Allocator => Read<_Allocator>(0x120);
        private class _Allocator : MemoryObject, IAllocator
        {
            public const int SizeOf = 0x2C;

            public Ptr<Ptr<T>> Items => Read<Ptr<Ptr<T>>>(0x00);
            public int BlockAllocations => Read<int>(0x08);
            public int x0C => Read<int>(0x0C); // Padding?

            // Could be new struct start
            public Ptr x10 => Read<Ptr>(0x10); // Array of block pointers
            public int Size => Read<int>(0x18);
            public int Flags => Read<int>(0x1C);
            public Ptr VT => Read<Ptr>(0x20);
            public int GoodFood => Read<int>(0x28);
        }
        public int x14C => Read<int>(0x14C); // Padding? Is part of _Allocator?
        public int x150 => Read<int>(0x150);
        public int x154 => Read<int>(0x154);
        public Ptr x158 => Read<Ptr>(0x158); // 0 (NULL).
        public int Limit => Read<int>(_32or64(0x15C, 0x160));
        public int MaxLimit => Read<int>(_32or64(0x160, 0x164));
        public int Bits => Read<int>(_32or64(0x164, 0x168));
        public int x16C => Read<int>(0x16C); // X64 Padding

        private int _32or64(int x86, int x64) => SymbolTable.Current.Platform == Platform.X86 ? x86 : x64;

        public override T this[int index]
        {
            get
            {
                index = (short)index;
                var blockSize = 1 << Bits;
                var blockNumber = index / blockSize;
                var blockOffset = index % blockSize;
                return (Allocator as _Allocator).Items[blockNumber][blockOffset];
            }
        }

        public override MemorySegment[] GetAllocatedBytes(ref byte[] buffer)
        {
            var blockSize = 1 << Bits;
            var blockCount = MaxIndex == 0xFFF ? 0 : ((MaxIndex / blockSize) + 1);
            var size = blockSize * blockCount * ItemSize;
            if (buffer.Length != size)
                Array.Resize(ref buffer, size);

            var segments = new MemorySegment[blockCount];

            var blocks = (Allocator as _Allocator).Items.ToArray(blockCount);
            var offset = 0;
            for (int i = 0; i < blockCount; i++)
            {
                var remainingItems = (MaxIndex + 1) - blockSize * i;

                segments[i].Address = blocks[i].ValueAddress;
                segments[i].Size = (ulong)(remainingItems * ItemSize);

                Memory.Reader.ReadBytes(blocks[i].ValueAddress, buffer, offset, remainingItems * ItemSize);
                offset += blockSize * ItemSize;
            }

            return segments;
        }

        public override IEnumerator<T> GetEnumerator()
        {
            short maxIndex = (short)MaxIndex;
            if (maxIndex < 0)
                yield break;

            int blockSize = 1 << Bits;
            int blockCount = (maxIndex / blockSize) + 1;

            var blocks = (Allocator as _Allocator).Items.ToArray(blockCount);

            var remaining = maxIndex + 1;
            foreach (var block in blocks)
            {
                var items = block.ToArray(Math.Min(remaining, blockSize));
                foreach (var item in items)
                    yield return item;
                remaining -= items.Length;
            }
        }
    }
}
