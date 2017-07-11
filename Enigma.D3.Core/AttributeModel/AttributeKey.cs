using Enigma.D3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.AttributeModel
{
    public struct AttributeKey
    {
        public static implicit operator AttributeKey(int value) => new AttributeKey { Value = value };

        public static bool operator ==(AttributeKey a, AttributeKey b) => a.Value == b.Value;

        public static bool operator !=(AttributeKey a, AttributeKey b) => a.Value != b.Value;

        public int Value;

        public AttributeId Id { get { return (AttributeId)(Value & 0xFFF); } set { Value = (int)((Value & 0xFFFFF000) + (int)value); } }
        public int Modifier { get { return Value >> 12; } set { Value = (Value & 0x00000FFF) + (value << 12); } }

        public override string ToString()
        {
            return Id + " mod: " + Modifier;
        }

        public override int GetHashCode()
        {
            return Value ^ (Value >> 12);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is AttributeKey))
                return false;

            return ((AttributeKey)obj).Value == Value;
        }
    }
}
