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
    public class Scene : MemoryObject
    {
        public static int SizeOf => SymbolTable.Current.Scene.SizeOf;

        public int ID => Read<int>(0x00);

        public int SSceneID => this.PlatformRead<int>(0x04, 0x08); // 64-bit: struct alignment

        public int SWorldID => this.PlatformRead<int>(0x08, 0x0C);

        public SNO LevelAreaSNO => this.PlatformRead<SNO>(0x18, 0x1C);

        public SNO SceneSNO => this.PlatformRead<SNO>(0xE8, 0xEC);
    }
}
