using Enigma.Memory;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.UI.Controls
{
	public class UXChatMessageList : UXItemsControl
	{
		public new const int SizeOf = 0x1D80; //7552
		public new const int VTable = 0x01774718;

		public int x0A48 { get { return Read<int>(0x0A48); } }
		public int x0A4C_FontSnoId { get { return Read<int>(0x0A4C); } }
		public int x0A50_FontSize { get { return Read<int>(0x0A50); } }
		public int x0A54_TextLength { get { return Read<int>(0x0A54); } }
		public Vector<Struct001> x0A58_StructStart_Min52Bytes_Array_ { get { return Read<Vector<Struct001>>(0x0A58); } }
		public Vector x0A90_StructStart_Min52Bytes_Array { get { return Read<Vector>(0x0A90); } }
		public Vector x0AC8_StructStart_Min52Bytes_Array { get { return Read<Vector>(0x0AC8); } }
		public int x0B00_Count { get { return Read<int>(0x0B00); } }
		public int _x0B04 { get { return Read<int>(0x0B04); } }
		public int x0B08 { get { return Read<int>(0x0B08); } }
		public int x0B0C { get { return Read<int>(0x0B0C); } }
		public int x0B10_Neg1 { get { return Read<int>(0x0B10); } }
		public int x0B14_Neg1 { get { return Read<int>(0x0B14); } }
		public UIReference x0B18_UIRef_Label { get { return Read<UIReference>(0x0B18); } }
		public UIReference x0D20_UIRef { get { return Read<UIReference>(0x0D20); } }
		public UIReference x0F28_UIRef { get { return Read<UIReference>(0x0F28); } }
		public UIReference x1130_UIRef { get { return Read<UIReference>(0x1130); } }
		public UIReference x1338_UIRef_ScrollBar { get { return Read<UIReference>(0x1338); } }
		public UIReference x1540_UIRef_BlinkerEnd { get { return Read<UIReference>(0x1540); } }
		public UIReference x1748_UIRef_NewMessage { get { return Read<UIReference>(0x1748); } }
		public UIReference x1950_UIRef_NewMessageBlinker { get { return Read<UIReference>(0x1950); } }
		public string x1B58_String512 { get { return ReadString(0x1B58, 512); } }
		public int x1D58 { get { return Read<int>(0x1D58); } }
		public int x1D5C { get { return Read<int>(0x1D5C); } }
		public int x1D60 { get { return Read<int>(0x1D60); } }
		public int x1D64 { get { return Read<int>(0x1D64); } }
		public int x1D68_Neg1 { get { return Read<int>(0x1D68); } }
		public float x1D6C_Base_x500 { get { return Read<float>(0x1D6C); } }
		public float x1D70_Base_x504 { get { return Read<float>(0x1D70); } }
		public float x1D74_Base_x4F8 { get { return Read<float>(0x1D74); } }
		public float x1D78_Base_x4FC { get { return Read<float>(0x1D78); } }
		public int _x1D7C { get { return Read<int>(0x1D7C); } }


		public class Struct001 : MemoryObject
		{
			public const int SizeOf = 0xB8; // 184

			public RefString x00_Filter { get { return Read<RefString>(0x00); } }
			public int _x0C { get { return Read<int>(0x0C); } }
			public Vector x10_Array { get { return Read<Vector>(0x10); } }
			public Vector x48_Array { get { return Read<Vector>(0x48); } }
			public Vector<ChatMessage> x80_Array { get { return Read<Vector<ChatMessage>>(0x80); } }
		}

		public class ChatMessage : MemoryObject
		{
			public const int SizeOf = 0x70; // 112

			public RefString x00_Margin { get { return Read<RefString>(0x00); } }
			public RefString x0C_Message { get { return Read<RefString>(0x0C); } }
			public int _x18 { get { return Read<int>(0x18); } }
			public int _x1C { get { return Read<int>(0x1C); } }
			public BasicAllocator x20_BasicAllocator { get { return Read<BasicAllocator>(0x20); } }
			public int _x3C { get { return Read<int>(0x3C); } }
			public int _x40 { get { return Read<int>(0x40); } }
			public int _x44 { get { return Read<int>(0x44); } }
			public int _x48 { get { return Read<int>(0x48); } }
			public int _x4C { get { return Read<int>(0x4C); } }
			public int _x50 { get { return Read<int>(0x50); } }
			public int _x54 { get { return Read<int>(0x54); } }
			public int _x58 { get { return Read<int>(0x58); } }
			public int _x5C { get { return Read<int>(0x5C); } }
			public int _x60 { get { return Read<int>(0x60); } }
			public int _x64 { get { return Read<int>(0x64); } }
			public int _x68 { get { return Read<int>(0x68); } }
			public int _x6C { get { return Read<int>(0x6C); } }
		}
	}
}
