public class KeyframedAttachment : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x19C; // 412

	public KeyframedAttachment(ProcessMemory memory, int address)
		: base(memory, address) { }

	public float x000 { get { return Field<float>(0x000); } }
	public TriggerEvent x004 { get { return Field<TriggerEvent>(0x004); } }
}
