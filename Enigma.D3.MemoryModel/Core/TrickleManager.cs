using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Core
{
    public class TrickleManager : MemoryObject
    {
        public static int SizeOf => SymbolTable.Current.TrickleManager.SizeOf;

        public IReadOnlyCollection<Trickle> Items
            => Read<Ptr<Collections.LinkedListB<Trickle>>>(SymbolTable.Current.TrickleManager.Items).Dereference();
    }
}
