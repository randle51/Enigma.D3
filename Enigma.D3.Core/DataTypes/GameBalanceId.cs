using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct GameBalanceId
	{
		public static implicit operator int(GameBalanceId gameBalanceId)
		{
			return gameBalanceId.Value;
		}

		public static implicit operator GameBalanceId(int value)
		{
			return new GameBalanceId { Value = value };
		}

		public int Value;

		public override string ToString()
		{
			return Value.ToString();
		}
	}
}
