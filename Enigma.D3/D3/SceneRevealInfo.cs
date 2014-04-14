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

		public int _x00 { get { return Field<int>(0x00); } }
		public int x04_SceneId_ { get { return Field<int>(0x04); } }
		public int x08_WorldId_ { get { return Field<int>(0x08); } }
		public int _x0C { get { return Field<int>(0x0C); } }
		public float x10_MinX { get { return Field<float>(0x10); } }
		public float x14_MinY { get { return Field<float>(0x14); } }
		public float x18_MaxX { get { return Field<float>(0x18); } }
		public float x1C_MaxY { get { return Field<float>(0x1C); } }
		public int x20_TextureSnoId_ { get { return Field<int>(0x20); } }
		public int _x24 { get { return Field<int>(0x24); } }
		public int _x28 { get { return Field<int>(0x28); } }
		public int _x2C { get { return Field<int>(0x2C); } }
		public int _x30 { get { return Field<int>(0x30); } }
		public int _x34 { get { return Field<int>(0x34); } }
		public int _x38 { get { return Field<int>(0x38); } }
	}
}
