using Enigma.D3.MemoryModel.MemoryManagement;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel32.MemoryManagement
{
	public class HeapNode : MemoryObject, IHeapNode
	{
		internal const int HeaderSize = Constants.HeapNode.HeaderSize;

		public uint Size
			=> Read<uint>(Constants.HeapNode.SizeAndFlag) >> 1;

		public bool IsUsed
			=> (Read<uint>(Constants.HeapNode.SizeAndFlag) & 1) != 0;

		public Ptr Data
			=> new Ptr(Memory, Address + HeaderSize);
	}
}
