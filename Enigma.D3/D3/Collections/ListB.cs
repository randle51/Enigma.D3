using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Collections
{
	public class ListB : ListB<MemoryObject> { }

	public class ListB<T> : MemoryObject, IEnumerable<T>
	{
		// 2.0.1.22044
		public const int SizeOf = 0x14; // 20

		public LinkedList<T> x00_List { get { return Read<LinkedList<T>>(0x00); } }
		public int x10_Boolean { get { return Read<int>(0x10); } }

		public IEnumerator<T> GetEnumerator()
		{
			return x00_List.GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public override string ToString()
		{
			return base.ToString() + " Count = " + x00_List.x08_Count;
		}
	}
}
