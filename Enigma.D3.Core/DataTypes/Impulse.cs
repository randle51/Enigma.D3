using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct Impulse
	{
		public static implicit operator float(Impulse impulse) => impulse.Value;

		public static implicit operator Impulse(float value) => new Impulse { Value = value };

		public float Value;

		public override string ToString()
			=> (Value * 60.0f).ToString("0.00") + " lb-sec";
	}
}
