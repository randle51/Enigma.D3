using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Memory
{
	public static class TypeHelper
	{
		private static readonly ConcurrentDictionary<Type, int> _cachedSizeOf = new ConcurrentDictionary<Type, int>();
		private static readonly ConcurrentDictionary<Type, bool> _cachedIsMemoryObject = new ConcurrentDictionary<Type, bool>();

		public static int SizeOf(this Type type)
		{
			return _cachedSizeOf.GetOrAdd(type, (t) =>
			{
				if (t.IsMemoryPointerType())
					return 0;
				if (t.Equals(typeof(MemoryObject)))
					return 0;

				if (t.IsSubclassOf(typeof(MemoryObject)))
				{
					var field = type.GetField("SizeOf",
						BindingFlags.FlattenHierarchy |
						BindingFlags.Static |
						BindingFlags.Public);
					if (field == null)
						return 0;
					var value = field.IsLiteral ? (int)field.GetRawConstantValue() : (int)field.GetValue(null);
					if (value < 0)
						throw new ArgumentOutOfRangeException("Negative value for the static 'SizeOf' field is not allowed.");
					return value;
				}

				return Marshal.SizeOf(t.IsEnum ? t.GetEnumUnderlyingType() : t);
			});
		}

		public static bool IsMemoryPointerType(this Type type)
		{
			return type.Equals(typeof(Ptr)) ||
				type.IsSubclassOf(typeof(Ptr));
		}

		public static bool IsMemoryObjectType(this Type type)
		{
			return _cachedIsMemoryObject.GetOrAdd(type, (t) =>
			{
				return t.IsSubclassOf(typeof(MemoryObject)) ||
					t.Equals(typeof(MemoryObject));
			});
		}
	}

	public static class TypeHelper<T>
	{
		public static readonly int SizeOf;
		public static readonly bool IsMemoryPointerType;
		public static readonly bool IsMemoryObjectType;
		public static readonly bool IsMemoryAddressType;
		public static readonly bool IsValueType;
		public static readonly bool IsVoidMemoryPointerType;
		public static readonly bool IsTypeSupportedByMemoryReader;
		public static readonly bool HasKnownStructLayout;
		public static readonly bool IsStringPointerType;
		public static readonly bool IsGenericType;
		public static readonly bool IsArrayType;

		static TypeHelper()
		{
			IsMemoryPointerType = typeof(T).IsMemoryPointerType();
			SizeOf = IsMemoryPointerType ? 0 : typeof(T).SizeOf(); // Cannot be fully sure of a pointer size, depends on the context.
			IsMemoryObjectType = typeof(T).IsMemoryObjectType();
			IsValueType = typeof(T).IsValueType;
			IsMemoryAddressType = typeof(T).Equals(typeof(MemoryAddress));
			IsStringPointerType = typeof(T).Equals(typeof(StringPointer));
			IsVoidMemoryPointerType = typeof(T).Equals(typeof(Ptr));
			IsGenericType = typeof(T).IsGenericType;
			IsArrayType = typeof(T).IsArray;
			
			var structLayoutAttribute = typeof(T).GetCustomAttribute<StructLayoutAttribute>();
			var hasExplicitStructLayout = structLayoutAttribute != null && structLayoutAttribute.Value != LayoutKind.Auto;
			HasKnownStructLayout = IsMemoryAddressType == false && IsValueType | hasExplicitStructLayout;

			IsTypeSupportedByMemoryReader = HasKnownStructLayout | IsMemoryObjectType | IsMemoryPointerType | IsMemoryAddressType;
		}
	}
}
