using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct HighPrecisionPercent
	{
		public static implicit operator float(HighPrecisionPercent highPrecisionPercent)
		{
			return highPrecisionPercent.Value;
		}

		public static implicit operator HighPrecisionPercent(float value)
		{
			return new HighPrecisionPercent { Value = value };
		}

		public float Value;

		public override string ToString()
		{
			return (Value * 100.0f).ToString("0.0000") + "%";
		}
	}
}
