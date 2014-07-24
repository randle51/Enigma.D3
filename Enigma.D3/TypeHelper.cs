using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Enigma
{
	public static class TypeHelper<T>
	{
		public static readonly int SizeOf;
		public static readonly bool IsMemoryObject;
		public static readonly bool IsStruct;
		public static readonly bool IsUXControl;
		public static readonly int UXVTableAddress;

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
			IsUXControl = type.IsUXControlType();
			if (IsUXControl)
			{
				var field = type.GetField("VTable", BindingFlags.FlattenHierarchy | BindingFlags.Static | BindingFlags.Public);
				if (field == null)
					throw new InvalidOperationException("Could not find 'VTable' constant on type '" + type.Name + "'");
				UXVTableAddress = field.IsLiteral ? (int)field.GetRawConstantValue() : (int)field.GetValue(null);
			}
			IsStruct = type.IsValueType;
		}

		public static void Initialize() { }
	}
}
