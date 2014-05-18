public class Conversation : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x210; // 528

	public Conversation(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00C_Enum { get { return Field<int>(0x00C); } } // 13: Quest Event, 12: Quest Float, 11: Quest Standard, 10: Talk Menu Gossip, 9: Ambient Gossip, 8: Lore Book, 7: Global Float, 6: Global Chatter, 5: Player Callout, 4: Follower Callout, 3: Follower Banter, 2: Ambient Float, 1: Player Emote, 0: Follower Soundset
	public int x010 { get { return Field<int>(0x010); } }
	public int x014_ConversationSnoId { get { return Field<int>(0x014); } }
	public int[] x018_Array_ConversationSnoId { get { return Field<int>(0x018, 3); } }
	public int x024 { get { return Field<int>(0x024); } }
	public string x028 { get { return Field(0x028, 128); } }
	public int x0A8_ActorSnoId { get { return Field<int>(0x0A8); } }
	public int x0AC_ActorSnoId { get { return Field<int>(0x0AC); } }
	public int x0B0_ActorSnoId { get { return Field<int>(0x0B0); } }
	public int x0B4_ActorSnoId { get { return Field<int>(0x0B4); } }
	public int x0B8_ActorSnoId { get { return Field<int>(0x0B8); } }
	public int x0BC { get { return Field<int>(0x0BC); } }
	public int x0C0_Count { get { return Field<int>(0x0C0); } }
	public ConversationTreeNode[] x0C4_PtrArray { get { return Dereference<ConversationTreeNode>(0x0C4, x0C0_Count); } }
	public SerializeData x0C8 { get { return Field<SerializeData>(0x0C8); } }
	public string x0D0 { get { return Field(0x0D0, 256); } }
	public int x1D0_Count { get { return Field<int>(0x1D0); } }
	public byte[] x1D4_PtrArray { get { return Dereference<byte>(0x1D4, x1D0_Count); } }
	public SerializeData x1D8 { get { return Field<SerializeData>(0x1D8); } }
	public int x208_BossEncounterSnoId { get { return Field<int>(0x208); } }
	public int x20C { get { return Field<int>(0x20C); } }
}
