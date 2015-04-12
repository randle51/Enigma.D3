using Enigma.Memory;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using System.Collections.Generic;

namespace Enigma.D3.UI.Controls
{
	public class UXChatMessageList : UXItemsControl
	{
		public new const int SizeOf = 0x1CD0; //7376
		public new const int VTable = 0x01829D80;

		public int x0A20 { get { return Read<int>(0x0A20); } }
		public int x0A24_FontSnoId { get { return Read<int>(0x0A24); } }
		public int x0A28_FontSize { get { return Read<int>(0x0A28); } }
		[ArraySize(6)]
		public LightVector<Struct001> x0A2C_StructStart_Min52Bytes_Array_ { get { return Read<LightVector<Struct001>>(0x0A2C); } }
		public LightVector x0A38_StructStart_Min52Bytes_Array { get { return Read<LightVector>(0x0A38); } }
		public LightVector x0A44_StructStart_Min52Bytes_Array { get { return Read<LightVector>(0x0A44); } }
		public int _x0A50 { get { return Read<int>(0x0A50); } }
		public int _x0A54 { get { return Read<int>(0x0A54); } }
		public int _x0A58 { get { return Read<int>(0x0A58); } }
		public int _x0A5C { get { return Read<int>(0x0A5C); } }
		public int _x0A60 { get { return Read<int>(0x0A60); } }
		public int _x0A64 { get { return Read<int>(0x0A64); } }
		public int _x0A68 { get { return Read<int>(0x0A68); } }
		public UIReference x0A68_UIRef_Label { get { return Read<UIReference>(0x0A68); } }
		public UIReference x0C70_UIRef { get { return Read<UIReference>(0x0C70); } }
		public UIReference x0E78_UIRef { get { return Read<UIReference>(0x0E78); } }
		public UIReference x1080_UIRef { get { return Read<UIReference>(0x1080); } }
		public UIReference x1288_UIRef_ScrollBar { get { return Read<UIReference>(0x1288); } }
		public UIReference x1490_UIRef_BlinkerEnd { get { return Read<UIReference>(0x1490); } }
		public UIReference x1698_UIRef_NewMessage { get { return Read<UIReference>(0x1698); } }
		public UIReference x18A0_UIRef_NewMessageBlinker { get { return Read<UIReference>(0x18A0); } }
		public string x1AA8_String512 { get { return ReadString(0x1AA8, 512); } }
		public int x1CA8 { get { return Read<int>(0x1CA8); } }
		public int x1CAC { get { return Read<int>(0x1CAC); } }
		public int x1CB0 { get { return Read<int>(0x1CB0); } }
		public int x1CB4 { get { return Read<int>(0x1CB4); } }
		public int x1CB8_Neg1 { get { return Read<int>(0x1CB8); } }
		public float x1CBC_Base_x500 { get { return Read<float>(0x1CBC); } }
		public float x1CC0_Base_x504 { get { return Read<float>(0x1CC0); } }
		public float x1CC4_Base_x4F8 { get { return Read<float>(0x1CC4); } }
		public float x1CC8_Base_x4FC { get { return Read<float>(0x1CC8); } }
		public int _x1CCC { get { return Read<int>(0x1CCC); } }


		public class Struct001 : MemoryObject
		{
			public const int SizeOf = 0x30;

			public RefString x00_Filter { get { return Read<RefString>(0x00); } }
			public LightVector x0C_Array { get { return Read<LightVector>(0x0C); } }
			public LightVector x18_Array { get { return Read<LightVector>(0x18); } }
			public LightVector<ChatMessage> x24_Messages { get { return Read<LightVector<ChatMessage>>(0x24); } }
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
