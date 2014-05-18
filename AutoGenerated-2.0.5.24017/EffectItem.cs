public class EffectItem : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x1E0; // 480

	public EffectItem(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x000 { get { return Field<int>(0x000); } }
	public string x004 { get { return Field(0x004, 64); } }
	public MsgTriggeredEvent x044 { get { return Field<MsgTriggeredEvent>(0x044); } }
}
