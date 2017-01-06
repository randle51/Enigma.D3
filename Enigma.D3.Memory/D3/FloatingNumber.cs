using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3
{
	public partial class FloatingNumber : MemoryObject
	{
		public const int SizeOf = 0x50; // 80

		public int x00_Neg1 { get { return Read<int>(0x00); } }
		public WorldPosition x04_WorldPos { get { return Read<WorldPosition>(0x04); } }
		public RefString x14_RefString { get { return Read<RefString>(0x14); } }
		public float x20 { get { return Read<float>(0x20); } }
		public float x24 { get { return Read<float>(0x24); } }
		public float x28 { get { return Read<float>(0x28); } }
		public int x2C_Tick { get { return Read<int>(0x2C); } }
		public int x30_StartTick { get { return Read<int>(0x30); } }
		public int x34_Neg1 { get { return Read<int>(0x34); } }
		public float x38_1f { get { return Read<float>(0x38); } }
		public float x3C_1f { get { return Read<float>(0x3C); } }
		public int x40 { get { return Read<int>(0x40); } }
		public int x44_ActorId { get { return Read<int>(0x44); } }
		public int x48_Type { get { return Read<int>(0x48); } }
		public float x4C_Value { get { return Read<float>(0x4C); } }
	}

	public partial class FloatingNumber
	{
		public static IEnumerable<FloatingNumber> EnumerateAll(Engine engine = null)
		{
			return (engine ?? Engine.Current).ObjectManager.xA0C_Player.Dereference().xA018_FloatingNumbers;
		}

		public static IList<FloatingNumber> GetList(Engine engine = null)
		{
			return EnumerateAll(engine).ToList();
		}
	}
}
