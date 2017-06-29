using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.Enums
{
    [Flags]
    public enum ModifierKeys
    {
        None = 0,
        Alt = 1,
        Ctrl = 2,
        Shift = 4
    }
}
