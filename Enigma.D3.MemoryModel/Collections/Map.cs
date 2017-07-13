using Enigma.D3.MemoryModel.MemoryManagement;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Enigma.D3.MemoryModel.Collections
{
    public class Map<TKey, TValue> : MemoryObject, IEnumerable<KeyValuePair<TKey, TValue>>
    {
        public static int SizeOf => 0x10 + Vector<Ptr<Entry>>.SizeOf;

        public int Mask => Read<int>(0x00);

        public int Count => Read<int>(0x04);

        public Ptr<Allocator<Entry>> PtrBucketAllocator => Read<Ptr<Allocator<Entry>>>(0x08);

        public Vector<Ptr<Entry>> Buckets => Read<Vector<Ptr<Entry>>>(0x10);

        public TValue this[TKey key]
        {
            get
            {
                TValue value;
                if (!TryGetValue(key, out value))
                    throw new KeyNotFoundException();
                return value;
            }
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            if (Count == 0)
            {
                value = default(TValue);
                return false;
            }

            var hash = key.GetHashCode();
            var index = hash & Mask;
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

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            foreach (var bucket in Buckets)
            {
                var entry = bucket.Dereference();
                while (entry != null)
                {
                    yield return new KeyValuePair<TKey, TValue>(
                        entry.Key, entry.Value);
                    entry = entry.GetNext();
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public class Entry : MemoryObject
        {
            private static bool X86 => SymbolTable.Current.Platform == Platform.X86;

            public static int SizeOf => X86 ?
                AlignedSize(0x04, Alignment) + AlignedSize(TypeHelper<TKey>.SizeOf, Alignment) + AlignedSize(TypeHelper<TValue>.SizeOf, Alignment) :
                0x08 + AlignedSize(TypeHelper<TKey>.SizeOf, Alignment) + AlignedSize(TypeHelper<TValue>.SizeOf, Alignment);

            // If either TKey or TValue is larger than 4 bytes, alignment 8 is used.
            private static int Alignment => TypeHelper<TKey>.SizeOf > 4 || TypeHelper<TValue>.SizeOf > 4 ? 8 : 4;

            public Ptr<Entry> Next => Read<Ptr<Entry>>(0x00);

            public TKey Key => this.PlatformRead<TKey>(
                AlignedSize(0x04, Alignment),
                0x08);

            public TValue Value => this.PlatformRead<TValue>(
                AlignedSize(0x04, Alignment) + AlignedSize(TypeHelper<TKey>.SizeOf, Alignment),
                0x08 + AlignedSize(TypeHelper<TKey>.SizeOf, Alignment));

            public Entry GetNext() => ReadPointer<Entry>(0x00).Dereference();
        }
    }

    public class MapA<TKey, TValue> : Map<TKey, TValue>
    {
        public new static int SizeOf = SymbolTable.Current.Platform == Platform.X86 ? 0x70 : 0x80;

        public Allocator<Entry> BucketAllocator => Read<Allocator<Entry>>(0x48);
    }
}
