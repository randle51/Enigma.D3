using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class Power : SerializeMemoryObject
	{
		public const int SizeOf = 0x460; // 1120
		
		public SNOHeader x000_Header { get { return Read<SNOHeader>(0x000); } }
		public string x00C_Text { get { return ReadString(0x00C, 64); } }
		public PowerDef x050_PowerDef { get { return Read<PowerDef>(0x050); } }
		public int x328 { get { return Read<int>(0x328); } }
		public int x32C { get { return Read<int>(0x32C); } }
		public string x330_Text { get { return ReadString(0x330, 256); } }
		public SerializeData x430_SerializeData { get { return Read<SerializeData>(0x430); } }
		public ScriptFormulaDetails[] x438_ScriptFormulaDetails { get { return Deserialize<ScriptFormulaDetails>(x430_SerializeData); } }
		public int x440 { get { return Read<int>(0x440); } }
		public byte[] x448_byte { get { return Deserialize<byte>(x450_SerializeData); } }
		public SerializeData x450_SerializeData { get { return Read<SerializeData>(0x450); } }
		public SNO x458_QuestSNO { get { return Read<SNO>(0x458); } }
		
		[CompilerGenerated]
		public partial class PowerDef : SerializeMemoryObject
		{
			public const int SizeOf = 0x2D8; // 728
			
			public SerializeData x000_SerializeData { get { return Read<SerializeData>(0x000); } }
			public TagMap x008_TagMap { get { return new TagMap(Deserialize<byte>(x000_SerializeData)); } } // type: 0x00040000
			public SerializeData x010_SerializeData { get { return Read<SerializeData>(0x010); } }
			public TagMap x018_TagMap { get { return new TagMap(Deserialize<byte>(x010_SerializeData)); } } // type: 0x00130000
			public SerializeData x020_SerializeData { get { return Read<SerializeData>(0x020); } }
			public TagMap x028_TagMap { get { return new TagMap(Deserialize<byte>(x020_SerializeData)); } } // type: 0x00130000
			public SerializeData x030_SerializeData { get { return Read<SerializeData>(0x030); } }
			public SerializeData x038_SerializeData { get { return Read<SerializeData>(0x038); } }
			public SerializeData x040_SerializeData { get { return Read<SerializeData>(0x040); } }
			public SerializeData x048_SerializeData { get { return Read<SerializeData>(0x048); } }
			public TagMap x050_TagMap { get { return new TagMap(Deserialize<byte>(x030_SerializeData)); } } // type: 0x00020000
			public TagMap x058_TagMap { get { return new TagMap(Deserialize<byte>(x038_SerializeData)); } } // type: 0x00020000
			public TagMap x060_TagMap { get { return new TagMap(Deserialize<byte>(x040_SerializeData)); } } // type: 0x00020000
			public TagMap x068_TagMap { get { return new TagMap(Deserialize<byte>(x048_SerializeData)); } } // type: 0x00020000
			public SerializeData x070_SerializeData { get { return Read<SerializeData>(0x070); } }
			public SerializeData x078_SerializeData { get { return Read<SerializeData>(0x078); } }
			public SerializeData x080_SerializeData { get { return Read<SerializeData>(0x080); } }
			public SerializeData x088_SerializeData { get { return Read<SerializeData>(0x088); } }
			public TagMap x090_TagMap { get { return new TagMap(Deserialize<byte>(x070_SerializeData)); } } // type: 0x00020000
			public TagMap x098_TagMap { get { return new TagMap(Deserialize<byte>(x078_SerializeData)); } } // type: 0x00020000
			public TagMap x0A0_TagMap { get { return new TagMap(Deserialize<byte>(x080_SerializeData)); } } // type: 0x00020000
			public TagMap x0A8_TagMap { get { return new TagMap(Deserialize<byte>(x088_SerializeData)); } } // type: 0x00020000
			public int x0B0 { get { return Read<int>(0x0B0); } }
			public ActorCollisionFlags x0B4_ActorCollisionFlags { get { return Read<ActorCollisionFlags>(0x0B4); } }
			public ActorCollisionFlags x0C4_ActorCollisionFlags { get { return Read<ActorCollisionFlags>(0x0C4); } }
			public BuffDef[] x0D8_BuffDefs { get { return Read<BuffDef>(0x0D8, 32); } }
		}
		
		[CompilerGenerated]
		public partial class ScriptFormulaDetails : MemoryObject
		{
			public const int SizeOf = 0x308; // 776
			
			public string x000_Text { get { return ReadString(0x000, 256); } }
			public string x100_Text { get { return ReadString(0x100, 512); } }
			public int x300 { get { return Read<int>(0x300); } }
			public int x304 { get { return Read<int>(0x304); } }
		}
		
		[CompilerGenerated]
		public partial class ActorCollisionFlags : MemoryObject
		{
			public const int SizeOf = 0x10; // 16
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class BuffDef : SerializeMemoryObject
		{
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Read<SerializeData>(0x00); } }
			public BuffFilterDef[] x08_BuffFilterDefs { get { return Deserialize<BuffFilterDef>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class BuffFilterDef : MemoryObject
		{
			public const int SizeOf = 0x08; // 8
			
			public SNO x00_PowerSNO { get { return Read<SNO>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
		}
	}
}
