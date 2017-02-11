using Enigma.D3.MemoryModel.Core;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Enigma.D3.MemoryModel64.Core
{
	public class PlayerDataManager : MemoryObject, IPlayerDataManager
	{
		public IPlayerData this[int index]
			=> new Ptr<PlayerData>(Memory, Address + Constants.PlayerDataManager.Items)[index];

		public int Count => 8;

		public IEnumerator<IPlayerData> GetEnumerator()
		{
			for (int i = 0; i < 8; i++)
				yield return this[i];
		}

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
}
