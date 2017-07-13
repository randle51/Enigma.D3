using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.MemoryManagement
{
    public class MemoryManager : MemoryObject
    {
        public static int SizeOf => SymbolTable.Current.MemoryManager.SizeOf;

        public LocalHeap LocalHeap
            => Read<Ptr<LocalHeap>>(SymbolTable.Current.MemoryManager.LocalHeap).Dereference();
    }
}
