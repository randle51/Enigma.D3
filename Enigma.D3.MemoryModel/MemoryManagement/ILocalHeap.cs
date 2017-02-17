using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.MemoryManagement
{
	public interface ILocalHeap : IEnumerable<IHeapNode>
	{
		IHeapNode FirstNode { get; }
		IHeapNode LastNode { get; }
		uint NodeCount { get; }
		uint TotalSize { get; }
	}
}
