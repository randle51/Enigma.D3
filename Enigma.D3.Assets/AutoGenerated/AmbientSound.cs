using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class AmbientSound : MemoryObject
	{
		public const int SizeOf = 0x9C; // 156
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public Sno x10_SoundSno { get { return Read<Sno>(0x10); } }
		public RandomAmbientSoundParams[] x14_RandomAmbientSoundParams { get { return Read<RandomAmbientSoundParams>(0x14, 2); } }
		public Sno x3C_SoundSno { get { return Read<Sno>(0x3C); } }
		public Time x40_Time { get { return Read<Time>(0x40); } }
		public Time x44_Time { get { return Read<Time>(0x44); } }
		public string x48_Text { get { return ReadString(0x48, 64); } }
		public float x88 { get { return Read<float>(0x88); } }
		public float x8C { get { return Read<float>(0x8C); } }
		public float x90 { get { return Read<float>(0x90); } }
		public float x94 { get { return Read<float>(0x94); } }
		public float x98 { get { return Read<float>(0x98); } }
		
		[CompilerGenerated]
		public partial class RandomAmbientSoundParams : MemoryObject
		{
			public const int SizeOf = 0x14; // 20
			
			public Sno x00_SoundSno { get { return Read<Sno>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
			public Time x0C_Time { get { return Read<Time>(0x0C); } }
			public Time x10_Time { get { return Read<Time>(0x10); } }
		}
	}
}
