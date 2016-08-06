using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.Memory.TypeSystem
{
	public class MessageDescriptor : ValueTypeDescriptor
	{
		// 2.0.0.20874
		public new const int SizeOf = 0x30; // = 48

		public int _x1C => Read<int>(0x1C);
		public int _x20 => Read<int>(0x20);
		public int _x24 => Read<int>(0x24);
		public int _x28 => Read<int>(0x28);
		public Ptr<MessageDescriptor> x2C_PtrNext => ReadPointer<MessageDescriptor>(0x2C);
	}
}
