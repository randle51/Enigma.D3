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
    public class SNOGroupStorage<T> : MemoryObject
    {
        // 2.4.3.42655
        public const int SizeOf = 0x7C; // TODO: Update size, 64-bit compatible

        public Container<SNODefinition<T>> Container { get { return ReadPointer<Container<SNODefinition<T>>>(0x10).Dereference(); } }
    }
}
