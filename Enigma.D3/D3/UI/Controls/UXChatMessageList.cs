using Enigma.D3.Collections;

namespace Enigma.D3.UI.Controls
{
	public class UXChatMessageList : UXItemsControl
	{
		// 2.0.6.24641
		public const int SizeOf = 0x1D90;
		public const int VTable = 0x017C6160;

		public UXChatMessageList(MemoryBase memory, int address)
			: base(memory, address) { }

		public int x0A58 { get { return Field<int>(0x0A58); } }
		public int x0A5C_FontSnoId { get { return Field<int>(0x0A5C); } }
		public int x0A60_FontSize { get { return Field<int>(0x0A60); } }
		public int x0A64_TextLength { get { return Field<int>(0x0A64); } }
		public Array<Struct001> x0A68_StructStart_Min52Bytes_ArrayEx_ { get { return Field<Array<Struct001>>(0x0A68); } }
		public int _x0A94 { get { return Field<int>(0x0A94); } }
		public int _x0A98 { get { return Field<int>(0x0A98); } }
		public int _x0A9C { get { return Field<int>(0x0A9C); } }
		public int x0AA0_StructStart_Min52Bytes_ArrayEx_ { get { return Field<int>(0x0AA0); } }
		public int _x0AA4 { get { return Field<int>(0x0AA4); } }
		public int x0AA8_Limit_ { get { return Field<int>(0x0AA8); } }
		public int _x0AAC { get { return Field<int>(0x0AAC); } }
		public int _x0AB0 { get { return Field<int>(0x0AB0); } }
		public int _x0AB4 { get { return Field<int>(0x0AB4); } }
		public int _x0AB8 { get { return Field<int>(0x0AB8); } }
		public int _x0ABC { get { return Field<int>(0x0ABC); } }
		public int _x0AC0 { get { return Field<int>(0x0AC0); } }
		public int _x0AC4 { get { return Field<int>(0x0AC4); } }
		public int _x0AC8 { get { return Field<int>(0x0AC8); } }
		public int _x0ACC { get { return Field<int>(0x0ACC); } }
		public int _x0AD0 { get { return Field<int>(0x0AD0); } }
		public int _x0AD4 { get { return Field<int>(0x0AD4); } }
		public int x0AD8_StructStart_Min52Bytes_ArrayEx_ { get { return Field<int>(0x0AD8); } }
		public int _x0ADC { get { return Field<int>(0x0ADC); } }
		public int x0AE0_Count { get { return Field<int>(0x0AE0); } }
		public int _x0AE4 { get { return Field<int>(0x0AE4); } }
		public int _x0AE8 { get { return Field<int>(0x0AE8); } }
		public int _x0AEC { get { return Field<int>(0x0AEC); } }
		public int _x0AF0 { get { return Field<int>(0x0AF0); } }
		public int _x0AF4 { get { return Field<int>(0x0AF4); } }
		public int _x0AF8 { get { return Field<int>(0x0AF8); } }
		public int _x0AFC { get { return Field<int>(0x0AFC); } }
		public int _x0B00 { get { return Field<int>(0x0B00); } }
		public int _x0B04 { get { return Field<int>(0x0B04); } }
		public int _x0B08 { get { return Field<int>(0x0B08); } }
		public int _x0B0C { get { return Field<int>(0x0B0C); } }
		public int x0B10_Count { get { return Field<int>(0x0B10); } }
		public int _x0B14 { get { return Field<int>(0x0B14); } }
		public int x0B18 { get { return Field<int>(0x0B18); } }
		public int x0B1C { get { return Field<int>(0x0B1C); } }
		public int x0B20_Neg1 { get { return Field<int>(0x0B20); } }
		public int x0B24_Neg1 { get { return Field<int>(0x0B24); } }
		public UIReference x0B28_UIRef_Label { get { return Field<UIReference>(0x0B28); } }
		public UIReference x0D30_UIRef { get { return Field<UIReference>(0x0D30); } }
		public UIReference x0F38_UIRef { get { return Field<UIReference>(0x0F38); } }
		public UIReference x1140_UIRef { get { return Field<UIReference>(0x1140); } }
		public UIReference x1348_UIRef_ScrollBar { get { return Field<UIReference>(0x1348); } }
		public UIReference x1550_UIRef_BlinkerEnd { get { return Field<UIReference>(0x1550); } }
		public UIReference x1758_UIRef_NewMessage { get { return Field<UIReference>(0x1758); } }
		public UIReference x1960_UIRef_NewMessageBlinker { get { return Field<UIReference>(0x1960); } }
		public string x1B68_String512 { get { return Field(0x1B68, 512); } }
		public int x1D68 { get { return Field<int>(0x1D68); } }
		public int x1D6C { get { return Field<int>(0x1D6C); } }
		public int x1D70 { get { return Field<int>(0x1D70); } }
		public int x1D74 { get { return Field<int>(0x1D74); } }
		public int x1D78_Neg1 { get { return Field<int>(0x1D78); } }
		public float x1D7C_Base_x500 { get { return Field<float>(0x1D7C); } }
		public float x1D80_Base_x504 { get { return Field<float>(0x1D80); } }
		public float x1D84_Base_x4F8 { get { return Field<float>(0x1D84); } }
		public float x1D88_Base_x4FC { get { return Field<float>(0x1D88); } }
		public int _x1D8C { get { return Field<int>(0x1D8C); } }


		public class Struct001 : MemoryObject
		{
			public const int SizeOf = 0xB8; // 184

			public RefString x00_Filter { get { return Field<RefString>(0x00); } }
			public int _x0C { get { return Field<int>(0x0C); } }
			public Array x10_Array { get { return Field<Array>(0x10); } }
			public int _x3C { get { return Field<int>(0x3C); } }
			public int _x40 { get { return Field<int>(0x40); } }
			public int _x44 { get { return Field<int>(0x44); } }
			public Array x48_Array { get { return Field<Array>(0x48); } }
			public int _x74 { get { return Field<int>(0x74); } }
			public int _x78 { get { return Field<int>(0x78); } }
			public int _x7C { get { return Field<int>(0x7C); } }
			public Array<ChatMessage> x80_Array { get { return Field<Array<ChatMessage>>(0x80); } }
			public int _xAC { get { return Field<int>(0xAC); } }
			public int _xB0 { get { return Field<int>(0xB0); } }
			public int _xB4 { get { return Field<int>(0xB4); } }
		}

		public class ChatMessage : MemoryObject
		{
			public const int SizeOf = 0x68; // 104

			public ChatMessage(MemoryBase memory, int address)
				: base(memory, address) { }

			public RefString x00_RefString { get { return Field<RefString>(0x00); } }
			public int _x0C { get { return Field<int>(0x0C); } }
			public int _x10 { get { return Field<int>(0x10); } }
			public int _x14 { get { return Field<int>(0x14); } }
			public int _x18 { get { return Field<int>(0x18); } }
			public int _x1C { get { return Field<int>(0x1C); } }
			public int _x20 { get { return Field<int>(0x20); } }
			public int _x24 { get { return Field<int>(0x24); } }
			public int _x28 { get { return Field<int>(0x28); } }
			public int _x2C { get { return Field<int>(0x2C); } }
			public int _x30 { get { return Field<int>(0x30); } }
			public int _x34 { get { return Field<int>(0x34); } }
			public int _x38 { get { return Field<int>(0x38); } }
			public int _x3C { get { return Field<int>(0x3C); } }
			public int _x40 { get { return Field<int>(0x40); } }
			public int _x44 { get { return Field<int>(0x44); } }
			public int _x48 { get { return Field<int>(0x48); } }
			public int _x4C { get { return Field<int>(0x4C); } }
			public int _x50 { get { return Field<int>(0x50); } }
			public int _x54 { get { return Field<int>(0x54); } }
			public int _x58 { get { return Field<int>(0x58); } }
			public int _x5C { get { return Field<int>(0x5C); } }
			public int _x60 { get { return Field<int>(0x60); } }
			public int _x64 { get { return Field<int>(0x64); } }
		}
	}
}
