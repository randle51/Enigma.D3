using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct Velocity
	{
		public static implicit operator float(Velocity velocity) => velocity.Value;

		public static implicit operator Velocity(float value) => new Velocity { Value = value };

		public float Value;

		public override string ToString()
			=> (Value * 60f).ToString("0.00") + " ft/s";
	}
}
