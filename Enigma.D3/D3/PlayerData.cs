using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3
{
	public class PlayerData : MemoryObject
	{
		// 2.0.0.21962
		public const int SizeOf = 0xD138; // = 53560

		public PlayerData(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x0000_Index { get { return Field<int>(0x0000); } }

		public int x0004_AcdId { get { return Field<int>(0x0004); } }
		public int x0008_ActorId { get { return Field<int>(0x0008); } }

		public byte[] _x0000 { get { return Field<byte>(0x0000, 4096); } }
		public byte[] _x1000 { get { return Field<byte>(0x1000, 4096); } }
		public byte[] _x2000 { get { return Field<byte>(0x2000, 4096); } }
		public byte[] _x3000 { get { return Field<byte>(0x3000, 4096); } }
		public byte[] _x4000 { get { return Field<byte>(0x4000, 4096); } }
		public byte[] _x5000 { get { return Field<byte>(0x5000, 4096); } }
		public byte[] _x6000 { get { return Field<byte>(0x6000, 4096); } }
		public byte[] _x7000 { get { return Field<byte>(0x7000, 4096); } }
		public byte[] _x8000 { get { return Field<byte>(0x8000, 4096); } }
		public byte[] _x9000 { get { return Field<byte>(0x9000, 4096); } }
		public byte[] _xA000 { get { return Field<byte>(0xA000, 4096); } }
		public byte[] _xB000 { get { return Field<byte>(0xB000, 4096); } }
		public byte[] _xC000 { get { return Field<byte>(0xC000, 4096); } }
		public int _xD000 { get { return Field<int>(0xD000); } }
		public int _xD004 { get { return Field<int>(0xD004); } }
		public int _xD008 { get { return Field<int>(0xD008); } }
		public int _xD00C { get { return Field<int>(0xD00C); } }
		public int _xD010 { get { return Field<int>(0xD010); } }
		public int _xD014 { get { return Field<int>(0xD014); } }
		public int _xD018 { get { return Field<int>(0xD018); } }
		public int _xD01C { get { return Field<int>(0xD01C); } }
		public int _xD020 { get { return Field<int>(0xD020); } }
		public int _xD024 { get { return Field<int>(0xD024); } }
		public int _xD028 { get { return Field<int>(0xD028); } }
		public int _xD02C { get { return Field<int>(0xD02C); } }
		public int _xD030 { get { return Field<int>(0xD030); } }
		public int _xD034 { get { return Field<int>(0xD034); } }
		public int _xD038 { get { return Field<int>(0xD038); } }
		public int _xD03C { get { return Field<int>(0xD03C); } }
		public int _xD040 { get { return Field<int>(0xD040); } }
		public int _xD044 { get { return Field<int>(0xD044); } }
		public int _xD048 { get { return Field<int>(0xD048); } }
		public int _xD04C { get { return Field<int>(0xD04C); } }
		public int _xD050 { get { return Field<int>(0xD050); } }
		public int _xD054 { get { return Field<int>(0xD054); } }
		public int _xD058 { get { return Field<int>(0xD058); } }
		public int _xD05C { get { return Field<int>(0xD05C); } }
		public int _xD060 { get { return Field<int>(0xD060); } }
		public int _xD064 { get { return Field<int>(0xD064); } }
		public int _xD068 { get { return Field<int>(0xD068); } }
		public int _xD06C { get { return Field<int>(0xD06C); } }
		public int _xD070 { get { return Field<int>(0xD070); } }
		public int _xD074 { get { return Field<int>(0xD074); } }
		public int _xD078 { get { return Field<int>(0xD078); } }
		public int _xD07C { get { return Field<int>(0xD07C); } }
		public int _xD080 { get { return Field<int>(0xD080); } }
		public int _xD084 { get { return Field<int>(0xD084); } }
		public int _xD088 { get { return Field<int>(0xD088); } }
		public int _xD08C { get { return Field<int>(0xD08C); } }
		public int _xD090 { get { return Field<int>(0xD090); } }
		public int _xD094 { get { return Field<int>(0xD094); } }
		public int _xD098 { get { return Field<int>(0xD098); } }
		public int _xD09C { get { return Field<int>(0xD09C); } }
		public int _xD0A0 { get { return Field<int>(0xD0A0); } }
		public int _xD0A4 { get { return Field<int>(0xD0A4); } }
		public int _xD0A8 { get { return Field<int>(0xD0A8); } }
		public int _xD0AC { get { return Field<int>(0xD0AC); } }
		public int _xD0B0 { get { return Field<int>(0xD0B0); } }
		public int _xD0B4 { get { return Field<int>(0xD0B4); } }
		public int _xD0B8 { get { return Field<int>(0xD0B8); } }
		public int _xD0BC { get { return Field<int>(0xD0BC); } }
		public int _xD0C0 { get { return Field<int>(0xD0C0); } }
		public int _xD0C4 { get { return Field<int>(0xD0C4); } }
		public int _xD0C8 { get { return Field<int>(0xD0C8); } }
		public int _xD0CC { get { return Field<int>(0xD0CC); } }



		public VendorToken[] xB5E4_VendorTokens { get { return Field<VendorToken>(0xB5E4, 256); } }
		public int xBDE4_VendorTokenCount { get { return Field<int>(0xBDE4); } }

		public IEnumerable<VendorToken> EnumerateVendorTokens()
		{
			return xB5E4_VendorTokens.Take(xBDE4_VendorTokenCount);
		}

		public class VendorToken : MemoryObject
		{
			public const int SizeOf = 8;

			public VendorToken(ProcessMemory memory, int address)
				: base(memory, address) { }

			public int x00_GameBalanceId { get { return Field<int>(0x00); } }
			public int x04_Value { get { return Field<int>(0x04); } }
		}
	}
}
