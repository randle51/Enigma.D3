public class Item : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x740; // 1856

	public Item(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 256); } }
	public int x100 { get { return Field<int>(0x100); } }
	public int x104 { get { return Field<int>(0x104); } }
	public int x108_ActorSnoId { get { return Field<int>(0x108); } }
	public DT_GBID x10C_ItemTypesGameBalanceId { get { return Field<DT_GBID>(0x10C); } }
	public DT_FLAG x110_00 { get { return (Field<int>(0x110) >> 0) & 1; } }
	public DT_FLAG x110_01 { get { return (Field<int>(0x110) >> 1) & 1; } }
	public DT_FLAG x110_02 { get { return (Field<int>(0x110) >> 2) & 1; } }
	public DT_FLAG x110_03 { get { return (Field<int>(0x110) >> 3) & 1; } }
	public DT_FLAG x110_04 { get { return (Field<int>(0x110) >> 4) & 1; } }
	public DT_FLAG x110_05 { get { return (Field<int>(0x110) >> 5) & 1; } }
	public DT_FLAG x110_07 { get { return (Field<int>(0x110) >> 7) & 1; } }
	public DT_FLAG x110_06 { get { return (Field<int>(0x110) >> 6) & 1; } }
	public DT_FLAG x110_08 { get { return (Field<int>(0x110) >> 8) & 1; } }
	public DT_FLAG x110_09 { get { return (Field<int>(0x110) >> 9) & 1; } }
	public DT_FLAG x110_10 { get { return (Field<int>(0x110) >> 10) & 1; } }
	public DT_FLAG x110_11 { get { return (Field<int>(0x110) >> 11) & 1; } }
	public DT_FLAG x110_12 { get { return (Field<int>(0x110) >> 12) & 1; } }
	public DT_FLAG x110_13 { get { return (Field<int>(0x110) >> 13) & 1; } }
	public DT_FLAG x110_14 { get { return (Field<int>(0x110) >> 14) & 1; } }
	public DT_FLAG x110_15 { get { return (Field<int>(0x110) >> 15) & 1; } }
	public DT_FLAG x110_16 { get { return (Field<int>(0x110) >> 16) & 1; } }
	public DT_FLAG x110_17 { get { return (Field<int>(0x110) >> 17) & 1; } }
	public DT_FLAG x110_18 { get { return (Field<int>(0x110) >> 18) & 1; } }
	public DT_FLAG x110_19 { get { return (Field<int>(0x110) >> 19) & 1; } }
	public DT_FLAG x110_20 { get { return (Field<int>(0x110) >> 20) & 1; } }
	public DT_FLAG x110_21 { get { return (Field<int>(0x110) >> 21) & 1; } }
	public int x114 { get { return Field<int>(0x114); } }
	public int x118 { get { return Field<int>(0x118); } }
	public int x11C_Enum { get { return Field<int>(0x11C); } } // -1: Invalid, 0: A1, 100: A2, 200: A3, 300: A4, 400: A5, 3000: OpenWorld, 1000: Test
	public int x120 { get { return Field<int>(0x120); } }
	public int x124 { get { return Field<int>(0x124); } }
	public int x128 { get { return Field<int>(0x128); } }
	public int x12C { get { return Field<int>(0x12C); } }
	public int x130 { get { return Field<int>(0x130); } }
	public int x134 { get { return Field<int>(0x134); } }
	public int x138 { get { return Field<int>(0x138); } }
	public int x13C { get { return Field<int>(0x13C); } }
	public int x140 { get { return Field<int>(0x140); } }
	public int x144 { get { return Field<int>(0x144); } }
	public int x148 { get { return Field<int>(0x148); } }
	public int x14C { get { return Field<int>(0x14C); } }
	public int x150 { get { return Field<int>(0x150); } }
	public int x154 { get { return Field<int>(0x154); } }
	public int x158 { get { return Field<int>(0x158); } }
	public int x15C { get { return Field<int>(0x15C); } }
	public int x160 { get { return Field<int>(0x160); } }
	public int x164 { get { return Field<int>(0x164); } }
	public int x168 { get { return Field<int>(0x168); } }
	public int x16C { get { return Field<int>(0x16C); } }
	public DT_GBID x170_ItemsGameBalanceId { get { return Field<DT_GBID>(0x170); } }
	public DT_GBID x174_SetItemBonusesGameBalanceId { get { return Field<DT_GBID>(0x174); } }
	public int x178_TreasureClassSnoId { get { return Field<int>(0x178); } }
	public int x17C_TreasureClassSnoId { get { return Field<int>(0x17C); } }
	public int x180_TreasureClassSnoId { get { return Field<int>(0x180); } }
	public int x184_TreasureClassSnoId { get { return Field<int>(0x184); } }
	public int x188_StringListSnoId { get { return Field<int>(0x188); } }
	public int x18C_StringListSnoId { get { return Field<int>(0x18C); } }
	public int[] x190_Array { get { return Field<int>(0x190, 4); } }
	public float x1F8 { get { return Field<float>(0x1F8); } }
	public float x1FC { get { return Field<float>(0x1FC); } }
	public float x254 { get { return Field<float>(0x254); } }
	public float x258 { get { return Field<float>(0x258); } }
	public float x304 { get { return Field<float>(0x304); } }
	public float x35C { get { return Field<float>(0x35C); } }
	public float x360 { get { return Field<float>(0x360); } }
	public int x3E8_PowerSnoId { get { return Field<int>(0x3E8); } }
	public int x3EC { get { return Field<int>(0x3EC); } }
	public int x3F0_PowerSnoId { get { return Field<int>(0x3F0); } }
	public int x3F4 { get { return Field<int>(0x3F4); } }
	public int x3F8_PowerSnoId { get { return Field<int>(0x3F8); } }
	public int x3FC { get { return Field<int>(0x3FC); } }
	public int x400_PowerSnoId { get { return Field<int>(0x400); } }
	public int x404 { get { return Field<int>(0x404); } }
	public DT_TRANSLATEABLE x438 { get { return Field<DT_TRANSLATEABLE>(0x438); } }
	public DT_ATTRIBUTEPARAM x43C { get { return Field<DT_ATTRIBUTEPARAM>(0x43C); } }
	public DT_FORMULA x440 { get { return Field<DT_FORMULA>(0x440); } }
	public SerializeData x448 { get { return Field<SerializeData>(0x448); } }
	public DT_TRANSLATEABLE x450 { get { return Field<DT_TRANSLATEABLE>(0x450); } }
	public DT_ATTRIBUTEPARAM x454 { get { return Field<DT_ATTRIBUTEPARAM>(0x454); } }
	public DT_FORMULA x458 { get { return Field<DT_FORMULA>(0x458); } }
	public SerializeData x460 { get { return Field<SerializeData>(0x460); } }
	public DT_TRANSLATEABLE x468 { get { return Field<DT_TRANSLATEABLE>(0x468); } }
	public DT_ATTRIBUTEPARAM x46C { get { return Field<DT_ATTRIBUTEPARAM>(0x46C); } }
	public DT_FORMULA x470 { get { return Field<DT_FORMULA>(0x470); } }
	public SerializeData x478 { get { return Field<SerializeData>(0x478); } }
	public DT_TRANSLATEABLE x480 { get { return Field<DT_TRANSLATEABLE>(0x480); } }
	public DT_ATTRIBUTEPARAM x484 { get { return Field<DT_ATTRIBUTEPARAM>(0x484); } }
	public DT_FORMULA x488 { get { return Field<DT_FORMULA>(0x488); } }
	public SerializeData x490 { get { return Field<SerializeData>(0x490); } }
	public DT_TRANSLATEABLE x498 { get { return Field<DT_TRANSLATEABLE>(0x498); } }
	public DT_ATTRIBUTEPARAM x49C { get { return Field<DT_ATTRIBUTEPARAM>(0x49C); } }
	public DT_FORMULA x4A0 { get { return Field<DT_FORMULA>(0x4A0); } }
	public SerializeData x4A8 { get { return Field<SerializeData>(0x4A8); } }
	public DT_TRANSLATEABLE x4B0 { get { return Field<DT_TRANSLATEABLE>(0x4B0); } }
	public DT_ATTRIBUTEPARAM x4B4 { get { return Field<DT_ATTRIBUTEPARAM>(0x4B4); } }
	public DT_FORMULA x4B8 { get { return Field<DT_FORMULA>(0x4B8); } }
	public SerializeData x4C0 { get { return Field<SerializeData>(0x4C0); } }
	public DT_TRANSLATEABLE x4C8 { get { return Field<DT_TRANSLATEABLE>(0x4C8); } }
	public DT_ATTRIBUTEPARAM x4CC { get { return Field<DT_ATTRIBUTEPARAM>(0x4CC); } }
	public DT_FORMULA x4D0 { get { return Field<DT_FORMULA>(0x4D0); } }
	public SerializeData x4D8 { get { return Field<SerializeData>(0x4D8); } }
	public DT_TRANSLATEABLE x4E0 { get { return Field<DT_TRANSLATEABLE>(0x4E0); } }
	public DT_ATTRIBUTEPARAM x4E4 { get { return Field<DT_ATTRIBUTEPARAM>(0x4E4); } }
	public DT_FORMULA x4E8 { get { return Field<DT_FORMULA>(0x4E8); } }
	public SerializeData x4F0 { get { return Field<SerializeData>(0x4F0); } }
	public DT_TRANSLATEABLE x4F8 { get { return Field<DT_TRANSLATEABLE>(0x4F8); } }
	public DT_ATTRIBUTEPARAM x4FC { get { return Field<DT_ATTRIBUTEPARAM>(0x4FC); } }
	public DT_FORMULA x500 { get { return Field<DT_FORMULA>(0x500); } }
	public SerializeData x508 { get { return Field<SerializeData>(0x508); } }
	public DT_TRANSLATEABLE x510 { get { return Field<DT_TRANSLATEABLE>(0x510); } }
	public DT_ATTRIBUTEPARAM x514 { get { return Field<DT_ATTRIBUTEPARAM>(0x514); } }
	public DT_FORMULA x518 { get { return Field<DT_FORMULA>(0x518); } }
	public SerializeData x520 { get { return Field<SerializeData>(0x520); } }
	public DT_TRANSLATEABLE x528 { get { return Field<DT_TRANSLATEABLE>(0x528); } }
	public DT_ATTRIBUTEPARAM x52C { get { return Field<DT_ATTRIBUTEPARAM>(0x52C); } }
	public DT_FORMULA x530 { get { return Field<DT_FORMULA>(0x530); } }
	public SerializeData x538 { get { return Field<SerializeData>(0x538); } }
	public DT_TRANSLATEABLE x540 { get { return Field<DT_TRANSLATEABLE>(0x540); } }
	public DT_ATTRIBUTEPARAM x544 { get { return Field<DT_ATTRIBUTEPARAM>(0x544); } }
	public DT_FORMULA x548 { get { return Field<DT_FORMULA>(0x548); } }
	public SerializeData x550 { get { return Field<SerializeData>(0x550); } }
	public DT_TRANSLATEABLE x558 { get { return Field<DT_TRANSLATEABLE>(0x558); } }
	public DT_ATTRIBUTEPARAM x55C { get { return Field<DT_ATTRIBUTEPARAM>(0x55C); } }
	public DT_FORMULA x560 { get { return Field<DT_FORMULA>(0x560); } }
	public SerializeData x568 { get { return Field<SerializeData>(0x568); } }
	public DT_TRANSLATEABLE x570 { get { return Field<DT_TRANSLATEABLE>(0x570); } }
	public DT_ATTRIBUTEPARAM x574 { get { return Field<DT_ATTRIBUTEPARAM>(0x574); } }
	public DT_FORMULA x578 { get { return Field<DT_FORMULA>(0x578); } }
	public SerializeData x580 { get { return Field<SerializeData>(0x580); } }
	public DT_TRANSLATEABLE x588 { get { return Field<DT_TRANSLATEABLE>(0x588); } }
	public DT_ATTRIBUTEPARAM x58C { get { return Field<DT_ATTRIBUTEPARAM>(0x58C); } }
	public DT_FORMULA x590 { get { return Field<DT_FORMULA>(0x590); } }
	public SerializeData x598 { get { return Field<SerializeData>(0x598); } }
	public DT_TRANSLATEABLE x5A0 { get { return Field<DT_TRANSLATEABLE>(0x5A0); } }
	public DT_ATTRIBUTEPARAM x5A4 { get { return Field<DT_ATTRIBUTEPARAM>(0x5A4); } }
	public DT_FORMULA x5A8 { get { return Field<DT_FORMULA>(0x5A8); } }
	public SerializeData x5B0 { get { return Field<SerializeData>(0x5B0); } }
	public int x5B8_Enum { get { return Field<int>(0x5B8); } } // -1: Invalid, 0: Inferior, 1: Normal, 2: Superior, 3: Magic1, 4: Magic2, 5: Magic3, 6: Rare4, 7: Rare5, 8: Rare6, 9: Legendary, 10: Special, 11: Set
	public DT_GBID[] x5BC_Array_RecipesGameBalanceId { get { return Field<DT_GBID>(0x5BC, 10); } }
	public DT_GBID x5E4_ItemEnchantmentsGameBalanceId { get { return Field<DT_GBID>(0x5E4); } }
	public DT_GBID x5E8_ItemsGameBalanceId { get { return Field<DT_GBID>(0x5E8); } }
	public DT_GBID[] x5EC_Array_ItemsGameBalanceId { get { return Field<DT_GBID>(0x5EC, 8); } }
	public int x60C { get { return Field<int>(0x60C); } }
	public int x610 { get { return Field<int>(0x610); } }
	public int x614 { get { return Field<int>(0x614); } }
	public int x618 { get { return Field<int>(0x618); } }
	public int x61C { get { return Field<int>(0x61C); } }
	public int x620 { get { return Field<int>(0x620); } }
	public int x624 { get { return Field<int>(0x624); } }
	public int x628 { get { return Field<int>(0x628); } }
	public DT_GBID x62C_47GameBalanceId { get { return Field<DT_GBID>(0x62C); } }
	public DT_GBID x630_47GameBalanceId { get { return Field<DT_GBID>(0x630); } }
	public DT_GBID x634_47GameBalanceId { get { return Field<DT_GBID>(0x634); } }
	public DT_GBID x638_47GameBalanceId { get { return Field<DT_GBID>(0x638); } }
	public DT_GBID x63C_47GameBalanceId { get { return Field<DT_GBID>(0x63C); } }
	public DT_GBID x640_47GameBalanceId { get { return Field<DT_GBID>(0x640); } }
	public int x644 { get { return Field<int>(0x644); } }
	public int x648 { get { return Field<int>(0x648); } }
	public int x64C { get { return Field<int>(0x64C); } }
	public int x650 { get { return Field<int>(0x650); } }
	public int x654 { get { return Field<int>(0x654); } }
	public int x658 { get { return Field<int>(0x658); } }
	public int x65C { get { return Field<int>(0x65C); } }
	public int x660 { get { return Field<int>(0x660); } }
	public int x664 { get { return Field<int>(0x664); } }
	public int x668 { get { return Field<int>(0x668); } }
	public int x66C { get { return Field<int>(0x66C); } }
	public int x670 { get { return Field<int>(0x670); } }
	public DT_GBID x674_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x674); } }
	public int x678_Enum { get { return Field<int>(0x678); } } // 1: Amethyst, 2: Emerald, 3: Ruby, 4: Topaz, 5: Diamond
	public int x67C { get { return Field<int>(0x67C); } }
	public int x680_Enum { get { return Field<int>(0x680); } } // 1: A, 2: B, 3: C, 4: D
	public int x684_ActorSnoId { get { return Field<int>(0x684); } }
	public int x688_WorldsSnoId { get { return Field<int>(0x688); } }
	public int x68C_WorldsSnoId { get { return Field<int>(0x68C); } }
	public int x690_LevelAreaSnoId { get { return Field<int>(0x690); } }
	public int x694 { get { return Field<int>(0x694); } }
	public int x698 { get { return Field<int>(0x698); } }
	public int x69C { get { return Field<int>(0x69C); } }
	public DT_GBID x6A0_MadeToOrderTypesGameBalanceId { get { return Field<DT_GBID>(0x6A0); } }
	public float x6A4 { get { return Field<float>(0x6A4); } }
	public float x6A8 { get { return Field<float>(0x6A8); } }
	public float x6AC { get { return Field<float>(0x6AC); } }
	public float x6B0 { get { return Field<float>(0x6B0); } }
	public float x6B4 { get { return Field<float>(0x6B4); } }
	public float x6B8 { get { return Field<float>(0x6B8); } }
	public float x6BC { get { return Field<float>(0x6BC); } }
	public float x6C0 { get { return Field<float>(0x6C0); } }
	public float x6C4 { get { return Field<float>(0x6C4); } }
	public float x6C8 { get { return Field<float>(0x6C8); } }
	public int x6CC { get { return Field<int>(0x6CC); } }
	public RecipeIngredient[] x6D0_Array { get { return Field<RecipeIngredient>(0x6D0, 6); } }
	public int x700 { get { return Field<int>(0x700); } }
	public RecipeIngredient[] x704_Array { get { return Field<RecipeIngredient>(0x704, 6); } }
	public int x734_LevelAreaSnoId { get { return Field<int>(0x734); } }
	public int x738_LevelAreaSnoId { get { return Field<int>(0x738); } }
	public int x73C_ActorSnoId { get { return Field<int>(0x73C); } }
}
