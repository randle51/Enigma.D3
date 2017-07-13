using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Enigma.D3.MemoryModel.Collections
{
    // TODO: Other offsets for 32-bit?
    public class CircularBuffer<T> : MemoryObject, IReadOnlyList<T>
    {
        public ulong Free => Read<ulong>(0x00);
        public ulong Head => Read<ulong>(0x08);
        public ulong Tail => Read<ulong>(0x10);
        public ulong Used => Read<ulong>(0x18);
        public T[] Buffer => Read<T>(0x20, (int)(Used + Free));

        public int Count => (int)Used;

        public T this[int index]
            => new Ptr<T>(Memory, Address + 0x20)[index];

        public IEnumerator<T> GetEnumerator()
        {
            SetSnapshot(Read<byte>(0, 0x20), 0, 0x20);
            var capacity = (int)(Used + Free);
            var size = 0x20 + TypeHelper<T>.SizeOf * capacity;
            FreeSnapshot();
            SetSnapshot(Read<byte>(0, size), 0, size);

            var items = Buffer;
            var count = Count;
            var head = (int)Head;

            var i = 0;
            do
            {
                var pos = head + i - capacity;
                if (head + i < capacity)
                    pos = head + i;
                ++i;
                yield return items[pos];
            }
            while (i < count);

            FreeSnapshot();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
