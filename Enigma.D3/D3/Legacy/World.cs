using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class World : MemoryObject
	{
		public const int SizeOf = 0x4C; // 1.0.8.16603 : Taken from container.

		public World(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x00_Id { get { return Field<int>(0x00); } } // There is 1 reference in memory that is pointing to current active world. Path unknown.
		public int x04_SnoId { get { return Field<int>(0x04); } }
		public int x08_Id { get { return Field<int>(0x08); } } // There is what's normally used for reference.
		public TileSize x0C_NavMeshTileSize { get { return Dereference<TileSize>(0x0C); } }
		public int _x10 { get { return Field<int>(0x10); } }
		public int _x14 { get { return Field<int>(0x14); } }
		public int _x18 { get { return Field<int>(0x18); } }
		public int _x1C { get { return Field<int>(0x1C); } }
		public int x20_Status_ { get { return Field<int>(0x20); } }
		public int _x24 { get { return Field<int>(0x24); } }
		public int _x28 { get { return Field<int>(0x28); } }
		public int _x2C { get { return Field<int>(0x2C); } }
		public int _x30 { get { return Field<int>(0x30); } }
		public int x34_LastRegisteredGameTick { get { return Field<int>(0x34); } } // Is updated when warping into world or moving enough distance.
		public int x38 { get { return Field<int>(0x38); } }
		public int _x3C { get { return Field<int>(0x3C); } }
		public int x40 { get { return Field<int>(0x40); } }
		public int _x44 { get { return Field<int>(0x44); } }
		public int _x48 { get { return Field<int>(0x48); } }
	}

	public struct TileSize
	{
		int Width1; // From log: "World %s had invalid nav mesh tile size (%d by %d) when stitching scene!\n"
		int Height1; // From log: "World %s had invalid nav mesh tile size (%d by %d) when stitching scene!\n"
		int Width2; // Not sure what these are
		int Height2;// Not sure what these are

		public override string ToString()
		{
			return "{ " + Width1 + " by " + Height1 + " } { " + Width2 + " by " + Height2 + " }";
		}
	}
}
