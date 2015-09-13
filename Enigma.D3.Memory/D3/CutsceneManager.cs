using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.Memory;

namespace Enigma.D3
{
	public class CutsceneManager : MemoryObject
	{
		public const int SizeOf = 20;

		public int x00 { get { return Read<int>(0x00); } }
		public int x04 { get { return Read<int>(0x04); } }
		public int x08 { get { return Read<int>(0x08); } }
		public int x0C_Neg1 { get { return Read<int>(0x0C); } }
		public int x10 { get { return Read<int>(0x10); } }
	}
}
