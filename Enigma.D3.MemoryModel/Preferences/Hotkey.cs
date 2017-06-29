using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Preferences
{
    public struct Hotkey
    {
        public KeyGesture PrimaryGesture;
        public KeyGesture SecondaryGesture;

        public override string ToString()
        {
            return PrimaryGesture + "   " + SecondaryGesture;
        }
    }
}
