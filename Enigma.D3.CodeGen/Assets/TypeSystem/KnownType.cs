using Enigma.D3.Memory.TypeSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.CodeGen.Assets.TypeSystem
{
    internal class KnownType
    {
        public static implicit operator KnownType(string name)
        {
            return new KnownType { Address = 0, Name = name };
        }

        public static implicit operator KnownType(ValueTypeDescriptor descriptor)
        {
            return new KnownType { Address = descriptor.Address, Name = descriptor.x04_Name };
        }

        public int Address;
        public string Name;

        public override bool Equals(object obj)
        {
            var other = obj as KnownType;
            if (other == null)
                return false;

            if (other.Name == this.Name)
            {
                if (this.Address == 0 || other.Address == 0)
                    return true;
                return this.Address == other.Address;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Address.GetHashCode();
        }
    }
}
