using System;
using System.Collections.Generic;
using System.Diagnostics;
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

			try
			{
				SizeOf = type.SizeOf();
			}
			catch (Exception exception)
			{
				Trace.TraceError("TypeHelper<" + typeof(T).Name + ">: " + exception.Message);
				SizeOf = 0;
			}
			IsMemoryObject = type.IsMemoryObjectType();
			IsStruct = type.IsValueType;
		}

		public static void Initialize() { }
	}
}
