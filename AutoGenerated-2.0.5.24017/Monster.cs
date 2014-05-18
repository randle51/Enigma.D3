public class Monster : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x540; // 1344

	public Monster(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00C { get { return Field<int>(0x00C); } }
	public int x010_ActorSnoId { get { return Field<int>(0x010); } }
	public int x014 { get { return Field<int>(0x014); } }
	public int x018_Enum { get { return Field<int>(0x018); } } // -1: , 0: Undead, 1: Demon, 2: Beast, 3: Human, 4: Breakable, 5: Scenery, 6: Ally, 7: Team, 8: Helper, 9: CorruptedAngel, 10: Pandemonium, 11: Adria, 12: Blood Golem
	public int x01C_Enum { get { return Field<int>(0x01C); } } // 0: , 1: Fallen, 2: GoatMen, 3: Rogue, 4: Skeleton, 5: Zombie, 6: Spider, 7: Triune, 8: WoodWraith, 9: Human, 10: Animal, 11: TreasureGoblin, 12: CrazedAngel
	public int x020_Enum { get { return Field<int>(0x020); } } // -1: , 3: Big, 4: Standard, 5: Ranged, 6: Swarm, 7: Boss
	public Monster x024 { get { return Field<Monster>(0x024); } }
	public int x038_Enum { get { return Field<int>(0x038); } } // -1: None, 0: Physical, 1: Fire, 2: Lightning, 3: Cold, 4: Poison, 5: Arcane, 6: Holy
	public int x03C { get { return Field<int>(0x03C); } }
	public int x040 { get { return Field<int>(0x040); } }
	public float[] x044_Array { get { return Field<float>(0x044, 146); } }
	public float x28C { get { return Field<float>(0x28C); } }
	public float x290 { get { return Field<float>(0x290); } }
	public float x294 { get { return Field<float>(0x294); } }
	public float x298 { get { return Field<float>(0x298); } }
	public float x29C { get { return Field<float>(0x29C); } }
	public float x2A0 { get { return Field<float>(0x2A0); } }
	public int x2A4 { get { return Field<int>(0x2A4); } }
	public HealthDropInfo x2A8 { get { return Field<HealthDropInfo>(0x2A8); } }
	public HealthDropInfo x2B4 { get { return Field<HealthDropInfo>(0x2B4); } }
	public HealthDropInfo x2C0 { get { return Field<HealthDropInfo>(0x2C0); } }
	public HealthDropInfo x2CC { get { return Field<HealthDropInfo>(0x2CC); } }
	public int x2D8_SkillKitSnoId { get { return Field<int>(0x2D8); } }
	public SkillDeclaration[] x2DC_Array { get { return Field<SkillDeclaration>(0x2DC, 8); } }
	public MonsterSkillDeclaration[] x31C_Array { get { return Field<MonsterSkillDeclaration>(0x31C, 8); } }
	public int x39C_TreasureClassSnoId { get { return Field<int>(0x39C); } }
	public int x3A0_TreasureClassSnoId { get { return Field<int>(0x3A0); } }
	public int x3A4_TreasureClassSnoId { get { return Field<int>(0x3A4); } }
	public int x3A8_TreasureClassSnoId { get { return Field<int>(0x3A8); } }
	public int x3AC_TreasureClassSnoId { get { return Field<int>(0x3AC); } }
	public float x3B0 { get { return Field<float>(0x3B0); } }
	public float x3B4 { get { return Field<float>(0x3B4); } }
	public float x3B8 { get { return Field<float>(0x3B8); } }
	public float x3BC { get { return Field<float>(0x3BC); } }
	public int x3C0 { get { return Field<int>(0x3C0); } }
	public float x3C4 { get { return Field<float>(0x3C4); } }
	public int x3C8 { get { return Field<int>(0x3C8); } }
	public int x3CC { get { return Field<int>(0x3CC); } }
	public int x3D0_TreasureClassSnoId { get { return Field<int>(0x3D0); } }
	public int x3D4_TreasureClassSnoId { get { return Field<int>(0x3D4); } }
	public int x3D8_LoreSnoId { get { return Field<int>(0x3D8); } }
	public int[] x3DC_Array_3SnoId { get { return Field<int>(0x3DC, 6); } }
	public DT_GBID[] x3F4_Array_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x3F4, 8); } }
	public int[] x414_Array_ActorSnoId { get { return Field<int>(0x414, 6); } }
	public int x42C { get { return Field<int>(0x42C); } }
	public DT_GBID[] x430_Array_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x430, 4); } }
	public DT_GBID[] x440_Array_AxeBadDataGameBalanceId { get { return Field<DT_GBID>(0x440, 6); } }
	public int x458 { get { return Field<int>(0x458); } }
	public int x45C { get { return Field<int>(0x45C); } }
	public int x460 { get { return Field<int>(0x460); } }
	public int x464_Enum { get { return Field<int>(0x464); } } // 0: Mana, 1: Arcanum, 2: Fury, 3: Spirit, 4: Power, 5: Hatred, 6: Discipline, 7: Faith
	public SerializeData x480 { get { return Field<SerializeData>(0x480); } }
	public DT_TAGMAP x488 { get { return Field<DT_TAGMAP>(0x488); } }
	public int x490 { get { return Field<int>(0x490); } }
	public int x498_Count { get { return Field<int>(0x498); } }
	public MonsterMinionSpawnGroup[] x49C_PtrArray { get { return Dereference<MonsterMinionSpawnGroup>(0x49C, x498_Count); } }
	public SerializeData x4A0 { get { return Field<SerializeData>(0x4A0); } }
	public int x4A8 { get { return Field<int>(0x4A8); } }
	public int x4B0_Count { get { return Field<int>(0x4B0); } }
	public MonsterChampionSpawnGroup[] x4B4_PtrArray { get { return Dereference<MonsterChampionSpawnGroup>(0x4B4, x4B0_Count); } }
	public SerializeData x4B8 { get { return Field<SerializeData>(0x4B8); } }
	public string x4C0 { get { return Field(0x4C0, 128); } }
}
