using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.Memory;

namespace Enigma.D3
{
	public class GlobalStruct013 : MemoryObject
	{
		public const int SizeOf = 0x9C;

		public int x00_Neg1 { get { return Read<int>(0x00); } }
		public X04 x04_Struct { get { return Read<X04>(0x04); } }
		public int x98_Neg1 { get { return Read<int>(0x98); } }

		public class X04 : MemoryObject
		{
			public const int SizeOf = 0x94;

			public int x00_Neg1 { get { return Read<int>(0x00); } }
			public int x04_Neg1 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public int x10_Neg1 { get { return Read<int>(0x10); } }
			public RefString x14_RefString { get { return Read<RefString>(0x14); } }
			public RefString x20_RefString { get { return Read<RefString>(0x20); } }
			public RefString x2C_RefString { get { return Read<RefString>(0x2C); } }
			public RefString x38_RefString { get { return Read<RefString>(0x38); } }
			public RefString x44_RefString { get { return Read<RefString>(0x44); } }
			public RefString x50_RefString { get { return Read<RefString>(0x50); } }
			public RefString x5C_RefString { get { return Read<RefString>(0x5C); } }
			public RefString x68_RefString { get { return Read<RefString>(0x68); } }
			public RefString x74_RefString { get { return Read<RefString>(0x74); } }
			public RefString x80_RefString { get { return Read<RefString>(0x80); } }
			public int x8C_Neg1 { get { return Read<int>(0x8C); } }
			public int x90_Neg1 { get { return Read<int>(0x90); } }
		}
	}
}
