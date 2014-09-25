using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;

namespace Enigma.D3.UI.Controls
{
	public class UXEvent : UXControl
	{
		public new const int SizeOf = 0x498; //1176
		public new const int VTable = 0x0174CB20;

		public int x450 { get { return Read<int>(0x450); } }
		public int x454 { get { return Read<int>(0x454); } }
		public int x458 { get { return Read<int>(0x458); } }
		public int x45C { get { return Read<int>(0x45C); } }
		public int x460 { get { return Read<int>(0x460); } }
		public int x464 { get { return Read<int>(0x464); } }
		public int x468 { get { return Read<int>(0x468); } }
		public int x46C { get { return Read<int>(0x46C); } }
		public int x470_Ptr_Allocator_Fieldx484 { get { return Read<int>(0x470); } }
		public Allocator x474_Allocator_10x12Bytes { get { return Read<Allocator>(0x474); } }
		public int x490_One { get { return Read<int>(0x490); } }
		public int x494 { get { return Read<int>(0x494); } }
	}
}
