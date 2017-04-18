using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Memory
{
	public class MemoryObject
	{
		public IMemory Memory { get; private set; }

		public MemoryAddress Address { get; private set; }

		protected BufferMemoryReader Snapshot { get; private set; }

		internal protected MemoryObject Initialize(IMemory memory, MemoryAddress address)
		{
			Memory = memory;
			Address = address;
			return this;
		}

		public virtual T Read<T>(int offset)
		{
			if (!TypeHelper<T>.IsTypeSupportedByMemoryReader)
				throw new NotSupportedException();

			var snapshot = Snapshot;
			if (snapshot != null)
			{
				if (TypeHelper<T>.IsMemoryObjectType)
				{
					var value = Memory.Reader.Read<T>(GetAbsoluteAddress(offset));
					(value as MemoryObject).SetSnapshot(
						snapshot.Segment.Array,
						snapshot.Segment.Offset + offset,
						TypeHelper<T>.SizeOf);
					return value;
				}
				else if (TypeHelper<T>.IsMemoryPointerType)
				{
					// It is important that a pointer doesn't get a snapshot as context!
					return (T)MemoryPointerFactory.Create<T>(Memory,
						ReadMemoryAddress(offset));
				}
				return snapshot.Read<T>(offset);
			}
			return Memory.Reader.Read<T>(GetAbsoluteAddress(offset));
		}

		public virtual T[] Read<T>(int offset, int count)
		{
			if (!TypeHelper<T>.IsTypeSupportedByMemoryReader)
				throw new NotSupportedException();

			var snapshot = Snapshot;
			if (snapshot != null)
			{
				if (TypeHelper<T>.IsMemoryObjectType)
				{
					var array = Memory.Reader.Read<T>(GetAbsoluteAddress(offset), count);
					var itemOffset = offset;
					for (int i = 0; i < count; i++)
					{
						(array[i] as MemoryObject).SetSnapshot(
							snapshot.Segment.Array,
							snapshot.Segment.Offset + itemOffset,
							TypeHelper<T>.SizeOf);
						itemOffset += TypeHelper<T>.SizeOf;
					}
					return array;
				}

				else if (TypeHelper<T>.IsMemoryPointerType)
				{
					// It is important that a pointer doesn't get a snapshot as context!
					var array = new T[count];
					for (int i = 0; i < count; i++)
					{
						array[i] = (T)MemoryPointerFactory.Create<T>(Memory,
							ReadMemoryAddress(offset + i * Memory.Reader.PointerSize));
					}
					return array;
				}
				return snapshot.Read<T>(offset, count);
			}
			return Memory.Reader.Read<T>(GetAbsoluteAddress(offset), count);
		}

		public string ReadString(int offset, int maxLength)
		{
			return ReadString(offset, maxLength, Encoding.UTF8);
		}

		public string ReadString(int offset, int maxLength, Encoding encoding)
		{
			var snapshot = Snapshot;
			if (snapshot != null)
			{
				return snapshot.ReadString(offset, maxLength, encoding);
			}
			return Memory.Reader.ReadString(GetAbsoluteAddress(offset), maxLength, encoding);
		}

		public Ptr ReadPointer(int offset)
		{
			return new Ptr(Memory, ReadMemoryAddress(offset));
		}

		public Ptr<T> ReadPointer<T>(int offset)
		{
			if (typeof(T) == typeof(string))
				return (Ptr<T>)(object)new StringPointer(Memory, ReadMemoryAddress(offset));
			return new Ptr<T>(Memory, ReadMemoryAddress(offset));
		}

		public StringPointer ReadStringPointer(int offset, int maxLength)
		{
			return new StringPointer(Memory, ReadMemoryAddress(offset), maxLength);
		}

		public StringPointer ReadStringPointer(int offset, int maxLength, Encoding encoding)
		{
			return new StringPointer(Memory, ReadMemoryAddress(offset), maxLength, encoding);
		}

		protected MemoryAddress ReadMemoryAddress(int offset)
		{
			var snapshot = Snapshot;
			if (snapshot != null)
			{
				return snapshot.ReadMemoryAddress(offset);
			}
			return Memory.Reader.ReadMemoryAddress(GetAbsoluteAddress(offset));
		}

		protected MemoryAddress GetAbsoluteAddress(int offset)
		{
			return Address + offset;
		}

		public void SetSnapshot(byte[] buffer, int offset, int count)
		{
			Snapshot = new BufferMemoryReader(buffer, offset, count,
				Memory.Reader.PointerSize);
		}

		public void TakeSnapshot()
		{
			if (Snapshot != null)
			{
				Memory.Reader.ReadBytes(Address, Snapshot.Segment.Array, Snapshot.Segment.Offset, Snapshot.Segment.Count);
			}
			else
			{
				int size = GetType().SizeOf();
				var buffer = new byte[size];
				Memory.Reader.ReadBytes(Address, buffer, 0, size);
				SetSnapshot(buffer, 0, size);
			}
		}

		public void FreeSnapshot()
		{
			Snapshot = null;
		}
	}
}
