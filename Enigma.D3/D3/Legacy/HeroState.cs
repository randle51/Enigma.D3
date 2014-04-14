using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class HeroState : MemoryObject
	{
		public HeroState(ProcessMemory memory, int address)
			:base(memory, address){}

		public byte[] x0000 {get{return Field<byte>(0x0000, 16);}}
		public int x0010_State {get{return Field<int>(0x0010);}}
		public PlayerSavedData x0014_SavedData { get { return Field<PlayerSavedData>(0x0014); } }

//  char x0000[16];
//  int x0010_State;
//  CPlayerSavedData x0014_SavedData;
//  char x0018[17040];
//};

	}
}
