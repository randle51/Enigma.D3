using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Textures : SerializeMemoryObject
	{
		// 2.1.0.26451
		public const int SizeOf = 0x270; // 624
		
		public int x010 { get { return Read<int>(0x010); } }
		public int x014 { get { return Read<int>(0x014); } }
		public int x018 { get { return Read<int>(0x018); } }
		public int x01C { get { return Read<int>(0x01C); } }
		public int x020 { get { return Read<int>(0x020); } }
		public int x024 { get { return Read<int>(0x024); } }
		public SerializeData[] x028_SerializeDatas { get { return Read<SerializeData>(0x028, 60); } }
		public int x208 { get { return Read<int>(0x208); } }
		public SerializeData x20C_SerializeData { get { return Read<SerializeData>(0x20C); } }
		public TexFrame[] x218_TexFrames { get { return Deserialize<TexFrame>(x20C_SerializeData); } }
		public IVector2D x220_IVector2D { get { return Read<IVector2D>(0x220); } }
		public int x228 { get { return Read<int>(0x228); } }
		public int x22C { get { return Read<int>(0x22C); } }
		public int x230 { get { return Read<int>(0x230); } }
		public int x234 { get { return Read<int>(0x234); } }
		public long x238 { get { return Read<long>(0x238); } }
		public int x240 { get { return Read<int>(0x240); } }
		public int x248 { get { return Read<int>(0x248); } }
		public int x24C { get { return Read<int>(0x24C); } }
		public ImageFileID[] x250_ImageFileIDs { get { return Deserialize<ImageFileID>(x258_SerializeData); } }
		public SerializeData x258_SerializeData { get { return Read<SerializeData>(0x258); } }
		public int x260 { get { return Read<int>(0x260); } }
		public int x264 { get { return Read<int>(0x264); } }
		public int x268 { get { return Read<int>(0x268); } }
		
		[CompilerGenerated]
		public partial class TexFrame : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x50; // 80
			
			public string x00_Text { get { return ReadString(0x00, 64); } }
			public float x40 { get { return Read<float>(0x40); } }
			public float x44 { get { return Read<float>(0x44); } }
			public float x48 { get { return Read<float>(0x48); } }
			public float x4C { get { return Read<float>(0x4C); } }
		}
		
		[CompilerGenerated]
		public partial class IVector2D : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x08; // 8
			
			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class ImageFileID : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x04; // 4
			
			public int x00 { get { return Read<int>(0x00); } }
		}
	}
}
