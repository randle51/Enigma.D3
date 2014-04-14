using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public struct AxisAlignedBoundingBox
	{
		public Point3D Min;
		public Point3D Max;

		public float Width { get { return Max.X - Min.X; } }
		public float Length { get { return Max.Y - Min.Y; } }
		public float Height { get { return Max.Z - Min.Z; } }

		public override string ToString()
		{
			return string.Format("{0:0.0} x {1:0.0} x {2:0.0}", Width, Length, Height);
		}
	}
}
