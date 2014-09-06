using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	public class SnoHeader : MemoryObject
	{
		public Sno x00_SnoId;
		public int x04_LockCount;
		public int x08_Flags; // 1 = DoNotPurge
	}
}
