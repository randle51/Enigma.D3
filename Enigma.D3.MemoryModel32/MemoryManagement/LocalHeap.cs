using Enigma.D3.MemoryModel.MemoryManagement;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Enigma.D3.MemoryModel32.MemoryManagement
{
	public class LocalHeap : MemoryObject, ILocalHeap
	{
		public IHeapNode FirstNode
			=> Read<Ptr<HeapNode>>(Constants.LocalHeap.FirstNode).Dereference();

		public IHeapNode LastNode
			=> Read<Ptr<HeapNode>>(Constants.LocalHeap.LastNode).Dereference();

		public uint NodeCount
			=> Read<uint>(Constants.LocalHeap.NodeCount);

		public uint TotalSize
			=> Read<uint>(Constants.LocalHeap.TotalSize);

		public IEnumerator<IHeapNode> GetEnumerator()
		{
			var current = FirstNode;
			var last = LastNode;
			while (current.Address != last.Address)
			{
				yield return current;
				current = new Ptr<HeapNode>(Memory, current.Address + HeapNode.HeaderSize + current.Size).Dereference();
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
			=> GetEnumerator();

		public IEnumerable<IHeapNode> MainBlocks
			=> this.Skip(1);

		public IEnumerable<IHeapNode> SmallBlocks
		{
			get
			{
				var block = this.First();
				var current = block.Data.Cast<HeapNode>().Dereference();
				var end = block.Data.ValueAddress + block.Size;
				while (current.Address != end)
				{
					yield return current;
					current = new Ptr<HeapNode>(Memory, current.Address + HeapNode.HeaderSize + current.Size).Dereference();
				}
			}
		}
	}
}
