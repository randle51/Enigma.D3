using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Textures : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x270; // 624
		
		public int x010 { get { return Field<int>(0x010); } }
		public int x014 { get { return Field<int>(0x014); } }
		public int x018 { get { return Field<int>(0x018); } }
		public int x01C { get { return Field<int>(0x01C); } }
		public int x020 { get { return Field<int>(0x020); } }
		public int x024 { get { return Field<int>(0x024); } }
		public SerializeData[] x028_SerializeDatas { get { return Field<SerializeData>(0x028, 60); } }
		public int x208 { get { return Field<int>(0x208); } }
		public SerializeData x20C_SerializeData { get { return Field<SerializeData>(0x20C); } }
		public TexFrame[] x218_TexFrames { get { return Deserialize<TexFrame>(x20C_SerializeData); } }
		public IVector2D x220_IVector2D { get { return Field<IVector2D>(0x220); } }
		public int x228 { get { return Field<int>(0x228); } }
		public int x22C { get { return Field<int>(0x22C); } }
		public int x230 { get { return Field<int>(0x230); } }
		public int x234 { get { return Field<int>(0x234); } }
		public long x238 { get { return Field<long>(0x238); } }
		public int x240 { get { return Field<int>(0x240); } }
		public int x248 { get { return Field<int>(0x248); } }
		public int x24C { get { return Field<int>(0x24C); } }
		public ImageFileID[] x250_ImageFileIDs { get { return Deserialize<ImageFileID>(x258_SerializeData); } }
		public SerializeData x258_SerializeData { get { return Field<SerializeData>(0x258); } }
		public int x260 { get { return Field<int>(0x260); } }
		public int x264 { get { return Field<int>(0x264); } }
		public int x268 { get { return Field<int>(0x268); } }
		
		[CompilerGenerated]
		public partial class TexFrame : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x50; // 80
			
			public string x00_Text { get { return Field(0x00, 64); } }
			public float x40 { get { return Field<float>(0x40); } }
			public float x44 { get { return Field<float>(0x44); } }
			public float x48 { get { return Field<float>(0x48); } }
			public float x4C { get { return Field<float>(0x4C); } }
		}
		
		[CompilerGenerated]
		public partial class IVector2D : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x8; // 8
			
			public int x00 { get { return Field<int>(0x00); } }
			public int x04 { get { return Field<int>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class ImageFileID : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x4; // 4
			
			public int x00 { get { return Field<int>(0x00); } }
		}
	}
}
