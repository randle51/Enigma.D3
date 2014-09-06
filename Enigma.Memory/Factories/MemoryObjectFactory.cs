using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Memory
{
	public static class MemoryObjectFactory
	{
		private static class MemoryObjectActivatorCache<T> where T : MemoryObject
		{
			static MemoryObjectActivatorCache()
			{
				Activator = GetOrCreateActivator(typeof(T));
			}

			public static readonly Activator Activator;
		}

		private static readonly ConcurrentDictionary<Type, Activator> _activatorCache = new ConcurrentDictionary<Type, Activator>();

		private delegate MemoryObject Activator(IMemory memory, MemoryAddress address);

		public static T Create<T>(MemoryReader reader, MemoryAddress address) where T : MemoryObject
		{
			if (reader == null)
				throw new ArgumentNullException("reader");
			if (reader.Memory == null)
				throw new ArgumentException("reader");

			return Create<T>(reader.Memory, address);
		}

		public static T Create<T>(IMemory memory, MemoryAddress address) where T : MemoryObject
		{
			if (memory == null)
				throw new ArgumentNullException("memory");
			if (memory.Reader == null)
				throw new ArgumentException("memory");
			if (!memory.Reader.IsValid)
				throw new ArgumentException("memory");
			if (!memory.Reader.IsValidAddress(address))
				throw new ArgumentOutOfRangeException("address");
			if (!memory.Reader.IsValidAddress(address + TypeHelper<T>.SizeOf))
				throw new ArgumentOutOfRangeException("address");

			return (T)UnsafeCreate(typeof(T), memory, address);
		}

		public static T UnsafeCreate<T>(MemoryReader reader, MemoryAddress address) where T : MemoryObject
		{
			return (T)MemoryObjectActivatorCache<T>.Activator.Invoke(reader.Memory, address);
		}

		public static T UnsafeCreate<T>(IMemory memory, MemoryAddress address) where T : MemoryObject
		{
			return (T)MemoryObjectActivatorCache<T>.Activator.Invoke(memory, address);
		}

		public static MemoryObject Create(Type type, MemoryReader reader, MemoryAddress address)
		{
			if (reader == null)
				throw new ArgumentNullException("reader");
			if (reader.Memory == null)
				throw new ArgumentException("reader");

			return Create(type, reader.Memory, address);
		}

		public static MemoryObject Create(Type type, IMemory memory, MemoryAddress address)
		{
			if (type == null)
				throw new ArgumentNullException("type");
			if (memory == null)
				throw new ArgumentNullException("memory");
			if (memory.Reader == null)
				throw new ArgumentException("memory");
			if (!memory.Reader.IsValidAddress(address))
				throw new ArgumentOutOfRangeException("address");
			if (!memory.Reader.IsValidAddress(address + type.SizeOf()))
				throw new ArgumentOutOfRangeException();

			return UnsafeCreate(type, memory, address);
		}

		public static MemoryObject UnsafeCreate(Type type, MemoryReader reader, MemoryAddress address)
		{
			return GetOrCreateActivator(type).Invoke(reader.Memory, address);
		}

		public static MemoryObject UnsafeCreate(Type type, IMemory memory, MemoryAddress address)
		{
			return GetOrCreateActivator(type).Invoke(memory, address);
		}

		private static Activator GetOrCreateActivator(Type type)
		{
			return _activatorCache.GetOrAdd(type, (t) =>
			{
				var memoryParam = Expression.Parameter(typeof(IMemory), "memory");
				var addressParam = Expression.Parameter(typeof(MemoryAddress), "address");
				Expression initialize;

				if (t.GetConstructor(Type.EmptyTypes) != null)
				{
					initialize = Expression.Call(
						Expression.New(t),
						t.GetMethod(
							"Initialize",
							BindingFlags.Instance | BindingFlags.InvokeMethod | BindingFlags.NonPublic,
							null,
							new Type[] { memoryParam.Type, addressParam.Type },
							null),
						memoryParam,
						addressParam);
				}
				else
				{
					var ctor = t.GetConstructor(new[] { memoryParam.Type, addressParam.Type });
					if (ctor == null)
						throw new InvalidOperationException();
					initialize = Expression.New(ctor, memoryParam, addressParam);
				}

				return (Activator)Expression.Lambda(typeof(Activator),
					initialize,
					memoryParam,
					addressParam).Compile();

			});
		}
	}
}
