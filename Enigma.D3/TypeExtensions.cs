using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Enigma
{
	public static class TypeExtensions
	{
		private static Dictionary<Type, int> _cachedSizes = new Dictionary<Type, int>();

		public static bool IsMemoryObjectType(this Type type)
		{
			return type.IsSubclassOf(typeof(MemoryObject)) || type.Equals(typeof(MemoryObject));
		}

		public static int SizeOf(this Type type)
		{
			int sizeOf;
			if (!_cachedSizes.TryGetValue(type, out sizeOf))
			{
				if (type.Equals(typeof(MemoryObject)))
				{
					return 0;
				}
				else if (type.IsSubclassOf(typeof(MemoryObject)))
				{
					var field = type.GetField("SizeOf", BindingFlags.FlattenHierarchy | BindingFlags.Static | BindingFlags.Public);
					if (field == null)
						throw new InvalidOperationException("Could not find 'SizeOf' constant on type '" + type.Name + "'");
					sizeOf = field.IsLiteral ? (int)field.GetRawConstantValue() : (int)field.GetValue(null);
				}
				else
				{
					sizeOf = Marshal.SizeOf(type);
				}
				_cachedSizes.Add(type, sizeOf);
			}
			return sizeOf;
		}
	}
}
