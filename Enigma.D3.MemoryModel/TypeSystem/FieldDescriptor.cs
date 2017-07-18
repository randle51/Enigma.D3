using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.TypeSystem
{
    // TODO: 64-bit
    public class FieldDescriptor : MemoryObject
    {
        public static int SizeOf = SymbolTable.PlatformSize(0x8C, 0);

        public string x00_Name => ReadStringPointer(0x00, 256).Dereference(); // Max length unknown
        public Ptr<ValueTypeDescriptor> x04_PtrType => ReadPointer<ValueTypeDescriptor>(0x04);
        public int x08_Offset => Read<int>(0x08);
        public int x0C_DefaultValuePtr => Read<int>(0x0C);
        public int x10_Min => Read<int>(0x10);
        public int x14_Max => Read<int>(0x14);
        public int x18_Flags => Read<int>(0x18); // 0x02 = (address + 8 = PtrToSerializedData), 0x10 = HasMinMaxBounds, 0x80000 = Bin2Text
        public Ptr<ValueTypeDescriptor> x1C_PtrBaseType => ReadPointer<ValueTypeDescriptor>(0x1C);
        public int x20_VariableArraySerializeOffsetDiff => Read<int>(0x20);
        public int x24_FixedArrayLength => Read<int>(0x24); // -1 if not an array
        public int x28_FixedArraySerializeOffsetDiff => Read<int>(0x28);
        public short x2C_UsedBits => Read<short>(0x2C); // Most likely used for transmission.
        public short x2E => Read<short>(0x2E);
        public int x30_GroupId => Read<int>(0x30); // -1 if none, used for DT_SNO and DT_GBID.
        public int x34 => Read<int>(0x34);
        public int x38_SymbolTable => Read<int>(0x38); // Used for DT_ENUM
        public int x3C_BitOffset => Read<int>(0x3C);
        public int x40_TranslateFromString => Read<int>(0x40);
        public int x44_TranslateFromValue => Read<int>(0x44);
        public int x48 => Read<int>(0x48);
        public string x4C_Text => ReadString(0x4C, 64); // Always empty

        public ValueTypeDescriptor GetFieldType()
            => x04_PtrType.Dereference();

        public ValueTypeDescriptor GetBaseType()
            => x1C_PtrBaseType.Dereference();
    }
}
