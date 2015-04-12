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
		public const int SizeOf = 0x38 + PlayerData.SizeOf * 8;

		public Allocator x0000_Allocator_10x272Bytes { get { return Read<Allocator>(0x00); } }
		public Allocator x001C_Allocator_10x12Bytes { get { return Read<Allocator>(0x1C); } }
		[ArraySize(8)]
		public PlayerData[] x0038_Items { get { return Read<PlayerData>(0x38, 8); } }
	}

	public partial class PlayerDataManager
	{
		public static PlayerDataManager Instance { get { return Storage.Instance.IfNotNull(a => a.x10C_PlayerDataCollection); } }
	}
}
