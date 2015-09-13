using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct AngularVelocity
	{
		public const float RadianToDegree = 180f / (float)Math.PI; //57.295776f;

		public static implicit operator float(AngularVelocity angularVelocity)
		{
			return angularVelocity.Value;
		}

		public static implicit operator AngularVelocity(float value)
		{
			return new AngularVelocity { Value = value };
		}

		public float Value;

		public override string ToString()
		{
			return ((Value * RadianToDegree) * 60.0f).ToString("0.00") + "-|/s";
		}
	}
}
