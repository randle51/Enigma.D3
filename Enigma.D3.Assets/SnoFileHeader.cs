using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	public struct SNOFileHeader
	{
		public uint MagicBytes;
		public uint Reserved0;
		public uint Reserved1;
		public uint Reserved2;

		public bool IsValid { get { return MagicBytes == 0xDEADBEEF; } }
	}
}
