using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.CodeGen.Assets.TypeSystem
{
	public static class NativeTypes
	{
		private static readonly Dictionary<string, string> _nativeTypes = new Dictionary<string, string>();

		public static void Register<T>(string rawName) where T : struct
		{
			string name = GetNativeName<T>();
			_nativeTypes.Add(rawName, name);
		}

		internal static string GetNativeName<T>() where T : struct
		{
			string name = typeof(T).Name;
			switch (name)
			{
				case "Boolean":
					name = "bool";
					break;
				case "Byte":
					name = "byte";
					break;
				case "Int16":
					name = "short";
					break;
				case "Int32":
					name = "int";
					break;
				case "Int64":
					name = "long";
					break;
				case "Single":
					name = "float";
					break;
			}
			return name;
		}

		public static bool TryGetName(string rawName, out string name)
		{
			if (!_nativeTypes.TryGetValue(rawName, out name))
				name = null;
			return name != null;
		}

		public static bool Contains(string rawName)
		{
			return _nativeTypes.ContainsKey(rawName);
		}

		public static IEnumerable<string> GetRawNames()
		{
			return _nativeTypes.Keys;
		}
	}
}
