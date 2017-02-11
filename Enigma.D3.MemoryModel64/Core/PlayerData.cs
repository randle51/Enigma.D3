using Enigma.D3.MemoryModel.Core;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel64.Core
{
	public class PlayerData : MemoryObject, IPlayerData
	{
		public const int SizeOf = Constants.PlayerData.SizeOf;

		public int Index => Read<int>(Constants.PlayerData.Index);
		public int ACDID => Read<int>(Constants.PlayerData.ACDID);
		public int ActorID => Read<int>(Constants.PlayerData.ActorID);
	}
}
