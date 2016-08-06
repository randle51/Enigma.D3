using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class BossEncounter : MemoryObject
	{
		public const int SizeOf = 0x68; // 104
		
		public SNOHeader x00_Header { get { return Read<SNOHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public int x10 { get { return Read<int>(0x10); } }
		public int x14 { get { return Read<int>(0x14); } }
		public int x18 { get { return Read<int>(0x18); } }
		public int x1C { get { return Read<int>(0x1C); } }
		public int x20 { get { return Read<int>(0x20); } }
		public int x24 { get { return Read<int>(0x24); } }
		public int x28 { get { return Read<int>(0x28); } }
		public int x2C { get { return Read<int>(0x2C); } }
		public int x30 { get { return Read<int>(0x30); } }
		public int x34 { get { return Read<int>(0x34); } }
		public int x38 { get { return Read<int>(0x38); } }
		public float x3C { get { return Read<float>(0x3C); } }
		public SNO x40_QuestRangeSNO { get { return Read<SNO>(0x40); } }
		public SNO[] x44_SNOs { get { return Read<SNO>(0x44, 4); } }
		public SNO[] x54_SNOs { get { return Read<SNO>(0x54, 3); } }
		public SNO x60_LevelAreaSNO { get { return Read<SNO>(0x60); } }
		public SNO x64_ActorSNO { get { return Read<SNO>(0x64); } }
	}
}
