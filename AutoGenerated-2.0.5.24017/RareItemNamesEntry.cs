public class RareItemNamesEntry : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x118; // 280

	public RareItemNamesEntry(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 256); } }
	public int x100 { get { return Field<int>(0x100); } }
	public int x104 { get { return Field<int>(0x104); } }
	public int x108_Enum { get { return Field<int>(0x108); } } // 1: Item Types, 2: Items, 3: Experience Table, 24: Help Codes, 5: Monster Levels, 7: Heros, 8: Affix List, 10: Movement Styles, 11: Labels, 12: Loot Distribution, 16: Rare Item Names, 18: Monster Affixes, 19: Monster Names, 21: Socketed Effects, 23: Item Enchantments, 25: Item Drop Table, 26: Item Level Modifiers, 27: Quality Classes, 28: Handicaps, 29: Item Salvage Levels, 17: Scenery, 4: Hirelings, 33: Set Item Bonuses, 34: Elite Modifiers, 35: Item Tiers, 36: Power Formula Tables, 32: Recipes, 37: Scripted Achievement Events, 38: Item Durability Cost Scalars, 39: LootRun Quest Tiers, 40: Paragon Bonuses, 42: Made To Order Types, 43: Made To Order Affix Folders, 44: Devil's Hand Redeemable Sets, 45: Legacy Item Conversions, 46: Enchant Item Affix Use Count Cost Scalars
	public DT_GBID x10C_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x10C); } }
	public int x110_Enum { get { return Field<int>(0x110); } } // 0: Prefix, 1: Suffix, 2: Inherent, 5: Title, 6: Quality, 7: Immunity, 9: Random, 10: Enchantment, 11: Socket Enhancement
	public int x114 { get { return Field<int>(0x114); } }
}
