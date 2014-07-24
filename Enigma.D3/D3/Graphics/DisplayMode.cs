using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Graphics
{
	public class DisplayMode : MemoryObject
	{
		// 2.0.0.20874
		public const int SizeOf = 0x30;

		public DisplayMode(MemoryBase memory, int address)
			: base(memory, address) { }

		public DisplayModeFlags x00_Flags { get { return (DisplayModeFlags)Field<int>(0x00); } }
		public WindowMode x04_WindowMode { get { return (WindowMode)Field<int>(0x04); } }
		public int x08_WinLeft { get { return Field<int>(0x08); } }
		public int x0C_WinTop { get { return Field<int>(0x0C); } }
		public int x10_WinWidth { get { return Field<int>(0x10); } }
		public int x14_WinHeight { get { return Field<int>(0x14); } }
		public int x18_UIOptWidth { get { return Field<int>(0x18); } }
		public int x1C_UIOptHeight { get { return Field<int>(0x1C); } }
		public int x20_Width { get { return Field<int>(0x20); } }
		public int x24_Height { get { return Field<int>(0x24); } }
		public int x28_RefreshRate { get { return Field<int>(0x28); } }
		public int x2C_BitDepth { get { return Field<int>(0x2C); } }
	}
}
