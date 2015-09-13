using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.D3.Enums;

namespace Enigma.D3.DataTypes
{
	public struct SnoGroup
	{
		public static implicit operator int(SnoGroup snoGroup)
		{
			return snoGroup.Value;
		}

		public static implicit operator SnoGroup(int value)
		{
			return new SnoGroup { Value = value };
		}

		public int Value;

		public override string ToString()
		{
			return ((SnoGroupId)Value).ToString().ToUpper() + "_SNO";
		}
	}
}
