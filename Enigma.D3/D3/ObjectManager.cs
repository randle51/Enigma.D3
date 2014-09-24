using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.UI;
using Enigma.D3.Memory;

namespace Enigma.D3
{
	public partial class ObjectManager : MemoryObject
	{
		// 2.1.1.27255
		public const int SizeOf = 0x9E8;

		public Time x000_Time { get { return Read<Time>(0x000); } }
		public int _x00C { get { return Read<int>(0x00C); } }
		public int _x010 { get { return Read<int>(0x010); } }
		public int _x014 { get { return Read<int>(0x014); } }
		public int x018 { get { return Read<int>(0x018); } }
		public int x01C { get { return Read<int>(0x01C); } }
		public Time x020_StructStart_Min24Bytes_Time_ { get { return Read<Time>(0x020); } }
		public int _x02C { get { return Read<int>(0x02C); } }
		public int _x030 { get { return Read<int>(0x030); } }
		public int _x034 { get { return Read<int>(0x034); } }
		public int x038_Counter_CurrentFrame { get { return Read<int>(0x038); } }
		public int x03C { get { return Read<int>(0x03C); } }
		public GameGlobals x040_GameGlobals { get { return Read<GameGlobals>(0x040); } }
		public GameGlobals x3E0_GameGlobals { get { return Read<GameGlobals>(0x3E0); } }
		public int _x780 { get { return Read<int>(0x780); } }
		public int _x784 { get { return Read<int>(0x784); } }
		public int _x788_int { get { return Read<int>(0x788); } }
		public Ptr<Allocator> x78C_Ptr_Allocator_20x256Bytes { get { return Read<Ptr<Allocator>>(0x78C); } }
		public Struct790 x790 { get { return Dereference<Struct790>(0x790); } }
		public int _x794_int { get { return Read<int>(0x794); } }
		public Storage x798_Storage { get { return Read<Storage>(0x798); } }
		// ??? No idea how large Storage is.
		public ExpandableContainer<Actor> x930_RActors { get { return Dereference<ExpandableContainer<Actor>>(0x930); } }
		public ActorManager x934_ActorManager { get { return Dereference<ActorManager>(0x934); } }
		public Ptr x938_Ptr_ { get { return Read<Ptr>(0x938); } }
		public Ptr x93C_Ptr_ { get { return Read<Ptr>(0x93C); } }
		public int _x940_int { get { return Read<int>(0x940); } }
		public Ptr x944_Ptr_ { get { return Read<Ptr>(0x944); } }
		public Ptr x948_Ptr_ { get { return Read<Ptr>(0x948); } }
		public Ptr x94C_Ptr_ { get { return Read<Ptr>(0x94C); } }
		public Ptr x950_Ptr_ { get { return Read<Ptr>(0x950); } }
		public Cinematography x954_Cinematography { get { return Dereference<Cinematography>(0x954); } }
		public Ptr x958_Ptr_ { get { return Read<Ptr>(0x958); } }
		public Ptr x95C_Ptr_ { get { return Read<Ptr>(0x95C); } }
		public Ptr x960_Ptr_ { get { return Read<Ptr>(0x960); } }
		public Ptr x964_Ptr_ { get { return Read<Ptr>(0x964); } }
		public Ptr x968_Ptr_ { get { return Read<Ptr>(0x968); } }
		public Ptr x96C_Ptr_ { get { return Read<Ptr>(0x96C); } }
		public Container<Scene> x970_Scenes { get { return Dereference<Container<Scene>>(0x970); } }
		public int _x974_int { get { return Read<int>(0x974); } }
		public Ptr x978_Ptr_ { get { return Read<Ptr>(0x978); } }
		public Ptr x97C_Ptr_ { get { return Read<Ptr>(0x97C); } }
		public Ptr x980_Ptr_ { get { return Read<Ptr>(0x980); } }
		public Ptr<Allocator> x984_Ptr_Allocator_296x64Bytes { get { return Read<Ptr<Allocator>>(0x984); } }
		public Ptr x988_Ptr_ { get { return Read<Ptr>(0x988); } }
		public Ptr<X98C> x98C_Ptr_Struct { get { return Read<Ptr<X98C>>(0x98C); } }
		public Ptr x990_Ptr_ { get { return Read<Ptr>(0x990); } }
		public Ptr x994_Ptr_ { get { return Read<Ptr>(0x994); } }
		public Ptr x998_Ptr_ { get { return Read<Ptr>(0x998); } }
		public Ptr x99C_Ptr_ { get { return Read<Ptr>(0x99C); } }
		public Ptr x9A0_Ptr_ { get { return Read<Ptr>(0x9A0); } }
		public UIManager x9A4_UI { get { return Dereference<UIManager>(0x9A4); } }
		public CameraManager x9A8_CameraManager { get { return Dereference<CameraManager>(0x9A8); } }
		public Container<World> x9AC_CWorlds { get { return Dereference<Container<World>>(0x9AC); } }
		public Ptr x9B0_Ptr_ { get { return Read<Ptr>(0x9B0); } }
		public Player x9B4_Player { get { return Dereference<Player>(0x9B4); } }
		public PlayerInput x9B8_PlayerInput { get { return Dereference<PlayerInput>(0x9B8); } }
		public Ptr x9BC_Ptr_ { get { return Read<Ptr>(0x9BC); } }
		public Ptr x9C0_Ptr_ { get { return Read<Ptr>(0x9C0); } }
		public int _x9C4_int { get { return Read<int>(0x9C4); } }
		public int _x9C8_int { get { return Read<int>(0x9C8); } }
		public Ptr x9CC_Ptr_ { get { return Read<Ptr>(0x9CC); } }
		public Ptr x9D0_Ptr_ { get { return Read<Ptr>(0x9D0); } }
		public Ptr x9D4_Ptr_ { get { return Read<Ptr>(0x9D4); } }
		public Ptr<Allocator> x9D8_Ptr_Allocator_224x1024Bytes { get { return Read<Ptr<Allocator>>(0x9D8); } }
		public Ptr<ListPack<TimedEvent>> x9DC_Ptr_TimedEvents { get { return ReadPointer<ListPack<TimedEvent>>(0x9DC); } }
		public Ptr x9E0_Ptr_ { get { return Read<Ptr>(0x9E0); } }
		public Ptr<Allocator> x9E4_Ptr_Allocator_656x1024Bytes { get { return Read<Ptr<Allocator>>(0x9E4); } }

		public class X98C : MemoryObject
		{
			public const int SizeOf = 232;

			public ListB x00_ListB { get { return Read<ListB>(0x00); } }
			public ListB x14_ListB { get { return Read<ListB>(0x14); } }
			public Vector x28_Vector { get { return Read<Vector>(0x28); } } // ItemSize 8
			public Vector x60_Vector { get { return Read<Vector>(0x60); } } // ItemSize 8
			public int x98_Neg1 { get { return Read<int>(0x98); } }
			public int _x9C { get { return Read<int>(0x9C); } }
			public int _xA0 { get { return Read<int>(0xA0); } }
			public int _xA4 { get { return Read<int>(0xA4); } }
			public int _xA8 { get { return Read<int>(0xA8); } }
			public int _xAC { get { return Read<int>(0xAC); } }
			public int _xB0 { get { return Read<int>(0xB0); } }
			public int _xB4 { get { return Read<int>(0xB4); } }
			public int _xB8 { get { return Read<int>(0xB8); } }
			public int _xBC { get { return Read<int>(0xBC); } }
			public int _xC0 { get { return Read<int>(0xC0); } }
			public int _xC4 { get { return Read<int>(0xC4); } }
			public int _xC8 { get { return Read<int>(0xC8); } }
			public int _xCC { get { return Read<int>(0xCC); } }
			public int _xD0 { get { return Read<int>(0xD0); } }
			public int _xD4 { get { return Read<int>(0xD4); } }
			public int _xD8 { get { return Read<int>(0xD8); } }
			public int _xDC { get { return Read<int>(0xDC); } }
			public int _xE0 { get { return Read<int>(0xE0); } }
			public int xE4_1f { get { return Read<int>(0xE4); } }
		}

		public class Struct790 : MemoryObject
		{
			public const int SizeOf = 0x124; // 292

			// 0x1000: Rendering?
			// 0x0200: Paused?
			// 0x0010: InGame?
			public int x000_Flags { get { return Read<int>(0x000); } }
			public int _x004 { get { return Read<int>(0x004); } }
			public int _x008 { get { return Read<int>(0x008); } }
			public int _x00C { get { return Read<int>(0x00C); } }
			public int _x010 { get { return Read<int>(0x010); } }
			public int _x014 { get { return Read<int>(0x014); } }
			public int _x018 { get { return Read<int>(0x018); } }
			public int _x01C { get { return Read<int>(0x01C); } }
			public int _x020 { get { return Read<int>(0x020); } }
			public int _x024 { get { return Read<int>(0x024); } }
			public int _x028 { get { return Read<int>(0x028); } }
			public int _x02C { get { return Read<int>(0x02C); } }
			public int _x030 { get { return Read<int>(0x030); } }
			public int _x034 { get { return Read<int>(0x034); } }
			public int x038_WorldId_ { get { return Read<int>(0x038); } }
			public int _x03C { get { return Read<int>(0x03C); } }
			// 0x01: Loading?
			// 0x00: Loaded?
			public int x040_Flag { get { return Read<int>(0x040); } }
			public int _x044 { get { return Read<int>(0x044); } }
			public int _x048 { get { return Read<int>(0x048); } }
			public int _x04C { get { return Read<int>(0x04C); } }
			public int _x050 { get { return Read<int>(0x050); } }
			public int x054_FrameCount { get { return Read<int>(0x054); } }
			public int x058_FrameTimestamp { get { return Read<int>(0x058); } }
			public int _x05C { get { return Read<int>(0x05C); } }
			public int x060_Flag { get { return Read<int>(0x060); } }
			public int _x064 { get { return Read<int>(0x064); } }
			public int _x068 { get { return Read<int>(0x068); } }
			public int _x06C { get { return Read<int>(0x06C); } }
			public int _x070 { get { return Read<int>(0x070); } }
			public int _x074 { get { return Read<int>(0x074); } }
			public int _x078 { get { return Read<int>(0x078); } }
			public int _x07C { get { return Read<int>(0x07C); } }
			public float _x080 { get { return Read<float>(0x080); } }
			public float _x084 { get { return Read<float>(0x084); } }
			public float _x088 { get { return Read<float>(0x088); } }
			public float _x08C { get { return Read<float>(0x08C); } }
			public float _x090 { get { return Read<float>(0x090); } }
			public float _x094 { get { return Read<float>(0x094); } }
			public int _x098 { get { return Read<int>(0x098); } }
			public float _x09C { get { return Read<float>(0x09C); } }
			public float _x0A0 { get { return Read<float>(0x0A0); } }
			public float _x0A4 { get { return Read<float>(0x0A4); } }
			public int _x0A8 { get { return Read<int>(0x0A8); } }
			public float _x0AC { get { return Read<float>(0x0AC); } }
			public float _x0B0 { get { return Read<float>(0x0B0); } }
			public float _x0B4 { get { return Read<float>(0x0B4); } }
			public float _x0B8 { get { return Read<float>(0x0B8); } }
			public float _x0BC { get { return Read<float>(0x0BC); } }
			public float _x0C0 { get { return Read<float>(0x0C0); } }
			public float _x0C4 { get { return Read<float>(0x0C4); } }
			public int _x0C8 { get { return Read<int>(0x0C8); } }
			public float _x0CC { get { return Read<float>(0x0CC); } }
			public int _x0D0 { get { return Read<int>(0x0D0); } }
			public int _x0D4 { get { return Read<int>(0x0D4); } }
			public int _x0D8 { get { return Read<int>(0x0D8); } }
			public int _x0DC { get { return Read<int>(0x0DC); } }
			public int _x0E0 { get { return Read<int>(0x0E0); } }
			public int _x0E4 { get { return Read<int>(0x0E4); } }
			public int _x0E8 { get { return Read<int>(0x0E8); } }
			public int _x0EC { get { return Read<int>(0x0EC); } }
			public int _x0F0 { get { return Read<int>(0x0F0); } }
			public int _x0F4 { get { return Read<int>(0x0F4); } }
			public int _x0F8 { get { return Read<int>(0x0F8); } }
			public int _x0FC { get { return Read<int>(0x0FC); } }
			public int _x100 { get { return Read<int>(0x100); } }
			public int _x104 { get { return Read<int>(0x104); } }
			public int _x108 { get { return Read<int>(0x108); } }
			public int _x10C { get { return Read<int>(0x10C); } }
			public int _x110_IsGamePaused { get { return Read<int>(0x110); } } // 1 for Achievements, Dialogs etc ?
			public int _x114 { get { return Read<int>(0x114); } }
			public int _x118 { get { return Read<int>(0x118); } }
		}
	}

	public partial class ObjectManager
	{
		//[ThreadStatic]
		//private static ObjectCache<ObjectManager> _instance = new ObjectCache<ObjectManager>(() =>
		//	Engine.TryGet(engine => engine.ObjectManager)) { IsFinalIfNotNull = true };

		public static ObjectManager Instance { get { return Engine.TryGet(a => a.ObjectManager); } }
	}
}
