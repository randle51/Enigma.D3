using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;

namespace Enigma.D3.UI.Controls
{
	public class UXItemsControlBase : UXControl
	{
		// 2.0.6.24641
		public const int SizeOf = 0x4A0;
		public const int VTable = 0x01770D28;

		public UXItemsControlBase(MemoryBase memory, int address)
			: base(memory, address) { }

		public Array<UIControlReference> x460_Children { get { return Field<Array<UIControlReference>>(0x460); } }
		public int _x494 { get { return Field<int>(0x494); } }
		public UXControl x498_UIControl { get { return Dereference<UXControl>(0x498); } }
		public UXControl x49C_UIControl { get { return Dereference<UXControl>(0x49C); } }
	}
}
