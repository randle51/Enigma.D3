using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct Sno
	{
		public static implicit operator int(Sno sno)
		{
			return sno.Value;
		}

		public static implicit operator Sno(int value)
		{
			return new Sno { Value = value };
		}

		public int Value;

		public override string ToString()
		{
			return Value.ToString();
		}
	}
}
