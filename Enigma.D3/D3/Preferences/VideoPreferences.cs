using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Graphics;

namespace Enigma.D3.Preferences
{
	public class VideoPreferences : MemoryObject
	{
		// 2.0.0.20874
		public const int SizeOf = 0x8C; // = 140

		public VideoPreferences(MemoryBase memory, int address)
			: base(memory, address) { }

		public int x00_Vsync { get { return Field<int>(0x00); } }  // default = 0, min = 0, max = 1
		public int x04_MipOffset { get { return Field<int>(0x04); } }  // default = 0
		public int x08_ShadowQuality { get { return Field<int>(0x08); } }  // default = 2, min = 0, max = 6
		public DisplayMode x0C_DisplayMode { get { return Field<DisplayMode>(0x0C); } }
		//public int x0C_DisplayModeFlags { get { return Field<int>(0x0C); } }  // default = 10
		//public int x10_DisplayModeWindowMode { get { return Field<int>(0x10); } }  // default = 0, min = 0, max = 2
		//public int x14_DisplayModeWinLeft { get { return Field<int>(0x14); } }  // default = 0
		//public int x18_DisplayModeWinTop { get { return Field<int>(0x18); } }  // default = 0
		//public int x1C_DisplayModeWinWidth { get { return Field<int>(0x1C); } }  // default = 1024
		//public int x20_DisplayModeWinHeight { get { return Field<int>(0x20); } }  // default = 768
		//public int x24_DisplayModeUIOptWidth { get { return Field<int>(0x24); } }  // default = 1024
		//public int x28_DisplayModeUIOptHeight { get { return Field<int>(0x28); } }  // default = 768
		//public int x2C_DisplayModeWidth { get { return Field<int>(0x2C); } }  // default = 1024
		//public int x30_DisplayModeHeight { get { return Field<int>(0x30); } }  // default = 768
		//public int x34_DisplayModeRefreshRate { get { return Field<int>(0x34); } }  // default = -1
		//public int x38_DisplayModeBitDepth { get { return Field<int>(0x38); } }  // default = 32
		public float x3C_Gamma { get { return Field<float>(0x3C); } }  // default = 1, min = 0.5, max = 1.5
		public int x40_ClutterQuality { get { return Field<int>(0x40); } }  // default = 2, min = 0, max = 3
		public int x44_PhysicsQuality { get { return Field<int>(0x44); } }  // default = 1, min = 0, max = 1
		public int x48_ShadowDetail { get { return Field<int>(0x48); } }  // default = 0, min = 0, max = 1
		public int x4C_Letterbox { get { return Field<int>(0x4C); } }  // default = 0, min = 0, max = 1
		public int x50_Antialiasing { get { return Field<int>(0x50); } }  // default = 1, min = 0, max = 1
		public int x54_LowFX { get { return Field<int>(0x54); } }  // default = 0, min = 0, max = 1
		public int x58_LockCursorInFullscreenWindowed { get { return Field<int>(0x58); } }  // default = 0, min = 0, max = 1
		public int x5C_LimitForegroundFPS { get { return Field<int>(0x5C); } }  // default = 1, min = 0, max = 1
		public int x60_MaxForegroundFPS { get { return Field<int>(0x60); } }  // default = 150, min = 1, max = 200
		public int x64_LimitBackgroundFPS { get { return Field<int>(0x64); } }  // default = 1, min = 0, max = 1
		public int x68_MaxBackgroundFPS { get { return Field<int>(0x68); } }  // default = 8, min = 1, max = 200
		public int x6C_DisableTrilinearFiltering { get { return Field<int>(0x6C); } }  // default = 0, min = 0, max = 1
		public int x70_ColorCorrection { get { return Field<int>(0x70); } }  // default = 1, min = 0, max = 1
		public float x74_MipBias { get { return Field<float>(0x74); } }  // default = 0, min = -10, max = 10
		public int x78_ReflectionQuality { get { return Field<int>(0x78); } }  // default = 0, min = 0, max = 1
		public int x7C_HardwareClass { get { return Field<int>(0x7C); } }  // default = 4, min = 0, max = 6
		public int x80_PCIVendor { get { return Field<int>(0x80); } }  // default = 0
		public int x84_PCIDevice { get { return Field<int>(0x84); } }  // default = 0
		public float x88_flSafeZoneLeft { get { return Field<float>(0x88); } }  // default = 0
	}
}
