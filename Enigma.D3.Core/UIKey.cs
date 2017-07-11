using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3
{
    public struct UIKey
    {
        public static implicit operator UIKey(string name)
        {
            return HashUtils.Fnv64(Encoding.ASCII.GetBytes(name.ToLowerInvariant()));
        }

        public static implicit operator UIKey(ulong value)
        {
            return new UIKey { Value = value };
        }

        public static bool operator ==(UIKey a, UIKey b) => a.Value == b.Value;

        public static bool operator !=(UIKey a, UIKey b) => a.Value != b.Value;

        public ulong Value;

        public override int GetHashCode()
        {
            return (int)HashUtils.Fnv32((int)Value);
        }

        public override bool Equals(object obj)
        {
            if (obj is UIKey == false)
                return false;

            return ((UIKey)obj).Value == Value;
        }
    }
}
