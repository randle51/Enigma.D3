using Enigma.D3.MemoryModel.Core;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Controls
{
    public class Control : MemoryObject
    {
        public UIID UIID => this.PlatformRead<UIID>(0x20, 0x30);
        public UIID ParentUUID => this.PlatformRead<UIID>(0x228, 0x238);
    }
}
