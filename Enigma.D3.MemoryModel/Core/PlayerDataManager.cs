using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Enigma.D3.MemoryModel.Core
{
    public class PlayerDataManager : MemoryObject, IEnumerable<PlayerData>
    {
        public PlayerData this[int index]
            => new Ptr<PlayerData>(Memory, Address + SymbolTable.Current.PlayerDataManager.Items)[index];

        public int Count => 8;

        public IEnumerator<PlayerData> GetEnumerator()
        {
            for (int i = 0; i < 8; i++)
                yield return this[i];
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
