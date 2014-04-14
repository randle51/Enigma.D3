using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class GameGlobals : MemoryObject
	{
		// This seems to be a structure that defines how D3 should operate. There are different
		// modes to run in (see GameTypes) and this structure provides the necessary data.

		public const int SizeOf = 0x3B0; // 1.0.8.16603 : [009752A0] NOTE that this structure is allocated on stack initially.

		public GameGlobals(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x000 { get { return Field<int>(0x000); } }
		public int x004 { get { return Field<int>(0x004); } }
		public int x008 { get { return Field<int>(0x008); } }
		public int x00C { get { return Field<int>(0x00C); } }
		public int x010 { get { return Field<int>(0x010); } }
		public int x014 { get { return Field<int>(0x014); } }
		public bool x018_IsInGame { get { return Field<bool>(0x018); } }
		public int x018_Int32 { get { return Field<int>(0x018); } }
		public int x01C { get { return Field<int>(0x01C); } }
		public int x020 { get { return Field<int>(0x020); } }
		public int x024 { get { return Field<int>(0x024); } }
		public int x028 { get { return Field<int>(0x028); } }
		public GameType x02C_GameType { get { return (GameType)Field<int>(0x02C); } }
		public int x030 { get { return Field<int>(0x030); } }
		public int x034 { get { return Field<int>(0x034); } }
		public int x038 { get { return Field<int>(0x038); } }
		public int x03C { get { return Field<int>(0x03C); } }
		public byte[] x040 { get { return Field<byte>(0x040, 12); } }
		public long x04C_Long { get { return Field<long>(0x04C); } }
		public long x054_Long { get { return Field<long>(0x054); } }
		public int x05C { get { return Field<int>(0x05C); } }
		public string x060_GameServerAddress { get { return Field(0x060, 128); } } // Size used in XNetwork::Parse
		public byte[] x0E0 { get { return Field<byte>(0x0E0, 132); } }
		public int x164 { get { return Field<int>(0x164); } }
		public byte[] x168 { get { return Field<byte>(0x168, 256); } }
		public string x168_String { get { return Field(0x168, 256); } } // <-- Doesn't seem to contain anything
		public byte[] x268 { get { return Field<byte>(0x268, 256); } }
		public string x268_HeroName { get { return Field(0x268, 256); } } // <-- Suspecting a length of 128
		public byte[] x368 { get { return Field<byte>(0x368, 8); } }
		public long x370_Long { get { return Field<long>(0x370); } }
		public long x378_Long { get { return Field<long>(0x378); } }
		public long x380_Long { get { return Field<long>(0x380); } }
		public long x388_Long { get { return Field<long>(0x388); } }
		public long x390_Long { get { return Field<long>(0x390); } }
		public long x398_Long { get { return Field<long>(0x398); } }
		public int x3A0 { get { return Field<int>(0x3A0); } }
		public int x3A4 { get { return Field<int>(0x3A4); } }
		public int x3A8 { get { return Field<int>(0x3A8); } }
		public byte[] x3AC { get { return Field<byte>(0x3AC, 4); } }

		public enum GameType
		{
			ToolGame = 1,
			SinglePlayerGame = 2,
			NetworkClientGame = 3,
			NetworkClientLanServerGame = 4,
			NetworkBattleNet = 5,
			HiddenServer = 6
		}
	}
}
