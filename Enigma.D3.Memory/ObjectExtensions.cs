using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.Memory;

namespace Enigma
{
	internal static class ObjectExtensions
	{
		public static TResult IfNotNull<T, TResult>(this T obj, Func<T, TResult> getter)
			where T : class
		{
			return obj == null ? default(TResult) : getter(obj);
		}

		public static TResult IfNotNull<T, TResult>(this T obj, Func<T, TResult> getter, TResult fallbackValue)
			where T : class
		{
			return obj == null ? fallbackValue : getter(obj);
		}
	}
}
