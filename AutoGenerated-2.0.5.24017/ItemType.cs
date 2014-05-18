public class ItemType : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x148; // 328

	public ItemType(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 256); } }
	public int x100 { get { return Field<int>(0x100); } }
	public int x104 { get { return Field<int>(0x104); } }
	public DT_GBID x108_ItemTypesGameBalanceId { get { return Field<DT_GBID>(0x108); } }
	public int x10C { get { return Field<int>(0x10C); } }
	public int x110 { get { return Field<int>(0x110); } }
	public DT_FLAG x114_00 { get { return (Field<int>(0x114) >> 0) & 1; } }
	public DT_FLAG x114_12 { get { return (Field<int>(0x114) >> 12) & 1; } }
	public DT_FLAG x114_01 { get { return (Field<int>(0x114) >> 1) & 1; } }
	public DT_FLAG x114_03 { get { return (Field<int>(0x114) >> 3) & 1; } }
	public DT_FLAG x114_06 { get { return (Field<int>(0x114) >> 6) & 1; } }
	public DT_FLAG x114_07 { get { return (Field<int>(0x114) >> 7) & 1; } }
	public DT_FLAG x114_08 { get { return (Field<int>(0x114) >> 8) & 1; } }
	public DT_FLAG x114_09 { get { return (Field<int>(0x114) >> 9) & 1; } }
	public DT_FLAG x114_10 { get { return (Field<int>(0x114) >> 10) & 1; } }
	public DT_FLAG x114_13 { get { return (Field<int>(0x114) >> 13) & 1; } }
	public DT_FLAG x114_11 { get { return (Field<int>(0x114) >> 11) & 1; } }
	public DT_FLAG x114_17 { get { return (Field<int>(0x114) >> 17) & 1; } }
	public DT_FLAG x114_14 { get { return (Field<int>(0x114) >> 14) & 1; } }
	public DT_FLAG x114_15 { get { return (Field<int>(0x114) >> 15) & 1; } }
	public DT_FLAG x114_16 { get { return (Field<int>(0x114) >> 16) & 1; } }
	public DT_FLAG x114_18 { get { return (Field<int>(0x114) >> 18) & 1; } }
	public int x118_Enum { get { return Field<int>(0x118); } } // 0: Player:Backpack, 1: Player:Head, 2: Player:Torso, 3: Player:RightHand, 4: Player:LeftHand, 5: Player:Hands, 6: Player:Waist, 7: Player:Feet, 8: Player:Shoulders, 9: Player:Legs, 10: Player:Bracers, 12: Player:LeftFinger, 11: Player:RightFinger, 13: Player:Neck, 18: Merchant, 21: Pet:RightHand, 22: Pet:LeftHand, 23: Pet:Special, 26: Pet:LeftFinger, 25: Pet:RightFinger, 24: Pet:Neck
	public int x11C_Enum { get { return Field<int>(0x11C); } } // 0: Player:Backpack, 1: Player:Head, 2: Player:Torso, 3: Player:RightHand, 4: Player:LeftHand, 5: Player:Hands, 6: Player:Waist, 7: Player:Feet, 8: Player:Shoulders, 9: Player:Legs, 10: Player:Bracers, 12: Player:LeftFinger, 11: Player:RightFinger, 13: Player:Neck, 18: Merchant, 21: Pet:RightHand, 22: Pet:LeftHand, 23: Pet:Special, 26: Pet:LeftFinger, 25: Pet:RightFinger, 24: Pet:Neck
	public int x120_Enum { get { return Field<int>(0x120); } } // 0: Player:Backpack, 1: Player:Head, 2: Player:Torso, 3: Player:RightHand, 4: Player:LeftHand, 5: Player:Hands, 6: Player:Waist, 7: Player:Feet, 8: Player:Shoulders, 9: Player:Legs, 10: Player:Bracers, 12: Player:LeftFinger, 11: Player:RightFinger, 13: Player:Neck, 18: Merchant, 21: Pet:RightHand, 22: Pet:LeftHand, 23: Pet:Special, 26: Pet:LeftFinger, 25: Pet:RightFinger, 24: Pet:Neck
	public int x124_Enum { get { return Field<int>(0x124); } } // 0: Player:Backpack, 1: Player:Head, 2: Player:Torso, 3: Player:RightHand, 4: Player:LeftHand, 5: Player:Hands, 6: Player:Waist, 7: Player:Feet, 8: Player:Shoulders, 9: Player:Legs, 10: Player:Bracers, 12: Player:LeftFinger, 11: Player:RightFinger, 13: Player:Neck, 18: Merchant, 21: Pet:RightHand, 22: Pet:LeftHand, 23: Pet:Special, 26: Pet:LeftFinger, 25: Pet:RightFinger, 24: Pet:Neck
	public DT_GBID x128_AffixListGameBalanceId { get { return Field<DT_GBID>(0x128); } }
	public DT_GBID x12C_AffixListGameBalanceId { get { return Field<DT_GBID>(0x12C); } }
	public DT_GBID x130_AffixListGameBalanceId { get { return Field<DT_GBID>(0x130); } }
	public DT_GBID x134_47GameBalanceId { get { return Field<DT_GBID>(0x134); } }
	public int[] x138_Array { get { return Field<int>(0x138, 4); } }
}
