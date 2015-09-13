using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct SnoNameHandle
	{
		public static implicit operator int(SnoNameHandle snoNameHandle)
		{
			return snoNameHandle.Value;
		}

		public static implicit operator SnoNameHandle(int value)
		{
			return new SnoNameHandle { Value = value };
		}

		public int Value;

		public override string ToString()
		{
			return Value.ToString();
		}
	}
}
