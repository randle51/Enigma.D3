using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Core
{
    public class Player : MemoryObject
    {
        public static int SizeOf => SymbolTable.Current.Player.SizeOf;

        public int LocalPlayerIndex
            => Read<int>(SymbolTable.Current.Player.LocalPlayerIndex);

        public IReadOnlyList<int> LatencySamples
            => Read<Collections.CircularBuffer<int>>(SymbolTable.Current.Player.LatencySamples);

        public IReadOnlyCollection<FloatingNumber> FloatingNumbers
            => Read<Collections.LinkedListWithAllocator<FloatingNumber>>(SymbolTable.Current.Player.FloatingNumbers);
    }
}
