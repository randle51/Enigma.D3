﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct AttributeParameter
	{
		public static implicit operator int(AttributeParameter attributeParameter) => attributeParameter.Value;

		public static implicit operator AttributeParameter(int value) => new AttributeParameter { Value = value };

		public int Value;

		public override string ToString()
			=> Value.ToString();
	}
}
