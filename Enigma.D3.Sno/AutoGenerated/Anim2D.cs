using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Anim2D : SerializeMemoryObject
	{
		// 2.1.2.28709
		public const int SizeOf = 0x40; // 64
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public int x10 { get { return Read<int>(0x10); } }
		public FrameAnim x14_FrameAnim { get { return Read<FrameAnim>(0x14); } }
		public Sno x28_SoundSno { get { return Read<Sno>(0x28); } }
		public int x2C { get { return Read<int>(0x2C); } }
		public SerializeData x30_SerializeData { get { return Read<SerializeData>(0x30); } }
		public Anim2DFrame[] x38_Anim2DFrames { get { return Deserialize<Anim2DFrame>(x30_SerializeData); } }
		
		[CompilerGenerated]
		public partial class FrameAnim : MemoryObject
		{
			// 2.1.2.28709
			public const int SizeOf = 0x14; // 20
			
			public int x00 { get { return Read<int>(0x00); } }
			public Velocity x04_Velocity { get { return Read<Velocity>(0x04); } }
			public Velocity x08_Velocity { get { return Read<Velocity>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public int x10 { get { return Read<int>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class Anim2DFrame : MemoryObject
		{
			// 2.1.2.28709
			public const int SizeOf = 0x44; // 68
			
			public string x00_Text { get { return ReadString(0x00, 64); } }
			public RGBAColor x40_RGBAColor { get { return Read<RGBAColor>(0x40); } }
		}
		
		[CompilerGenerated]
		public partial class RGBAColor : MemoryObject
		{
			// 2.1.2.28709
			public const int SizeOf = 0x04; // 4
			
			public byte x00 { get { return Read<byte>(0x00); } }
			public byte x01 { get { return Read<byte>(0x01); } }
			public byte x02 { get { return Read<byte>(0x02); } }
			public byte x03 { get { return Read<byte>(0x03); } }
		}
	}
}
