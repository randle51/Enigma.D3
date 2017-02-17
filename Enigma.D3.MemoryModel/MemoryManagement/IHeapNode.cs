using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.MemoryManagement
{
	public interface IHeapNode
	{
		MemoryAddress Address { get; }
		bool IsUsed { get; }
		uint Size { get; }
		Ptr Data { get; }
	}
}
