using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Memory
{
	public class Pointer : Pointer<MemoryObject>
	{
		public Pointer(ProcessMemory memory, int address)
			: base(memory, address) { }

		public T Read<T>()
		{
			return Field<T>(0);
		}

		public T Dereference<T>()
		{
			return Dereference<T>(0);
		}
	}

	public class Pointer<T> : MemoryObject
	{
		public const int SizeOf = 4;

		public Pointer(ProcessMemory memory, int address)
			: base(memory, address) { }

		public T Value { get { return Dereference<T>(0x00); } }

		public T this[int index]
		{
			get
			{
				var address = Field<int>(0x00);
				address += TypeHelper<T>.SizeOf * index;
				return Memory.Read<T>(address);
			}
		}

		public Pointer<TResult> Cast<TResult>()
		{
			return new Pointer<TResult>(Memory, Address);
		}

		public override string ToString()
		{
			return "0x" + Field<int>(0x00).ToString("X8");
		}
	}
}
