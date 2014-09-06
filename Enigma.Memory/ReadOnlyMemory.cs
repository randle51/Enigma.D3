using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Memory
{
	public class ReadOnlyMemory : IMemory
	{
		public ReadOnlyMemory(MemoryReader reader)
		{
			if (reader == null)
				throw new ArgumentNullException("reader");

			Reader = reader;
		}

		public MemoryReader Reader { get; private set; }

		public void Dispose()
		{
			Reader.Dispose();
		}
	}
}
