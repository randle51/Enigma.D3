using Enigma.D3.MemoryModel;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryExplorer
{
	internal class Segment : ISegment
	{
		public Segment(MemoryAddress start, uint length)
		{
			Start = start;
			End = start + length;
			Size = length;
		}

		public MemoryAddress Start { get; private set; }
		public MemoryAddress End { get; private set; }
		public uint Size { get; private set; }
	}
}
