using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXControl40 : UXItemsControl
	{
		public new const int SizeOf = 0x1CB8;
		public new const int VTable = 0x01705C18;

		public int x0A48 { get { return Read<int>(0x0A48); } }
		public int _x0A4C { get { return Read<int>(0x0A4C); } }
		public X0A50 x0A50_StructStart_Min4708Bytes { get { return Read<X0A50>(0x0A50); } }
		public int _x1CB4 { get { return Read<int>(0x1CB4); } }

		[Obsolete("Not checked")]
		public class X0A50 : MemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x1264;

			public UIReference[] x0000 { get { return Read<UIReference>(0x0000, 8); } }
			public UIReference x1040_UIRef { get { return Read<UIReference>(0x1040); } }
			public int x1248 { get { return Read<int>(0x1248); } }
			public int x124C { get { return Read<int>(0x124C); } }
			public int x1250 { get { return Read<int>(0x1250); } }
			public float x1254 { get { return Read<float>(0x1254); } }
			public float x1258 { get { return Read<float>(0x1258); } }
			public int x125C_70 { get { return Read<int>(0x125C); } }
			public int x1260_70 { get { return Read<int>(0x1260); } }
		}
	}
}
