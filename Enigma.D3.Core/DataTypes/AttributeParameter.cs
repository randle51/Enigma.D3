using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct AttributeParameter
	{
		public static implicit operator int(AttributeParameter attributeParameter)
		{
			return attributeParameter.Value;
		}

		public static implicit operator AttributeParameter(int value)
		{
			return new AttributeParameter { Value = value };
		}

		public int Value;

		public override string ToString()
		{
			return Value.ToString();
		}
	}
}
