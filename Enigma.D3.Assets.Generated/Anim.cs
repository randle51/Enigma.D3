using System.Runtime.CompilerServices;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	[CompilerGenerated]
	public partial class Anim : SerializeMemoryObject
	{
		public const int SizeOf = 0x38; // 56
		
		public SNOHeader x00_Header { get { return Read<SNOHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public int x10 { get { return Read<int>(0x10); } }
		public SNO x14_AppearanceSNO { get { return Read<SNO>(0x14); } }
		public SerializeData x18_SerializeData { get { return Read<SerializeData>(0x18); } }
		public int x20 { get { return Read<int>(0x20); } }
		public AnimPermutation[] x28_AnimPermutations { get { return Deserialize<AnimPermutation>(x18_SerializeData); } }
		public int x30 { get { return Read<int>(0x30); } }
		
		[CompilerGenerated]
		public partial class AnimPermutation : SerializeMemoryObject
		{
			public const int SizeOf = 0x198; // 408
			
			public int x000 { get { return Read<int>(0x000); } }
			public string x004_Text { get { return ReadString(0x004, 68); } }
			public Velocity x048_Velocity { get { return Read<Velocity>(0x048); } }
			public float x04C { get { return Read<float>(0x04C); } }
			public float x050 { get { return Read<float>(0x050); } }
			public float x054 { get { return Read<float>(0x054); } }
			public float x058 { get { return Read<float>(0x058); } }
			public Time x05C_Time { get { return Read<Time>(0x05C); } }
			public Time x060_Time { get { return Read<Time>(0x060); } }
			public int x064 { get { return Read<int>(0x064); } }
			public float x068 { get { return Read<float>(0x068); } }
			public float x06C { get { return Read<float>(0x06C); } }
			public float x070 { get { return Read<float>(0x070); } }
			public float x074 { get { return Read<float>(0x074); } }
			public int x078 { get { return Read<int>(0x078); } }
			public SerializeData x07C_SerializeData { get { return Read<SerializeData>(0x07C); } }
			public BoneName[] x088_BoneNames { get { return Deserialize<BoneName>(x07C_SerializeData); } }
			public int x090 { get { return Read<int>(0x090); } }
			public SerializeData x094_SerializeData { get { return Read<SerializeData>(0x094); } }
			public TranslationCurve[] x0A0_TranslationCurves { get { return Deserialize<TranslationCurve>(x094_SerializeData); } }
			public SerializeData x0A8_SerializeData { get { return Read<SerializeData>(0x0A8); } }
			public RotationCurve[] x0B0_RotationCurves { get { return Deserialize<RotationCurve>(x0A8_SerializeData); } }
			public SerializeData x0B8_SerializeData { get { return Read<SerializeData>(0x0B8); } }
			public ScaleCurve[] x0C0_ScaleCurves { get { return Deserialize<ScaleCurve>(x0B8_SerializeData); } }
			public float x0C8 { get { return Read<float>(0x0C8); } }
			public float x0CC { get { return Read<float>(0x0CC); } }
			public float x0D0 { get { return Read<float>(0x0D0); } }
			public float x0D4 { get { return Read<float>(0x0D4); } }
			public Vector3 x0D8 { get { return Read<Vector3>(0x0D8); } }
			public Vector3 x0E4 { get { return Read<Vector3>(0x0E4); } }
			public Vector3 x0F0 { get { return Read<Vector3>(0x0F0); } }
			public Vector3 x0FC { get { return Read<Vector3>(0x0FC); } }
			public float x108 { get { return Read<float>(0x108); } }
			public SerializeData x10C_SerializeData { get { return Read<SerializeData>(0x10C); } }
			public int x114 { get { return Read<int>(0x114); } }
			public KeyframedAttachment[] x118_KeyframedAttachments { get { return Deserialize<KeyframedAttachment>(x10C_SerializeData); } }
			public SerializeData x120_SerializeData { get { return Read<SerializeData>(0x120); } }
			public Vector3[] x128_Vector3 { get { return Deserialize<Vector3>(x120_SerializeData); } }
			public SerializeData x130_SerializeData { get { return Read<SerializeData>(0x130); } }
			public Vector3[] x138_Vector3 { get { return Deserialize<Vector3>(x130_SerializeData); } }
			public VelocityVector3D x140_VelocityVector3D { get { return Read<VelocityVector3D>(0x140); } }
			public HardpointLink x14C_HardpointLink { get { return Read<HardpointLink>(0x14C); } }
		}
		
		[CompilerGenerated]
		public partial class BoneName : MemoryObject
		{
			public const int SizeOf = 0x40; // 64
			
			public string x00_Text { get { return ReadString(0x00, 64); } }
		}
		
		[CompilerGenerated]
		public partial class TranslationCurve : SerializeMemoryObject
		{
			public const int SizeOf = 0x18; // 24
			
			public int x00 { get { return Read<int>(0x00); } }
			public SerializeData x04_SerializeData { get { return Read<SerializeData>(0x04); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public TranslationKey[] x10_TranslationKeies { get { return Deserialize<TranslationKey>(x04_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class RotationCurve : SerializeMemoryObject
		{
			public const int SizeOf = 0x18; // 24
			
			public int x00 { get { return Read<int>(0x00); } }
			public SerializeData x04_SerializeData { get { return Read<SerializeData>(0x04); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public RotationKey[] x10_RotationKeies { get { return Deserialize<RotationKey>(x04_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class ScaleCurve : SerializeMemoryObject
		{
			public const int SizeOf = 0x18; // 24
			
			public int x00 { get { return Read<int>(0x00); } }
			public SerializeData x04_SerializeData { get { return Read<SerializeData>(0x04); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public ScaleKey[] x10_ScaleKeies { get { return Deserialize<ScaleKey>(x04_SerializeData); } }
		}
		
		[CompilerGenerated]
		public partial class KeyframedAttachment : MemoryObject
		{
			public const int SizeOf = 0x19C; // 412
			
			public float x000 { get { return Read<float>(0x000); } }
			public TriggerEvent x004_TriggerEvent { get { return Read<TriggerEvent>(0x004); } }
		}
		
		[CompilerGenerated]
		public partial class VelocityVector3D : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public Velocity x00_Velocity { get { return Read<Velocity>(0x00); } }
			public Velocity x04_Velocity { get { return Read<Velocity>(0x04); } }
			public Velocity x08_Velocity { get { return Read<Velocity>(0x08); } }
		}
		
		[CompilerGenerated]
		public partial class HardpointLink : MemoryObject
		{
			public const int SizeOf = 0x44; // 68
			
			public string x00_Text { get { return ReadString(0x00, 64); } }
			public int x40 { get { return Read<int>(0x40); } }
		}
		
		[CompilerGenerated]
		public partial class TranslationKey : MemoryObject
		{
			public const int SizeOf = 0x10; // 16
			
			public int x00 { get { return Read<int>(0x00); } }
			public Vector3 x04 { get { return Read<Vector3>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class RotationKey : MemoryObject
		{
			public const int SizeOf = 0x0C; // 12
			
			public int x00 { get { return Read<int>(0x00); } }
			public QuaternionI x04 { get { return Read<QuaternionI>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class ScaleKey : MemoryObject
		{
			public const int SizeOf = 0x08; // 8
			
			public int x00 { get { return Read<int>(0x00); } }
			public float x04 { get { return Read<float>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class TriggerEvent : MemoryObject
		{
			public const int SizeOf = 0x198; // 408
			
			public int x000 { get { return Read<int>(0x000); } }
			public TriggerConditions x004_TriggerConditions { get { return Read<TriggerConditions>(0x004); } }
			public int x028 { get { return Read<int>(0x028); } }
			public SNOName x02C { get { return Read<SNOName>(0x02C); } }
			public int x034 { get { return Read<int>(0x034); } }
			public int x038 { get { return Read<int>(0x038); } }
			public int x03C { get { return Read<int>(0x03C); } }
			public int x040 { get { return Read<int>(0x040); } }
			public HardpointLink[] x044_HardpointLinks { get { return Read<HardpointLink>(0x044, 2); } }
			public LookLink x0CC_LookLink { get { return Read<LookLink>(0x0CC); } }
			public ConstraintLink x10C_ConstraintLink { get { return Read<ConstraintLink>(0x10C); } }
			public int x14C { get { return Read<int>(0x14C); } }
			public float x150 { get { return Read<float>(0x150); } }
			public int x154 { get { return Read<int>(0x154); } }
			public int x158 { get { return Read<int>(0x158); } }
			public int x15C { get { return Read<int>(0x15C); } }
			public int x160 { get { return Read<int>(0x160); } }
			public int x164 { get { return Read<int>(0x164); } }
			public float x168 { get { return Read<float>(0x168); } }
			public float x16C { get { return Read<float>(0x16C); } }
			public int x170 { get { return Read<int>(0x170); } }
			public float x174 { get { return Read<float>(0x174); } }
			public int x178 { get { return Read<int>(0x178); } }
			public Velocity x17C_Velocity { get { return Read<Velocity>(0x17C); } }
			public int x180 { get { return Read<int>(0x180); } }
			public Time x184_Time { get { return Read<Time>(0x184); } }
			public DT_RGBACOLOR x188_DT_RGBACOLOR { get { return Read<DT_RGBACOLOR>(0x188); } }
			public Time x18C_Time { get { return Read<Time>(0x18C); } }
			public DT_RGBACOLOR x190_DT_RGBACOLOR { get { return Read<DT_RGBACOLOR>(0x190); } }
			public Time x194_Time { get { return Read<Time>(0x194); } }
		}
		
		[CompilerGenerated]
		public partial class TriggerConditions : MemoryObject
		{
			public const int SizeOf = 0x24; // 36
			
			public Percent x00_Percent { get { return Read<Percent>(0x00); } }
			public Time x04_Time { get { return Read<Time>(0x04); } }
			public Time x08_Time { get { return Read<Time>(0x08); } }
			public Time x0C_Time { get { return Read<Time>(0x0C); } }
			public Time x10_Time { get { return Read<Time>(0x10); } }
			public Impulse x14_Impulse { get { return Read<Impulse>(0x14); } }
			public Impulse x18_Impulse { get { return Read<Impulse>(0x18); } }
			public int x1C { get { return Read<int>(0x1C); } }
			public int x20 { get { return Read<int>(0x20); } }
		}
		
		[CompilerGenerated]
		public partial class LookLink : MemoryObject
		{
			public const int SizeOf = 0x40; // 64
			
			public string x00_Text { get { return ReadString(0x00, 64); } }
		}
		
		[CompilerGenerated]
		public partial class ConstraintLink : MemoryObject
		{
			public const int SizeOf = 0x40; // 64
			
			public string x00_Text { get { return ReadString(0x00, 64); } }
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
