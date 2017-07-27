using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Memory
{
    public abstract class MemoryReader : IDisposable
    {
        private const int _smallBufferSize = 16;
        [ThreadStatic]
        private static byte[] _smallBuffer;

        public MemoryReader()
        {
            Memory = new ReadOnlyMemory(this);
        }

        public MemoryReader(IMemory memory)
        {
            if (memory == null)
                throw new ArgumentNullException("memory");

            Memory = memory;
        }

        public IMemory Memory { get; private set; }

        public abstract MemoryAddress MinValidAddress { get; }

        public abstract MemoryAddress MaxValidAddress { get; }

        public abstract bool IsValid { get; }

        public abstract int PointerSize { get; }

        public bool IsValidAddress(MemoryAddress address)
        {
            return address >= MinValidAddress && address <= MaxValidAddress;
        }

        protected byte[] GetBuffer(int minSize)
        {
            if (minSize <= _smallBufferSize)
                return _smallBuffer = _smallBuffer ?? new byte[_smallBufferSize];
            return new byte[minSize];
        }

        public T Read<T>(MemoryAddress[] path)
        {
            if (path == null)
                throw new ArgumentNullException(nameof(path));
            if (path.Length == 0)
                throw new ArgumentException();

            var address = path[0];
            for (int i = 1; i < path.Length; i++)
            {
                if (address == 0)
                    return default(T);

                address = Read<MemoryAddress>(address);
                address += path[i];
            }
            return Read<T>(address);
        }

        public T Read<T>(MemoryAddress address)
        {
            if (!IsValidAddress(address))
                throw new ArgumentOutOfRangeException();
            if (!IsValidAddress(address + TypeHelper<T>.SizeOf))
                throw new ArgumentException("address");

            if (TypeHelper<T>.HasKnownStructLayout)
            {
                byte[] buffer = GetBuffer(TypeHelper<T>.SizeOf);
                UnsafeReadBytes(address, buffer, 0, TypeHelper<T>.SizeOf);
                return StructHelper<T>.UnsafeRead(buffer, 0);
            }
            else if (TypeHelper<T>.IsMemoryObjectType)
            {
                return (T)(object)MemoryObjectFactory.UnsafeCreate(typeof(T), Memory, address);
            }
            else if (TypeHelper<T>.IsMemoryPointerType)
            {
                return (T)(object)MemoryPointerFactory.UnsafeCreate<T>(Memory, ReadMemoryAddress(address));
            }
            else if (TypeHelper<T>.IsMemoryAddressType)
            {
                return (T)(object)ReadMemoryAddress(address);
            }
            else throw new NotSupportedException();
        }

        public T[] Read<T>(MemoryAddress address, int count)
        {
            if (!IsValidAddress(address))
                throw new ArgumentOutOfRangeException("address");
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (!IsValidAddress(address + TypeHelper<T>.SizeOf * count))
                throw new ArgumentException();

            T[] array = new T[count];

            if (TypeHelper<T>.HasKnownStructLayout)
            {
                int bufferSize = TypeHelper<T>.SizeOf * count;
                byte[] buffer = GetBuffer(bufferSize);
                UnsafeReadBytes(address, buffer, 0, bufferSize);
                StructHelper<T>.CopyFromBuffer(buffer, 0, array, 0, count);
            }
            else if (TypeHelper<T>.IsMemoryObjectType)
            {
                for (int i = 0; i < count; i++)
                {
                    array[i] = (T)(object)MemoryObjectFactory.UnsafeCreate(typeof(T), Memory, address + i * TypeHelper<T>.SizeOf);
                }
            }
            else if (TypeHelper<T>.IsMemoryPointerType)
            {
                var buffer = new byte[count * PointerSize];
                UnsafeReadBytes(address, buffer, 0, buffer.Length);
                var bufferReader = new BufferMemoryReader(buffer, 0, buffer.Length, PointerSize);

                for (int i = 0; i < count; i++)
                {
                    array[i] = (T)(object)MemoryPointerFactory.UnsafeCreate<T>(Memory, bufferReader.ReadMemoryAddress(i * PointerSize));
                }
            }
            else if (TypeHelper<T>.IsMemoryAddressType)
            {
                for (int i = 0; i < count; i++)
                {
                    array[i] = (T)(object)ReadMemoryAddress(address + i * PointerSize);
                }
            }
            else throw new NotSupportedException();

            return array;
        }

        public byte[] ReadBytes(MemoryAddress address, int count)
        {
            if (!IsValidAddress(address))
                throw new ArgumentOutOfRangeException("address");
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (!IsValidAddress(address + count))
                throw new ArgumentException();

            // NOTE: Do NOT allocate buffer with "GetBuffer" as a small buffer could be modified
            // by other reads.
            byte[] buffer = new byte[count];
            if (count == 0)
                return buffer; // Cannot read anything into an empty buffer, would get exception.
            UnsafeReadBytes(address, buffer, 0, count);
            return buffer;
        }

        public void ReadBytes(MemoryAddress address, byte[] buffer)
        {
            if (!IsValidAddress(address))
                throw new ArgumentOutOfRangeException("address");
            if (buffer == null)
                throw new ArgumentNullException("buffer");
            if (!IsValidAddress(address + buffer.Length))
                throw new ArgumentException();

            UnsafeReadBytes(address, buffer, 0, buffer.Length);
        }

        public void ReadBytes(MemoryAddress address, byte[] buffer, int offset, int count)
        {
            if (!IsValidAddress(address))
                throw new ArgumentOutOfRangeException("address");
            if (buffer == null)
                throw new ArgumentNullException("buffer");
            if (offset < 0)
                throw new ArgumentOutOfRangeException("offset");
            if (offset > buffer.Length)
                throw new ArgumentOutOfRangeException("offset");
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (offset + count > buffer.Length)
                throw new ArgumentException();
            if (!IsValidAddress(address + buffer.Length))
                throw new ArgumentException();

            UnsafeReadBytes(address, buffer, offset, count);
        }

        public string ReadString(MemoryAddress address, int maxLength)
        {
            return ReadString(address, maxLength, Encoding.UTF8);
        }

        public string ReadString(MemoryAddress address, int maxLength, Encoding encoding)
        {
            if (encoding == null)
                throw new ArgumentNullException("encoding");

            var buffer = ReadBytes(address, maxLength);
            int count = 0; // Get the index of NULL-terminator, or use maxLength if none is found.
            while (count < maxLength && buffer[count] != 0)
                count++;
            return encoding.GetString(buffer, 0, count);
        }

        protected internal virtual MemoryAddress ReadMemoryAddress(MemoryAddress address)
        {
            if (PointerSize == 4)
            {
                return Read<int>(address);
            }
            else if (PointerSize == 8)
            {
                return Read<long>(address);
            }
            else
            {
                throw new NotSupportedException();
            }
        }

        public ulong TotalReadCount { get; private set; }

        public ulong TotalReadSize { get; private set; }

        public TimeSpan TotalReadTime { get; private set; }

        public void ResetCounters()
        {
            TotalReadCount = 0;
            TotalReadSize = 0;
            TotalReadTime = TimeSpan.Zero;
        }

        private readonly Stopwatch _sw = new Stopwatch();
        public void UnsafeReadBytes(MemoryAddress address, byte[] buffer, int offset, int count)
        {
            _sw.Restart();
            UnsafeReadBytesCore(address, buffer, offset, count);
            _sw.Stop();

            TotalReadCount++;
            TotalReadSize += (ulong)count;
            TotalReadTime = TotalReadTime.Add(_sw.Elapsed);
        }

        protected abstract void UnsafeReadBytesCore(MemoryAddress address, byte[] buffer, int offset, int count);

        public abstract void Dispose();
    }
}
