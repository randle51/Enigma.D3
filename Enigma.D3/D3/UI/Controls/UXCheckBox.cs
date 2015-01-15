using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXCheckBox : UXItemsControl
	{
		public new const int SizeOf = 0xAD0; //2768
		public new const int VTable = 0x017719D0;

		public int xA48 { get { return Read<int>(0xA48); } }
		public int xA4C { get { return Read<int>(0xA4C); } }
		public int xA50 { get { return Read<int>(0xA50); } }
		public int _xA54 { get { return Read<int>(0xA54); } }
		public int _xA58 { get { return Read<int>(0xA58); } }
		public int xA5C { get { return Read<int>(0xA5C); } }
		public int xA60 { get { return Read<int>(0xA60); } }
		public int xA64_Neg1 { get { return Read<int>(0xA64); } }
		public int xA68_Neg1 { get { return Read<int>(0xA68); } }
		public int xA6C_Neg1 { get { return Read<int>(0xA6C); } }
		public int xA70_Neg1 { get { return Read<int>(0xA70); } }
		public int xA74_Neg1 { get { return Read<int>(0xA74); } }
		public int xA78_Neg1 { get { return Read<int>(0xA78); } }
		public int xA7C_Neg1 { get { return Read<int>(0xA7C); } }
		public int xA80_Neg1 { get { return Read<int>(0xA80); } }
		public int xA84_Neg1 { get { return Read<int>(0xA84); } }
		public int xA88_Neg1 { get { return Read<int>(0xA88); } }
		public int xA8C_Neg1 { get { return Read<int>(0xA8C); } }
		public int xA90_Neg1 { get { return Read<int>(0xA90); } }
		public int xA94 { get { return Read<int>(0xA94); } }
		public int xA98 { get { return Read<int>(0xA98); } }
		public int xA9C { get { return Read<int>(0xA9C); } }
		public int xAA0 { get { return Read<int>(0xAA0); } }
		public int xAA4 { get { return Read<int>(0xAA4); } }
		public int xAA8 { get { return Read<int>(0xAA8); } }
		public int xAAC { get { return Read<int>(0xAAC); } }
		public int xAB0 { get { return Read<int>(0xAB0); } }
		public int xAB4 { get { return Read<int>(0xAB4); } }
		public int xAB8 { get { return Read<int>(0xAB8); } }
		public int xABC { get { return Read<int>(0xABC); } }
		public int xAC0 { get { return Read<int>(0xAC0); } }
		public Ptr<UXItemsControl> xAC4_Ptr_ItemsControl { get { return ReadPointer<UXItemsControl>(0xAC4); } }
		public Ptr<UXLabel> xAC8_Ptr_Label { get { return ReadPointer<UXLabel>(0xAC8); } }
		public int _xACC { get { return Read<int>(0xACC); } }
	}
}
