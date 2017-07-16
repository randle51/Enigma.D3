using Enigma.D3.MemoryModel.Collections;
using Enigma.D3.MemoryModel.Controls;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Core
{
    public class UIManager : MemoryObject
    {
        public static int SizeOf => SymbolTable.Current.UIManager.SizeOf;

        public Ptr<MapA<UIKey, Ptr<Control>>> PtrControlsMap
            => Read<Ptr<MapA<UIKey, Ptr<Control>>>>(0x0);

        public int TargetACDID => this.PlatformRead<int>(0x0E50, 0x0E60);
    }
}
