using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Enigma.D3.MemoryModel;

namespace Enigma.D3.MemoryModel.BattleNet
{
    public class Map<T> : MemoryObject, IEnumerable<T>
    {
        public static int SizeOf => SymbolTable.Current.Platform == Platform.X86 ? 0x10 : 0x20;

        public int NumberOfSlots => Read<int>(0x00);
        public Ptr<Ptr<Bucket>> Buckets => this.PlatformRead<Ptr<Ptr<Bucket>>>(0x04, 0x08);
        public int Count => this.PlatformRead<int>(0x08, 0x10);
        public float LoadFactor => this.PlatformRead<float>(0x0C, 0x18);

        public IEnumerator<T> GetEnumerator()
        {
            var buckets = Buckets.ToArray(NumberOfSlots);
            for (int i = 0; i < buckets.Length; i++)
            {
                var bucket = buckets[i].Dereference();
                while (bucket != null)
                {
                    yield return bucket.Value;
                    bucket = bucket.Next.Dereference();
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();


        public class Bucket : MemoryObject
        {
            public static int SizeOf => SymbolTable.Current.Platform == Platform.X86 ?
                0x10 + TypeHelper.SizeOf(typeof(T)) :
                0x18 + TypeHelper.SizeOf(typeof(T));

            public Ptr<Bucket> Next => Read<Ptr<Bucket>>(0x00);
            public Ptr<Bucket> Prev => this.PlatformRead<Ptr<Bucket>>(0x04, 0x08);
            public ulong Hash => this.PlatformRead<ulong>(0x08, 0x10);
            public T Value => this.PlatformRead<T>(0x10, 0x18);
        }
    }
}
