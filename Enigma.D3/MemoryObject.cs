using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Enigma
{
	public class MemoryObject
	{
		private ProcessMemory _memory;
		private int _address;
		private int _snapshotOffset;

		public MemoryObject(ProcessMemory memory, int address)
		{
			if (memory == null)
				throw new ArgumentNullException("memory");
			if ((uint)address > 0xCFFFFFFF) // 3GB
				throw new ArgumentOutOfRangeException("address");

			_memory = memory;
			_address = address;
		}

		public ProcessMemory Memory { get { return _memory; } }

		public int Address { get { return _address; } }

		protected byte[] Snapshot { get; private set; }

		protected T Field<T>(int offset)
		{
			if (Snapshot != null)
			{
				int size = typeof(T).SizeOf();
				if (typeof(T).IsSubclassOf(typeof(MemoryObject)) ||
					typeof(T).Equals(typeof(MemoryObject)))
				{
					var value = (T)Activator.CreateInstance(
						typeof(T),
						_memory, _address + offset);
					var memoryObject = value as MemoryObject;
					//var nestedSnapshot = new byte[size];
					//Buffer.BlockCopy(Snapshot, offset, nestedSnapshot, 0, size);
					//memoryObject.Snapshot = nestedSnapshot;
					memoryObject.Snapshot = this.Snapshot;
					memoryObject._snapshotOffset = offset;
					return value;
				}
				else
				{
					var handle = GCHandle.Alloc(Snapshot, GCHandleType.Pinned);
					return (T)Marshal.PtrToStructure(
						handle.AddrOfPinnedObject() + _snapshotOffset + offset,
						typeof(T));
				}
			}
			return ReadAbsoluteAddress<T>(_address + offset);
		}

		protected T[] Field<T>(int offset, int count)
		{
			if (typeof(T).IsSubclassOf(typeof(MemoryObject)) ||
				typeof(T).Equals(typeof(MemoryObject)))
			{
				int sizeOf = (int)typeof(T).GetField("SizeOf").GetRawConstantValue();
				return Enumerable.Range(0, count).Select(a => (T)Activator.CreateInstance(
					typeof(T),
					_memory, _address + offset + a * sizeOf)).ToArray();
			}
			else
			{
				int sizeOf = Marshal.SizeOf(typeof(T));
				return Enumerable.Range(0, count).Select(a => _memory.Read<T>(
					_address + offset + a * sizeOf)).ToArray();
			}
		}

		protected string Field(int offset, int length)
		{
			if (Snapshot != null)
			{
				return ReadString(Snapshot, _snapshotOffset + offset, length);
			}
			else
			{
				byte[] bytes = _memory.ReadBytes(_address + offset, length);
				return ReadString(bytes, 0, length);
			}
		}

		protected string[] Field(int offset, int length, int count)
		{
			return Enumerable.Range(0, count).Select(a => Field(offset + a * length, length)).ToArray();
		}

		private string ReadString(byte[] buffer, int offset, int length)
		{
			return Encoding.ASCII.GetString(
				buffer,
				offset,
				length).Split('\0')[0];
		}

		protected T Dereference<T>(int offset)
		{
			int reference;
			if (Snapshot != null)
			{
				reference = BitConverter.ToInt32(Snapshot, _snapshotOffset + offset);
			}
			else
			{
				reference = _memory.Read<int>(_address + offset);
			}

			if (reference == 0)
			{
				return default(T);
			}
			return ReadAbsoluteAddress<T>(reference);
		}

		protected T[] Dereference<T>(int offset, int count)
		{
			int pointer = Field<int>(offset);
			if (typeof(T).IsSubclassOf(typeof(MemoryObject)) ||
				typeof(T).Equals(typeof(MemoryObject)))
			{
				int sizeOf = typeof(T).SizeOf();
				return Enumerable.Range(0, count).Select(a => (T)Activator.CreateInstance(
					typeof(T),
					_memory, pointer + a * sizeOf)).ToArray();
			}
			else
			{
				return _memory.Read<T>(pointer, count);
			}
		}

		protected string Dereference(int offset, int count)
		{
			int address = Field<int>(offset);
			var bytes = _memory.ReadBytes(address, count);
			return ReadString(bytes, 0, count);
		}

		private T ReadAbsoluteAddress<T>(int absoluteAddress)
		{
			if (typeof(T).IsSubclassOf(typeof(MemoryObject)) ||
				typeof(T).Equals(typeof(MemoryObject)))
			{
				return (T)Activator.CreateInstance(
					typeof(T),
					_memory, absoluteAddress);
			}
			else
			{
				return _memory.Read<T>(absoluteAddress);
			}
		}

		public void TakeSnapshot()
		{
			Snapshot = Snapshot ?? new byte[GetType().SizeOf()];
			Snapshot = Memory.ReadBytes(_address, Snapshot);
		}

		public void FreeSnapshot()
		{
			Snapshot = null;
			_snapshotOffset = 0;
			GC.Collect();
		}

		public override string ToString()
		{
			return Address.ToString("X8") + " " + GetType().Name;
		}
	}
}
