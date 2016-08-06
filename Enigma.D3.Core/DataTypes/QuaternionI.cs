using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.DataTypes
{
	public struct QuaternionI
	{
		public short X;
		public short Y;
		public short Z;
		public short W;

		public override string ToString()
			=> $"iquat({X}, {Y}, {Z}, {W})";
	}
}
