using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.UI;

namespace Enigma.D3
{
	public class GlobalStruct010 : MemoryObject
	{
		// 2.0.5.24017
		public const int SizeOf = 0x230;

		public GlobalStruct010(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x000 { get { return Field<int>(0x000); } }
		public int _x004 { get { return Field<int>(0x004); } }
		public Array<UIControlReference> x008_Array_Of_CUIControlReference { get { return Field<Array<UIControlReference>>(0x008); } }
		public int _x03C { get { return Field<int>(0x03C); } }
		public string x040_String256 { get { return Field(0x040, 256); } }
		public Map x140_MapEx_SocialBlockList_ { get { return Field<Map>(0x140); } }
		public Array<UIControlReference> x1B0_Array_Of_CUIControlReference_ChatChannelColors { get { return Field<Array<UIControlReference>>(0x1B0); } }
		public int _x1E4 { get { return Field<int>(0x1E4); } }
		public int x1E8_ChatChannelColorIndex { get { return Field<int>(0x1E8); } }
		public int _x1EC { get { return Field<int>(0x1EC); } }
		public Array<UIControlReference> x1F0_Array_Of_CUIControlReferences_Currencies { get { return Field<Array<UIControlReference>>(0x1F0); } }
		public int _x224 { get { return Field<int>(0x224); } }
		public int x228_GameDifficulty { get { return Field<int>(0x228); } }
		public int _x22C { get { return Field<int>(0x22C); } }
	}
}
