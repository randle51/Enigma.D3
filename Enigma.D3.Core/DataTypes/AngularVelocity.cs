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

		public static implicit operator float(AngularVelocity angularVelocity) => angularVelocity.Value;

		public static implicit operator AngularVelocity(float value) => new AngularVelocity { Value = value };

		public float Value;

		public override string ToString()
			=> ((Value * RadianToDegree) * 60.0f).ToString("0.00") + "-|/s";
	}
}
