using Enigma.D3.MemoryModel.Collections;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Assets
{
    // TODO: 64-bit offset/size validation
    public class SNOFiles : MemoryObject
    {
        public const int SizeOf = 0x4A88; // 32-bit 2.6.0

        public LinkedListWithAllocator<SNODiskEntry> SNODiskEntries
            => Read<Ptr<LinkedListWithAllocator<SNODiskEntry>>>(0x118).Dereference();
    }
}
