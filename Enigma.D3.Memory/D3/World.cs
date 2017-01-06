using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;

namespace Enigma.D3
{
	public partial class World : MemoryObject
	{
		// 2.0.0.21962
		public const int SizeOf = 0x64; // 100

		public int x00_SWorldId { get { return Read<int>(0x00); } }
		// Struct.Start - Max.Relative = 0x3C
		public int x04_SnoId { get { return Read<int>(0x04); } }
		public int _x08 { get { return Read<int>(0x08); } }
		public int x0C_Id { get { return Read<int>(0x0C); } }
		public int _x10_Ptr_Min24Bytes { get { return Read<int>(0x10); } }
		public int _x14 { get { return Read<int>(0x14); } }
		public int _x18 { get { return Read<int>(0x18); } }
		public int _x1C { get { return Read<int>(0x1C); } }
		public int _x20 { get { return Read<int>(0x20); } }
		public int _x24 { get { return Read<int>(0x24); } }
		public int _x28 { get { return Read<int>(0x28); } }
		public int _x2C { get { return Read<int>(0x2C); } }
		public int _x30 { get { return Read<int>(0x30); } }
		public int _x34 { get { return Read<int>(0x34); } }
		public int _x38 { get { return Read<int>(0x38); } }
		public int x3C_LastRegisteredTick { get { return Read<int>(0x3C); } }
		public int _x40 { get { return Read<int>(0x40); } }
		public int _x44 { get { return Read<int>(0x44); } }
		public int _x48 { get { return Read<int>(0x48); } }
		public int _x4C { get { return Read<int>(0x4C); } }
		public int _x50 { get { return Read<int>(0x50); } }
		public float _x54 { get { return Read<float>(0x54); } }
		public int _x58 { get { return Read<int>(0x58); } }
		public int _x5C { get { return Read<int>(0x5C); } }
		public int _x60 { get { return Read<int>(0x60); } }
	}

	public partial class World
	{
		public static World Local { get { return Enigma.D3.Helpers.WorldHelper.GetLocalWorld(); } }

		public static Container<World> Container { get { return ObjectManager.Instance.IfNotNull(a => a.xA04_CWorlds.Dereference()); } }
	}
}
