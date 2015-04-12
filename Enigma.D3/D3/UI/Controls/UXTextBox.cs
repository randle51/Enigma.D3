using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXTextBox : UXLabel
	{
		public new const int SizeOf = 0xBD8; //3032
		public new const int VTable = 0x017CF0A8;

		public int xB78_Anim2DSnoId_EditBoxCursor { get { return Read<int>(0xB78); } }
		public float xB7C_AnimClock { get { return Read<float>(0xB7C); } }
		public float xB80_AnimClock { get { return Read<float>(0xB80); } }
		public float xB84_AnimClockFrom { get { return Read<float>(0xB84); } }
		public float xB88_AnimClockTo { get { return Read<float>(0xB88); } }
		public int xB8C_Flags { get { return Read<int>(0xB8C); } }
		public int xB90_CaretPosition { get { return Read<int>(0xB90); } }
		public int xB94_CaretMaxPosition { get { return Read<int>(0xB94); } }
		public int xB98_InputMaxLength { get { return Read<int>(0xB98); } }
		public int xB9C_InputLength { get { return Read<int>(0xB9C); } }
		public int xBA0 { get { return Read<int>(0xBA0); } }
		public int xBA4 { get { return Read<int>(0xBA4); } }
		public int xBA8 { get { return Read<int>(0xBA8); } }
		public int xBAC { get { return Read<int>(0xBAC); } }
		public int xBB0 { get { return Read<int>(0xBB0); } }
		public int xBB4 { get { return Read<int>(0xBB4); } }
		public int xBB8 { get { return Read<int>(0xBB8); } }
		public int xBBC { get { return Read<int>(0xBBC); } }
		public int xBC0 { get { return Read<int>(0xBC0); } }
		public int xBC4 { get { return Read<int>(0xBC4); } }
		public int xBC8 { get { return Read<int>(0xBC8); } }
		public float xBCC { get { return Read<float>(0xBCC); } }
		public float xBD0 { get { return Read<float>(0xBD0); } }
		public int xBD4 { get { return Read<int>(0xBD4); } }
	}
}
