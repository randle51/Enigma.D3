using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class Shaders : SerializeMemoryObject
	{
		public const int SizeOf = 0x128; // 296
		
		public SNOHeader x000_Header { get { return Read<SNOHeader>(0x000); } }
		public int x00C { get { return Read<int>(0x00C); } }
		public int x010 { get { return Read<int>(0x010); } }
		public int x014 { get { return Read<int>(0x014); } }
		public SerializeData x018_SerializeData { get { return Read<SerializeData>(0x018); } }
		public RenderPass[] x020_RenderPass { get { return Deserialize<RenderPass>(x018_SerializeData); } }
		public string x028_Text { get { return ReadString(0x028, 256); } }
		
		[CompilerGenerated]
		public partial class RenderPass : SerializeMemoryObject
		{
			public const int SizeOf = 0x238; // 568
			
			public int x000 { get { return Read<int>(0x000); } }
			public int x004 { get { return Read<int>(0x004); } }
			public RenderParams x008_RenderParams { get { return Read<RenderParams>(0x008); } }
			public int x068 { get { return Read<int>(0x068); } }
			public int x06C { get { return Read<int>(0x06C); } }
			public SerializeData x070_SerializeData { get { return Read<SerializeData>(0x070); } }
			public TextureStageParams[] x078_TextureStageParams { get { return Deserialize<TextureStageParams>(x070_SerializeData); } }
			public int x080 { get { return Read<int>(0x080); } }
			public string x084_Text { get { return ReadString(0x084, 256); } }
			public string x184_Text { get { return ReadString(0x184, 64); } }
			public string x1C4_Text { get { return ReadString(0x1C4, 64); } }
			public SerializeData x204_SerializeData { get { return Read<SerializeData>(0x204); } }
			public int[] x210_TagMap { get { return Deserialize<int>(x204_SerializeData); } } // type: 0x00100000
			public int x230 { get { return Read<int>(0x230); } }
			public int x234 { get { return Read<int>(0x234); } }
		}
		
		[CompilerGenerated]
		public partial class RenderParams : MemoryObject
		{
			public const int SizeOf = 0x60; // 96
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public float x0C { get { return Read<float>(0x0C); } }
			public float x10 { get { return Read<float>(0x10); } }
			public int x14 { get { return Read<int>(0x14); } }
			public int x18 { get { return Read<int>(0x18); } }
			public int x1C { get { return Read<int>(0x1C); } }
			public int x20 { get { return Read<int>(0x20); } }
			public int x24 { get { return Read<int>(0x24); } }
			public int x28 { get { return Read<int>(0x28); } }
			public int x2C { get { return Read<int>(0x2C); } }
			public int x30 { get { return Read<int>(0x30); } }
			public byte x34 { get { return Read<byte>(0x34); } }
			public int x38 { get { return Read<int>(0x38); } }
			public int x3C { get { return Read<int>(0x3C); } }
			public int x40 { get { return Read<int>(0x40); } }
			public int x44 { get { return Read<int>(0x44); } }
			public int x48 { get { return Read<int>(0x48); } }
			public int x4C { get { return Read<int>(0x4C); } }
			public int x50 { get { return Read<int>(0x50); } }
			public int x54 { get { return Read<int>(0x54); } }
			public int x58 { get { return Read<int>(0x58); } }
			public DT_RGBACOLOR x5C_DT_RGBACOLOR { get { return Read<DT_RGBACOLOR>(0x5C); } }
		}
		
		[CompilerGenerated]
		public partial class TextureStageParams : MemoryObject
		{
			public const int SizeOf = 0x18; // 24
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public int x10 { get { return Read<int>(0x10); } }
			public float x14 { get { return Read<float>(0x14); } }
		}
		
		[CompilerGenerated]
		public partial class DT_RGBACOLOR : MemoryObject
		{
			public const int SizeOf = 0x03; // 3
			
			public byte x00 { get { return Read<byte>(0x00); } }
			public byte x01 { get { return Read<byte>(0x01); } }
			public byte x02 { get { return Read<byte>(0x02); } }
			public byte x03 { get { return Read<byte>(0x03); } }
		}
	}
}
