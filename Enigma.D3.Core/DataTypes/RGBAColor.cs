using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct RGBAColor
	{
		public static implicit operator uint(RGBAColor color) => color.Value;

		public static implicit operator RGBAColor(uint value) => new RGBAColor { Value = value };

		public uint Value;

		public override string ToString()
			=> "rgba(0x" + Value.ToString("X8") + ")";
	}
}
