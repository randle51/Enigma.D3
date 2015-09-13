using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct Quaternion16
	{
		public short X;
		public short Y;
		public short Z;
		public short W;

		public override string ToString()
		{
			return "quat16(" + string.Join(", ", X, Y, Z, W) + ")";
		}
	}
}
