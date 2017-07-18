using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.TypeSystem
{
    // TODO: 64-bit
    public class ValueTypeDescriptor : MemoryObject
    {
        public static int SizeOf = 0x1C; // = 28

        public int x00_VTable => Read<int>(0x00);
        public string x04_Name => ReadStringPointer(0x04, 64).Dereference(); // Max length unknown
        public int _x08 => Read<int>(0x08);
        public Ptr<FieldDescriptor> x0C_FieldDescriptors => ReadPointer<FieldDescriptor>(0x0C);
        public int x10_FieldCount => Read<int>(0x10);
        public int _x14 => Read<int>(0x14);
        public int x18_Flags => Read<int>(0x18);

        public FieldDescriptor[] GetFieldDescriptors()
            => x0C_FieldDescriptors.ToArray(x10_FieldCount);

        public override string ToString()
            => base.ToString() + ": " + x04_Name;
    }
}
