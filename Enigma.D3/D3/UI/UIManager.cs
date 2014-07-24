using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;

namespace Enigma.D3.UI
{
	public class UIManager : MemoryObject
	{
		// 2.0.0.21806
		public const int SizeOf = 0x2710; // = 10000

		public UIManager(MemoryBase memory, int address)
			: base(memory, address) { }

		public X0000 x0000_Controls { get { return Dereference<X0000>(0x0000); } }
		// ...
		public UIReference x0008_MouseCapture { get { return Field<UIReference>(0x0008); } }
		public UIReference x0210_KeyboardFocus { get { return Field<UIReference>(0x0210); } }
		public UIReference x0418_UIReference { get { return Field<UIReference>(0x0418); } } // Unknown
		public UIReference x0620_ContextMenu { get { return Field<UIReference>(0x0620); } }
		public UIReference x0828_LastClicked { get { return Field<UIReference>(0x0828); } }
		public UIReference x0A30_MouseOver { get { return Field<UIReference>(0x0A30); } }
		public UIReference x0C38_UIReference { get { return Field<UIReference>(0x0C38); } }
		// ...
		public int x1E60_MouseX { get { return Field<int>(0x1E60); } }
		public int x1E64_MouseY { get { return Field<int>(0x1E64); } }
		public int x1E68_LogoutTime { get { return Field<int>(0x1E68); } }
		public int x1E6C { get { return Field<int>(0x1E6C); } }
		public int x1E70 { get { return Field<int>(0x1E70); } }
		public int _x1E74 { get { return Field<int>(0x1E74); } }
		public string x1E78_String1024 { get { return Field(0x1E78, 1024); } }
		public string x2278_String1024 { get { return Field(0x2278, 1024); } }
		// ...
		public int x2698_AcdId { get { return Field<int>(0x2698); } }
		public int _x269C { get { return Field<int>(0x269C); } }
		public int x26A0_Handlers { get { return Field<int>(0x26A0); } }
		// ...


		public class X0000 : MemoryObject
		{
			public const int SizeOf = 0;

			public X0000(MemoryBase memory, int address)
				: base(memory, address) { }

			public int x00_Mask { get { return Field<int>(0x00); } }
			public int x04_Count { get { return Field<int>(0x04); } }
			public Allocator<UIMap.Pair> x08_PtrAllocator_FieldX48 { get { return Dereference<Allocator<UIMap.Pair>>(0x08); } }
			public int _x0C { get { return Field<int>(0x0C); } }
			public UIMap x10_Map { get { return Field<UIMap>(0x10); } }
			public int _x44 { get { return Field<int>(0x44); } }
			public Allocator<UIMap.Pair> x48_Allocator_10x24Bytes { get { return Field<Allocator<UIMap.Pair>>(0x48); } }
			public int _x64 { get { return Field<int>(0x64); } }
			public int x68 { get { return Field<int>(0x68); } }
			public int _x6C { get { return Field<int>(0x6C); } }
		}
	}
}