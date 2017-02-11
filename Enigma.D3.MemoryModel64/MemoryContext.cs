using Enigma.D3.MemoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.D3.MemoryModel.Segments;
using Enigma.Memory;
using Enigma.D3.MemoryModel64.Segments;

namespace Enigma.D3.MemoryModel64
{
	public class MemoryContext : IMemoryContext
	{
		public IMemory Memory { get; }

		public MemoryContext(IMemory memory)
		{
			if (memory == null)
				throw new ArgumentNullException(nameof(memory));

			Memory = memory;
			DataSegment = Memory.Reader.Read<DataSegment>(0x1415CD000);
		}

		public IDataSegment DataSegment { get; }
	}
}
