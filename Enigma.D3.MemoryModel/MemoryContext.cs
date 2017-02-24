using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.D3.MemoryModel.Segments;
using Enigma.Memory;

namespace Enigma.D3.MemoryModel
{
	public class MemoryContext
	{
		public IMemory Memory { get; }

		public MemoryContext(IMemory memory)
		{
			if (memory == null)
				throw new ArgumentNullException(nameof(memory));

			Memory = memory;

			SymbolTable.Current = new SymbolTable(this);
			DataSegment = Memory.Reader.Read<DataSegment>(SymbolTable.Current.DataSegment.Address);
		}

		public DataSegment DataSegment { get; }
	}
}
