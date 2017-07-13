using Enigma.D3.DataTypes;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Core
{
    public class PlayerSavedData : MemoryObject
    {
        public static int SizeOf => SymbolTable.Current.PlayerSavedData.SizeOf;

        public HotbarButtonData[] x0000_HotbarButtonData { get { return Read<HotbarButtonData>(0x0000, 6); } }
        public HotbarButtonData x0060_HotbarButtonData { get { return Read<HotbarButtonData>(0x0060); } }

        public ActiveSkillSavedData[] ActiveSkillSavedData => Read<ActiveSkillSavedData>(SymbolTable.Current.PlayerSavedData.ActiveSkillSavedData, 6);
        public SNO[] PassiveSkills => Read<SNO>(SymbolTable.Current.PlayerSavedData.PassiveSkills, 4);
    }

    public class HotbarButtonData : MemoryObject
    {
        public const int SizeOf = 0x10;

        public SNO PowerSNO { get { return Read<SNO>(0x00); } }
        public int Modifier { get { return Read<int>(0x04); } }
        public int ItemsGBID { get { return Read<int>(0x08); } }
        public int x0C { get { return Read<int>(0x0C); } }
    }
}
