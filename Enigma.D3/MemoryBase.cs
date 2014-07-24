using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma
{
	public abstract class MemoryBase : IDisposable
	{
		private const int _smallBufferSize = 8;
		[ThreadStatic]
		private static byte[] _smallBuffer;

		protected abstract uint MinValidAddress { get; }

		protected abstract uint MaxValidAddress { get; }

		public abstract bool IsValid { get; }

		protected bool IsValidAddress(int address)
		{
			return unchecked((uint)address) >= MinValidAddress && unchecked((uint)address) <= MaxValidAddress;
		}

		protected byte[] GetBuffer(int size)
		{
			if (size <= _smallBufferSize)
				return _smallBuffer = _smallBuffer ?? new byte[_smallBufferSize];
			return new byte[size];
		}

		public T Read<T>(int address)
		{
			if (TypeHelper<T>.IsMemoryObject)
			{
				return (T)MemoryObject.UnsafeCreate(typeof(T), this, address);
			}
			else
			{
				byte[] buffer = ReadBytes(address, StructHelper<T>.SizeOf);
				return StructHelper<T>.Read(buffer, 0);
			}
		}

		public T[] Read<T>(int address, int count)
		{
			var type = typeof(T);
			int sizeOf = TypeHelper<T>.SizeOf;

			T[] array = new T[count];
			if (TypeHelper<T>.IsMemoryObject)
			{
				for (int i = 0; i < count; i++)
				{
					array[i] = (T)(object)MemoryObject.UnsafeCreate(type, this, address + i * sizeOf);
				}
			}
			else
			{
				byte[] buffer = ReadBytes(address, sizeOf * count);
				for (int i = 0; i < count; i++)
				{
					array[i] = StructHelper<T>.Read(buffer, i * sizeOf);
				}
			}
			return array;
		}

		public virtual byte[] ReadBytes(int address, int count)
		{
			if (!IsValidAddress(address))
				throw new ArgumentOutOfRangeException("address");
			if (count < 0 || !IsValidAddress(address + count))
				throw new ArgumentOutOfRangeException("count");

			byte[] buffer = GetBuffer(count);
			return ReadBytes(address, buffer, 0, count);
		}

		public virtual byte[] ReadBytes(int address, byte[] buffer)
		{
			if (!IsValidAddress(address))
				throw new ArgumentOutOfRangeException("address");
			if (buffer == null)
				throw new ArgumentNullException("buffer");
			if (!IsValidAddress(address + buffer.Length))
				throw new ArgumentOutOfRangeException();
			if (buffer.Length == 0)
				return buffer;

			return ReadBytes(address, buffer, 0, buffer.Length);
		}

		public abstract byte[] ReadBytes(int address, byte[] buffer, int offset, int count);

		public abstract void Dispose();
	}
}
