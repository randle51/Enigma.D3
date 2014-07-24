using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;

namespace Enigma.D3.Collections
{
	public class Array : Array<MemoryObject>
	{
		public Array(MemoryBase memory, int address)
			: base(memory, address) { }
	}

	public class Array<T> : MemoryObject, IEnumerable<T>
	{
		public const int SizeOf = 0x2C; // = 44

		public Array(MemoryBase memory, int address)
			: base(memory, address) { }

		public T[] x00_Array { get { return Dereference<T>(0x00, x08_Size); } }
		public Pointer<T> x00_Data { get { return Field<Pointer<T>>(0x00); } }
		public int x04 { get { return Field<int>(0x04); } }
		public int x08_Size { get { return Field<int>(0x08); } }
		public int _x0C { get { return Field<int>(0x0C); } }
		public BasicAllocator x10_Allocator { get { return Field<BasicAllocator>(0x10); } }

		public T this[int index]
		{
			get
			{
				if (index < 0 || index >= x08_Size)
					throw new ArgumentOutOfRangeException();

				return x00_Data[index];
			}
		}

		public IEnumerator<T> GetEnumerator()
		{
			var ptr = x00_Data;
			for (int i = 0; i < x08_Size; i++)
			{
				yield return ptr[i];
			}
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public override string ToString()
		{
			return base.ToString() + " Size = " + x08_Size + ", Allocator = " + x10_Allocator.ToString() + ", @Data = 0x" + Field<int>(0x00).ToString("X8");
		}
	}
}