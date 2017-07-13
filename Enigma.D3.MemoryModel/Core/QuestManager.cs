using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Core
{
    public class QuestManager : MemoryObject
    {
        public IReadOnlyCollection<Quest> Quests
            => Read<Collections.LinkedList<Quest>>(SymbolTable.Current.QuestManager.Quests);
    }
}
