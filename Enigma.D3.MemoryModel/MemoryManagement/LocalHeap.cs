using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Enigma.D3.MemoryModel;

namespace Enigma.D3.MemoryModel.MemoryManagement
{
    public class LocalHeap : MemoryObject, IEnumerable<HeapNode>
    {
        public HeapNode FirstNode
            => Read<Ptr<HeapNode>>(SymbolTable.Current.LocalHeap.FirstNode).Dereference();

        public HeapNode LastNode
            => Read<Ptr<HeapNode>>(SymbolTable.Current.LocalHeap.LastNode).Dereference();

        public uint NodeCount
            => Read<uint>(SymbolTable.Current.LocalHeap.NodeCount);

        public uint TotalSize
            => Read<uint>(SymbolTable.Current.LocalHeap.TotalSize);

        public IEnumerator<HeapNode> GetEnumerator()
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

        public IEnumerable<HeapNode> MainBlocks
            => this.Skip(1);

        public IEnumerable<HeapNode> SmallBlocks
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
