using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public struct CriticalSection
	{
		public int DebugInfo;
		public int LockCount;
		public int RecursionCount;
		public int OwningThread;
		public int LockSemaphore;
		public int SpinCount;
	}
}
