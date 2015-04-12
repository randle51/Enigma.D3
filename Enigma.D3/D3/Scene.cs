using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;

namespace Enigma.D3
{
	[Obsolete]
	public partial class Scene : MemoryObject
	{
		public const int SizeOf = 0x6C4;

		public int x000_Id { get { return Read<int>(0x000); } }
		public int x004_StructStart_Internal_SceneId { get { return Read<int>(0x004); } }
		public int x008_WorldId { get { return Read<int>(0x008); } }
		public int _x00C { get { return Read<int>(0x00C); } }
		public int _x010 { get { return Read<int>(0x010); } }
		public int _x014 { get { return Read<int>(0x014); } }
		public int x018_LevelAreaSnoId { get { return Read<int>(0x018); } }
		public int _x01C { get { return Read<int>(0x01C); } }
		public int _x020 { get { return Read<int>(0x020); } }
		public int _x024 { get { return Read<int>(0x024); } }
		public int _x028 { get { return Read<int>(0x028); } }
		public int _x02C { get { return Read<int>(0x02C); } }
		public int _x030 { get { return Read<int>(0x030); } }
		public int _x034 { get { return Read<int>(0x034); } }
		public int _x038 { get { return Read<int>(0x038); } }
		public int _x03C { get { return Read<int>(0x03C); } }
		public int x040_MusicSnoId { get { return Read<int>(0x040); } }
		public int x044_AmbientSoundSnoId { get { return Read<int>(0x044); } }
		public int x048_ReverbSnoId { get { return Read<int>(0x048); } }
		public int x04C_WeatherSnoId { get { return Read<int>(0x04C); } }
		public int x050_WorldsSnoId { get { return Read<int>(0x050); } }
		public int _x054 { get { return Read<int>(0x054); } }
		public int _x058 { get { return Read<int>(0x058); } }
		public int _x05C { get { return Read<int>(0x05C); } }
		public int _x060 { get { return Read<int>(0x060); } }
		public int _x064 { get { return Read<int>(0x064); } }
		public int _x068 { get { return Read<int>(0x068); } }
		public int _x06C { get { return Read<int>(0x06C); } }
		public int _x070 { get { return Read<int>(0x070); } }
		public int _x074 { get { return Read<int>(0x074); } }
		public int _x078 { get { return Read<int>(0x078); } }
		public int _x07C { get { return Read<int>(0x07C); } }
		public int _x080 { get { return Read<int>(0x080); } }
		public int _x084 { get { return Read<int>(0x084); } }
		public int _x088 { get { return Read<int>(0x088); } }
		public int _x08C { get { return Read<int>(0x08C); } }
		public int _x090 { get { return Read<int>(0x090); } }
		public int _x094 { get { return Read<int>(0x094); } }
		public int _x098 { get { return Read<int>(0x098); } }
		public int _x09C { get { return Read<int>(0x09C); } }
		public int _x0A0 { get { return Read<int>(0x0A0); } }
		public float x0A4 { get { return Read<float>(0x0A4); } }
		public float x0A8 { get { return Read<float>(0x0A8); } }
		public float x0AC { get { return Read<float>(0x0AC); } }
		public float x0B0 { get { return Read<float>(0x0B0); } }
		public float x0B4 { get { return Read<float>(0x0B4); } }
		public float x0B8 { get { return Read<float>(0x0B8); } }
		public float x0BC { get { return Read<float>(0x0BC); } }
		public float x0C0 { get { return Read<float>(0x0C0); } }
		public float x0C4 { get { return Read<float>(0x0C4); } }
		public float x0C8 { get { return Read<float>(0x0C8); } }
		public float x0CC { get { return Read<float>(0x0CC); } }
		public float x0D0 { get { return Read<float>(0x0D0); } }
		public int _x0D4 { get { return Read<int>(0x0D4); } }
		public int _x0D8 { get { return Read<int>(0x0D8); } }
		public int _x0DC { get { return Read<int>(0x0DC); } }
		public int _x0E0 { get { return Read<int>(0x0E0); } }
		public int _x0E4 { get { return Read<int>(0x0E4); } }
		public int x0E8_SceneSnoId { get { return Read<int>(0x0E8); } }
		public int x0EC_StructStart { get { return Read<int>(0x0EC); } }
		public int _x0F0 { get { return Read<int>(0x0F0); } }
		public int _x0F4 { get { return Read<int>(0x0F4); } }
		public float x0F8 { get { return Read<float>(0x0F8); } }
		public float x0FC { get { return Read<float>(0x0FC); } }
		public float x100 { get { return Read<float>(0x100); } }
		public float x104 { get { return Read<float>(0x104); } }
		public float x108 { get { return Read<float>(0x108); } }
		public float x10C { get { return Read<float>(0x10C); } }
		public float x110 { get { return Read<float>(0x110); } }
		public float x114 { get { return Read<float>(0x114); } }
		public float x118 { get { return Read<float>(0x118); } }
		public float x11C { get { return Read<float>(0x11C); } }
		public float x120 { get { return Read<float>(0x120); } }
		public float x124 { get { return Read<float>(0x124); } }
		public float x128 { get { return Read<float>(0x128); } }
		public float x12C { get { return Read<float>(0x12C); } }
		public float x130 { get { return Read<float>(0x130); } }
		public float x134 { get { return Read<float>(0x134); } }
		public float x138 { get { return Read<float>(0x138); } }
		public float x13C { get { return Read<float>(0x13C); } }
		public float x140 { get { return Read<float>(0x140); } }
		public float x144 { get { return Read<float>(0x144); } }
		public float x148 { get { return Read<float>(0x148); } }
		public float x14C { get { return Read<float>(0x14C); } }
		public float x150 { get { return Read<float>(0x150); } }
		public float x154 { get { return Read<float>(0x154); } }
		public float x158 { get { return Read<float>(0x158); } }
		public float x15C { get { return Read<float>(0x15C); } }
		public float x160 { get { return Read<float>(0x160); } }
		public float x164 { get { return Read<float>(0x164); } }
		public float x168 { get { return Read<float>(0x168); } }
		public float x16C { get { return Read<float>(0x16C); } }
		public float x170 { get { return Read<float>(0x170); } }
		public float x174 { get { return Read<float>(0x174); } }
		public float x178 { get { return Read<float>(0x178); } }
		public int _x17C { get { return Read<int>(0x17C); } }
		public int _x180 { get { return Read<int>(0x180); } }
		public int _x184 { get { return Read<int>(0x184); } }
		public int _x188 { get { return Read<int>(0x188); } }
		public int x18C { get { return Read<int>(0x18C); } }
		public int _x190 { get { return Read<int>(0x190); } }
		public int _x194 { get { return Read<int>(0x194); } }
		public int x198_Flags { get { return Read<int>(0x198); } }
		public int _x19C { get { return Read<int>(0x19C); } }
		public int _x1A0 { get { return Read<int>(0x1A0); } }
		public int x1A4 { get { return Read<int>(0x1A4); } }
		public int _x1A8 { get { return Read<int>(0x1A8); } }
		public LinkedList.Node x1AC_Ptr_ListNode_ { get { return Dereference<LinkedList.Node>(0x1AC); } }
		public int _x1B0 { get { return Read<int>(0x1B0); } }
		public int _x1B4 { get { return Read<int>(0x1B4); } }
		public int _x1B8 { get { return Read<int>(0x1B8); } }
		public int _x1BC { get { return Read<int>(0x1BC); } }
		public int x1C0_SceneSnoId_ { get { return Read<int>(0x1C0); } }
		public int _x1C4 { get { return Read<int>(0x1C4); } }
		public int _x1C8 { get { return Read<int>(0x1C8); } }
		public int _x1CC { get { return Read<int>(0x1CC); } }
		public int _x1D0 { get { return Read<int>(0x1D0); } }
		public int _x1D4 { get { return Read<int>(0x1D4); } }
		public int _x1D8 { get { return Read<int>(0x1D8); } }
		public int _x1DC { get { return Read<int>(0x1DC); } }
		public int _x1E0 { get { return Read<int>(0x1E0); } }
		public int _x1E4 { get { return Read<int>(0x1E4); } }
		public int _x1E8 { get { return Read<int>(0x1E8); } }
		public int _x1EC { get { return Read<int>(0x1EC); } }
		public int _x1F0 { get { return Read<int>(0x1F0); } }
		public int _x1F4 { get { return Read<int>(0x1F4); } }
		public int _x1F8 { get { return Read<int>(0x1F8); } }
		public int _x1FC { get { return Read<int>(0x1FC); } }
		public int _x200 { get { return Read<int>(0x200); } }
		public int _x204 { get { return Read<int>(0x204); } }
		public int _x208 { get { return Read<int>(0x208); } }
		public int _x20C { get { return Read<int>(0x20C); } }
		public int _x210 { get { return Read<int>(0x210); } }
		public int _x214 { get { return Read<int>(0x214); } }
		public int _x218 { get { return Read<int>(0x218); } }
		public int _x21C { get { return Read<int>(0x21C); } }
		public int _x220 { get { return Read<int>(0x220); } }
		public int _x224 { get { return Read<int>(0x224); } }
		public int _x228 { get { return Read<int>(0x228); } }
		public int x22C_Flags { get { return Read<int>(0x22C); } }
		public int _x230 { get { return Read<int>(0x230); } }
		public int _x234 { get { return Read<int>(0x234); } }
		public int x238_StructStart_Min28Bytes { get { return Read<int>(0x238); } }
		public int _x23C { get { return Read<int>(0x23C); } }
		public int _x240 { get { return Read<int>(0x240); } }
		public int _x244 { get { return Read<int>(0x244); } }
		public int _x248 { get { return Read<int>(0x248); } }
		public int _x24C { get { return Read<int>(0x24C); } }
		public int _x250 { get { return Read<int>(0x250); } }
		public int x254_StructStart { get { return Read<int>(0x254); } }
		public int _x258 { get { return Read<int>(0x258); } }
		public int _x25C { get { return Read<int>(0x25C); } }
		public int x260_PtrListNodeAllocator { get { return Read<int>(0x260); } }
		public int _x264 { get { return Read<int>(0x264); } }
		public int x268 { get { return Read<int>(0x268); } }
		public int _x26C { get { return Read<int>(0x26C); } }
		public int _x270 { get { return Read<int>(0x270); } }
		public int _x274 { get { return Read<int>(0x274); } }
		public int x278_AppearanceSnoId { get { return Read<int>(0x278); } }
		public int x27C_StructStart_Min44Bytes { get { return Read<int>(0x27C); } }
		public int _x280 { get { return Read<int>(0x280); } }
		public int _x284 { get { return Read<int>(0x284); } }
		public int _x288 { get { return Read<int>(0x288); } }
		public int _x28C { get { return Read<int>(0x28C); } }
		public int _x290 { get { return Read<int>(0x290); } }
		public int _x294 { get { return Read<int>(0x294); } }
		public int _x298 { get { return Read<int>(0x298); } }
		public int _x29C { get { return Read<int>(0x29C); } }
		public int _x2A0 { get { return Read<int>(0x2A0); } }
		public int _x2A4 { get { return Read<int>(0x2A4); } }
		public ListB x2A8_ListB_ActorIds { get { return Read<ListB>(0x2A8); } }
	}

	public partial class Scene
	{
		public static Container<Scene> Container { get { return ObjectManager.Instance.IfNotNull(a => a.x978_Scenes); } }
	}
}
