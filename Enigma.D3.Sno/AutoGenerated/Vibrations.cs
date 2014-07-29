using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Vibrations : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x88; // 136
		
		public int x0C { get { return Field<int>(0x0C); } }
		public Time x10_Time { get { return Field<Time>(0x10); } }
		public Time x14_Time { get { return Field<Time>(0x14); } }
		public float x18 { get { return Field<float>(0x18); } }
		public float x1C { get { return Field<float>(0x1C); } }
		public float x20 { get { return Field<float>(0x20); } }
		public FloatPath x28_FloatPath { get { return Field<FloatPath>(0x28); } }
		public FloatPath x58_FloatPath { get { return Field<FloatPath>(0x58); } }
		
		[CompilerGenerated]
		public partial class FloatPath : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x30; // 48
			
			public InterpolationPathHeader x00_InterpolationPathHeader { get { return Field<InterpolationPathHeader>(0x00); } }
			public FloatNode[] x20_FloatNodes { get { return Deserialize<FloatNode>(x28_SerializeData); } }
			public SerializeData x28_SerializeData { get { return Field<SerializeData>(0x28); } }
		}
		
		[CompilerGenerated]
		public partial class InterpolationPathHeader : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x1C; // 28
			
			public int x00 { get { return Field<int>(0x00); } }
			public float x04 { get { return Field<float>(0x04); } }
			public float x08 { get { return Field<float>(0x08); } }
			public int x0C { get { return Field<int>(0x0C); } }
			public InterpolationScalar x10_InterpolationScalar { get { return Field<InterpolationScalar>(0x10); } }
		}
		
		[CompilerGenerated]
		public partial class FloatNode : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0xC; // 12
			
			public float x00 { get { return Field<float>(0x00); } }
			public float x04 { get { return Field<float>(0x04); } }
			public float x08 { get { return Field<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class InterpolationScalar : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0xC; // 12
			
			public int x00 { get { return Field<int>(0x00); } }
			public float x04 { get { return Field<float>(0x04); } }
			public float x08 { get { return Field<float>(0x08); } }
		}
	}
}
