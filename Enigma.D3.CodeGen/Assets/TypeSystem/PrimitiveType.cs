using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.CodeGen.Assets.TypeSystem
{
    public class PrimitiveType
    {
        private static readonly Dictionary<string, PrimitiveType> _primitiveTypes = new Dictionary<string, PrimitiveType>();

        public static PrimitiveType Register<T>(string rawName, string name, string toString = null, params string[] constants) where T : struct
        {
            var type = new PrimitiveType();
            type.BaseType = typeof(T);
            type.RawName = rawName;
            type.Name = name;
            type.NativeName = NativeTypes.GetNativeName<T>();
            type.ToStringBody = toString;
            type.Constants = constants;
            _primitiveTypes.Add(rawName, type);
            return type;
        }

        public static bool TryGetName(string rawName, out string name)
        {
            PrimitiveType type;
            name = _primitiveTypes.TryGetValue(rawName, out type) ?
                type.Name : null;
            return type != null;
        }

        public static IEnumerable<string> GetRawNames()
        {
            return _primitiveTypes.Values.Select(a => a.RawName);
        }

        public static IEnumerable<PrimitiveType> Enumerate()
        {
            return _primitiveTypes.Values;
        }

        public Type BaseType;
        public string RawName;
        public string Name;
        public string ToStringBody;
        public string[] Constants;
        public string NativeName;
    }
}
