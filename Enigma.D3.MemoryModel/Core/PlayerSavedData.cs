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

        public ActiveSkillSavedData[] ActiveSkillSavedData => Read<ActiveSkillSavedData>(SymbolTable.Current.PlayerSavedData.ActiveSkillSavedData, 6);
        public SNO[] PassiveSkills => Read<SNO>(SymbolTable.Current.PlayerSavedData.PassiveSkills, 4);
    }
}
