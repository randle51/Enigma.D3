using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct Vector2
	{
		public float X;
		public float Y;

		public override string ToString()
			=> $"vec2({X}, {Y})";
	}
}
