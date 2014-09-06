using System;

namespace Enigma.Memory
{
	public unsafe struct MemoryAddress
	{
		public static implicit operator int(MemoryAddress address) { return unchecked((int)address.Value.ToPointer()); }
		public static implicit operator uint(MemoryAddress address) { return unchecked((uint)address.Value.ToPointer()); }
		public static implicit operator long(MemoryAddress address) { return unchecked((long)address.Value.ToPointer()); }
		public static implicit operator ulong(MemoryAddress address) { return unchecked((ulong)address.Value.ToPointer()); }
		public static implicit operator IntPtr(MemoryAddress address) { return unchecked((IntPtr)address.Value.ToPointer()); }
		public static implicit operator UIntPtr(MemoryAddress address) { return unchecked((UIntPtr)address.Value.ToPointer()); }
		public static implicit operator MemoryAddress(int value) { return new MemoryAddress((void*)value); }
		public static implicit operator MemoryAddress(uint value) { return new MemoryAddress((void*)value); }
		public static implicit operator MemoryAddress(long value) { return new MemoryAddress((void*)value); }
		public static implicit operator MemoryAddress(ulong value) { return new MemoryAddress((void*)value); }
		public static implicit operator MemoryAddress(IntPtr value) { return new MemoryAddress((void*)value); }
		public static implicit operator MemoryAddress(UIntPtr value) { return new MemoryAddress((void*)value); }

		public static bool operator >=(MemoryAddress m1, MemoryAddress m2)
		{
			if (IntPtr.Size == 4)
				return unchecked((uint)m1 >= (uint)m2);
			return unchecked((ulong)m1 >= (ulong)m2);
		}
		public static bool operator >(MemoryAddress m1, MemoryAddress m2)
		{
			if (IntPtr.Size == 4)
				return unchecked((uint)m1 > (uint)m2);
			return unchecked((ulong)m1 > (ulong)m2);
		}
		public static bool operator <=(MemoryAddress m1, MemoryAddress m2)
		{
			if (IntPtr.Size == 4)
				return unchecked((uint)m1 <= (uint)m2);
			return unchecked((ulong)m1 <= (ulong)m2);
		}
		public static bool operator <(MemoryAddress m1, MemoryAddress m2)
		{
			if (IntPtr.Size == 4)
				return unchecked((uint)m1 < (uint)m2);
			return unchecked((ulong)m1 < (ulong)m2);
		}

		private MemoryAddress(void* value)
		{
			Value = (IntPtr)value;
		}

		internal IntPtr Value;

		private static readonly string _format = "0x{0:X" + IntPtr.Size * 2 + "}";

		public override string ToString()
		{
			return string.Format(_format, (ulong)this);
		}

		public string ToString(string format)
		{
			return ((ulong)this).ToString(format);
		}
	}
}
