using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public struct UIRect
	{
		public float x00_Left;
		public float x04_Top;
		public float x08_Right;
		public float x0C_Bottom;

		public float Width { get { return x08_Right - x00_Left; } }
		public float Height { get { return x0C_Bottom - x04_Top; } }

		public override string ToString()
		{
			return string.Format("L: {0}, T: {1}, R: {2}, B: {3} - W: {4}, H: {5}",
				x00_Left, x04_Top, x08_Right, x0C_Bottom,
				Width, Height);
		}
	}
}
