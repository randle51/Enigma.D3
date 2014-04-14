using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	[Flags]
	public enum WindowMode : int
	{
		Fullscreen = 0,
		Windowed = 1,
		WindowedFullscreen = 2
	}
}
