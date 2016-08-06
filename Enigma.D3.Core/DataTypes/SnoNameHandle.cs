using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct SNONameHandle
	{
		public static implicit operator int(SNONameHandle snoNameHandle)
			=> snoNameHandle.Value;

		public static implicit operator SNONameHandle(int value)
			=> new SNONameHandle { Value = value };

		public int Value;

		public override string ToString()
			=> Value.ToString();
	}
}
