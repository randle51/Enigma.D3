public class DspEffect : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x108; // 264

	public DspEffect(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x000_Enum { get { return Field<int>(0x000); } } // 0: Chorus, 1: Compressor, 2: Distortion, 3: Echo, 4: Flange, 5: High Pass Filter, 6: Low Pass Filter, 7: Low Pass Filter (Simple), 8: Parametric EQ, 9: SFX Reverb
	public int x004 { get { return Field<int>(0x004); } }
	public DspParam x008 { get { return Field<DspParam>(0x008); } }
	public DspParam x008 { get { return Field<DspParam>(0x008); } }
	public DspParam x008 { get { return Field<DspParam>(0x008); } }
	public DspParam x008 { get { return Field<DspParam>(0x008); } }
	public DspParam x008 { get { return Field<DspParam>(0x008); } }
	public DspParam x008 { get { return Field<DspParam>(0x008); } }
	public DspParam x008 { get { return Field<DspParam>(0x008); } }
	public DspParam x008 { get { return Field<DspParam>(0x008); } }
	public DspParam x008 { get { return Field<DspParam>(0x008); } }
	public DspParam x008 { get { return Field<DspParam>(0x008); } }
	public DspParam x018 { get { return Field<DspParam>(0x018); } }
	public DspParam x018 { get { return Field<DspParam>(0x018); } }
	public DspParam x018 { get { return Field<DspParam>(0x018); } }
	public DspParam x018 { get { return Field<DspParam>(0x018); } }
	public DspParam x018 { get { return Field<DspParam>(0x018); } }
	public DspParam x018 { get { return Field<DspParam>(0x018); } }
	public DspParam x018 { get { return Field<DspParam>(0x018); } }
	public DspParam x018 { get { return Field<DspParam>(0x018); } }
	public DspParam x028 { get { return Field<DspParam>(0x028); } }
	public DspParam x028 { get { return Field<DspParam>(0x028); } }
	public DspParam x028 { get { return Field<DspParam>(0x028); } }
	public DspParam x028 { get { return Field<DspParam>(0x028); } }
	public DspParam x028 { get { return Field<DspParam>(0x028); } }
	public DspParam x028 { get { return Field<DspParam>(0x028); } }
	public DspParam x038 { get { return Field<DspParam>(0x038); } }
	public DspParam x038 { get { return Field<DspParam>(0x038); } }
	public DspParam x038 { get { return Field<DspParam>(0x038); } }
	public DspParam x038 { get { return Field<DspParam>(0x038); } }
	public DspParam x038 { get { return Field<DspParam>(0x038); } }
	public DspParam x048 { get { return Field<DspParam>(0x048); } }
	public DspParam x048 { get { return Field<DspParam>(0x048); } }
	public DspParam x048 { get { return Field<DspParam>(0x048); } }
	public DspParam x058 { get { return Field<DspParam>(0x058); } }
	public DspParam x058 { get { return Field<DspParam>(0x058); } }
	public DspParam x068 { get { return Field<DspParam>(0x068); } }
	public DspParam x068 { get { return Field<DspParam>(0x068); } }
	public DspParam x078 { get { return Field<DspParam>(0x078); } }
	public DspParam x078 { get { return Field<DspParam>(0x078); } }
	public DspParam x088 { get { return Field<DspParam>(0x088); } }
	public DspParam x098 { get { return Field<DspParam>(0x098); } }
	public DspParam x0A8 { get { return Field<DspParam>(0x0A8); } }
	public DspParam x0B8 { get { return Field<DspParam>(0x0B8); } }
	public DspParam x0C8 { get { return Field<DspParam>(0x0C8); } }
	public DspParam x0D8 { get { return Field<DspParam>(0x0D8); } }
	public DspParam x0E8 { get { return Field<DspParam>(0x0E8); } }
}
