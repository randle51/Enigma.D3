using Enigma.D3.DataTypes;
using Enigma.D3.Enums;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Assets
{
    // TODO: 64-bit offset/size validation
    public class SNODiskEntry : MemoryObject
    {
        public const int SizeOf = 0x0C;

        public SNOType SNOType => (SNOType)Read<byte>(0x00);
        public SNO SNO => Read<uint>(0x00) >> 8;
        public string Slug => ReadStringPointer(0x04, 0x80).Dereference();
        public uint Flags => Read<uint>(0x08);
    }
}
