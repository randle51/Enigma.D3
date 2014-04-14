using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class Attachment : MemoryObject
	{
		public const int SizeOf = 0xA0; // 1.0.8.16603 : Taken from the container.

		public Attachment(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x00 { get { return Field<int>(0x00); } }
		public int x04_ActorId { get { return Field<int>(0x04); } }
		public int x08_SnoGroupId { get { return Field<int>(0x08); } } // 0x1B: ParticleSystem, 0x20: Rope, 0x26: Shake, 0x28: Sounds, 0x21: Scene, 0x2D: Trail, 0x05: AmbientSound, 0x11: Explosion, 0x17: Light, 0x01: Actor
		public int _x0C { get { return Field<int>(0x0C); } }
		public int _x10 { get { return Field<int>(0x10); } }
		public int x14_Id { get { return Field<int>(0x14); } }
		public int _x18 { get { return Field<int>(0x18); } }
		public int _x1C { get { return Field<int>(0x1C); } }
		public int _x20 { get { return Field<int>(0x20); } }
		public int _x24 { get { return Field<int>(0x24); } }
		public int _x28 { get { return Field<int>(0x28); } }
		public int _x2C { get { return Field<int>(0x2C); } }
		public int _x30 { get { return Field<int>(0x30); } }
		public int _x34 { get { return Field<int>(0x34); } }
		public int _x38 { get { return Field<int>(0x38); } }
		public int _x3C { get { return Field<int>(0x3C); } }
		public int _x40 { get { return Field<int>(0x40); } }
		public int _x44 { get { return Field<int>(0x44); } }
		public int _x48 { get { return Field<int>(0x48); } }
		public int _x4C { get { return Field<int>(0x4C); } }
		public int _x50 { get { return Field<int>(0x50); } }
		public int _x54 { get { return Field<int>(0x54); } }
		public int _x58 { get { return Field<int>(0x58); } }
		public int _x5C { get { return Field<int>(0x5C); } }
		public int _x60 { get { return Field<int>(0x60); } }
		public int _x64 { get { return Field<int>(0x64); } }
		public int _x68 { get { return Field<int>(0x68); } }
		public int _x6C { get { return Field<int>(0x6C); } }
		public int _x70 { get { return Field<int>(0x70); } }
		public int _x74 { get { return Field<int>(0x74); } }
		public int _x78 { get { return Field<int>(0x78); } }
		public int _x7C { get { return Field<int>(0x7C); } }
		public int _x80 { get { return Field<int>(0x80); } }
		public int _x84 { get { return Field<int>(0x84); } }
		public int _x88 { get { return Field<int>(0x88); } }
		public int _x8C { get { return Field<int>(0x8C); } }
		public int _x90 { get { return Field<int>(0x90); } }
		public int _x94 { get { return Field<int>(0x94); } }
		public int x98_Type { get { return Field<int>(0x98); } } // 0+5: Actor, 1: ParticleSystems, 3: Rope, 4: Scene, 2: Particles
		public int x9C_ActorId { get { return Field<int>(0x9C); } }
	}
}
