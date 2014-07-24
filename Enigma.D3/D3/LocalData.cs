using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3
{
	public class LocalData : MemoryObject
	{
		// 2.0.4.23119
		public const int SizeOf = 0x38;

		public LocalData(MemoryBase memory, int address)
			: base(memory, address) { }

		public int x00_IsActorCreated { get { return Field<int>(0x00); } }
		public int x04_IsNotInGame { get { return Field<int>(0x04); } }
		public int x08_SceneSnoId { get { return Field<int>(0x08); } }
		public int x0C_WorldSnoId { get { return Field<int>(0x0C); } }
		public int x10_ActorSnoId { get { return Field<int>(0x10); } }
		public int x14_ActId { get { return Field<int>(0x14); } }
		public int x18_WorldSeed { get { return Field<int>(0x18); } }
		public int x1C_QuestId { get { return Field<int>(0x1C); } }
		public int x20_QuestStep { get { return Field<int>(0x20); } }
		public float x24_WorldPosX { get { return Field<float>(0x24); } }
		public float x28_WorldPosY { get { return Field<float>(0x28); } }
		public float x2C_WorldPosZ { get { return Field<float>(0x2C); } }
		public int x30_PlayerDataSlotsInUse { get { return Field<int>(0x30); } }
		public int x34_IsPlayerDataCreated { get { return Field<int>(0x34); } }
	}
}
