using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;

namespace Enigma.D3.Collections
{
	public class Vector : Vector<MemoryObject> { }

	public class Vector<T> : MemoryObject, IEnumerable<T>
	{
		public const int SizeOf = 0x38; // = 56

		public Ptr<T> x00_Data { get { return Read<Ptr<T>>(0x00); } }
		public int x04 { get { return Read<int>(0x04); } }
		public int x08_Size { get { return Read<int>(0x08); } }
		public int x0C_Capacity { get { return Read<int>(0x0C); } }
		public BasicAllocator x10_Allocator { get { return Read<BasicAllocator>(0x10); } }
		public int _x2C { get { return Read<int>(0x2C); } }
		public int x30 { get { return Read<int>(0x30); } } // Sometimes 1
		public int _x34 { get { return Read<int>(0x34); } }

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
			return base.ToString() + " Size = " + x08_Size + ", Allocator = " + x10_Allocator.ToString() + ", @Data = 0x" + Read<int>(0x00).ToString("X8");
		}
	}
}