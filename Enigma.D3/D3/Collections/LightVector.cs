using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.Memory;

namespace Enigma.D3.Collections
{
	public class LightVector : LightVector<MemoryObject> { }

	public class LightVector<T> : MemoryObject, IEnumerable<T>
	{
		public const int SizeOf = 12;

		public Ptr<T> x00_PtrItems { get { return ReadPointer<T>(0x00); } }
		public int x04_Size { get { return Read<int>(0x04); } }
		public int x08_Capacity { get { return Read<int>(0x08); } }

		public T this[int index]
		{
			get { return x00_PtrItems[index]; }
		}

		public IEnumerator<T> GetEnumerator()
		{
			var ptr = x00_PtrItems;
			var size = x04_Size;
			for (int i = 0; i < size; i++)
				yield return ptr[i];
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

}
