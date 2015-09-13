using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct Percent
	{
		public static implicit operator byte(Percent percent)
		{
			return percent.Value;
		}

		public static implicit operator Percent(byte value)
		{
			return new Percent { Value = value };
		}

		public byte Value;

		public override string ToString()
		{
			return (((float)Value / 255.0f) * 100.0f).ToString("0.00") + "%";
		}
	}
}
