public class ConversationTreeNode : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x480; // 1152

	public ConversationTreeNode(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x000 { get { return Field<int>(0x000); } }
	public int x004 { get { return Field<int>(0x004); } }
	public int x008 { get { return Field<int>(0x008); } }
	public int x00C_Enum { get { return Field<int>(0x00C); } } // -1: - None -, 0: Player, 1: Primary NPC, 2: Alt. NPC 1, 3: Alt. NPC 2, 4: Alt. NPC 3, 5: Alt. NPC 4, 6: Templar Follower, 7: Scoundrel Follower, 8: Enchantress Follower
	public int x010_Enum { get { return Field<int>(0x010); } } // -1: - None -, 0: Player, 1: Primary NPC, 2: Alt. NPC 1, 3: Alt. NPC 2, 4: Alt. NPC 3, 5: Alt. NPC 4, 6: Templar Follower, 7: Scoundrel Follower, 8: Enchantress Follower
	public int x014 { get { return Field<int>(0x014); } }
	public DT_TIME x018 { get { return Field<DT_TIME>(0x018); } }
	public int x01C { get { return Field<int>(0x01C); } }
	public int x020 { get { return Field<int>(0x020); } }
	public int x024 { get { return Field<int>(0x024); } }
	public ConvLocaleDisplayTimes[] x028_Array { get { return Field<ConvLocaleDisplayTimes>(0x028, 19); } }
	public string x3B8 { get { return Field(0x3B8, 64); } }
	public int x3F8_Enum { get { return Field<int>(0x3F8); } } // -1: - None -, 0: Equal To, 1: Less Than, 2: Greater Than, 3: Less Than Or Equal To, 4: Greater Than Or Equal To, 5: Not Equal To
	public int x3FC { get { return Field<int>(0x3FC); } }
	public string x400 { get { return Field(0x400, 64); } }
	public int x440_Enum { get { return Field<int>(0x440); } } // -1: - None -, 0: Incremented By, 1: Decremented By, 2: Set To
	public int x444 { get { return Field<int>(0x444); } }
	public int x448 { get { return Field<int>(0x448); } }
	public int x44C { get { return Field<int>(0x44C); } }
	public int x450_Count { get { return Field<int>(0x450); } }
	public ConversationTreeNode[] x454_PtrArray { get { return Dereference<ConversationTreeNode>(0x454, x450_Count); } }
	public SerializeData x458 { get { return Field<SerializeData>(0x458); } }
	public int x460_Count { get { return Field<int>(0x460); } }
	public ConversationTreeNode[] x464_PtrArray { get { return Dereference<ConversationTreeNode>(0x464, x460_Count); } }
	public SerializeData x468 { get { return Field<SerializeData>(0x468); } }
	public int x470_Count { get { return Field<int>(0x470); } }
	public ConversationTreeNode[] x474_PtrArray { get { return Dereference<ConversationTreeNode>(0x474, x470_Count); } }
	public SerializeData x478 { get { return Field<SerializeData>(0x478); } }
}
