using Enigma.D3.MemoryModel.MemoryManagement;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryExplorer
{
	internal static class Extensions
	{
		public static bool Contains(this HeapNode node, MemoryAddress address)
		{
			return node.Data.ValueAddress <= address &&
				node.Data.ValueAddress + node.Size > address;
		}
	}
}
