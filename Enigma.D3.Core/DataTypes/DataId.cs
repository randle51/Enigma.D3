using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct DataId
	{
		public static implicit operator int(DataId dataId)
		{
			return dataId.Value;
		}

		public static implicit operator DataId(int value)
		{
			return new DataId { Value = value };
		}

		public int Value;

		public override string ToString()
		{
			return "0x" + Value.ToString("X8");
		}
	}
}
