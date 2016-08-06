using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct Quaternion
	{
		public float W;
		public float X;
		public float Y;
		public float Z;

		public override string ToString()
			=> $"quat({X}, {Y}, {Z}, {W})";
	}
}
