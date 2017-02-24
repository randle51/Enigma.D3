using Enigma.D3.Enums;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel32.BattleNet
{
	// TODO: 64-bit, non-PTR
	public class Hero : MemoryObject
	{
		public string Name
			=> ReadStringPointer(0xC4, 512).Dereference();

		public ulong HeroId => Read<ulong>(0x0B8);
		public int CurrentActivity => Read<int>(0x0D0);
		public HeroClass Class => Read<HeroClass>(0x0D4);
		public int Level => Read<int>(0x0DC);
		public int Paragon => Read<int>(0x0E0);
		public int HighestSoloRift => Read<int>(0x0E8);
		public int PvpRank => Read<int>(0x0EC);
		public int HighestAct => Read<int>(0x0F4);
		public int Flags => Read<int>(0x124);
		public int LastPlayedAct => Read<int>(0x130);
		public int Quest => Read<int>(0x134);
		public int QuestStep => Read<int>(0x138);
		public TimeSpan Played => TimeSpan.FromSeconds(Read<int>(0x13C));

		public bool IsHardcore => (Flags & 1) != 0;
		public bool IsDeceased => (Flags & 8) != 0;

		public override string ToString() => Name;
	}
}
