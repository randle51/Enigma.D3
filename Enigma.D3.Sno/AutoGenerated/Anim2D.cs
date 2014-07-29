using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Anim2D : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x40; // 64
		
		public int x0C { get { return Field<int>(0x0C); } }
		public int x10 { get { return Field<int>(0x10); } }
		public FrameAnim x14_FrameAnim { get { return Field<FrameAnim>(0x14); } }
		public Sno x28_SoundSno { get { return Field<Sno>(0x28); } }
		public int x2C { get { return Field<int>(0x2C); } }
		public SerializeData x30_SerializeData { get { return Field<SerializeData>(0x30); } }
		public Anim2DFrame[] x38_Anim2DFrames { get { return Deserialize<Anim2DFrame>(x30_SerializeData); } }
		
		[CompilerGenerated]
		public partial class FrameAnim : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x14; // 20
			
			public int x00 { get { return Field<int>(0x00); } }
			public Velocity x04_Velocity { get { return Field<Velocity>(0x04); } }
			public Velocity x08_Velocity { get { return Field<Velocity>(0x08); } }
			public int x0C { get { return Field<int>(0x0C); } }
			public int x10 { get { return Field<int>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class Anim2DFrame : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x44; // 68
			
			public string x00_Text { get { return Field(0x00, 64); } }
			public RGBAColor x40_RGBAColor { get { return Field<RGBAColor>(0x40); } }
		}
		
		[CompilerGenerated]
		public partial class RGBAColor : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x4; // 4
			
			public byte x00 { get { return Field<byte>(0x00); } }
			public byte x01 { get { return Field<byte>(0x01); } }
			public byte x02 { get { return Field<byte>(0x02); } }
			public byte x03 { get { return Field<byte>(0x03); } }
		}
	}
}
