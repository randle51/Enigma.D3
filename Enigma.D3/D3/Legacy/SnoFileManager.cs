using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class SnoFileManager : MemoryObject
	{
		public const int SizeOf = 0x3F28; // 1.0.8.16603 : [0x00EA1D10] SNOFilesInitialize

		public SnoFileManager(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x0000_Ptr48Bytes { get { return Field<int>(0x0000); } }
		public int _x0004 { get { return Field<int>(0x0004); } }
		public SnoFile[] x0008_Files { get { return Field<SnoFile>(0x0008, 69); } }
		public SnoFile[] x1E38_Files { get { return Field<SnoFile>(0x1E38, 69); } }
		public string x3C68_DataDirectoryName { get { return Field(0x3C68, 255); } }
		public string x3D67_BranchName { get { return Field(0x3D67, 257); } } // Both 256 and 260 has been used, storage-wise there is room for 257.
		public int x3E68_CoreDataHash_ { get { return Field<int>(0x3E68); } } // Could be a value, or file object.
		public int _x3E6C { get { return Field<int>(0x3E6C); } }
		public int _x3E70 { get { return Field<int>(0x3E70); } }
		public int _x3E74 { get { return Field<int>(0x3E74); } }
		public int _x3E78 { get { return Field<int>(0x3E78); } }
		public int _x3E7C { get { return Field<int>(0x3E7C); } }
		public int _x3E80 { get { return Field<int>(0x3E80); } }
		public int _x3E84 { get { return Field<int>(0x3E84); } }
		public int _x3E88 { get { return Field<int>(0x3E88); } }
		public int _x3E8C { get { return Field<int>(0x3E8C); } }
		public int _x3E90 { get { return Field<int>(0x3E90); } }
		public int _x3E94 { get { return Field<int>(0x3E94); } }
		public int _x3E98 { get { return Field<int>(0x3E98); } }
		public int _x3E9C { get { return Field<int>(0x3E9C); } }
		public int _x3EA0 { get { return Field<int>(0x3EA0); } }
		public int _x3EA4 { get { return Field<int>(0x3EA4); } }
		public int x3EA8_Struct_RelatedTo_BannedNames { get { return Field<int>(0x3EA8); } } // <-- Min. 5x ints (see 0x01022330)
		public int _x3EAC { get { return Field<int>(0x3EAC); } }
		public int _x3EB0 { get { return Field<int>(0x3EB0); } }
		public int _x3EB4 { get { return Field<int>(0x3EB4); } }
		public int _x3EB8 { get { return Field<int>(0x3EB8); } }
		public int _x3EBC { get { return Field<int>(0x3EBC); } }
		public int _x3EC0 { get { return Field<int>(0x3EC0); } }
		public int _x3EC4 { get { return Field<int>(0x3EC4); } }
		public int _x3EC8 { get { return Field<int>(0x3EC8); } }
		public int _x3ECC { get { return Field<int>(0x3ECC); } }
		public int _x3ED0 { get { return Field<int>(0x3ED0); } }
		public int _x3ED4 { get { return Field<int>(0x3ED4); } }
		public int _x3ED8 { get { return Field<int>(0x3ED8); } }
		public int _x3EDC { get { return Field<int>(0x3EDC); } }
		public int _x3EE0 { get { return Field<int>(0x3EE0); } }
		public int _x3EE4 { get { return Field<int>(0x3EE4); } }
		public int x3EE8_Struct_RelatedTo_LocaleBannedNames { get { return Field<int>(0x3EE8); } } // <-- Min. 5x ints (see 0x01022330)
		public int _x3EEC { get { return Field<int>(0x3EEC); } }
		public int _x3EF0 { get { return Field<int>(0x3EF0); } }
		public int _x3EF4 { get { return Field<int>(0x3EF4); } }
		public int _x3EF8 { get { return Field<int>(0x3EF8); } }
		public int _x3EFC { get { return Field<int>(0x3EFC); } }
		public int _x3F00 { get { return Field<int>(0x3F00); } }
		public int _x3F04 { get { return Field<int>(0x3F04); } }
		public int _x3F08 { get { return Field<int>(0x3F08); } }
		public int _x3F0C { get { return Field<int>(0x3F0C); } }
		public int _x3F10 { get { return Field<int>(0x3F10); } }
		public int _x3F14 { get { return Field<int>(0x3F14); } }
		public int _x3F18 { get { return Field<int>(0x3F18); } }
		public int _x3F1C { get { return Field<int>(0x3F1C); } }
		public int _x3F20 { get { return Field<int>(0x3F20); } }
		public int _x3F24 { get { return Field<int>(0x3F24); } }
	}
}
