using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public struct Point2D
	{
		public float X;
		public float Y;

		public override string ToString()
		{
			return string.Format(
				"{{ X: {0:0.0}, Y: {1:0.0} }}",
				X, Y);
		}
	}
}
