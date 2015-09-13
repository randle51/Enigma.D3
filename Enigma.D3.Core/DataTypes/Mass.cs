using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct Mass
	{
		public static implicit operator float(Mass mass)
		{
			return mass.Value;
		}

		public static implicit operator Mass(float value)
		{
			return new Mass { Value = value };
		}

		public float Value;

		public override string ToString()
		{
			return (Value * 32.2f).ToString("0.00") + " lb";
		}
	}
}
