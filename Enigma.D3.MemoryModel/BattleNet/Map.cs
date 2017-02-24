using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Enigma.D3.MemoryModel32.BattleNet
{
	// TODO: 64-bit, non-PTR
	public class Map<T> : MemoryObject, IEnumerable<T>
	{
		public const int SizeOf = 0x10;

		public int NumberOfSlots => Read<int>(0x00);
		public Ptr<Ptr<Bucket>> Buckets => Read<Ptr<Ptr<Bucket>>>(0x04);
		public int Count => Read<int>(0x08);
		public float LoadFactor => Read<float>(0x0C);

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
			public static int SizeOf = 0x10 + TypeHelper.SizeOf(typeof(T));

			public Ptr<Bucket> Next => Read<Ptr<Bucket>>(0x00);
			public Ptr<Bucket> Prev => Read<Ptr<Bucket>>(0x04);
			public ulong Hash => Read<ulong>(0x08);
			public T Value => Read<T>(0x10);
		}
	}
}
