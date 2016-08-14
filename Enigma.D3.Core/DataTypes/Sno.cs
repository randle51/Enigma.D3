using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct SNO
	{
		public static readonly SNO NONE = new SNO { Value = 0xFFFFFFFF };

		public static implicit operator uint(SNO sno) => sno.Value;

		public static implicit operator SNO(uint value) => new SNO { Value = value };

		public uint Value;

		public override string ToString()
			=> Value.ToString();
	}
}
