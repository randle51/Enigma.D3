public class PowerFormulaTableEntry : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x530; // 1328

	public PowerFormulaTableEntry(ProcessMemory memory, int address)
		: base(memory, address) { }

	public string x000 { get { return Field(0x000, 1024); } }
	public float x400 { get { return Field<float>(0x400); } }
	public float x404 { get { return Field<float>(0x404); } }
	public float x408 { get { return Field<float>(0x408); } }
	public float x40C { get { return Field<float>(0x40C); } }
	public float x410 { get { return Field<float>(0x410); } }
	public float x414 { get { return Field<float>(0x414); } }
	public float x418 { get { return Field<float>(0x418); } }
	public float x41C { get { return Field<float>(0x41C); } }
	public float x420 { get { return Field<float>(0x420); } }
	public float x424 { get { return Field<float>(0x424); } }
	public float x428 { get { return Field<float>(0x428); } }
	public float x42C { get { return Field<float>(0x42C); } }
	public float x430 { get { return Field<float>(0x430); } }
	public float x434 { get { return Field<float>(0x434); } }
	public float x438 { get { return Field<float>(0x438); } }
	public float x43C { get { return Field<float>(0x43C); } }
	public float x440 { get { return Field<float>(0x440); } }
	public float x444 { get { return Field<float>(0x444); } }
	public float x448 { get { return Field<float>(0x448); } }
	public float x44C { get { return Field<float>(0x44C); } }
	public float x450 { get { return Field<float>(0x450); } }
	public float x454 { get { return Field<float>(0x454); } }
	public float x458 { get { return Field<float>(0x458); } }
	public float x45C { get { return Field<float>(0x45C); } }
	public float x460 { get { return Field<float>(0x460); } }
	public float x464 { get { return Field<float>(0x464); } }
	public float x468 { get { return Field<float>(0x468); } }
	public float x46C { get { return Field<float>(0x46C); } }
	public float x470 { get { return Field<float>(0x470); } }
	public float x474 { get { return Field<float>(0x474); } }
	public float x478 { get { return Field<float>(0x478); } }
	public float x47C { get { return Field<float>(0x47C); } }
	public float x480 { get { return Field<float>(0x480); } }
	public float x484 { get { return Field<float>(0x484); } }
	public float x488 { get { return Field<float>(0x488); } }
	public float x48C { get { return Field<float>(0x48C); } }
	public float x490 { get { return Field<float>(0x490); } }
	public float x494 { get { return Field<float>(0x494); } }
	public float x498 { get { return Field<float>(0x498); } }
	public float x49C { get { return Field<float>(0x49C); } }
	public float x4A0 { get { return Field<float>(0x4A0); } }
	public float x4A4 { get { return Field<float>(0x4A4); } }
	public float x4A8 { get { return Field<float>(0x4A8); } }
	public float x4AC { get { return Field<float>(0x4AC); } }
	public float x4B0 { get { return Field<float>(0x4B0); } }
	public float x4B4 { get { return Field<float>(0x4B4); } }
	public float x4B8 { get { return Field<float>(0x4B8); } }
	public float x4BC { get { return Field<float>(0x4BC); } }
	public float x4C0 { get { return Field<float>(0x4C0); } }
	public float x4C4 { get { return Field<float>(0x4C4); } }
	public float x4C8 { get { return Field<float>(0x4C8); } }
	public float x4CC { get { return Field<float>(0x4CC); } }
	public float x4D0 { get { return Field<float>(0x4D0); } }
	public float x4D4 { get { return Field<float>(0x4D4); } }
	public float x4D8 { get { return Field<float>(0x4D8); } }
	public float x4DC { get { return Field<float>(0x4DC); } }
	public float x4E0 { get { return Field<float>(0x4E0); } }
	public float x4E4 { get { return Field<float>(0x4E4); } }
	public float x4E8 { get { return Field<float>(0x4E8); } }
	public float x4EC { get { return Field<float>(0x4EC); } }
	public float x4F0 { get { return Field<float>(0x4F0); } }
	public float x4F4 { get { return Field<float>(0x4F4); } }
	public float x4F8 { get { return Field<float>(0x4F8); } }
	public float x4FC { get { return Field<float>(0x4FC); } }
	public float x500 { get { return Field<float>(0x500); } }
	public float x504 { get { return Field<float>(0x504); } }
	public float x508 { get { return Field<float>(0x508); } }
	public float x50C { get { return Field<float>(0x50C); } }
	public float x510 { get { return Field<float>(0x510); } }
	public float x514 { get { return Field<float>(0x514); } }
	public float x518 { get { return Field<float>(0x518); } }
	public float x51C { get { return Field<float>(0x51C); } }
	public float x520 { get { return Field<float>(0x520); } }
	public float x524 { get { return Field<float>(0x524); } }
	public float x528 { get { return Field<float>(0x528); } }
	public float x52C { get { return Field<float>(0x52C); } }
}
