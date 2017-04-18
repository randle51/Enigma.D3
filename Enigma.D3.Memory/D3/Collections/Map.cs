using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;

namespace Enigma.D3.Collections
{
	public class Map : Map<MemoryObject, MemoryObject> { }

	public class Map<TKey, TValue> : MemoryObject
	{
		// 2.0.4.23119
		public const int SizeOf = 0x70; // 112

		public int x00_Mask { get { return Read<int>(0x00); } }
		public int x04_Count { get { return Read<int>(0x04); } }
		public Ptr<Allocator<Entry>> x08_PtrEntryAllocator { get { return ReadPointer<Allocator<Entry>>(0x08); } }
		public int _x0C { get { return Read<int>(0x0C); } }
		public Data x10_Buckets { get { return Read<Data>(0x10); } }
		public Allocator<Entry> x48_EntryAllocator { get { return Read<Allocator<Entry>>(0x48); } }
		public int _x64 { get { return Read<int>(0x00); } }
		public int _x68 { get { return Read<int>(0x00); } }
		public int _x6C { get { return Read<int>(0x00); } }

		public TValue GetValue(TKey key, Func<TKey, uint> hasher)
		{
			var hash = hasher(key);
			var index = unchecked((int)(hash & x00_Mask));
			var bucket = x10_Buckets[index];
			var entry = bucket;
			while (entry != null)
			{
				if (entry.x04_Key.Equals(key))
					return entry.x08_Value;
				entry = entry.x00_Next;
			}
			throw new KeyNotFoundException();
		}

		public bool TryGetValue(TKey key, out TValue value, Func<TKey, uint> hasher)
		{
			var hash = hasher(key);
			var index = unchecked((int)(hash & x00_Mask));
			var bucket = x10_Buckets[index];
			var entry = bucket;
			while (entry != null)
			{
				if (entry.x04_Key.Equals(key))
				{
					value = entry.x08_Value;
					return true;
				}
				entry = entry.x00_Next;
			}
			value = default(TValue);
			return false;
		}

		public Dictionary<TKey, TValue> ToDictionary()
		{
			var count = (short)x04_Count;
			var dic = new Dictionary<TKey, TValue>(count);

			foreach (var block in x48_EntryAllocator.x08_Blocks)
			{
				block.TakeSnapshot();
				var elements = block.x00_Elements;
				var isSlotFree = block.x24_FreeSpaceBitmap;
				for (int i = 0; i < elements.Length; i++)
				{
					if (isSlotFree[i])
						continue;
					var element = elements[i];
					dic.Add(element.x04_Key, element.x08_Value);
				}
				block.FreeSnapshot();
			}

			return dic;
		}

		public override string ToString()
		{
			return base.ToString() + ", Count: " + x04_Count;
		}



		public class Data : Vector<Ptr<Entry>>
		{
			public new Entry this[int bucket]
			{
				get
				{
					if (bucket < 0 || bucket > x08_Size)
						throw new ArgumentOutOfRangeException();

					return x00_Data[bucket].Dereference();
				}
			}
		}



		public class Entry : MemoryObject
		{
			public static int SizeOf = GetSizeOf();
			private static int GetSizeOf()
			{
				int sizeOf = 4;
				sizeOf += TypeHelper<TKey>.IsMemoryPointerType ? 4 : TypeHelper<TKey>.SizeOf;
				sizeOf += TypeHelper<TValue>.IsMemoryPointerType ? 4 : TypeHelper<TValue>.SizeOf;
				return sizeOf;
			}

			public Entry x00_Next { get { return ReadPointer<Entry>(0x00).Dereference(); } }
			public TKey x04_Key { get { return Read<TKey>(0x04); } }
			public TValue x08_Value { get { return Read<TValue>(0x08); } }
		}
	}
}
