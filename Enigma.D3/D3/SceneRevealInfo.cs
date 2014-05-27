using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3
{
	public class SceneRevealInfo : MemoryObject
	{
		// 2.0.1.22044
		public const int SizeOf = 0x3C; // 60

		public SceneRevealInfo(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x00_SceneSnoId { get { return Field<int>(0x00); } }
		public int x04_SceneId_ { get { return Field<int>(0x04); } }
		public int x08_WorldId_ { get { return Field<int>(0x08); } }
		public int x0C_TextureSnoId { get { return Field<int>(0x0C); } }
		public float x10_MinX { get { return Field<float>(0x10); } }
		public float x14_MinY { get { return Field<float>(0x14); } }
		public float x18_MaxX { get { return Field<float>(0x18); } }
		public float x1C_MaxY { get { return Field<float>(0x1C); } }
		public int x20_TextureSnoId_ { get { return Field<int>(0x20); } }
		public byte[] x24_OpacityMask { get { return Dereference<byte>(0x24, x28_OpacityMaskWidth * x2C_OpacityMaskHeight); } } // 8 bits-per-channel grayscale channel
		public int x28_OpacityMaskWidth { get { return Field<int>(0x28); } }
		public int x2C_OpacityMaskHeight { get { return Field<int>(0x2C); } }
		public int x30_FrameCounter { get { return Field<int>(0x30); } }
		public int x34_IsFullyVisible { get { return Field<int>(0x34); } }
		public int _x38 { get { return Field<int>(0x38); } }

		public byte[] GetPixelBuffer(ref byte[] buffer, out int width, out int height)
		{
			width = x28_OpacityMaskWidth;
			height = x2C_OpacityMaskHeight;
			int size = width * height;
			if (buffer.Length != size)
				Array.Resize(ref buffer, size);

			if (x34_IsFullyVisible == 1)
			{
				for (int i = 0; i < buffer.Length; i++)
					buffer[i] = 0xFF;
			}
			else
			{
				Memory.ReadBytes(Field<int>(0x24), buffer);
			}
			return buffer;
		}
	}
}
