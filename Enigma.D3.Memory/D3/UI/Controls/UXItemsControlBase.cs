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
		public new const int SizeOf = 0x468; //1128
		public new const int VTable = 0x017D2D80;

		public LightVector<UIControlReference> Children { get { return Read<LightVector<UIControlReference>>(0x450); } }
		public Ptr<UXControl> x45C_Ptr_UIControl { get { return ReadPointer<UXControl>(0x45C); } }
		public Ptr<UXControl> x460_Ptr_UIControl { get { return ReadPointer<UXControl>(0x460); } }
		public int _x464 { get { return Read<int>(0x464); } }
	}
}
