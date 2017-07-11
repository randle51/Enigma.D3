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
    public class SNODiskEntry : MemoryObject
    {
        public static int SizeOf => SymbolTable.Current.Platform == Platform.X86 ? 0x0C : AlignedSize(0x14, 8);

        public SNOType SNOType => (SNOType)Read<byte>(0x00);
        public SNO SNO => Read<uint>(0x00) >> 8;
        public string Slug => this.PlatformReadStringPointer(0x04, 0x08, maxLength: 0x80).Dereference();
        public uint Flags => this.PlatformRead<uint>(0x08, 0x10);
    }
}
