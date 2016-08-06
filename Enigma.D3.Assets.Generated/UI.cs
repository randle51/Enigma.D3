using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class UI : SerializeMemoryObject
	{
		public const int SizeOf = 0xB8; // 184
		
		public SNOHeader x00_Header { get { return Read<SNOHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public int x10 { get { return Read<int>(0x10); } }
		public SerializeData x14_SerializeData { get { return Read<SerializeData>(0x14); } }
		public UIControlData[] x20_UIControlData { get { return Deserialize<UIControlData>(x14_SerializeData); } }
		public int x28 { get { return Read<int>(0x28); } }
		public SerializeData x2C_SerializeData { get { return Read<SerializeData>(0x2C); } }
		public UIStyle[] x38_UIStyles { get { return Deserialize<UIStyle>(x2C_SerializeData); } }
		public DataElements x40_DataElements { get { return Read<DataElements>(0x40); } }
		
		[CompilerGenerated]
		public partial class UIControlData : SerializeMemoryObject
		{
			public const int SizeOf = 0x740; // 1856
			
			public int x000 { get { return Read<int>(0x000); } }
			public long x008 { get { return Read<long>(0x008); } }
			public string x010_Text { get { return ReadString(0x010, 512); } }
			public long x210 { get { return Read<long>(0x210); } }
			public string x218_Text { get { return ReadString(0x218, 512); } }
			public int x418 { get { return Read<int>(0x418); } }
			public UIStyle x420_UIStyle { get { return Read<UIStyle>(0x420); } }
			public UIAnimationElements x6B0_UIAnimationElements { get { return Read<UIAnimationElements>(0x6B0); } }
		}
		
		[CompilerGenerated]
		public partial class UIStyle : SerializeMemoryObject
		{
			public const int SizeOf = 0x290; // 656
			
			public long x000 { get { return Read<long>(0x000); } }
			public string x008_Text { get { return ReadString(0x008, 512); } }
			public DataElements x208_DataElements { get { return Read<DataElements>(0x208); } }
			public int x250 { get { return Read<int>(0x250); } }
			public SerializeData x254_SerializeData { get { return Read<SerializeData>(0x254); } }
			public UIStyleChildSpec[] x260_UIStyleChildSpecs { get { return Deserialize<UIStyleChildSpec>(x254_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class DataElements : SerializeMemoryObject
		{
			public const int SizeOf = 0x48; // 72
			
			public int x00 { get { return Read<int>(0x00); } }
			public SerializeData x04_SerializeData { get { return Read<SerializeData>(0x04); } }
			public UIControlElement[] x10_UIControlElements { get { return Deserialize<UIControlElement>(x04_SerializeData); } }
			public int x18 { get { return Read<int>(0x18); } }
			public SerializeData x1C_SerializeData { get { return Read<SerializeData>(0x1C); } }
			public UIDataElementInt32[] x28_UIDataElementInt32s { get { return Deserialize<UIDataElementInt32>(x1C_SerializeData); } }
			public int x30 { get { return Read<int>(0x30); } }
			public SerializeData x34_SerializeData { get { return Read<SerializeData>(0x34); } }
			public UIDataElementFloat32[] x40_UIDataElementFloat32s { get { return Deserialize<UIDataElementFloat32>(x34_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class UIAnimationElements : SerializeMemoryObject
		{
			public const int SizeOf = 0x78; // 120
			
			public int x00 { get { return Read<int>(0x00); } }
			public SerializeData x04_SerializeData { get { return Read<SerializeData>(0x04); } }
			public UIAnimationElementInt32[] x10_UIAnimationElementInt32s { get { return Deserialize<UIAnimationElementInt32>(x04_SerializeData); } }
			public int x18 { get { return Read<int>(0x18); } }
			public SerializeData x1C_SerializeData { get { return Read<SerializeData>(0x1C); } }
			public UIAnimationElementFloat[] x28_UIAnimationElementFloats { get { return Deserialize<UIAnimationElementFloat>(x1C_SerializeData); } }
			public int x30 { get { return Read<int>(0x30); } }
			public SerializeData x34_SerializeData { get { return Read<SerializeData>(0x34); } }
			public UIAnimationElementVector2D[] x40_UIAnimationElementVector2Ds { get { return Deserialize<UIAnimationElementVector2D>(x34_SerializeData); } }
			public int x48 { get { return Read<int>(0x48); } }
			public SerializeData x4C_SerializeData { get { return Read<SerializeData>(0x4C); } }
			public UIAnimationDescription[] x58_UIAnimationDescriptions { get { return Deserialize<UIAnimationDescription>(x4C_SerializeData); } }
			public int x60 { get { return Read<int>(0x60); } }
			public SerializeData x64_SerializeData { get { return Read<SerializeData>(0x64); } }
			public UIControlAnimationBinding[] x70_UIControlAnimationBindings { get { return Deserialize<UIControlAnimationBinding>(x64_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class UIStyleChildSpec : SerializeMemoryObject
		{
			public const int SizeOf = 0x260; // 608
			
			public string x000_Text { get { return ReadString(0x000, 512); } }
			public DataElements x200_DataElements { get { return Read<DataElements>(0x200); } }
		}
		
		[CompilerGenerated]
		public partial class UIControlElement : MemoryObject
		{
			public const int SizeOf = 0x108; // 264
			
			public long x000 { get { return Read<long>(0x000); } }
			public string x008_Text { get { return ReadString(0x008, 256); } }
		}
		
		[CompilerGenerated]
		public partial class UIDataElementInt32 : MemoryObject
		{
			public const int SizeOf = 0x10; // 16
			
			public long x00 { get { return Read<long>(0x00); } }
			public int x08 { get { return Read<int>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class UIDataElementFloat32 : MemoryObject
		{
			public const int SizeOf = 0x10; // 16
			
			public long x00 { get { return Read<long>(0x00); } }
			public float x08 { get { return Read<float>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class UIAnimationElementInt32 : MemoryObject
		{
			public const int SizeOf = 0x08; // 8
			
			public float x00 { get { return Read<float>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class UIAnimationElementFloat : MemoryObject
		{
			public const int SizeOf = 0x08; // 8
			
			public float x00 { get { return Read<float>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class UIAnimationElementVector2D : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public float x00 { get { return Read<float>(0x00); } }
			public float[] x04_float { get { return Read<float>(0x04, 2); } }
		}
		
		[CompilerGenerated]
		public partial class UIAnimationDescription : MemoryObject
		{
			public const int SizeOf = 0x218; // 536
			
			public long x000 { get { return Read<long>(0x000); } }
			public string x008_Text { get { return ReadString(0x008, 512); } }
			public int x208 { get { return Read<int>(0x208); } }
			public int[] x20C_int { get { return Read<int>(0x20C, 2); } }
		}
		
		[CompilerGenerated]
		public partial class UIControlAnimationBinding : MemoryObject
		{
			public const int SizeOf = 0x208; // 520
			
			public string x000_Text { get { return ReadString(0x000, 512); } }
			public int x200 { get { return Read<int>(0x200); } }
			public float x204 { get { return Read<float>(0x204); } }
		}
	}
}
