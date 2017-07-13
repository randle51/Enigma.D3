using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Core
{
    public class Waypoint : MemoryObject
    {
        public static int SizeOf => SymbolTable.Current.Waypoint.SizeOf;

        public int ActID => Read<int>(SymbolTable.Current.Waypoint.ActID);
        public int LevelAreaSNO => Read<int>(SymbolTable.Current.Waypoint.LevelAreaSNO);
        public int X => Read<int>(SymbolTable.Current.Waypoint.X);
        public int Y => Read<int>(SymbolTable.Current.Waypoint.Y);
    }
}
