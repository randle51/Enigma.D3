using Enigma.D3.MemoryModel.Core;
using Enigma.D3.MemoryModel64.Collections;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel64.Core
{
	public class Player : MemoryObject, IPlayer
	{
		public int LocalPlayerIndex
			=> Read<int>(Constants.Player.LocalPlayerIndex);

		public IReadOnlyList<int> LatencySamples
			=> Read<CircularBuffer<int>>(Constants.Player.LatencySamples);

		public IReadOnlyCollection<IFloatingNumber> FloatingNumbers
			=> Read<LinkedListWithAllocator<FloatingNumber>>(Constants.Player.FloatingNumbers);
	}
}
