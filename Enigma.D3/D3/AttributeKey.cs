using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.D3.Enums;

namespace Enigma.D3
{
	public struct AttributeKey
	{
		public int Value;

		public AttributeId Id { get { return (AttributeId)(Value & 0xFFF); } set { Value = (int)((Value & 0xFFFFF000) + (int)value); } }
		public int Modifier { get { return Value >> 12; } set { Value = (Value & 0x00000FFF) + (value << 12); } }

		public override string ToString()
		{
			return Id + " mod: " + Modifier;
		}

		public override int GetHashCode()
		{
			return unchecked((int)(Value ^ (Value >> 12)));
		}
	}
}
