using Enigma.Memory;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.Explorer.Utilities
{
	internal static class ReflectionHelper
	{
		public static bool IsGenericPointer(this Type type)
		{
			return type.IsMemoryPointerType() && type.IsGenericType;
		}

		public static bool IsEnumerable(this Type type)
		{
			return typeof(IEnumerable).IsAssignableFrom(type);
		}

		public static Type GetEnumerableType(this Type type)
		{
			return type.GetInterfaces()
				.FirstOrDefault(x =>
					x.IsGenericType &&
					x.GetGenericTypeDefinition() == typeof(IEnumerable<>));
		}
	}
}
