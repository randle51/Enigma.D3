using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.UI.Controls;

namespace Enigma.D3.UI
{
	public class UIControlReference : MemoryObject
	{
		// 2.0.4.23119
		public const int SizeOf = 0x210; // 528

		public UIReference x000_UIReference { get { return Read<UIReference>(0x000); } }
		public UXControl x208_UIControl { get { return ReadPointer<UXControl>(0x208).Dereference(); } }
		public UXControl x20C_UIControl { get { return ReadPointer<UXControl>(0x20C).Dereference(); } }
	}
}
