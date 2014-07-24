using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	public class UXControl40 : UXItemsControl
	{
		// 2.0.6.24641
		public const int SizeOf = 0x1CC8;
		public const int VTable = 0x01770E40;

		public UXControl40(MemoryBase memory, int address)
			: base(memory, address) { }

		public int x0A58 { get { return Field<int>(0x0A58); } }
		public int _x0A5C { get { return Field<int>(0x0A5C); } }
		public X0A60 x0A60_StructStart_Min4708Bytes { get { return Field<X0A60>(0x0A60); } }
		public int _x1CC4 { get { return Field<int>(0x1CC4); } }



		public class X0A60 : MemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x1264;

			public X0A60(MemoryBase memory, int address)
				: base(memory, address) { }

			public UIReference[] x0000 { get { return Field<UIReference>(0x0000, 8); } }
			public UIReference x1040_UIRef { get { return Field<UIReference>(0x1040); } }
			public int x1248 { get { return Field<int>(0x1248); } }
			public int x124C { get { return Field<int>(0x124C); } }
			public int x1250 { get { return Field<int>(0x1250); } }
			public float x1254 { get { return Field<float>(0x1254); } }
			public float x1258 { get { return Field<float>(0x1258); } }
			public int x125C_70 { get { return Field<int>(0x125C); } }
			public int x1260_70 { get { return Field<int>(0x1260); } }
		}
	}
}
