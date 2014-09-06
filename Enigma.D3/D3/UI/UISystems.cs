using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.UI
{
	public class UIRefStruct001 : MemoryObject
	{
		// 2.0.6
		public const int SizeOf = 0x418;

		public UIReference x000_UIRef { get { return Read<UIReference>(0x000); } }
		public UIReference x208_UIRef { get { return Read<UIReference>(0x208); } }
		public int x410 { get { return Read<int>(0x410); } }
		public int x414 { get { return Read<int>(0x414); } }
	}

	public class UISystems : MemoryObject
	{
		// 2.0.6
		public const int SizeOf = 0x426B8;

		public int x00000 { get { return Read<int>(0x00000); } }
		public int _x00004 { get { return Read<int>(0x00004); } }
		public string x00008_String1024 { get { return ReadString(0x00008, 1024); } }
		public string x00408_String1024 { get { return ReadString(0x00408, 1024); } }
		public int x00808 { get { return Read<int>(0x00808); } }
		public int x0080C { get { return Read<int>(0x0080C); } }
		public int x00810_LevelAreaSnoId { get { return Read<int>(0x00810); } }
		public int x00814_LevelAreaSnoId { get { return Read<int>(0x00814); } }
		public int x00818 { get { return Read<int>(0x00818); } }
		public ListPack x0081C_ListPack_NodeSize1036 { get { return Dereference<ListPack>(0x0081C); } }
		public int x00820_ActorId { get { return Read<int>(0x00820); } }
		public int _x00824 { get { return Read<int>(0x00824); } }
		public UIReference x00828_UIRef { get { return Read<UIReference>(0x00828); } }
		public int x00A30_SkillErrorTick { get { return Read<int>(0x00A30); } }
		public string x00A34_SkillErrorText { get { return ReadString(0x00A34, 1024); } }
		public int x00E34 { get { return Read<int>(0x00E34); } }
		[ArraySize(256)]
		public UIRefStruct001[] x00E38 { get { return Read<UIRefStruct001>(0x00E38, 256); } }
		public UIRefStruct001 x42638 { get { return Dereference<UIRefStruct001>(0x42638); } }
		public int x4263C { get { return Read<int>(0x4263C); } }
		public int x42640_Count { get { return Read<int>(0x42640); } }
		public Allocator x42644_Ptr_Allocator { get { return Dereference<Allocator>(0x42644); } }
		public Allocator x42648_Allocator_10x528Bytes { get { return Read<Allocator>(0x42648); } }
		public int _x42664 { get { return Read<int>(0x42664); } }
		public ListPack x42668_ListPack_NodeSize36Bytes { get { return Read<ListPack>(0x42668); } }
		public int x42698 { get { return Read<int>(0x42698); } }
		public int x4269C { get { return Read<int>(0x4269C); } }
		public int x426A0 { get { return Read<int>(0x426A0); } }
		public int x426A4 { get { return Read<int>(0x426A4); } }
		public int x426A8 { get { return Read<int>(0x426A8); } }
		public int x426AC { get { return Read<int>(0x426AC); } }
		public int x426B0 { get { return Read<int>(0x426B0); } }
		public int x426B4 { get { return Read<int>(0x426B4); } }
	}
}
