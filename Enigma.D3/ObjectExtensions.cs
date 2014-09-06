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
			where TResult : class
		{
			return obj == null ? null : getter(obj);
		}
	}
}
