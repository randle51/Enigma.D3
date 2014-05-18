public class TimedEvent : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x10; // 16

	public TimedEvent(ProcessMemory memory, int address)
		: base(memory, address) { }

	public DT_TIME x0C { get { return Field<DT_TIME>(0x0C); } }
}
