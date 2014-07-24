using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXHotKey : UXControl
	{
		// 2.0.6.24641
		public const int SizeOf = 0x478;
		public const int VTable = 0x017C6350;

		public UXHotKey(MemoryBase memory, int address)
			: base(memory, address) { }

		public int x460 { get { return Field<int>(0x460); } }
		public int x464 { get { return Field<int>(0x464); } }
		public int x468 { get { return Field<int>(0x468); } }
		public int x46C { get { return Field<int>(0x46C); } }
		public int x470_Neg1 { get { return Field<int>(0x470); } }
		public int x474 { get { return Field<int>(0x474); } }
	}
}
