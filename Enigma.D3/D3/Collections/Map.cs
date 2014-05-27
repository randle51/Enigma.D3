using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;

namespace Enigma.D3.Collections
{
	public class Map : Map<MemoryObject, MemoryObject>
	{
		public Map(ProcessMemory memory, int address)
			: base(memory, address) { }
	}

	public class Map<TKey, TValue> : MemoryObject
	{
		// 2.0.4.23119
		public const int SizeOf = 0x70;

		public Map(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x00_Mask { get { return Field<int>(0x00); } }
		public int x04_Count { get { return Field<int>(0x04); } }
		public Allocator<Entry> x08_PtrEntryAllocator { get { return Dereference<Allocator<Entry>>(0x08); } }
		public int _x0C { get { return Field<int>(0x0C); } }
		public Data x10_Buckets { get { return Field<Data>(0x10); } }
		public int _x3C { get { return Field<int>(0x3C); } }
		public int _x40 { get { return Field<int>(0x40); } }
		public int _x44 { get { return Field<int>(0x44); } }
		public Allocator<Entry> x48_Allocator { get { return Field<Allocator<Entry>>(0x48); } }
		public int _x64 { get { return Field<int>(0x00); } }
		public int _x68 { get { return Field<int>(0x00); } }
		public int _x6C { get { return Field<int>(0x00); } }

		public Dictionary<TKey, TValue> ToDictionary()
		{
			var count = (short)x04_Count;
			var dic = new Dictionary<TKey, TValue>(count);

			foreach (var block in x08_PtrEntryAllocator.x08_Blocks)
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



		public class Data : Array<Pointer<Entry>>
		{
			public Data(ProcessMemory memory, int address)
				: base(memory, address) { }

			public Entry this[int bucket]
			{
				get
				{
					if (bucket < 0 || bucket > x08_Size)
						throw new ArgumentOutOfRangeException();

					return x00_Data[bucket].Value;
				}
			}
		}



		public class Entry : MemoryObject
		{
			public static int SizeOf = 4 + TypeHelper<TKey>.SizeOf + TypeHelper<TValue>.SizeOf;
			//public const int SizeOf = 0x0C; // = 12 (minimum)

			public Entry(ProcessMemory memory, int address)
				: base(memory, address) { }

			public Entry x00_Next { get { return Dereference<Entry>(0x00); } }
			public TKey x04_Key { get { return Field<TKey>(0x04); } }
			public TValue x08_Value { get { return Field<TValue>(0x08); } }
		}
	}
}
