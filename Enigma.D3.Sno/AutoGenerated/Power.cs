using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Power : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x460; // 1120
		
		public string x00C_Text { get { return Field(0x00C, 64); } }
		public PowerDef x050_PowerDef { get { return Field<PowerDef>(0x050); } }
		public int x328 { get { return Field<int>(0x328); } }
		public int x32C { get { return Field<int>(0x32C); } }
		public string x330_Text { get { return Field(0x330, 256); } }
		public SerializeData x430_SerializeData { get { return Field<SerializeData>(0x430); } }
		public ScriptFormulaDetails[] x438_ScriptFormulaDetails { get { return Deserialize<ScriptFormulaDetails>(x430_SerializeData); } }
		public int x440 { get { return Field<int>(0x440); } }
		public byte[] x448_byte { get { return Deserialize<byte>(x450_SerializeData); } }
		public SerializeData x450_SerializeData { get { return Field<SerializeData>(0x450); } }
		public Sno x458_QuestSno { get { return Field<Sno>(0x458); } }
		
		[CompilerGenerated]
		public partial class PowerDef : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x2D8; // 728
			
			public SerializeData x000_SerializeData { get { return Field<SerializeData>(0x000); } }
			public int[] x008_TagMap { get { return Deserialize<int>(x000_SerializeData); } }
			public SerializeData x010_SerializeData { get { return Field<SerializeData>(0x010); } }
			public int[] x018_TagMap { get { return Deserialize<int>(x010_SerializeData); } }
			public SerializeData x020_SerializeData { get { return Field<SerializeData>(0x020); } }
			public int[] x028_TagMap { get { return Deserialize<int>(x020_SerializeData); } }
			public SerializeData x030_SerializeData { get { return Field<SerializeData>(0x030); } }
			public SerializeData x038_SerializeData { get { return Field<SerializeData>(0x038); } }
			public SerializeData x040_SerializeData { get { return Field<SerializeData>(0x040); } }
			public SerializeData x048_SerializeData { get { return Field<SerializeData>(0x048); } }
			public int[] x050_TagMap { get { return Deserialize<int>(x030_SerializeData); } }
			public int[] x058_TagMap { get { return Deserialize<int>(x038_SerializeData); } }
			public int[] x060_TagMap { get { return Deserialize<int>(x040_SerializeData); } }
			public int[] x068_TagMap { get { return Deserialize<int>(x048_SerializeData); } }
			public SerializeData x070_SerializeData { get { return Field<SerializeData>(0x070); } }
			public SerializeData x078_SerializeData { get { return Field<SerializeData>(0x078); } }
			public SerializeData x080_SerializeData { get { return Field<SerializeData>(0x080); } }
			public SerializeData x088_SerializeData { get { return Field<SerializeData>(0x088); } }
			public int[] x090_TagMap { get { return Deserialize<int>(x070_SerializeData); } }
			public int[] x098_TagMap { get { return Deserialize<int>(x078_SerializeData); } }
			public int[] x0A0_TagMap { get { return Deserialize<int>(x080_SerializeData); } }
			public int[] x0A8_TagMap { get { return Deserialize<int>(x088_SerializeData); } }
			public int x0B0 { get { return Field<int>(0x0B0); } }
			public ActorCollisionFlags x0B4_ActorCollisionFlags { get { return Field<ActorCollisionFlags>(0x0B4); } }
			public ActorCollisionFlags x0C4_ActorCollisionFlags { get { return Field<ActorCollisionFlags>(0x0C4); } }
			public BuffDef[] x0D8_BuffDefs { get { return Field<BuffDef>(0x0D8, 32); } }
		}
		
		[CompilerGenerated]
		public partial class ScriptFormulaDetails : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x308; // 776
			
			public string x000_Text { get { return Field(0x000, 256); } }
			public string x100_Text { get { return Field(0x100, 512); } }
			public int x300 { get { return Field<int>(0x300); } }
			public int x304 { get { return Field<int>(0x304); } }
		}
		
		[CompilerGenerated]
		public partial class ActorCollisionFlags : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public int x00 { get { return Field<int>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
			public int x08 { get { return Field<int>(0x08); } }
			public int x0C { get { return Field<int>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class BuffDef : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x10; // 16
			
			public SerializeData x00_SerializeData { get { return Field<SerializeData>(0x00); } }
			public BuffFilterDef[] x08_BuffFilterDefs { get { return Deserialize<BuffFilterDef>(x00_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class BuffFilterDef : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x8; // 8
			
			public Sno x00_PowerSno { get { return Field<Sno>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
		}
	}
}
