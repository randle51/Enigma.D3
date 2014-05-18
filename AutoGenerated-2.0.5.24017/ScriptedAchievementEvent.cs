public class ScriptedAchievementEvent : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x108; // 264

	public ScriptedAchievementEvent(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 256); } }
	public int x100 { get { return Field<int>(0x100); } }
	public int x104 { get { return Field<int>(0x104); } }
}
