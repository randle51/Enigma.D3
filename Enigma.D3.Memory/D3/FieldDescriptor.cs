using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Enums;

namespace Enigma.D3
{
	public class FieldDescriptor : MemoryObject
	{
		public const int SizeOf = 0x8C; // = 140

		public string x00_Name { get { return ReadStringPointer(0x00, 256).Dereference(); } } // Max length unknown
		public ValueTypeDescriptor x04_Type { get { return Dereference<ValueTypeDescriptor>(0x04); } }
		public int x08_Offset { get { return Read<int>(0x08); } }
		public int x0C_DefaultValuePtr { get { return Read<int>(0x0C); } }
		public int x10_Min { get { return Read<int>(0x10); } }
		public int x14_Max { get { return Read<int>(0x14); } }
		public int x18_Flags { get { return Read<int>(0x18); } } // 0x02 = (address + 8 = PtrToSerializedData), 0x10 = HasMinMaxBounds, 0x80000 = Bin2Text
		public ValueTypeDescriptor x1C_BaseType { get { return Dereference<ValueTypeDescriptor>(0x1C); } }
		public int x20_VariableArraySerializeOffsetDiff { get { return Read<int>(0x20); } }
		public int x24_FixedArrayLength { get { return Read<int>(0x24); } } // -1 if not an array
		public int x28_FixedArraySerializeOffsetDiff { get { return Read<int>(0x28); } }
		public short x2C_UsedBits { get { return Read<short>(0x2C); } } // Most likely used for transmission.
		public short x2E { get { return Read<short>(0x2E); } }
		public int x30_GroupId { get { return Read<int>(0x30); } } // -1 if none, used for DT_SNO and DT_GBID.
		public int x34 { get { return Read<int>(0x34); } }
		public int x38_SymbolTable { get { return Read<int>(0x38); } } // Used for DT_ENUM
		public int x3C_BitOffset { get { return Read<int>(0x3C); } }
		public int x40_TranslateFromString { get { return Read<int>(0x40); } }
		public int x44_TranslateFromValue { get { return Read<int>(0x44); } }
		public int x48 { get { return Read<int>(0x48); } }
		public string x4C_Text { get { return ReadString(0x4C, 64); } } // Always empty
	}
}