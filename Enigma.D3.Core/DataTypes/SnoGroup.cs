using Enigma.D3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct SNOGroup
	{
		public static implicit operator int(SNOGroup snoGroup)
			=> snoGroup.Value;

		public static implicit operator SNOGroup(int value)
			=> new SNOGroup { Value = value };

		public int Value;

		public override string ToString()
			=> ((SNOType)Value).ToString().ToUpper() + "_SNO";
	}
}
