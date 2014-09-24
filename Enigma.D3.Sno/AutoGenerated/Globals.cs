using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Globals : SerializeMemoryObject
	{
		// 2.1.1.27255
		public const int SizeOf = 0x288; // 648
		
		public SnoHeader x000_Header { get { return Read<SnoHeader>(0x000); } }
		public GlobalServerData[] x010_GlobalServerDatas { get { return Deserialize<GlobalServerData>(x018_SerializeData); } }
		public SerializeData x018_SerializeData { get { return Read<SerializeData>(0x018); } }
		public int x020 { get { return Read<int>(0x020); } }
		public StartLocationName[] x028_StartLocationNames { get { return Deserialize<StartLocationName>(x030_SerializeData); } }
		public SerializeData x030_SerializeData { get { return Read<SerializeData>(0x030); } }
		public float x038 { get { return Read<float>(0x038); } }
		public float x03C { get { return Read<float>(0x03C); } }
		public float x040 { get { return Read<float>(0x040); } }
		public float x044 { get { return Read<float>(0x044); } }
		public int x048 { get { return Read<int>(0x048); } }
		public int x04C { get { return Read<int>(0x04C); } }
		public float x050 { get { return Read<float>(0x050); } }
		public float x054 { get { return Read<float>(0x054); } }
		public int x058 { get { return Read<int>(0x058); } }
		public float x05C { get { return Read<float>(0x05C); } }
		public float x060 { get { return Read<float>(0x060); } }
		public float x064 { get { return Read<float>(0x064); } }
		public float x068 { get { return Read<float>(0x068); } }
		public float x06C { get { return Read<float>(0x06C); } }
		public float x070 { get { return Read<float>(0x070); } }
		public float x074 { get { return Read<float>(0x074); } }
		public float x078 { get { return Read<float>(0x078); } }
		public float x07C { get { return Read<float>(0x07C); } }
		public int x080 { get { return Read<int>(0x080); } }
		public int[] x084_int { get { return Read<int>(0x084, 4); } }
		public BannerParams x098_BannerParams { get { return Read<BannerParams>(0x098); } }
		public int x180 { get { return Read<int>(0x180); } }
		public int x184 { get { return Read<int>(0x184); } }
		public int x188 { get { return Read<int>(0x188); } }
		public int x18C { get { return Read<int>(0x18C); } }
		public float x190 { get { return Read<float>(0x190); } }
		public int x194 { get { return Read<int>(0x194); } }
		public float x198 { get { return Read<float>(0x198); } }
		public float x19C { get { return Read<float>(0x19C); } }
		public float x1A0 { get { return Read<float>(0x1A0); } }
		public float x1A4 { get { return Read<float>(0x1A4); } }
		public float x1A8 { get { return Read<float>(0x1A8); } }
		public float x1AC { get { return Read<float>(0x1AC); } }
		public float x1B0 { get { return Read<float>(0x1B0); } }
		public float x1B4 { get { return Read<float>(0x1B4); } }
		public float x1B8 { get { return Read<float>(0x1B8); } }
		public float x1BC { get { return Read<float>(0x1BC); } }
		public float x1C0 { get { return Read<float>(0x1C0); } }
		public float x1C4 { get { return Read<float>(0x1C4); } }
		public float x1C8 { get { return Read<float>(0x1C8); } }
		public float x1CC { get { return Read<float>(0x1CC); } }
		public float x1D0 { get { return Read<float>(0x1D0); } }
		public float x1D4 { get { return Read<float>(0x1D4); } }
		public float x1D8 { get { return Read<float>(0x1D8); } }
		public float x1DC { get { return Read<float>(0x1DC); } }
		public float x1E0 { get { return Read<float>(0x1E0); } }
		public float x1E4 { get { return Read<float>(0x1E4); } }
		public float x1E8 { get { return Read<float>(0x1E8); } }
		public int x1EC { get { return Read<int>(0x1EC); } }
		public float x1F0 { get { return Read<float>(0x1F0); } }
		public int x1F4 { get { return Read<int>(0x1F4); } }
		public int x1F8 { get { return Read<int>(0x1F8); } }
		public float x1FC { get { return Read<float>(0x1FC); } }
		public float x200 { get { return Read<float>(0x200); } }
		public float x204 { get { return Read<float>(0x204); } }
		public float x208 { get { return Read<float>(0x208); } }
		public float x20C { get { return Read<float>(0x20C); } }
		public AssetList[] x210_AssetLists { get { return Read<AssetList>(0x210, 7); } }
		public float x280 { get { return Read<float>(0x280); } }
		public float x284 { get { return Read<float>(0x284); } }
		
		[CompilerGenerated]
		public partial class GlobalServerData : SerializeMemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x2A8; // 680
			
			public ActorGroup[] x000_ActorGroups { get { return Deserialize<ActorGroup>(x008_SerializeData); } }
			public SerializeData x008_SerializeData { get { return Read<SerializeData>(0x008); } }
			public GlobalScriptVariable[] x010_GlobalScriptVariables { get { return Deserialize<GlobalScriptVariable>(x018_SerializeData); } }
			public SerializeData x018_SerializeData { get { return Read<SerializeData>(0x018); } }
			public DifficultyTuningParams[] x020_DifficultyTuningParams { get { return Read<DifficultyTuningParams>(0x020, 6); } }
			public float x158 { get { return Read<float>(0x158); } }
			public float x15C { get { return Read<float>(0x15C); } }
			public float x160 { get { return Read<float>(0x160); } }
			public float x164 { get { return Read<float>(0x164); } }
			public float x168 { get { return Read<float>(0x168); } }
			public float x16C { get { return Read<float>(0x16C); } }
			public float x170 { get { return Read<float>(0x170); } }
			public float x174 { get { return Read<float>(0x174); } }
			public int x178 { get { return Read<int>(0x178); } }
			public float x17C { get { return Read<float>(0x17C); } }
			public float x180 { get { return Read<float>(0x180); } }
			public float x184 { get { return Read<float>(0x184); } }
			public float x188 { get { return Read<float>(0x188); } }
			public float x18C { get { return Read<float>(0x18C); } }
			public float x190 { get { return Read<float>(0x190); } }
			public float x194 { get { return Read<float>(0x194); } }
			public float x198 { get { return Read<float>(0x198); } }
			public float x19C { get { return Read<float>(0x19C); } }
			public float x1A0 { get { return Read<float>(0x1A0); } }
			public int x1A4 { get { return Read<int>(0x1A4); } }
			public int x1A8 { get { return Read<int>(0x1A8); } }
			public int x1AC { get { return Read<int>(0x1AC); } }
			public float x1B0 { get { return Read<float>(0x1B0); } }
			public float x1B4 { get { return Read<float>(0x1B4); } }
			public float x1B8 { get { return Read<float>(0x1B8); } }
			public float x1BC { get { return Read<float>(0x1BC); } }
			public float x1C0 { get { return Read<float>(0x1C0); } }
			public float x1C4 { get { return Read<float>(0x1C4); } }
			public float x1C8 { get { return Read<float>(0x1C8); } }
			public int x1CC { get { return Read<int>(0x1CC); } }
			public float x1D0 { get { return Read<float>(0x1D0); } }
			public int x1D4 { get { return Read<int>(0x1D4); } }
			public int x1D8 { get { return Read<int>(0x1D8); } }
			public int x1DC { get { return Read<int>(0x1DC); } }
			public int x1E0 { get { return Read<int>(0x1E0); } }
			public int x1E4 { get { return Read<int>(0x1E4); } }
			public int x1E8 { get { return Read<int>(0x1E8); } }
			public int x1EC { get { return Read<int>(0x1EC); } }
			public int x1F0 { get { return Read<int>(0x1F0); } }
			public int x1F4 { get { return Read<int>(0x1F4); } }
			public float x1F8 { get { return Read<float>(0x1F8); } }
			public float x1FC { get { return Read<float>(0x1FC); } }
			public float[] x200_float { get { return Read<float>(0x200, 10); } }
			public float x228 { get { return Read<float>(0x228); } }
			public float x22C { get { return Read<float>(0x22C); } }
			public int x230 { get { return Read<int>(0x230); } }
			public int x234 { get { return Read<int>(0x234); } }
			public int x238 { get { return Read<int>(0x238); } }
			public float x23C { get { return Read<float>(0x23C); } }
			public int x240 { get { return Read<int>(0x240); } }
			public float x244 { get { return Read<float>(0x244); } }
			public float x248 { get { return Read<float>(0x248); } }
			public float x24C { get { return Read<float>(0x24C); } }
			public float x250 { get { return Read<float>(0x250); } }
			public float x254 { get { return Read<float>(0x254); } }
			public float x258 { get { return Read<float>(0x258); } }
			public float x25C { get { return Read<float>(0x25C); } }
			public float x260 { get { return Read<float>(0x260); } }
			public float x264 { get { return Read<float>(0x264); } }
			public float x268 { get { return Read<float>(0x268); } }
			public float[] x26C_float { get { return Read<float>(0x26C, 2); } }
			public float x274 { get { return Read<float>(0x274); } }
			public float x278 { get { return Read<float>(0x278); } }
			public float x27C { get { return Read<float>(0x27C); } }
			public float x280 { get { return Read<float>(0x280); } }
			public float x284 { get { return Read<float>(0x284); } }
			public float x288 { get { return Read<float>(0x288); } }
			public float x28C { get { return Read<float>(0x28C); } }
			public int x290 { get { return Read<int>(0x290); } }
			public int x294 { get { return Read<int>(0x294); } }
			public int x298 { get { return Read<int>(0x298); } }
			public float x29C { get { return Read<float>(0x29C); } }
			public float x2A0 { get { return Read<float>(0x2A0); } }
			public float x2A4 { get { return Read<float>(0x2A4); } }
		}
		
		[CompilerGenerated]
		public partial class StartLocationName : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x44; // 68
			
			public int x00 { get { return Read<int>(0x00); } }
			public string x04_Text { get { return ReadString(0x04, 64); } }
		}
		
		[CompilerGenerated]
		public partial class BannerParams : SerializeMemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0xE8; // 232
			
			public BannerTexturePair[] x00_BannerTexturePairs { get { return Deserialize<BannerTexturePair>(x08_SerializeData); } }
			public SerializeData x08_SerializeData { get { return Read<SerializeData>(0x08); } }
			public int x10 { get { return Read<int>(0x10); } }
			public BannerTexturePair[] x18_BannerTexturePairs { get { return Deserialize<BannerTexturePair>(x20_SerializeData); } }
			public SerializeData x20_SerializeData { get { return Read<SerializeData>(0x20); } }
			public int x28 { get { return Read<int>(0x28); } }
			public BannerTexturePair[] x30_BannerTexturePairs { get { return Deserialize<BannerTexturePair>(x38_SerializeData); } }
			public SerializeData x38_SerializeData { get { return Read<SerializeData>(0x38); } }
			public BannerTexturePair[] x40_BannerTexturePairs { get { return Deserialize<BannerTexturePair>(x48_SerializeData); } }
			public SerializeData x48_SerializeData { get { return Read<SerializeData>(0x48); } }
			public int x50 { get { return Read<int>(0x50); } }
			public BannerTexturePair[] x58_BannerTexturePairs { get { return Deserialize<BannerTexturePair>(x60_SerializeData); } }
			public SerializeData x60_SerializeData { get { return Read<SerializeData>(0x60); } }
			public int x68 { get { return Read<int>(0x68); } }
			public BannerColorSet[] x70_BannerColorSets { get { return Deserialize<BannerColorSet>(x78_SerializeData); } }
			public SerializeData x78_SerializeData { get { return Read<SerializeData>(0x78); } }
			public BannerSigilPlacement[] x80_BannerSigilPlacements { get { return Deserialize<BannerSigilPlacement>(x88_SerializeData); } }
			public SerializeData x88_SerializeData { get { return Read<SerializeData>(0x88); } }
			public Sno[] x90_Snos { get { return Deserialize<Sno>(x98_SerializeData); } }
			public SerializeData x98_SerializeData { get { return Read<SerializeData>(0x98); } }
			public Sno[] xA0_Snos { get { return Deserialize<Sno>(xA8_SerializeData); } }
			public SerializeData xA8_SerializeData { get { return Read<SerializeData>(0xA8); } }
			public Sno[] xB0_Snos { get { return Deserialize<Sno>(xB8_SerializeData); } }
			public SerializeData xB8_SerializeData { get { return Read<SerializeData>(0xB8); } }
			public Sno[] xC0_Snos { get { return Deserialize<Sno>(xC8_SerializeData); } }
			public SerializeData xC8_SerializeData { get { return Read<SerializeData>(0xC8); } }
			public EpicBannerDescription[] xD0_EpicBannerDescriptions { get { return Deserialize<EpicBannerDescription>(xD8_SerializeData); } }
			public SerializeData xD8_SerializeData { get { return Read<SerializeData>(0xD8); } }
		}
		
		[CompilerGenerated]
		public partial class AssetList : SerializeMemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x10; // 16
			
			public AssetListEntry[] x00_AssetListEntries { get { return Deserialize<AssetListEntry>(x08_SerializeData); } }
			public SerializeData x08_SerializeData { get { return Read<SerializeData>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class ActorGroup : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x44; // 68
			
			public int x00 { get { return Read<int>(0x00); } }
			public string x04_Text { get { return ReadString(0x04, 64); } }
		}
		
		[CompilerGenerated]
		public partial class GlobalScriptVariable : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x28; // 40
			
			public int x00 { get { return Read<int>(0x00); } }
			public string x04_Text { get { return ReadString(0x04, 32); } }
			public float x24 { get { return Read<float>(0x24); } }
		}
		
		[CompilerGenerated]
		public partial class DifficultyTuningParams : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x34; // 52
			
			public float x00 { get { return Read<float>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
			public float x08 { get { return Read<float>(0x08); } }
			public float x0C { get { return Read<float>(0x0C); } }
			public float x10 { get { return Read<float>(0x10); } }
			public float x14 { get { return Read<float>(0x14); } }
			public float x18 { get { return Read<float>(0x18); } }
			public float x1C { get { return Read<float>(0x1C); } }
			public float x20 { get { return Read<float>(0x20); } }
			public float x24 { get { return Read<float>(0x24); } }
			public float x28 { get { return Read<float>(0x28); } }
			public float x2C { get { return Read<float>(0x2C); } }
			public float x30 { get { return Read<float>(0x30); } }
		}
		
		[CompilerGenerated]
		public partial class BannerTexturePair : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x10; // 16
			
			public Sno x00_TexturesSno { get { return Read<Sno>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class BannerColorSet : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x54; // 84
			
			public RGBAColor[] x00_RGBAColors { get { return Read<RGBAColor>(0x00, 2); } }
			public string x08_Text { get { return ReadString(0x08, 64); } }
			public int x48 { get { return Read<int>(0x48); } }
			public int x4C { get { return Read<int>(0x4C); } }
		}
		
		[CompilerGenerated]
		public partial class BannerSigilPlacement : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x44; // 68
			
			public string x00_Text { get { return ReadString(0x00, 64); } }
			public int x40 { get { return Read<int>(0x40); } }
		}
		
		[CompilerGenerated]
		public partial class EpicBannerDescription : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x94; // 148
			
			public Sno x00_TexturesSno { get { return Read<Sno>(0x00); } }
			public Sno x04_ActorSno { get { return Read<Sno>(0x04); } }
			public Sno x08_ActorSno { get { return Read<Sno>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public string x10_Text { get { return ReadString(0x10, 128); } }
		}
		
		[CompilerGenerated]
		public partial class AssetListEntry : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x08; // 8
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class RGBAColor : MemoryObject
		{
			// 2.1.1.27255
			public const int SizeOf = 0x04; // 4
			
			public byte x00 { get { return Read<byte>(0x00); } }
			public byte x01 { get { return Read<byte>(0x01); } }
			public byte x02 { get { return Read<byte>(0x02); } }
			public byte x03 { get { return Read<byte>(0x03); } }
		}
	}
}
