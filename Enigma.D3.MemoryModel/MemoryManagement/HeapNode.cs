using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.MemoryManagement
{
    public class HeapNode : MemoryObject
    {
        public static int HeaderSize => SymbolTable.Current.HeapNode.HeaderSize;

        public uint Size
            => Read<uint>(SymbolTable.Current.HeapNode.SizeAndFlag) >> 1;

        public bool IsUsed
            => (Read<uint>(SymbolTable.Current.HeapNode.SizeAndFlag) & 1) != 0;

        public Ptr Data
            => new Ptr(Memory, Address + HeaderSize);
    }
}
