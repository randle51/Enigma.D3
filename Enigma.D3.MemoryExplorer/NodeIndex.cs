using Enigma.D3.MemoryModel.MemoryManagement;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryExplorer
{
	internal class NodeIndex
	{
		private HeapNode[] _nodes;
		private List<ulong> _starts;

		public NodeIndex(ICollection<HeapNode> nodes)
		{
			var q = nodes.AsEnumerable();
			_nodes = q.OrderBy(x => (ulong)x.Address).ToArray();
			_starts = _nodes.Select(x => (ulong)x.Address).ToList();
		}

		public HeapNode FindNode(MemoryAddress address)
		{
			var index = _starts.BinarySearch(address);
			if (index == -1)
				return null; // lower than first value

			if (index < 0)
			{
				int closest = ~index - 1;
				if (_nodes[closest].Contains(address))
				{
					return _nodes[closest];
				}
				else
				{
					if (closest + 1 < _nodes.Length &&
						_nodes[closest + 1].Contains(address))
					{
						return _nodes[closest + 1];
					}
					else
					{
						return null;
					}
				}
			}
			else return _nodes[index];
		}
	}
}
