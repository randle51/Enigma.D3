using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Enigma.D3.MemoryModel.Collections
{
    public class Vector<T> : MemoryObject, IEnumerable<T>
    {
        public const int SizeOf = 0x10; // TODO: Not accurate

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                    throw new ArgumentOutOfRangeException();

                return Items[index];
            }
        }

        public Ptr<T> Items => Read<Ptr<T>>(0x00);

        public int Count => Read<int>(0x08);

        public IEnumerator<T> GetEnumerator()
        {
            return Items.ToArray(Count).AsEnumerable().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
