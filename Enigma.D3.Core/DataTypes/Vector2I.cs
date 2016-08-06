using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct Vector2I
	{
		public int X;
		public int Y;

		public override string ToString()
			=> $"ivec2({X}, {Y})";
	}
}
