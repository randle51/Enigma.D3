using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.MemoryModel.Core
{
    public class ActiveSkillSavedData : MemoryObject
    {
        public static int SizeOf => SymbolTable.Current.ActiveSkillSavedData.SizeOf;

        public SNO PowerSNO => Read<SNO>(SymbolTable.Current.ActiveSkillSavedData.PowerSNO);
        public int Modifier => Read<int>(SymbolTable.Current.ActiveSkillSavedData.Modifier);
    }
}