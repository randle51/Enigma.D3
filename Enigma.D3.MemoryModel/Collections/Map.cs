using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Collections
{
    public class Map<TValue> : MemoryObject
    {
        public int Mask => Read<int>(0x00);

        public int Count => Read<int>(0x04);

        public Vector<Ptr<Entry>> Buckets => Read<Vector<Ptr<Entry>>>(0x10);

        public bool TryGetValue(int key, out TValue value, Func<int,uint> hasher)
        {
            var hash = hasher(key);
            var index = unchecked((int)(hash & Mask));
            var bucket = Buckets[index].Dereference();
            var entry = bucket;
            while (entry != null)
            {
                if (entry.Key.Equals(key))
                {
                    value = entry.Value;
                    return true;
                }
                entry = entry.GetNext();
            }
            value = default(TValue);
            return false;
        }


        public class Entry : MemoryObject
        {
            private static bool X86 => SymbolTable.Current.Platform == Platform.X86;
            
            public int Key => Read<int>(X86 ? 0x04 : 0x08);
            public TValue Value => Read<TValue>(X86 ? 0x08 : 0x0C);

            public Entry GetNext() => ReadPointer<Entry>(0x00).Dereference();
        }
    }
}
