using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Music : SerializeMemoryObject
	{
		// 2.1.1.27255
		public const int SizeOf = 0x50; // 80
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public float x10 { get { return Read<float>(0x10); } }
		public Time x14_Time { get { return Read<Time>(0x14); } }
		public Time x18_Time { get { return Read<Time>(0x18); } }
		public SerializeData x1C_SerializeData { get { return Read<SerializeData>(0x1C); } }
		public int x24 { get { return Read<int>(0x24); } }
		public PlaylistEntry[] x28_PlaylistEntries { get { return Deserialize<PlaylistEntry>(x1C_SerializeData); } }
		public RandomMusicSoundParams[] x30_RandomMusicSoundParams { get { return Read<RandomMusicSoundParams>(0x30, 2); } }
		
		[CompilerGenerated]
		public partial class PlaylistEntry : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0xCC; // 204
			
			public Sno x00_SoundBankSno { get { return Read<Sno>(0x00); } }
			public string x04_Text { get { return ReadString(0x04, 132); } }
			public float x88 { get { return Read<float>(0x88); } }
			public int x8C { get { return Read<int>(0x8C); } }
			public int x90 { get { return Read<int>(0x90); } }
			public int x94 { get { return Read<int>(0x94); } }
			public int x98 { get { return Read<int>(0x98); } }
			public int x9C { get { return Read<int>(0x9C); } }
			public int xA0 { get { return Read<int>(0xA0); } }
			public int xA4 { get { return Read<int>(0xA4); } }
			public int xA8 { get { return Read<int>(0xA8); } }
			public int xAC { get { return Read<int>(0xAC); } }
			public int xB0 { get { return Read<int>(0xB0); } }
			public int xB4 { get { return Read<int>(0xB4); } }
			public int xB8 { get { return Read<int>(0xB8); } }
			public float xBC { get { return Read<float>(0xBC); } }
			public float xC0 { get { return Read<float>(0xC0); } }
		}
		
		[CompilerGenerated]
		public partial class RandomMusicSoundParams : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x10; // 16
			
			public Sno x00_SoundSno { get { return Read<Sno>(0x00); } }
			public Time x04_Time { get { return Read<Time>(0x04); } }
			public Time x08_Time { get { return Read<Time>(0x08); } }
			public Time x0C_Time { get { return Read<Time>(0x0C); } }
		}
	}
}
