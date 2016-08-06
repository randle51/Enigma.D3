using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct Mass
	{
		public static implicit operator float(Mass mass) => mass.Value;

		public static implicit operator Mass(float value) => new Mass { Value = value };

		public float Value;

		public override string ToString()
			=> (Value * 32.2f).ToString("0.00") + " lb";
	}
}
