using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct Angle
	{
		public const float RadianToDegree = 180f / (float)Math.PI; //57.295776f;

		public static implicit operator float(Angle angle)
		{
			return angle.Value;
		}

		public static implicit operator Angle(float value)
		{
			return new Angle { Value = value };
		}

		public float Value;

		public override string ToString()
		{
			return (Value * RadianToDegree).ToString("0.00") + "-|";
		}
	}
}
