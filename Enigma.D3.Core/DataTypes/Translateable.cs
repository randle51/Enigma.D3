using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct Translateable
	{
		public static implicit operator int(Translateable translateable)
		{
			return translateable.Value;
		}

		public static implicit operator Translateable(int value)
		{
			return new Translateable { Value = value };
		}

		public int Value;

		public override string ToString()
		{
			return Value.ToString();
		}
	}
}
