using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Enums;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	public class GameBalanceManager : MemoryObject
	{
		public const int SizeOf = 32; // 2.0.0.20874
		public const int NumberOfGroups = 47;

		public GameBalanceGroup this[GameBalanceType type]
		{
			get
			{
				int index = (int)type;
				if (index < 0 || index >= NumberOfGroups)
					throw new ArgumentOutOfRangeException("type");
				return Read<Ptr<GameBalanceGroup>>(0x00)[index];
			}
		}

		public GameBalanceGroup[] x00_Groups { get { return Dereference<GameBalanceGroup>(0x00, NumberOfGroups); } }
		public Allocator x04_Allocator { get { return Read<Allocator>(0x04); } }
	}
}