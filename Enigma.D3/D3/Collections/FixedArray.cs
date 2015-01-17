using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.Memory;

namespace Enigma.D3.Collections
{
	public class FixedArray<T> : MemoryObject, IEnumerable<T>
	{
		public const int SizeOf = 8;

		public T this[int index]
		{
			get
			{
				if (index < 0 || index >= Size)
					throw new ArgumentOutOfRangeException("index");
				return Data[index];
			}
		}

		public int Size { get { return Read<int>(0x00); } }
		public Ptr<T> Data { get { return ReadPointer<T>(0x04); } }

		public IEnumerator<T> GetEnumerator()
		{
			return ((IEnumerable<T>)Data.ToArray(Size)).GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
