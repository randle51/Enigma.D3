using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3
{
	public partial class ActorManager : MemoryObject
	{
		public const int SizeOf = 0x358;

		public int x000_NextSerialNumber { get { return Read<int>(0x000); } }
		public Allocator x004_Allocator_1024x1352Bytes { get { return Read<Allocator>(0x004); } }
		public Allocator x020_Allocator_1024x28Bytes { get { return Read<Allocator>(0x020); } }
		public Allocator x03C_Allocator_1024x48Bytes { get { return Read<Allocator>(0x03C); } }
		public ListB x058_PtrListB { get { return Dereference<ListB>(0x058); } }
		public ListB x05C_ListB { get { return Read<ListB>(0x05C); } }
		public int x070_Neg1 { get { return Read<int>(0x070); } }
		public int x074_Neg1 { get { return Read<int>(0x074); } }
		public int x078 { get { return Read<int>(0x078); } }
		public int _x07C { get { return Read<int>(0x07C); } }
		public int x080 { get { return Read<int>(0x080); } }
		public int x084 { get { return Read<int>(0x084); } }
		public int x088_Count { get { return Read<int>(0x088); } }
		public int _x08C { get { return Read<int>(0x08C); } }
		public BasicAllocator x090_DynAllocator { get { return Read<BasicAllocator>(0x090); } }
		public int _x0AC { get { return Read<int>(0x0AC); } }
		public int _x0B0 { get { return Read<int>(0x0B0); } }
		public int _x0B4 { get { return Read<int>(0x0B4); } }
		public Map x0B8_Map { get { return Read<Map>(0x0B8); } }
		public Map x128_Map { get { return Read<Map>(0x128); } }
		public Map x198_Map { get { return Read<Map>(0x198); } }
		public Map x208_Map { get { return Read<Map>(0x208); } }
		public Map x278_Map { get { return Read<Map>(0x278); } }
		public Map x2E8_Map { get { return Read<Map>(0x2E8); } }
	}

	public partial class ActorManager
	{
		public static ActorManager Instance { get { return ObjectManager.Instance.IfNotNull(a => a.x934_ActorManager); } }
	}
}
