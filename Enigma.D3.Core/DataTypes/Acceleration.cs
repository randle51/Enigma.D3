using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct Acceleration
	{
		public static implicit operator float(Acceleration acceleration) => acceleration.Value;

		public static implicit operator Acceleration(float value) => new Acceleration { Value = value };

		public float Value;

		public override string ToString()
			=> (Value * 3600.0f).ToString("0.00") + " ft/s^2";
	}
}
