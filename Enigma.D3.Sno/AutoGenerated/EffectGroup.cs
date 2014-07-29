using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class EffectGroup : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x78; // 120
		
		public int x0C { get { return Field<int>(0x0C); } }
		public SerializeData x10_SerializeData { get { return Field<SerializeData>(0x10); } }
		public int x18 { get { return Field<int>(0x18); } }
		public EffectItem[] x20_EffectItems { get { return Deserialize<EffectItem>(x10_SerializeData); } }
		public int x28 { get { return Field<int>(0x28); } }
		public int x2C { get { return Field<int>(0x2C); } }
		public int x30 { get { return Field<int>(0x30); } }
		public Sno x34_PowerSno { get { return Field<Sno>(0x34); } }
		public int[] x38_int { get { return Field<int>(0x38, 16); } }
		
		[CompilerGenerated]
		public partial class EffectItem : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x1E0; // 480
			
			public int x000 { get { return Field<int>(0x000); } }
			public string x004_Text { get { return Field(0x004, 64); } }
			public MsgTriggeredEvent x044_MsgTriggeredEvent { get { return Field<MsgTriggeredEvent>(0x044); } }
		}
		
		[CompilerGenerated]
		public partial class MsgTriggeredEvent : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x19C; // 412
			
			public int x000 { get { return Field<int>(0x000); } }
			public TriggerEvent x004_TriggerEvent { get { return Field<TriggerEvent>(0x004); } }
		}
		
		[CompilerGenerated]
		public partial class TriggerEvent : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x198; // 408
			
			public int x000 { get { return Field<int>(0x000); } }
			public TriggerConditions x004_TriggerConditions { get { return Field<TriggerConditions>(0x004); } }
			public int x028 { get { return Field<int>(0x028); } }
			public SNOName x02C_SNOName { get { return Field<SNOName>(0x02C); } }
			public int x034 { get { return Field<int>(0x034); } }
			public int x038 { get { return Field<int>(0x038); } }
			public int x03C { get { return Field<int>(0x03C); } }
			public int x040 { get { return Field<int>(0x040); } }
			public HardpointLink[] x044_HardpointLinks { get { return Field<HardpointLink>(0x044, 2); } }
			public LookLink x0CC_LookLink { get { return Field<LookLink>(0x0CC); } }
			public ConstraintLink x10C_ConstraintLink { get { return Field<ConstraintLink>(0x10C); } }
			public int x14C { get { return Field<int>(0x14C); } }
			public float x150 { get { return Field<float>(0x150); } }
			public int x154 { get { return Field<int>(0x154); } }
			public int x158 { get { return Field<int>(0x158); } }
			public int x15C { get { return Field<int>(0x15C); } }
			public int x160 { get { return Field<int>(0x160); } }
			public int x164 { get { return Field<int>(0x164); } }
			public float x168 { get { return Field<float>(0x168); } }
			public float x16C { get { return Field<float>(0x16C); } }
			public int x170 { get { return Field<int>(0x170); } }
			public float x174 { get { return Field<float>(0x174); } }
			public int x178 { get { return Field<int>(0x178); } }
			public Velocity x17C_Velocity { get { return Field<Velocity>(0x17C); } }
			public int x180 { get { return Field<int>(0x180); } }
			public Time x184_Time { get { return Field<Time>(0x184); } }
			public RGBAColor x188_RGBAColor { get { return Field<RGBAColor>(0x188); } }
			public Time x18C_Time { get { return Field<Time>(0x18C); } }
			public RGBAColor x190_RGBAColor { get { return Field<RGBAColor>(0x190); } }
			public Time x194_Time { get { return Field<Time>(0x194); } }
		}
		
		[CompilerGenerated]
		public partial class TriggerConditions : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x24; // 36
			
			public Percent x00_Percent { get { return Field<Percent>(0x00); } }
			public Time x04_Time { get { return Field<Time>(0x04); } }
			public Time x08_Time { get { return Field<Time>(0x08); } }
			public Time x0C_Time { get { return Field<Time>(0x0C); } }
			public Time x10_Time { get { return Field<Time>(0x10); } }
			public Impulse x14_Impulse { get { return Field<Impulse>(0x14); } }
			public Impulse x18_Impulse { get { return Field<Impulse>(0x18); } }
			public int x1C { get { return Field<int>(0x1C); } }
			public int x20 { get { return Field<int>(0x20); } }
		}
		
		[CompilerGenerated]
		public partial class SNOName : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x8; // 8
			
			public SnoGroup x00_SnoGroup { get { return Field<SnoGroup>(0x00); } }
			public SnoNameHandle x04_SnoNameHandle { get { return Field<SnoNameHandle>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class HardpointLink : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x44; // 68
			
			public string x00_Text { get { return Field(0x00, 64); } }
			public int x40 { get { return Field<int>(0x40); } }
		}
		
		[CompilerGenerated]
		public partial class LookLink : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x40; // 64
			
			public string x00_Text { get { return Field(0x00, 64); } }
		}
		
		[CompilerGenerated]
		public partial class ConstraintLink : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x40; // 64
			
			public string x00_Text { get { return Field(0x00, 64); } }
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
