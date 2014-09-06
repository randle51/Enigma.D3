using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3
{
	public class MessageDescriptor : ValueTypeDescriptor
	{
		// 2.0.0.20874
		public new const int SizeOf = 0x30; // = 48

		public int _x1C { get { return Read<int>(0x1C); } }
		public int _x20 { get { return Read<int>(0x20); } }
		public int _x24 { get { return Read<int>(0x24); } }
		public int _x28 { get { return Read<int>(0x28); } }
		public MessageDescriptor x2C_Next { get { return Dereference<MessageDescriptor>(0x2C); } }
	}
}
