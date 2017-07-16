using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Memory
{
    public class MemoryObject
    {
        public static int AlignedSize(int size, int alignment)
        {
            return ((size + (alignment - 1)) / alignment) * alignment;
        }

        public IMemory Memory { get; private set; }

        public MemoryAddress Address { get; private set; }

        internal MemorySnapshot Snapshot { get; private set; }

        internal protected MemoryObject Initialize(IMemory memory, MemoryAddress address)
        {
            Memory = memory;
            Address = address;
            return this;
        }

        public virtual T Read<T>(int offset)
        {
            if (!TypeHelper<T>.IsTypeSupportedByMemoryReader)
                throw new NotSupportedException();

            var snapshot = Snapshot;
            if (snapshot != null)
            {
                return snapshot.Read<T>(GetAbsoluteAddress(offset));
            }
            return Memory.Reader.Read<T>(GetAbsoluteAddress(offset));
        }

        public virtual T[] Read<T>(int offset, int count)
        {
            if (!TypeHelper<T>.IsTypeSupportedByMemoryReader)
                throw new NotSupportedException();

            var snapshot = Snapshot;
            if (snapshot != null)
            {
                return Snapshot.Read<T>(GetAbsoluteAddress(offset), count);
            }
            return Memory.Reader.Read<T>(GetAbsoluteAddress(offset), count);
        }

        public string ReadString(int offset, int maxLength)
        {
            return ReadString(offset, maxLength, Encoding.UTF8);
        }

        public string ReadString(int offset, int maxLength, Encoding encoding)
        {
            var snapshot = Snapshot;
            if (snapshot != null)
            {
                return snapshot.ReadString(GetAbsoluteAddress(offset), maxLength, encoding);
            }
            return Memory.Reader.ReadString(GetAbsoluteAddress(offset), maxLength, encoding);
        }

        public Ptr ReadPointer(int offset)
        {
            return new Ptr(Memory, ReadMemoryAddress(offset));
        }

        public Ptr<T> ReadPointer<T>(int offset)
        {
            if (typeof(T) == typeof(string))
                return (Ptr<T>)(object)new StringPointer(Memory, ReadMemoryAddress(offset));
            return new Ptr<T>(Memory, ReadMemoryAddress(offset));
        }

        public StringPointer ReadStringPointer(int offset, int maxLength)
        {
            return new StringPointer(Memory, ReadMemoryAddress(offset), maxLength);
        }

        public StringPointer ReadStringPointer(int offset, int maxLength, Encoding encoding)
        {
            return new StringPointer(Memory, ReadMemoryAddress(offset), maxLength, encoding);
        }

        protected MemoryAddress ReadMemoryAddress(int offset)
        {
            var snapshot = Snapshot;
            if (snapshot != null)
            {
                return snapshot.ReadMemoryAddress(GetAbsoluteAddress(offset));
            }
            return Memory.Reader.ReadMemoryAddress(GetAbsoluteAddress(offset));
        }

        protected MemoryAddress GetAbsoluteAddress(int offset)
        {
            return Address + offset;
        }

        public void SetSnapshot(byte[] buffer, int offset, int count)
        {
            Snapshot = new MemorySnapshot(Memory, Address - offset, buffer, offset, count);
        }

        public void TakeSnapshot()
        {
            // Refresh snapshot only if we're in its root object (the object that created the snapshot).
            // A substruct is not allowed to update its parent snapshot and must instead create a new one.
            if (Snapshot?.IsRoot(this) == true)
            {
                Snapshot.Refresh();
                return;
            }

            int size = GetType().SizeOf();
            var buffer = new byte[size];
            Memory.Reader.ReadBytes(Address, buffer, 0, size);
            SetSnapshot(buffer, 0, size);
        }

        public void FreeSnapshot()
        {
            Snapshot = null;
        }
    }
}
