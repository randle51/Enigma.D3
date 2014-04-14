using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Enums;
using Enigma.D3.Memory;

namespace Enigma.D3
{
	public class ActorCommonData : MemoryObject
	{
		// 2.0.0.20874
		public const int SizeOf = 0x2F8; // = 760

		public ActorCommonData(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x000_Id { get { return Field<int>(0x000); } }
		public string x004_Name { get { return Field(0x004, 128); } }
		public int _x084 { get { return Field<int>(0x084); } }
		public int _x088 { get { return Field<int>(0x088); } }
		public int x08C_ActorId { get { return Field<int>(0x08C); } }
		public int x090_SnoId { get { return Field<int>(0x090); } }
		public int _x094 { get { return Field<int>(0x094); } }
		public int _x098 { get { return Field<int>(0x098); } }
		public int _x09C { get { return Field<int>(0x09C); } }
		public int _x0A0 { get { return Field<int>(0x0A0); } }
		public int _x0A4 { get { return Field<int>(0x0A4); } }
		public int _x0A8 { get { return Field<int>(0x0A8); } }
		public int _x0AC { get { return Field<int>(0x0AC); } }
		public int _x0B0 { get { return Field<int>(0x0B0); } }
		public int _x0B4 { get { return Field<int>(0x0B4); } }
		public int _x0B8 { get { return Field<int>(0x0B8); } }
		public int _x0BC { get { return Field<int>(0x0BC); } }
		public int _x0C0 { get { return Field<int>(0x0C0); } }
		public int _x0C4 { get { return Field<int>(0x0C4); } }
		public float x0C8_Direction { get { return Field<float>(0x0C8); } }
		public float x0CC_Direction { get { return Field<float>(0x0CC); } }
		public float x0D0_WorldPosX { get { return Field<float>(0x0D0); } }
		public float x0D4_WorldPosY { get { return Field<float>(0x0D4); } }
		public float x0D8_WorldPosZ { get { return Field<float>(0x0D8); } }
		public float x0DC_Radius { get { return Field<float>(0x0DC); } }
		public float _x0E0 { get { return Field<float>(0x0E0); } }
		public float _x0E4 { get { return Field<float>(0x0E4); } }
		public float _x0E8 { get { return Field<float>(0x0E8); } }
		public float _x0EC { get { return Field<float>(0x0EC); } }
		public float _x0F0 { get { return Field<float>(0x0F0); } }
		public float _x0F4 { get { return Field<float>(0x0F4); } }
		public float _x0F8 { get { return Field<float>(0x0F8); } }
		public float _x0FC { get { return Field<float>(0x0FC); } }
		public float _x100 { get { return Field<float>(0x100); } }
		public int _x104 { get { return Field<int>(0x104); } }
		public int x108_WorldId { get { return Field<int>(0x108); } }
		public int _x10C { get { return Field<int>(0x10C); } }
		public float x110 { get { return Field<int>(0x110); } }
		public int _x114 { get { return Field<int>(0x114); } }
		public int _x118 { get { return Field<int>(0x118); } }
		public int _x11C { get { return Field<int>(0x11C); } }
		public int x120_FastAttribGroupId { get { return Field<int>(0x120); } }
		public int _x124 { get { return Field<int>(0x124); } }
		public int _x128 { get { return Field<int>(0x128); } }
		public int _x12C { get { return Field<int>(0x12C); } }
		public int _x130 { get { return Field<int>(0x130); } }
		public int _x134 { get { return Field<int>(0x134); } }
		public int _x138 { get { return Field<int>(0x138); } }
		public int _x13C { get { return Field<int>(0x13C); } }
		public int _x140 { get { return Field<int>(0x140); } }
		public int _x144 { get { return Field<int>(0x144); } }
		public int _x148 { get { return Field<int>(0x148); } }
		public int _x14C { get { return Field<int>(0x14C); } }
		public int _x150 { get { return Field<int>(0x150); } }
		public int _x154 { get { return Field<int>(0x154); } }
		public int _x158 { get { return Field<int>(0x158); } }
		public int _x15C { get { return Field<int>(0x15C); } }
		public int _x160 { get { return Field<int>(0x160); } }
		public int _x164 { get { return Field<int>(0x164); } }
		public int _x168 { get { return Field<int>(0x168); } }
		public int _x16C { get { return Field<int>(0x16C); } }
		public int _x170 { get { return Field<int>(0x170); } }
		public int _x174 { get { return Field<int>(0x174); } }
		public int _x178 { get { return Field<int>(0x178); } }
		public int _x17C { get { return Field<int>(0x17C); } }
		public GizmoType x180_GizmoType { get { return (GizmoType)Field<int>(0x180); } }
		public ActorType x184_ActorType { get { return (ActorType)Field<int>(0x184); } }
		public float x188_Hitpoints { get { return Field<float>(0x188); } }
		public int x18C_TeamIdOverride { get { return Field<int>(0x18C); } }
		public int x190_TeamId { get { return Field<int>(0x190); } }
		public int _x194 { get { return Field<int>(0x194); } }
		public int x198_FollowPlayerIndex { get { return Field<int>(0x198); } } // 7 = None
		public int _x19C { get { return Field<int>(0x19C); } }
		public int _x1A0 { get { return Field<int>(0x1A0); } }
		public int _x1A4 { get { return Field<int>(0x1A4); } }
		public int _x1A8 { get { return Field<int>(0x1A8); } }
		public int _x1AC { get { return Field<int>(0x1AC); } }
		public int _x1B0 { get { return Field<int>(0x1B0); } }
		public int _x1B4 { get { return Field<int>(0x1B4); } }
		public int _x1B8 { get { return Field<int>(0x1B8); } }
		public int _x1BC { get { return Field<int>(0x1BC); } }
		public int _x1C0 { get { return Field<int>(0x1C0); } }
		public int _x1C4 { get { return Field<int>(0x1C4); } }
		public int _x1C8 { get { return Field<int>(0x1C8); } }
		public int _x1CC { get { return Field<int>(0x1CC); } }
		public int _x1D0 { get { return Field<int>(0x1D0); } }
		public int _x1D4 { get { return Field<int>(0x1D4); } }
		public int _x1D8 { get { return Field<int>(0x1D8); } }
		public int _x1DC { get { return Field<int>(0x1DC); } }
		public int _x1E0 { get { return Field<int>(0x1E0); } }
		public int _x1E4 { get { return Field<int>(0x1E4); } }
		public int _x1E8 { get { return Field<int>(0x1E8); } }
		public int _x1EC { get { return Field<int>(0x1EC); } }
		public int _x1F0 { get { return Field<int>(0x1F0); } }
		public int _x1F4 { get { return Field<int>(0x1F4); } }
		public int _x1F8 { get { return Field<int>(0x1F8); } }
		public int _x1FC { get { return Field<int>(0x1FC); } }
		public int _x200 { get { return Field<int>(0x200); } }
		public int _x204 { get { return Field<int>(0x204); } }
		public int _x208 { get { return Field<int>(0x208); } }
		public int _x20C { get { return Field<int>(0x20C); } }
		public int _x210 { get { return Field<int>(0x210); } }
		public int _x214 { get { return Field<int>(0x214); } }
		public int _x218 { get { return Field<int>(0x218); } }
		public int _x21C { get { return Field<int>(0x21C); } }
		public int _x220 { get { return Field<int>(0x220); } }
		public int _x224 { get { return Field<int>(0x224); } }
		public int _x228 { get { return Field<int>(0x228); } }
		public int _x22C { get { return Field<int>(0x22C); } }
		public int _x230 { get { return Field<int>(0x230); } }
		public int _x234 { get { return Field<int>(0x234); } }
		public int _x238 { get { return Field<int>(0x238); } }
		public int _x23C { get { return Field<int>(0x23C); } }
		public int _x240 { get { return Field<int>(0x240); } }
		public int _x244 { get { return Field<int>(0x244); } }
		public int _x248 { get { return Field<int>(0x248); } }
		public int _x24C { get { return Field<int>(0x24C); } }
		public float _x250 { get { return Field<float>(0x250); } }
		public float _x254 { get { return Field<float>(0x254); } }
		public float _x258 { get { return Field<float>(0x258); } }
		public float _x25C { get { return Field<float>(0x25C); } }
		public float _x260 { get { return Field<float>(0x260); } }
		public float _x264 { get { return Field<float>(0x264); } }
		public float _x268 { get { return Field<float>(0x268); } }
		public float _x26C { get { return Field<float>(0x26C); } }
		public float _x270 { get { return Field<float>(0x270); } }
		public float _x274 { get { return Field<float>(0x274); } }
		public int _x278 { get { return Field<int>(0x278); } }
		public int _x27C { get { return Field<int>(0x27C); } }
		public int _x280 { get { return Field<int>(0x280); } }
		public int _x284 { get { return Field<int>(0x284); } }
		public int _x288 { get { return Field<int>(0x288); } }
		public int _x28C { get { return Field<int>(0x28C); } }
		public Allocator x290_PtrAllocator_FieldX2D0 { get { return Dereference<Allocator>(0x290); } }
		public int _x294 { get { return Field<int>(0x294); } }
		public int _x298 { get { return Field<int>(0x298); } }
		public int _x29C { get { return Field<int>(0x29C); } }
		public int _x2A0 { get { return Field<int>(0x2A0); } }
		public int _x2A4 { get { return Field<int>(0x2A4); } }
		public BasicAllocator x2A8_DynAllocator { get { return Field<BasicAllocator>(0x2A8); } }
		public int _x2C4 { get { return Field<int>(0x2C4); } }
		public int _x2C8 { get { return Field<int>(0x2C8); } }
		public int _x2CC { get { return Field<int>(0x2CC); } }
		public Allocator x2D0_Allocator_16x12Bytes { get { return Field<Allocator>(0x2D0); } }
		public int _x2EC { get { return Field<int>(0x2EC); } }
		public int _x2F0 { get { return Field<int>(0x2F0); } }
		public int _x2F4 { get { return Field<int>(0x2F4); } }
	}
}
