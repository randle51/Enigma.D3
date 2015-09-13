using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Win32
{
	public struct CriticalSection
	{
		public const int SizeOf = 24;

		public int DebugInfo;
		public int LockCount;
		public int RecursionCount;
		public int OwningThread;
		public int LockSemaphore;
		public int SpinCount;
	}
}
