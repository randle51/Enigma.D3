using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.TypeSystem
{
    public class TagDescriptor : MemoryObject
    {
        public static int SizeOf => SymbolTable.PlatformSize(0x2C, 0x40);

        public uint Key => Read<uint>(0x00);
        public int I1 => Read<int>(0x04);
        public Ptr P0 => Read<Ptr>(0x08);
        public int I2 => this.PlatformRead<int>(0x0C, 0x10);
        public StringPointer DescriptionPtr => this.PlatformReadStringPointer(0x10, 0x18, 256);
        public StringPointer NamePtr => this.PlatformReadStringPointer(0x14, 0x20, 256);
        public StringPointer P1 => this.PlatformReadStringPointer(0x18, 0x28, 256);
        public int I3 => this.PlatformRead<int>(0x1C, 0x30);
        public int I4 => this.PlatformRead<int>(0x20, 0x34);
        public int I5 => this.PlatformRead<int>(0x24, 0x38);
        public int I6 => this.PlatformRead<int>(0x28, 0x3C);

        public string Description => DescriptionPtr.Dereference();
        public string Name => NamePtr.Dereference();
    }
}
