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
		// 2.0.0.21806
		public const int SizeOf = 0x64; // Unsure, might be 0x70

		public Map(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x00_Mask { get { return Field<int>(0x00); } }
		public int x04_Count { get { return Field<int>(0x04); } }
		public Allocator x08_PtrAllocator_10x12Bytes { get { return Dereference<Allocator>(0x08); } }
		public int _x0C { get { return Field<int>(0x0C); } }
		public Data x10_Data { get { return Field<Data>(0x10); } }
		public int _x3C { get { return Field<int>(0x3C); } }
		public int _x40 { get { return Field<int>(0x40); } }
		public int _x44 { get { return Field<int>(0x44); } }
		public Allocator x48_Allocator { get { return Field<Allocator>(0x48); } }
		public int _x64 { get { return Field<int>(0x00); } } // <-- Might be specific to UIElementMap
		public int _x68 { get { return Field<int>(0x00); } } // <-- Might be specific to UIElementMap
		public int _x6C { get { return Field<int>(0x00); } } // <-- Might be specific to UIElementMap



		public class Data : MemoryObject
		{
			public const int SizeOf = 0x2C; // = 44

			public Data(ProcessMemory memory, int address)
				: base(memory, address) { }

			public Pointer<Entry>[] x00_BucketPointers { get { return Dereference<Pointer<Entry>>(0x00, x08_Limit); } }
			public Entry[] x00_Buckets { get { return x00_BucketPointers.Select(a => a.Value).ToArray(); } }
			public int x04 { get { return Field<int>(0x04); } }
			public int x08_Limit { get { return Field<int>(0x08); } }
			public int _x0C { get { return Field<int>(0x0C); } }
			public BasicAllocator x10_BucketAllocator { get { return Field<BasicAllocator>(0x10); } }

			public Entry this[int bucket]
			{
				get
				{
					if (bucket < 0 || bucket > x08_Limit)
						throw new IndexOutOfRangeException();

					return Memory.Read<Entry>(Field<int>(0x00) + Pointer.SizeOf * bucket);
				}
			}
		}



		public class Entry : MemoryObject
		{
			public const int SizeOf = 0x0C; // = 12 (minimum)

			public Entry(ProcessMemory memory, int address)
				: base(memory, address) { }

			public Entry x00_Next { get { return Dereference<Entry>(0x00); } }
			public TKey x04_Key { get { return Field<TKey>(0x04); } }
			public TValue x08_Value { get { return Field<TValue>(0x08); } }
		}
	}
}
