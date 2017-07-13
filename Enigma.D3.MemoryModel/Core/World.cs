using Enigma.D3.DataTypes;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Core
{
    // TODO: SymbolTable offsets
    public class World : MemoryObject
    {
        public static int SizeOf => SymbolTable.Current.World.SizeOf;

        public int ID => Read<int>(0x00);

        public SNO WorldSNO => this.PlatformRead<SNO>(0x04, 0x08); // 64-bit: struct alignment

        public int SWorldID => this.PlatformRead<int>(0x0C, 0x10);
    }
}
