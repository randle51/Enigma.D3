using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Helpers;

namespace Enigma.D3.UI.Controls
{
	public partial class UXControl : MemoryObject
	{
		public const int SizeOf = 0x450; //1104
		public const int VTable = 0x017CF1F8;

		public int x000_VTable { get { return Read<int>(0x000); } }
		public int _x004 { get { return Read<int>(0x004); } }
		public Ptr x008_Ptr_20Bytes { get { return ReadPointer(0x008); } }
		public int x00C { get { return Read<int>(0x00C); } }
		public int x010 { get { return Read<int>(0x010); } }
		public int x014_Flags { get { return Read<int>(0x014); } } // 1 = IsValid?, 2 = ???, 3 = IsVisible?
		public Ptr<UXControl> x018_Ptr_UIControl { get { return ReadPointer<UXControl>(0x018); } }
		public Ptr<UXControl> x01C_Ptr_UIControl { get { return ReadPointer<UXControl>(0x01C); } }
		public UIReference x020_Self { get { return Read<UIReference>(0x020); } }
		public UIReference x228_Parent { get { return Read<UIReference>(0x228); } }
		public int x430 { get { return Read<int>(0x430); } }
		public int x434_Tag { get { return Read<int>(0x434); } } // Can be any 32-bit data, typically an ID such as SNO or ACD.
		public int x438_UISnoId_StructStart_Min16Bytes { get { return Read<int>(0x438); } }
		public int x43C { get { return Read<int>(0x43C); } }
		public int x440 { get { return Read<int>(0x440); } }
		public int x444 { get { return Read<int>(0x444); } }
		public Ptr<RefString> x448_Ptr_RefString { get { return ReadPointer<RefString>(0x448); } }
		public Ptr<RefString> x44C_Ptr_RefString { get { return ReadPointer<RefString>(0x44C); } }
	}

	public partial class UXControl
	{
		public static T Get<T>(string name) where T : UXControl
		{
			if (!typeof(T).IsSubclassOf(typeof(UXControl)))
				throw new ArgumentException("Invalid type.");

			return UXHelper.GetControl<T>(name);
		}

		public static T Get<T>(UIReference uiRef) where T : UXControl
		{
			return Get<T>(uiRef.x008_Name);
		}

		public static T Get<T>(ulong hash) where T : UXControl
		{
			return UXHelper.GetControl<T>(hash);
		}

		public override string ToString()
		{
			return x020_Self.ToString();
		}
	}
}
