using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.Memory.Input
{
	public struct Hotkey
	{
		public KeyGesture PrimaryGesture;
		public KeyGesture SecondaryGesture;

		public override string ToString()
		{
			return PrimaryGesture + "   " + SecondaryGesture;
		}

		public static Hotkey Get(HotkeyIndex index)
		{
			if ((int)index >= 70)
				throw new ArgumentOutOfRangeException("index");
			return Engine.Current.Hotkeys[(int)index];
		}
	}
}
