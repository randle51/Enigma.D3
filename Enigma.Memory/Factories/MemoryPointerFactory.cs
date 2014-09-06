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
	public static class MemoryPointerFactory
	{
		private static class MemoryPointerActivatorCache<T>
		{
			static MemoryPointerActivatorCache()
			{
				Activator = GetOrCreateActivator(typeof(T));
			}

			public static readonly Activator Activator;
		}

		private static readonly ConcurrentDictionary<Type, Activator> _activatorCache = new ConcurrentDictionary<Type, Activator>();

		private delegate Ptr Activator(IMemory memory, MemoryAddress address);

		private static Activator GetOrCreateActivator(Type type)
		{
			return _activatorCache.GetOrAdd(type, (t) =>
			{
				var memoryParam = Expression.Parameter(typeof(IMemory), "memory");
				var valueParam = Expression.Parameter(typeof(MemoryAddress), "value");

				var ctor = t.GetConstructor(new[] { memoryParam.Type, valueParam.Type });
				if (ctor == null)
					throw new InvalidOperationException();

				var call = Expression.New(ctor, memoryParam, valueParam);
				return (Activator)Expression.Lambda(typeof(Activator), call, memoryParam, valueParam).Compile();
			});
		}

		public static object Create<T>(IMemory memory, MemoryAddress value)
		{
			if (!TypeHelper<T>.IsMemoryPointerType)
				throw new NotSupportedException();

			return UnsafeCreate<T>(memory, value);
		}

		public static object UnsafeCreate<T>(IMemory memory, MemoryAddress value)
		{
			if (TypeHelper<T>.IsVoidMemoryPointerType)
				return new Ptr(memory, value);
			else if (TypeHelper<T>.IsStringPointerType)
				return new StringPointer(memory, value);
			else if (TypeHelper<T>.IsGenericType)
				return MemoryPointerActivatorCache<T>.Activator.Invoke(memory, value);
			else throw new NotSupportedException();
		}
	}
}
