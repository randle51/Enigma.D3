using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Enums;
using Enigma.D3.Memory;

namespace Enigma.D3
{
	public class GameBalanceManager : MemoryObject
	{
		public const int SizeOf = 32; // 2.0.0.20874
		public const int NumberOfGroups = 47;

		public GameBalanceManager(ProcessMemory memory, int address)
			: base(memory, address) { }

		public GameBalanceGroup this[GameBalanceType type]
		{
			get
			{
				int index = (int)type;
				if (index < 0 || index >= NumberOfGroups)
					throw new ArgumentOutOfRangeException("type");
				return new GameBalanceGroup(this.Memory, Field<int>(0x00) + GameBalanceGroup.SizeOf * index);
			}
		}

		public GameBalanceGroup[] x00_Groups { get { return Dereference<GameBalanceGroup>(0x00, NumberOfGroups); } }
		public Allocator x04_Allocator { get { return Field<Allocator>(0x04); } }
	}
}