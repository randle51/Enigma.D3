using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct Time
	{
		public static implicit operator float(Time time)
		{
			return time.Value;
		}

		public static implicit operator Time(float value)
		{
			return new Time { Value = value };
		}

		public float Value;

		public override string ToString()
		{
			return (Value / 60f).ToString("0.00 sec");
		}
	}
}
