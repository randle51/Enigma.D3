using Enigma.D3.MemoryModel.MemoryManagement;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Caching
{
    public class AllocationCache<T> where T : MemoryObject
    {
        private readonly Allocator<T> _allocator;
        private MemoryBlock[] _blocks;

        public AllocationCache(Allocator<T> allocator)
        {
            _allocator = allocator ?? throw new ArgumentNullException(nameof(allocator));
        }

        public void Update()
        {
            _blocks = _allocator.Blocks
                .Select(block => new MemoryBlock
                {
                    Address = block.PtrElements.ValueAddress,
                    Data = block.PtrElements.Cast<byte>().ToArray(block.Limit * block.ElementSize)
                }).ToArray();
        }

        public T Read(MemoryAddress address)
        {
            var block = _blocks.FirstOrDefault(x => x.Contains(address));
            if (block == null)
                throw new ArgumentException("Address not contained in the cache.", nameof(address));

            var reader = new BufferMemoryReader(block.Data, 0, block.Data.Length, _allocator.Memory.Reader.PointerSize);
            var offset = address - block.Address;
            var value = reader.Read<T>(offset);
            return value;
        }

        public T[] GetItems()
        {
            var items = new T[_blocks.Sum(x => x.Data.Length / TypeHelper<T>.SizeOf)];
            var index = 0;
            foreach (var block in _blocks)
            {
                var offset = 0;
                while (offset < block.Data.Length)
                {
                    var item = _allocator.Memory.Reader.Read<T>(block.Address + offset);
                    (item as MemoryObject).SetSnapshot(block.Data, offset, TypeHelper<T>.SizeOf);
                    items[index] = item;
                    index++;
                    offset += TypeHelper<T>.SizeOf;
                }
            }
            return items;
        }

        private class MemoryBlock
        {
            public MemoryAddress Address;
            public byte[] Data;

            public bool Contains(MemoryAddress address)
                => address >= Address && address < Address + Data.Length;
        }
    }
}
