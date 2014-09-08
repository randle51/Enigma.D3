using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Recipe : MemoryObject
	{
		// 2.1.0.26451
		public const int SizeOf = 0x48; // 72
		
		public SnoHeader x00_Header { get { return Read<SnoHeader>(0x00); } }
		public ItemSpecifierData x0C_ItemSpecifierData { get { return Read<ItemSpecifierData>(0x0C); } }
		public int x44 { get { return Read<int>(0x44); } }
		
		[CompilerGenerated]
		public partial class ItemSpecifierData : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x38; // 56
			
			public GameBalanceId x00_ItemsGameBalanceId { get { return Read<GameBalanceId>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public GameBalanceId[] x08_GameBalanceIds { get { return Read<GameBalanceId>(0x08, 6); } }
			public int x20 { get { return Read<int>(0x20); } }
			public int x24 { get { return Read<int>(0x24); } }
			public int x28 { get { return Read<int>(0x28); } }
			public int x2C { get { return Read<int>(0x2C); } }
			public int x30 { get { return Read<int>(0x30); } }
			public int x34 { get { return Read<int>(0x34); } }
		}
	}
}
