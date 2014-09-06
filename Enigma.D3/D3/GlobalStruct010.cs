using Enigma.Memory;
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

		public int x000 { get { return Read<int>(0x000); } }
		public int _x004 { get { return Read<int>(0x004); } }
		public Vector<UIControlReference> x008_Array_Of_CUIControlReference { get { return Read<Vector<UIControlReference>>(0x008); } }
		public string x040_String256 { get { return ReadString(0x040, 256); } }
		public Map x140_MapEx_SocialBlockList_ { get { return Read<Map>(0x140); } }
		public Vector<UIControlReference> x1B0_Array_Of_CUIControlReference_ChatChannelColors { get { return Read<Vector<UIControlReference>>(0x1B0); } }
		public int x1E8_ChatChannelColorIndex { get { return Read<int>(0x1E8); } }
		public int _x1EC { get { return Read<int>(0x1EC); } }
		public Vector<UIControlReference> x1F0_Array_Of_CUIControlReferences_Currencies { get { return Read<Vector<UIControlReference>>(0x1F0); } }
		public int x228_GameDifficulty { get { return Read<int>(0x228); } }
		public int _x22C { get { return Read<int>(0x22C); } }
	}
}
