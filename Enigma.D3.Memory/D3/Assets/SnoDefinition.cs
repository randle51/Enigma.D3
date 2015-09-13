using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Enums;

namespace Enigma.D3.Assets
{
	public class SnoDefinition : SnoDefinition<MemoryObject> { }

	public class SnoDefinition<T> : MemoryObject
	{
		public const int SizeOf = 16;

		public int x00_Id { get { return Read<int>(0x00); } }
		public int x04_LastTouched { get { return Read<int>(0x04); } }
		public byte x07_SnoGroupId { get { return Read<byte>(0x07); } }
		public int x08_Size { get { return Read<int>(0x08); } }
		public Ptr<T> x0C_Ptr_SnoValue { get { return ReadPointer<T>(0x0C); } }
	}
}
