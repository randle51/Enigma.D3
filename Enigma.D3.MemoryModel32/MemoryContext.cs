using Enigma.D3.MemoryModel;
using Enigma.D3.MemoryModel.Segments;
using Enigma.D3.MemoryModel32.Segments;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel32
{
	public class MemoryContext : IMemoryContext
	{
		public IMemory Memory { get; }

		public MemoryContext(IMemory memory)
		{
			if (memory == null)
				throw new ArgumentNullException(nameof(memory));

			Memory = memory;
			DataSegment = Memory.Reader.Read<DataSegment>(0x01D89000);
		}

		public IDataSegment DataSegment { get; }
	}
}
