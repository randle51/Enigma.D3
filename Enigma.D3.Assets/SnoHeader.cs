using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	public class SNOHeader : MemoryObject
	{
		public const int SizeOf = 0x0C; // 12

		public SNO x00_SnoId { get { return Read<SNO>(0x00); } }
		public int x04_LockCount { get { return Read<int>(0x04); } }
		public int x08_Flags { get { return Read<int>(0x08); } } // 1 = DoNotPurge
	}
}
