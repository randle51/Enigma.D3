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

        public int SSceneID => Read<int>(0x04);

        public int SWorldID => Read<int>(0x08);

        public SNO LevelAreaSNO => Read<SNO>(0x18);

        public SNO SceneSNO => Read<SNO>(0xE8);
	}
}
