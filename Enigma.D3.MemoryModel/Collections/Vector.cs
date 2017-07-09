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
        public const int SizeOf = 0x10;

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Size)
                    throw new ArgumentOutOfRangeException();

                return Items[index];
            }
        }

        public Ptr<T> Items => Read<Ptr<T>>(0x00);

        public int Size => Read<int>(0x08);

        public int Capacity => Read<int>(0x0C);

        public IEnumerator<T> GetEnumerator()
        {
            return Items.ToArray(Size).AsEnumerable().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
