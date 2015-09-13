using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct Acceleration
	{
		public static implicit operator float(Acceleration acceleration)
		{
			return acceleration.Value;
		}

		public static implicit operator Acceleration(float value)
		{
			return new Acceleration { Value = value };
		}

		public float Value;

		public override string ToString()
		{
			return (Value * 3600.0f).ToString("0.00") + " ft/s^2";
		}
	}
}
