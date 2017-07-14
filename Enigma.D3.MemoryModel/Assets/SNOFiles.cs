using Enigma.D3.MemoryModel.Collections;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Assets
{
    public class SNOFiles : MemoryObject
    {
        public static int SizeOf => SymbolTable.Current.SNOFiles.SizeOf;

        public LinkedListWithAllocatorB<SNODiskEntry> SNODiskEntries
            => Read<Ptr<LinkedListWithAllocatorB<SNODiskEntry>>>(SymbolTable.Current.SNOFiles.SNODiskEntries).Dereference();
    }
}
