using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Core
{
    public class UIID : MemoryObject
    {
        public const int SizeOf = 0x208;

        public static implicit operator UIKey(UIID id) => id.Key;

        public ulong Key => Read<ulong>(0x000);
        public string Name => ReadString(0x008, 0x200);

        public override string ToString() => Name;
    }
}
