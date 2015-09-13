using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;

namespace Enigma.D3.Assets
{
	public class SnoGroupInitializer : MemoryObject
	{
		public const int SizeOf = 8;

		public int x00_Initializer { get { return Read<int>(0x00); } }
		public Ptr<Ptr<SnoGroupManager>> x04_Ptr_Ptr_SnoGroup { get { return ReadPointer<Ptr<SnoGroupManager>>(0x04); } }

		public SnoGroupManager GetSnoGroup()
		{
			return ReadPointer<Ptr<SnoGroupManager>>(0x04).Dereference().Dereference();
		}
	}
}
