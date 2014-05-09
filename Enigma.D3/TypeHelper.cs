using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma
{
	public static class TypeHelper<T>
	{
		public static readonly int SizeOf;
		public static readonly bool IsMemoryObject;
		public static readonly bool IsStruct;

		static TypeHelper()
		{
			var type = typeof(T);

			SizeOf = type.SizeOf();
			IsMemoryObject = type.IsMemoryObjectType();
			IsStruct = type.IsValueType;
		}

		public static void Initialize() { }
	}
}
