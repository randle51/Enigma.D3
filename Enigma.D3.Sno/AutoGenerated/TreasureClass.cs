using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class TreasureClass : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x28; // 40
		
		public HighPrecisionPercent x0C_HighPrecisionPercent { get { return Field<HighPrecisionPercent>(0x0C); } }
		public int x10 { get { return Field<int>(0x10); } }
		public int x14 { get { return Field<int>(0x14); } }
		public LootDropModifier[] x18_LootDropModifiers { get { return Deserialize<LootDropModifier>(x20_SerializeData); } }
		public SerializeData x20_SerializeData { get { return Field<SerializeData>(0x20); } }
		
		[CompilerGenerated]
		public partial class LootDropModifier : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x78; // 120
			
			public int x00 { get { return Field<int>(0x00); } }
			public Sno x04_TreasureClassSno { get { return Field<Sno>(0x04); } }
			public HighPrecisionPercent x08_HighPrecisionPercent { get { return Field<HighPrecisionPercent>(0x08); } }
			public int x0C { get { return Field<int>(0x0C); } }
			public GameBalanceId x10_QualityClassesGameBalanceId { get { return Field<GameBalanceId>(0x10); } }
			public int x14 { get { return Field<int>(0x14); } }
			public int x18 { get { return Field<int>(0x18); } }
			public Sno x1C_ConditionSno { get { return Field<Sno>(0x1C); } }
			public ItemSpecifierData x20_ItemSpecifierData { get { return Field<ItemSpecifierData>(0x20); } }
			public int x58 { get { return Field<int>(0x58); } }
			public int x5C { get { return Field<int>(0x5C); } }
			public int[] x60_int { get { return Field<int>(0x60, 4); } }
			public int x70 { get { return Field<int>(0x70); } }
			public int x74 { get { return Field<int>(0x74); } }
		}
		
		[CompilerGenerated]
		public partial class ItemSpecifierData : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x38; // 56
			
			public GameBalanceId x00_ItemsGameBalanceId { get { return Field<GameBalanceId>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
			public GameBalanceId[] x08_GameBalanceIds { get { return Field<GameBalanceId>(0x08, 6); } }
			public int x20 { get { return Field<int>(0x20); } }
			public int x24 { get { return Field<int>(0x24); } }
			public int x28 { get { return Field<int>(0x28); } }
			public int x2C { get { return Field<int>(0x2C); } }
			public int x30 { get { return Field<int>(0x30); } }
			public int x34 { get { return Field<int>(0x34); } }
		}
	}
}
