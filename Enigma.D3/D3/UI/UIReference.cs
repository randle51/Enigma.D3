using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI
{
	public class UIReference : MemoryObject
	{
		public const int SizeOf = 0x208; // 2.0.0.20874

		public ulong x000_Hash { get { return Read<ulong>(0x000); } }
		public string x008_Name { get { return ReadString(0x008, 0x200); } }

		public override string ToString()
		{
			return x008_Name;
		}
	}
}
