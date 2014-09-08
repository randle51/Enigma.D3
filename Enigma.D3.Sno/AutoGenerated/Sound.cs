using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Sound : SerializeMemoryObject
	{
		// 2.1.0.26451
		public const int SizeOf = 0xA8; // 168
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public int x10 { get { return Read<int>(0x10); } }
		public float x14 { get { return Read<float>(0x14); } }
		public float x18 { get { return Read<float>(0x18); } }
		public float x1C { get { return Read<float>(0x1C); } }
		public int x20 { get { return Read<int>(0x20); } }
		public float x24 { get { return Read<float>(0x24); } }
		public float x28 { get { return Read<float>(0x28); } }
		public float x2C { get { return Read<float>(0x2C); } }
		public float x30 { get { return Read<float>(0x30); } }
		public Impulse x34_Impulse { get { return Read<Impulse>(0x34); } }
		public Impulse x38_Impulse { get { return Read<Impulse>(0x38); } }
		public float x3C { get { return Read<float>(0x3C); } }
		public float x40 { get { return Read<float>(0x40); } }
		public SerializeData x44_SerializeData { get { return Read<SerializeData>(0x44); } }
		public int x4C { get { return Read<int>(0x4C); } }
		public SoundPermutation[] x50_SoundPermutations { get { return Deserialize<SoundPermutation>(x44_SerializeData); } }
		public int x58 { get { return Read<int>(0x58); } }
		public int x5C { get { return Read<int>(0x5C); } }
		public int x60 { get { return Read<int>(0x60); } }
		public DspEffect[] x68_DspEffects { get { return Deserialize<DspEffect>(x70_SerializeData); } }
		public SerializeData x70_SerializeData { get { return Read<SerializeData>(0x70); } }
		public RTPCParams[] x78_RTPCParams { get { return Deserialize<RTPCParams>(x80_SerializeData); } }
		public SerializeData x80_SerializeData { get { return Read<SerializeData>(0x80); } }
		public Time x88_Time { get { return Read<Time>(0x88); } }
		public Time x8C_Time { get { return Read<Time>(0x8C); } }
		
		[CompilerGenerated]
		public partial class SoundPermutation : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0xC0; // 192
			
			public Sno x00_SoundBankSno { get { return Read<Sno>(0x00); } }
			public string x04_Text { get { return ReadString(0x04, 132); } }
			public int x88 { get { return Read<int>(0x88); } }
			public float x8C { get { return Read<float>(0x8C); } }
			public float x90 { get { return Read<float>(0x90); } }
			public float x94 { get { return Read<float>(0x94); } }
			public float x98 { get { return Read<float>(0x98); } }
			public Time x9C_Time { get { return Read<Time>(0x9C); } }
			public Time xA0_Time { get { return Read<Time>(0xA0); } }
			public int xA4 { get { return Read<int>(0xA4); } }
			public int xA8 { get { return Read<int>(0xA8); } }
			public float xAC { get { return Read<float>(0xAC); } }
			public float xB0 { get { return Read<float>(0xB0); } }
			public Time xB4_Time { get { return Read<Time>(0xB4); } }
		}
		
		[CompilerGenerated]
		public partial class DspEffect : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x108; // 264
			
			public int x000_Enum { get { return Read<int>(0x000); } } // Chorus = 0, Compressor = 1, Distortion = 2, Echo = 3, Flange = 4, High Pass Filter = 5, Low Pass Filter = 6, Low Pass Filter (Simple) = 7, Parametric EQ = 8, SFX Reverb = 9
			public int x004 { get { return Read<int>(0x004); } }
			public DspParam x008_DspParam { get { return Read<DspParam>(0x008); } }
			public DspParam x018_DspParam { get { return Read<DspParam>(0x018); } }
			public DspParam x028_DspParam { get { return Read<DspParam>(0x028); } }
			public DspParam x038_DspParam { get { return Read<DspParam>(0x038); } }
			public DspParam x048_DspParam { get { return Read<DspParam>(0x048); } }
			public DspParam x058_DspParam { get { return Read<DspParam>(0x058); } }
			public DspParam x068_DspParam { get { return Read<DspParam>(0x068); } }
			public DspParam x078_DspParam { get { return Read<DspParam>(0x078); } }
			public DspParam x088_DspParam { get { return Read<DspParam>(0x088); } }
			public DspParam x098_DspParam { get { return Read<DspParam>(0x098); } }
			public DspParam x0A8_DspParam { get { return Read<DspParam>(0x0A8); } }
			public DspParam x0B8_DspParam { get { return Read<DspParam>(0x0B8); } }
			public DspParam x0C8_DspParam { get { return Read<DspParam>(0x0C8); } }
			public DspParam x0D8_DspParam { get { return Read<DspParam>(0x0D8); } }
			public DspParam x0E8_DspParam { get { return Read<DspParam>(0x0E8); } }
		}
		
		[CompilerGenerated]
		public partial class RTPCParams : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x18; // 24
			
			public int x00 { get { return Read<int>(0x00); } }
			public InterpolationScalar x04_InterpolationScalar { get { return Read<InterpolationScalar>(0x04); } }
			public int x10 { get { return Read<int>(0x10); } }
			public float x14 { get { return Read<float>(0x14); } }
		}
		
		[CompilerGenerated]
		public partial class DspParam : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16
			
			public float x00 { get { return Read<float>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
		}
		
		[CompilerGenerated]
		public partial class InterpolationScalar : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x0C; // 12
			
			public int x00 { get { return Read<int>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
		}
	}
}
