using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public struct WorldRect
	{
		public Point2D Min;
		public Point2D Max;

		public float Width { get { return Max.X - Min.X; } }
		public float Length { get { return Max.Y - Min.Y; } }

		public override string ToString()
		{
			return string.Format("X1:{0}, Y1:{1}, X2:{2}, Y2:{3}", Min.X, Min.Y, Max.X, Max.Y);
		}
	}
}
