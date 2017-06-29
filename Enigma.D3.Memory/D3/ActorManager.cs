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
		public const int SizeOf = 0x330; // 816

		public int x000_NextSerialNumber { get { return Read<int>(0x000); } }
		public Allocator x004_Allocator_1024x1352Bytes { get { return Read<Allocator>(0x004); } }
		public Allocator x020_Allocator_1024x28Bytes { get { return Read<Allocator>(0x020); } }
		public Allocator x03C_Allocator_1024x48Bytes { get { return Read<Allocator>(0x03C); } }
		public Ptr<ListB> x058_PtrListB { get { return ReadPointer<ListB>(0x058); } }
		public ListB x05C_ListB_ActorIds { get { return Read<ListB>(0x05C); } }
		public int x070_Neg1 { get { return Read<int>(0x070); } }
		public int x074_Neg1 { get { return Read<int>(0x074); } }
		public int x078_Neg1 { get { return Read<int>(0x078); } }
		public int x07C { get { return Read<int>(0x07C); } }
		public int x080 { get { return Read<int>(0x080); } }
		public int x084_StructStart_Min12Bytes { get { return Read<int>(0x084); } }
		public int x088 { get { return Read<int>(0x088); } }
		public int x08C { get { return Read<int>(0x08C); } }
		public Map x090_Map { get { return Read<Map>(0x090); } }
		public Map x100_Map { get { return Read<Map>(0x100); } }
		public Map x170_Map { get { return Read<Map>(0x170); } }
		public Map x1E0_Map { get { return Read<Map>(0x1E0); } }
		public Map x250_Map { get { return Read<Map>(0x250); } }
		public Map x2C0_Map { get { return Read<Map>(0x2C0); } }
	}

	public partial class ActorManager
	{
		public static ActorManager Instance { get { return ObjectManager.Instance?.x9AC_Ptr_816Bytes_ActorManager.Dereference(); } }
	}
}
