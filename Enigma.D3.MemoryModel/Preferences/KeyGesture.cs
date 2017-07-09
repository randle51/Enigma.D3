using Enigma.D3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Preferences
{
    public struct KeyGesture
    {
        public static readonly KeyGesture None = new KeyGesture { Key = Key.Undefined, Modifiers = ModifierKeys.None };

        public Key Key;
        public ModifierKeys Modifiers;

        public override string ToString()
        {
            var sb = new StringBuilder();
            if (Modifiers != ModifierKeys.None)
                sb.Append(Modifiers.ToString().Replace(", ", "+")).Append("+");
            sb.Append(Key == Key.Undefined ? "Not Set" : Key.ToString());
            return sb.ToString();
        }
    }
}
