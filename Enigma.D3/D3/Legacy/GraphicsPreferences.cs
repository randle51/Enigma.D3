using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class GraphicsPreferences : MemoryObject
	{
		public const int SizeOf = 0x94; // 1.0.8.16603 : [008FFA20]

		public GraphicsPreferences(ProcessMemory memory, int address)
			: base(memory, address) { }

		// See field names at [0x014777A0] (1.0.8.16603).
		public bool x00_VSync { get { return Field<bool>(0x00); } }
		public int x04_TextureQuality { get { return Field<int>(0x04); } }
		public int x08_ShadowQuality { get { return Field<int>(0x08); } }
		public DisplayMode x0C_DisplayMode { get { return Field<DisplayMode>(0x0C); } }
		public float x3C_Gamma { get { return Field<float>(0x3C); } }
		public int x40_ClutterDensity { get { return Field<int>(0x40); } }
		public int x44_PhysicsQuality { get { return Field<int>(0x44); } }
		public bool x48_Letterbox { get { return Field<bool>(0x48); } }
		public bool x4C_Antialiasing { get { return Field<bool>(0x4C); } }
		public bool x50_LowFX { get { return Field<bool>(0x50); } }
		public bool x54_LockCursorInFullscreenWindowed { get { return Field<bool>(0x54); } }
		public bool x58_LimitForegroundFps { get { return Field<bool>(0x58); } }
		public int x5C_MaxForegroundFps { get { return Field<int>(0x5C); } }
		public bool x60_LimitBackgroundFps { get { return Field<bool>(0x60); } }
		public int x64_MaxBackgroundFps { get { return Field<int>(0x64); } }
		public bool x68_DisableTrilinearFiltering { get { return Field<bool>(0x68); } }
		public bool x6C_ColorCorrection { get { return Field<bool>(0x6C); } }
		public int x70_MipBias { get { return Field<int>(0x70); } }
		public int x74_ReflectionQuality { get { return Field<int>(0x74); } }
		public int _x78_TonemapExposure { get { return Field<int>(0x78); } }
		public int _x7C_TonemapContrast { get { return Field<int>(0x7C); } }
		public int _x80_TonemapSaturation { get { return Field<int>(0x80); } }
		public int _x84_TonemapGain { get { return Field<int>(0x84); } }
		public int x88_HardwareClass { get { return Field<int>(0x88); } }
		public int x8C_PciVendor { get { return Field<int>(0x8C); } }
		public int x90_PciDevice { get { return Field<int>(0x90); } }
	}
}
