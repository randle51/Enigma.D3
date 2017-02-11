using Enigma.D3.MemoryModel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.MemoryModel64.Core
{
	public class LocalData : MemoryObject, ILocalData
	{
		public const int SizeOf = Constants.LocalData.SizeOf;

		public int ActID => Read<int>(Constants.LocalData.ActID);

		public int PlayerActorSNO => Read<int>(Constants.LocalData.ActorSNO);

		public bool IsPlayerValid => Read<int>(Constants.LocalData.IsPlayerValid) != 0;

		public bool IsStartUpGame => Read<int>(Constants.LocalData.IsStartUpGame) != 0;

		public int LocalPlayerCount => Read<int>(Constants.LocalData.LocalPlayerCount);

		public int PlayerCount => Read<int>(Constants.LocalData.PlayerCount);

		public int QuestSNO => Read<int>(Constants.LocalData.QuestSNO);

		public int QuestStepUID => Read<int>(Constants.LocalData.QuestStepUID);

		public int SceneSNO => Read<int>(Constants.LocalData.SceneSNO);

		public Vector3 WorldPos => Read<Vector3>(Constants.LocalData.WorldPos);

		public int WorldSeed => Read<int>(Constants.LocalData.WorldSeed);

		public int WorldSNO => Read<int>(Constants.LocalData.WorldSNO);
	}
}
