using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.D3.MemoryModel.Collections;

namespace Enigma.D3.MemoryModel.Core
{
    public class ACDManager : MemoryObject
    {
        public static int SizeOf => SymbolTable.Current.ACDManager.SizeOf;

        public Container<ACD> ActorCommonData
            => Read<Ptr<ExpandableContainer<ACD>>>(SymbolTable.Current.ACDManager.ActorCommonData).Dereference();
    }
}
