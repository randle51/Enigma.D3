using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.UI
{
	public partial class UIManager : MemoryObject
	{
		public const int SizeOf = 0x2710; // 10000

		public Ptr<X0000> x0000_Ptr_Controls { get { return ReadPointer<X0000>(0x0000); } }
		public int _x0004 { get { return Read<int>(0x0004); } }
		public UIReference x0008_MouseCapture { get { return Read<UIReference>(0x0008); } }
		public UIReference x0210_KeyboardFocus { get { return Read<UIReference>(0x0210); } }
		public UIReference x0418_UIReference { get { return Read<UIReference>(0x0418); } } // Unknown
		public UIReference x0620_ContextMenu { get { return Read<UIReference>(0x0620); } }
		public UIReference x0828_LastClicked { get { return Read<UIReference>(0x0828); } }
		public UIReference x0A30_MouseOver { get { return Read<UIReference>(0x0A30); } }
		public UIReference x0C38_UIReference { get { return Read<UIReference>(0x0C38); } }
		// ...
		public Ptr<X0E48> x0E48_Ptr_144Bytes { get { return ReadPointer<X0E48>(0x0E48); } }
		public Ptr<X0E4C> x0E4C_Ptr_44Bytes { get { return ReadPointer<X0E4C>(0x0E4C); } }
		// ...
		public int x1E60_MouseX { get { return Read<int>(0x1E60); } }
		public int x1E64_MouseY { get { return Read<int>(0x1E64); } }
		public int x1E68_LogoutTime { get { return Read<int>(0x1E68); } }
		public int x1E6C { get { return Read<int>(0x1E6C); } }
		public int x1E70 { get { return Read<int>(0x1E70); } }
		public int _x1E74 { get { return Read<int>(0x1E74); } }
		public string x1E78_String1024 { get { return ReadString(0x1E78, 1024); } }
		public string x2278_String1024 { get { return ReadString(0x2278, 1024); } }
		// ...
		public int x2694_AcdId { get { return Read<int>(0x2694); } }
		public Map x2698_Handlers { get { return Read<Map>(0x2698); } }
		public int _x2708 { get { return Read<int>(0x2708); } }
		public int _x270C { get { return Read<int>(0x270C); } }


		// TODO: Rewrite this as a Map
		public class X0000 : MemoryObject
		{
			public const int SizeOf = 0x70;

			public int x00_Mask { get { return Read<int>(0x00); } }
			public int x04_Count { get { return Read<int>(0x04); } }
			public Ptr<Allocator<UIMap.Pair>> x08_Ptr_Allocator_FieldX48 { get { return ReadPointer<Allocator<UIMap.Pair>>(0x08); } }
			public int _x0C { get { return Read<int>(0x0C); } }
			public UIMap x10_Map { get { return Read<UIMap>(0x10); } }
			public int _x44 { get { return Read<int>(0x44); } }
			public Allocator<UIMap.Pair> x48_Allocator_10x24Bytes { get { return Read<Allocator<UIMap.Pair>>(0x48); } }
			public int _x64 { get { return Read<int>(0x64); } }
			public int x68 { get { return Read<int>(0x68); } }
			public int _x6C { get { return Read<int>(0x6C); } }
		}

		public class X0E48 : MemoryObject
		{
			public const int SizeOf = 0x94; // 148

			public int x00_One { get { return Read<int>(0x00); } }
			public ListPack<UIReference> x04_ListPack_Of_UIReference { get { return Read<ListPack<UIReference>>(0x04); } }
			public ListPack x34_ListPack_Of_Ptr { get { return Read<ListPack>(0x34); } }
			public ListPack x64_ListPack_Of_Ptr { get { return Read<ListPack>(0x64); } }
		}

		public class X0E4C : MemoryObject
		{
			public const int SizeOf = 0x2C; // 44

			public Allocator x00_Allocator_2048x40Bytes { get { return Read<Allocator>(0x00); } }
			public int _x1C { get { return Read<int>(0x1C); } }
			public int _x20 { get { return Read<int>(0x20); } }
			public int _x24 { get { return Read<int>(0x24); } }
			public int _x28 { get { return Read<int>(0x28); } }
		}
	}

	public partial class UIManager
	{
		public static UIManager Instance { get { return ObjectManager.Instance.xA1C_Ptr_10000Bytes_UI.Dereference(); } }
	}
}