using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.D3.MemoryModel.Segments;
using Enigma.Memory;

namespace Enigma.D3.MemoryModel
{
	public class MemoryContext : IDisposable
	{
        public static MemoryContext Current;

		public IMemory Memory { get; }

		public MemoryContext(IMemory memory)
		{
            Memory = memory ?? throw new ArgumentNullException(nameof(memory));

			SymbolTable.Current = new SymbolTable(this);
			DataSegment = Memory.Reader.Read<DataSegment>(SymbolTable.Current.DataSegment.Address);

            Current = this;
		}

		public DataSegment DataSegment { get; }

        public void Dispose()
        {
            Memory.Dispose();
        }
	}
}
