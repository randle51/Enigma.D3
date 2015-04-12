using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class EffectGroup : SerializeMemoryObject
	{
		// 2.2.0.30894
		public const int SizeOf = 0x78; // 120
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public SerializeData x10_SerializeData { get { return Read<SerializeData>(0x10); } }
		public int x18 { get { return Read<int>(0x18); } }
		public EffectItem[] x20_EffectItems { get { return Deserialize<EffectItem>(x10_SerializeData); } }
		public int x28 { get { return Read<int>(0x28); } }
		public int x2C { get { return Read<int>(0x2C); } }
		public int x30 { get { return Read<int>(0x30); } }
		public Sno x34_PowerSno { get { return Read<Sno>(0x34); } }
		public int[] x38_int { get { return Read<int>(0x38, 16); } }
		
		[CompilerGenerated]
		public partial class EffectItem : MemoryObject
		{
			// 2.2.0.30894
			public const int SizeOf = 0x1E0; // 480
			
			public int x000 { get { return Read<int>(0x000); } }
			public string x004_Text { get { return ReadString(0x004, 64); } }
			public MsgTriggeredEvent x044_MsgTriggeredEvent { get { return Read<MsgTriggeredEvent>(0x044); } }
		}
		
		[CompilerGenerated]
		public partial class MsgTriggeredEvent : MemoryObject
		{
			// 2.2.0.30894
			public const int SizeOf = 0x19C; // 412
			
			public int x000 { get { return Read<int>(0x000); } }
			public TriggerEvent x004_TriggerEvent { get { return Read<TriggerEvent>(0x004); } }
		}
		
		[CompilerGenerated]
		public partial class TriggerEvent : MemoryObject
		{
			// 2.2.0.30894
			public const int SizeOf = 0x198; // 408
			
			public int x000 { get { return Read<int>(0x000); } }
			public TriggerConditions x004_TriggerConditions { get { return Read<TriggerConditions>(0x004); } }
			public int x028 { get { return Read<int>(0x028); } }
			public SNOName x02C_SNOName { get { return Read<SNOName>(0x02C); } }
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
			// 2.2.0.30894
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
		public partial class SNOName : MemoryObject
		{
			// 2.2.0.30894
			public const int SizeOf = 0x08; // 8
			
			public SnoGroup x00_SnoGroup { get { return Read<SnoGroup>(0x00); } }
			public SnoNameHandle x04_SnoNameHandle { get { return Read<SnoNameHandle>(0x04); } }
		}
		
		[CompilerGenerated]
		public partial class HardpointLink : MemoryObject
		{
			// 2.2.0.30894
			public const int SizeOf = 0x44; // 68
			
			public string x00_Text { get { return ReadString(0x00, 64); } }
			public int x40 { get { return Read<int>(0x40); } }
		}
		
		[CompilerGenerated]
		public partial class LookLink : MemoryObject
		{
			// 2.2.0.30894
			public const int SizeOf = 0x40; // 64
			
			public string x00_Text { get { return ReadString(0x00, 64); } }
		}
		
		[CompilerGenerated]
		public partial class ConstraintLink : MemoryObject
		{
			// 2.2.0.30894
			public const int SizeOf = 0x40; // 64
			
			public string x00_Text { get { return ReadString(0x00, 64); } }
		}
		
		[CompilerGenerated]
		public partial class DT_RGBACOLOR : MemoryObject
		{
			// 2.2.0.30894
			public const int SizeOf = 0x03; // 3
			
			public byte x00 { get { return Read<byte>(0x00); } }
			public byte x01 { get { return Read<byte>(0x01); } }
			public byte x02 { get { return Read<byte>(0x02); } }
			public byte x03 { get { return Read<byte>(0x03); } }
		}
	}
}
