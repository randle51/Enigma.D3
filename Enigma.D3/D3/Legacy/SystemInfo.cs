using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public struct SystemInfo
	{
		public int OemId;
		public int PageSize;
		public int MinimumApplicationAddress;
		public int MaximumApplicationAddress;
		public int ActiveProcessorMask;
		public int NumberOfProcessors;
		public int ProcessorType;
		public int AllocationGranularity;
		public short ProcessorLevel;
		public short ProcessorRevision;
	}
}
