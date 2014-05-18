public class QuestStep : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0xD8; // 216

	public QuestStep(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x00 { get { return Field(0x00, 64); } }
	public int x40 { get { return Field<int>(0x40); } }
	public int x44 { get { return Field<int>(0x44); } }
	public int x48_Enum { get { return Field<int>(0x48); } } // 0: - No Item -, 1: Shared Recipe, 2: Class Recipe, 3: Treasure Class
	public int[] x4C_Array_RecipeSnoId { get { return Field<int>(0x4C, 6); } }
	public int x64_TreasureClassSnoId { get { return Field<int>(0x64); } }
	public int x68 { get { return Field<int>(0x68); } }
	public int x6C { get { return Field<int>(0x6C); } }
	public int x70_Enum { get { return Field<int>(0x70); } } // 0: - No Item -, 1: Shared Recipe, 2: Class Recipe, 3: Treasure Class
	public int[] x74_Array_RecipeSnoId { get { return Field<int>(0x74, 6); } }
	public int x8C_TreasureClassSnoId { get { return Field<int>(0x8C); } }
	public int x90 { get { return Field<int>(0x90); } }
	public int x94 { get { return Field<int>(0x94); } }
	public int x98_PowerSnoId { get { return Field<int>(0x98); } }
	public int[] x9C_Array_LevelAreaSnoId { get { return Field<int>(0x9C, 2); } }
	public int xA8_Count { get { return Field<int>(0xA8); } }
	public QuestStepObjectiveSet[] xAC_PtrArray { get { return Dereference<QuestStepObjectiveSet>(0xAC, xA8_Count); } }
	public SerializeData xB0 { get { return Field<SerializeData>(0xB0); } }
	public int xB8_Count { get { return Field<int>(0xB8); } }
	public QuestStepBonusObjectiveSet[] xBC_PtrArray { get { return Dereference<QuestStepBonusObjectiveSet>(0xBC, xB8_Count); } }
	public SerializeData xC0 { get { return Field<SerializeData>(0xC0); } }
	public int xC8_Count { get { return Field<int>(0xC8); } }
	public QuestStepFailureConditionSet[] xCC_PtrArray { get { return Dereference<QuestStepFailureConditionSet>(0xCC, xC8_Count); } }
	public SerializeData xD0 { get { return Field<SerializeData>(0xD0); } }
}
