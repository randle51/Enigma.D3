using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;

namespace Enigma.D3
{
	public partial class PlayerDataManager : MemoryObject
	{
		// 2.0.5.24017
		public const int SizeOf = 0x68A98; // 428696

		public Allocator x0000_Allocator_10x272Bytes { get { return Read<Allocator>(0x00); } }
		public Allocator x001C_Allocator_10x12Bytes { get { return Read<Allocator>(0x1C); } }
		public Allocator x0038_Allocator_10x16Bytes { get { return Read<Allocator>(0x38); } }
		public int _x0054 { get { return Read<int>(0x54); } }
		[ArraySize(8)]
		public PlayerData[] x0058_Items { get { return Read<PlayerData>(0x58, 8); } }
	}

	public partial class PlayerDataManager
	{
		public static PlayerDataManager Instance { get { return Storage.Instance.IfNotNull(a => a.x0FC_PlayerDataCollection); } }
	}
}
