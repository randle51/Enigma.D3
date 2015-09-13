using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXControl34 : UXRadioButton
	{
		public new const int SizeOf = 0x1098; //4248
		public new const int VTable = 0x01829A50;

		public Ptr<UXLabel> x1198_Ptr_Label { get { return ReadPointer<UXLabel>(0x1198); } }
		public int x119C_ProgressBar { get { return Read<int>(0x119C); } }
	}
}
