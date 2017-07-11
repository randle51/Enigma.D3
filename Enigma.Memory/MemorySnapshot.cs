using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Memory
{
    internal class MemorySnapshot
    {
        public MemorySnapshot(IMemory baseMemory, MemoryAddress baseAddress, byte[] buffer, int offset, int count)
        {
            BaseMemory = baseMemory;
            BaseAddress = baseAddress;
            SnapshotReader = new BufferMemoryReader(buffer, offset, count, baseMemory.Reader.PointerSize);
        }

        public IMemory BaseMemory { get; private set; }

        public MemoryAddress BaseAddress { get; private set; }
        
        public BufferMemoryReader SnapshotReader { get; private set; }

        public bool IsRoot(MemoryObject memoryObject)
        {
            return memoryObject.Address == BaseAddress &&
                TypeHelper.SizeOf(memoryObject.GetType()) == SnapshotReader.Segment.Array.Length;
        }

        public void Refresh()
        {
            BaseMemory.Reader.ReadBytes(
                BaseAddress,
                SnapshotReader.Segment.Array,
                SnapshotReader.Segment.Offset,
                SnapshotReader.Segment.Count);
        }
        
        public T Read<T>(MemoryAddress address)
        {
            var snapshotAddress = ToSnapshotAddress(address);
            if (TypeHelper<T>.IsMemoryObjectType)
            {
                var value = BaseMemory.Reader.Read<T>(address);
                (value as MemoryObject).SetSnapshot(
                    SnapshotReader.Segment.Array,
                    SnapshotReader.Segment.Offset + snapshotAddress,
                    TypeHelper<T>.SizeOf);
                return value;
            }
            else if (TypeHelper<T>.IsMemoryPointerType)
            {
                // It is important that a pointer doesn't get a snapshot as context!
                return (T)MemoryPointerFactory.Create<T>(BaseMemory,
                    SnapshotReader.ReadMemoryAddress(snapshotAddress));
            }
            return SnapshotReader.Read<T>(snapshotAddress);
        }

        public T[] Read<T>(MemoryAddress address, int count)
        {
            var snapshotAddress = ToSnapshotAddress(address);

            if (TypeHelper<T>.IsMemoryObjectType)
            {
                var array = BaseMemory.Reader.Read<T>(address, count);
                var itemOffset = snapshotAddress;
                for (int i = 0; i < count; i++)
                {
                    (array[i] as MemoryObject).SetSnapshot(
                        SnapshotReader.Segment.Array,
                        SnapshotReader.Segment.Offset + itemOffset,
                        TypeHelper<T>.SizeOf);
                    itemOffset += TypeHelper<T>.SizeOf;
                }
                return array;
            }
            else if (TypeHelper<T>.IsMemoryPointerType)
            {
                // It is important that a pointer doesn't get a snapshot as context!
                var array = new T[count];
                for (int i = 0; i < count; i++)
                {
                    array[i] = (T)MemoryPointerFactory.Create<T>(BaseMemory,
                        SnapshotReader.ReadMemoryAddress(snapshotAddress + i * BaseMemory.Reader.PointerSize));
                }
                return array;
            }
            return SnapshotReader.Read<T>(snapshotAddress, count);
        }

        public string ReadString(MemoryAddress address, int maxLength, Encoding encoding)
        {
            var snapshotAddress = ToSnapshotAddress(address);
            return SnapshotReader.ReadString(snapshotAddress, maxLength, encoding);
        }

        public MemoryAddress ReadMemoryAddress(MemoryAddress address)
        {
            var snapshotAddress = ToSnapshotAddress(address);
            return SnapshotReader.ReadMemoryAddress(snapshotAddress);
        }

        private MemoryAddress ToSnapshotAddress(MemoryAddress address)
        {
            return address - SnapshotReader.Segment.Offset - BaseAddress;
        }
    }
}
