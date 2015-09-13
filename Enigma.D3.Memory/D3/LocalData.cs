using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3
{
	public partial class LocalData : MemoryObject
	{
		// 2.0.4.23119
		public const int SizeOf = 0x38;

		public int x00_IsActorCreated { get { return Read<int>(0x00); } }
		public int x04_IsNotInGame { get { return Read<int>(0x04); } }
		public int x08_SceneSnoId { get { return Read<int>(0x08); } }
		public int x0C_WorldSnoId { get { return Read<int>(0x0C); } }
		public int x10_ActorSnoId { get { return Read<int>(0x10); } }
		public int x14_ActId { get { return Read<int>(0x14); } }
		public int x18_WorldSeed { get { return Read<int>(0x18); } }
		public int x1C_QuestId { get { return Read<int>(0x1C); } }
		public int x20_QuestStep { get { return Read<int>(0x20); } }
		public float x24_WorldPosX { get { return Read<float>(0x24); } }
		public float x28_WorldPosY { get { return Read<float>(0x28); } }
		public float x2C_WorldPosZ { get { return Read<float>(0x2C); } }
		public int x30_PlayerDataSlotsInUse { get { return Read<int>(0x30); } }
		public int x34_IsPlayerDataCreated { get { return Read<int>(0x34); } }
	}

	public partial class LocalData
	{
		public static LocalData Instance { get { return Engine.Current.LocalData; } }
	}
}
