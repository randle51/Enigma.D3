using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;

namespace Enigma
{
	public static class StructHelper<T>
	{
		internal delegate T UnsafeReadDelegate(byte[] buffer, int offset);

		internal static readonly UnsafeReadDelegate UnsafeReadImplementation;

		public static readonly int SizeOf;

		static StructHelper()
		{
			if (!TypeHelper<T>.IsStruct)
				throw new NotSupportedException("Type must be a value type.");

			SizeOf = TypeHelper<T>.SizeOf;
			UnsafeReadImplementation = CreateUnsafeReadImplementation();
		}

		private static UnsafeReadDelegate CreateUnsafeReadImplementation()
		{
			// The IL code that is emitted here reflects the following C# code (although it is not
			// possible to compile with C#):
			//
			// T UnsafeReadImplementation(byte[] buffer, int offset)
			// {
			//     fixed (byte* pBuffer = &buffer[offset])
			//         return *(T*)pBuffer;
			// }
			//
			// IL reflected from a statically typed method where the type arguments has been
			// replaced. Some operations might not be required, but it is better to let the JIT
			// optimize that so nothing important goes missing.

			var dm = new DynamicMethod(
				"UnsafeReadImplementation",
				typeof(T),
				new Type[] { typeof(byte[]), typeof(int) },
				Assembly.GetExecutingAssembly().ManifestModule);

			var il = dm.GetILGenerator();

			il.DeclareLocal(typeof(byte).MakeByRefType(), true);
			il.DeclareLocal(typeof(T));

			var IL_0012 = il.DefineLabel();

			il.Emit(OpCodes.Ldarg_0);
			il.Emit(OpCodes.Ldarg_1);
			il.Emit(OpCodes.Ldelema, typeof(byte));
			il.Emit(OpCodes.Stloc_0);
			il.Emit(OpCodes.Ldloc_0);
			il.Emit(OpCodes.Conv_I);
			il.Emit(OpCodes.Ldobj, typeof(T));
			il.Emit(OpCodes.Stloc_1);
			il.Emit(OpCodes.Leave_S, IL_0012);

			il.MarkLabel(IL_0012);
			il.Emit(OpCodes.Ldloc_1);
			il.Emit(OpCodes.Ret);

			return (UnsafeReadDelegate)dm.CreateDelegate(typeof(UnsafeReadDelegate));
		}

		/// <summary>
		/// Read a struct from a buffer at given offset.
		/// </summary>
		public static T Read(byte[] buffer, int offset)
		{
			if (buffer == null)
				throw new ArgumentNullException("buffer");
			if (buffer.Length == 0)
				throw new ArgumentOutOfRangeException("buffer");
			if (offset < 0)
				throw new ArgumentOutOfRangeException("offset");
			if (offset + SizeOf > buffer.Length)
				throw new ArgumentOutOfRangeException();

			return UnsafeReadImplementation(buffer, offset);
		}

		/// <summary>
		/// Read a struct from a buffer at given offset.
		/// </summary>
		/// <remarks>No validation is made.</remarks>
		public static T UnsafeRead(byte[] buffer, int offset)
		{
			return UnsafeReadImplementation(buffer, offset);
		}

		/// <summary>
		/// Forces a call to the static constructor if it hasn't run already. Method body is empty.
		/// </summary>
		public static void Initialize() { }
	}
}
