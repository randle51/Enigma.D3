using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Linq.Expressions;

namespace Enigma
{
	public class MemoryObject
	{
		// TODO: Make thread-safe!
		private static readonly Dictionary<Type, Activator> _activators = new Dictionary<Type, Activator>();

		private delegate object Activator(MemoryBase memory, int address);

		/// <remark>
		/// Assumes that type is of MemoryObject and that all other arguments are valid.
		/// </remark>
		internal static object UnsafeCreate(Type type, MemoryBase memory, int address)
		{
			Activator activator;
			if (!_activators.TryGetValue(type, out activator))
			{
				if (type.GetConstructor(Type.EmptyTypes) != null)
				{
					// return new T().Initialize(memory, address);

					var memoryParam = Expression.Parameter(typeof(MemoryBase), "memory");
					var addressParam = Expression.Parameter(typeof(int), "address");
					var callExpression = Expression.Call(
						Expression.New(type),
						type.GetMethod(
							"Initialize",
							BindingFlags.Instance | BindingFlags.InvokeMethod | BindingFlags.NonPublic,
							null,
							new Type[] { typeof(MemoryBase), typeof(int) },
							null),
						memoryParam,
						addressParam);

					activator = (Activator)Expression.Lambda(typeof(Activator),
						callExpression,
						memoryParam,
						addressParam).Compile();
				}
				else
				{
					// return new T(memory, address);

					var ctor = type.GetConstructor(new Type[] { typeof(MemoryBase), typeof(int) });
					if (ctor == null)
						throw new InvalidOperationException();

					var memoryParam = Expression.Parameter(typeof(MemoryBase), "memory");
					var addressParam = Expression.Parameter(typeof(int), "address");
					var newExpression = Expression.New(ctor, memoryParam, addressParam);

					activator = (Activator)Expression.Lambda(typeof(Activator), newExpression,
						memoryParam,
						addressParam
					).Compile();
				}

				_activators.Add(type, activator);
			}
			return activator.Invoke(memory, address);
		}

		/// <remark>
		/// Assumes that type is of MemoryObject and that all other arguments are valid.
		/// </remark>
		internal static object UnsafeCreate(Type type, MemoryBase memory, int address, byte[] buffer, int offset)
		{
			var obj = UnsafeCreate(type, memory, address);
			var memObj = obj as MemoryObject;
			memObj.SetSnapshot(buffer, offset);
			return memObj;
		}

		public static T Create<T>(MemoryBase memory, int address) where T : MemoryObject
		{
			ValidateArguments(memory, address);
			return (T)UnsafeCreate(typeof(T), memory, address);
		}

		public static T Create<T>(MemoryBase memory, int address, byte[] buffer, int offset) where T : MemoryObject
		{
			ValidateArguments(memory, address);
			if (buffer == null)
				throw new ArgumentNullException("buffer");
			if (offset < 0)
				throw new ArgumentOutOfRangeException("offset");
			if (buffer.Length - offset < TypeHelper<T>.SizeOf)
				throw new ArgumentOutOfRangeException();
			return (T)UnsafeCreate(typeof(T), memory, address, buffer, offset);
		}

		private static void ValidateArguments(MemoryBase memory, int address)
		{
			if (memory == null)
				throw new ArgumentNullException("memory");
#warning address range check disabled.
			//if ((uint)address > 0xCFFFFFFF) // 3GB
			//	throw new ArgumentOutOfRangeException("address");
		}

		private MemoryBase _memory;
		private int _address;
		private int _snapshotOffset;

		protected internal MemoryObject() { }

		protected MemoryObject Initialize(MemoryBase memory, int address)
		{
			_memory = memory;
			_address = address;
			return this;
		}

		protected MemoryObject(MemoryBase memory, int address)
		{
			ValidateArguments(memory, address);
			Initialize(memory, address);
		}

		public MemoryBase Memory { get { return _memory; } private set { _memory = value; } }

		public int Address { get { return _address; } set { _address = value; } }

		protected byte[] Snapshot { get; private set; }

		protected T Field<T>(int offset)
		{
			if (Snapshot != null)
			{
				if (TypeHelper<T>.IsMemoryObject)
				{
					return (T)MemoryObject.UnsafeCreate(typeof(T), _memory, _address + offset, this.Snapshot, offset);
				}
				else
				{
					return StructHelper<T>.Read(Snapshot, _snapshotOffset + offset);
				}
			}
			return _memory.Read<T>(_address + offset);
		}

		protected T[] Field<T>(int offset, int count)
		{
			T[] array = new T[count];
			var size = TypeHelper<T>.SizeOf;
			if (TypeHelper<T>.IsMemoryObject)
			{
				for (int i = 0; i < count; i++)
					array[i] = (T)MemoryObject.UnsafeCreate(typeof(T), _memory, _address + offset + i * size);
			}
			else
			{
				for (int i = 0; i < count; i++)
					array[i] = _memory.Read<T>(_address + offset + i * size);
			}
			return array;
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
			string[] array = new string[count];
			for (int i = 0; i < count; i++)
				array[i] = Field(offset + i * length, length);
			return array;
		}

		private string ReadString(byte[] buffer, int offset, int length)
		{
			return Encoding.UTF8.GetString(
				buffer,
				offset,
				length).Split('\0')[0];
		}

		protected T Dereference<T>(int offset)
		{
			int pointer;
			if (Snapshot != null)
			{
				pointer = BitConverter.ToInt32(Snapshot, _snapshotOffset + offset);
			}
			else
			{
				pointer = _memory.Read<int>(_address + offset);
			}

			if (pointer == 0)
			{
				return default(T);
			}
			return _memory.Read<T>(pointer);
		}

		protected T[] Dereference<T>(int offset, int count)
		{
			int pointer = Field<int>(offset);
			if (pointer == 0)
				return default(T[]);

			if (TypeHelper<T>.IsMemoryObject)
			{
				int size = TypeHelper<T>.SizeOf;
				var array = new T[count];
				for (int i = 0; i < count; i++)
					array[i] = (T)MemoryObject.UnsafeCreate(typeof(T), _memory, pointer + i * size);
				return array;
			}
			else
			{
				return _memory.Read<T>(pointer, count);
			}
		}

		protected string Dereference(int offset, int count)
		{
			int address = Field<int>(offset);
			if (address == 0)
				return default(string);

			var bytes = _memory.ReadBytes(address, count);
			return ReadString(bytes, 0, count);
		}

		protected internal void SetSnapshot(byte[] buffer, int offset = 0)
		{
			Snapshot = buffer;
			_snapshotOffset = offset;
		}

		public void TakeSnapshot()
		{
			if (Snapshot != null)
			{
				// Assume that we just need to update the current snapshot buffer.
				Memory.ReadBytes(_address, Snapshot, _snapshotOffset, GetType().SizeOf());
			}
			else
			{
				SetSnapshot(Memory.ReadBytes(_address, new byte[GetType().SizeOf()]), 0);
			}
		}

		public void FreeSnapshot()
		{
			SetSnapshot(null, 0);
		}

		public override string ToString()
		{
			return Address.ToString("X8") + " " + GetType().Name;
		}
	}
}
