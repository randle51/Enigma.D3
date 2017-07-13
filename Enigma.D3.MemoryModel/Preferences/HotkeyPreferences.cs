using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Preferences
{
    public class HotkeyPreferences : MemoryObject
    {
        public static int SizeOf => 70 * TypeHelper<Hotkey>.SizeOf;

        public Hotkey[] Hotkeys => Read<Hotkey>(0x00, 70);
    }
}
