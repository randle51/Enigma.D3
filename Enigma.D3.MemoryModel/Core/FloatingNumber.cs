using Enigma.D3.DataTypes;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Core
{
    public class FloatingNumber : MemoryObject
    {
        public static int SizeOf = SymbolTable.Current.FloatingNumber.SizeOf;

        public Vector3 WorldPos
            => Read<Vector3>(SymbolTable.Current.FloatingNumber.WorldPos);

        public int SWorldID
            => Read<SNO>(SymbolTable.Current.FloatingNumber.SWorldID);

        // TODO: 0x18 RefString (64-bit)

        public int Type
            => Read<int>(SymbolTable.Current.FloatingNumber.Type);

        public float Value
            => Read<float>(SymbolTable.Current.FloatingNumber.Value);
    }
}
