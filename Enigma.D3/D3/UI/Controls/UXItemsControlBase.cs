using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;

namespace Enigma.D3.UI.Controls
{
	public class UXItemsControlBase : UXControl
	{
		public new const int SizeOf = 0x490; //1168
		public new const int VTable = 0x01725D50;

		public Vector<UIControlReference> x450_Children { get { return Read<Vector<UIControlReference>>(0x450); } }
		public Ptr<UXControl> x488_Ptr_UIControl { get { return ReadPointer<UXControl>(0x488); } }
		public Ptr<UXControl> x48C_Ptr_UIControl { get { return ReadPointer<UXControl>(0x48C); } }
	}
}
