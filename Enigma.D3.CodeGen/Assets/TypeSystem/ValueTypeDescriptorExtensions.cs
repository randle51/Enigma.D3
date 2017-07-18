using Enigma.D3.Memory.TypeSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.CodeGen.Assets.TypeSystem
{
    public static class ValueTypeDescriptorExtensions
    {
        public static bool IsPrimitive(this ValueTypeDescriptor descriptor)
        {
            return descriptor.x10_FieldCount == 0;
        }

        public static int GetSizeOf(this ValueTypeDescriptor descriptor)
        {
            if (descriptor.IsPrimitive())
                return -1;
            return descriptor.GetFieldDescriptors().Last().x08_Offset;
        }

        public static bool IsNull(this ValueTypeDescriptor descriptor)
        {
            return descriptor.x04_Name == "DT_NULL";
        }

        public static bool IsNative(this ValueTypeDescriptor descriptor)
        {
            return NativeTypes.Contains(descriptor.x04_Name);
        }

        public static string GetName(this ValueTypeDescriptor descriptor)
        {
            var name = descriptor.x04_Name;
            if (name == "Items" && descriptor.x0C_FieldDescriptors[1].GetTypeName() == "ItemType")
                name = "ItemTypes";
            if (name == "Monster" && descriptor.GetFieldDescriptors().All(a => a.GetFieldType().x04_Name != "Monster" && a.GetBaseType().x04_Name != "Monster"))
                name = "MonsterData";
            if (name == "QuestRange" && descriptor.GetFieldDescriptors().All(a => a.GetFieldType().x04_Name != "QuestRange" && a.GetBaseType().x04_Name != "QuestRange"))
                name = "QuestRangeData";
            return name;
        }

        public static bool ContainsSerializedData(this ValueTypeDescriptor descriptor)
        {
            return (descriptor.x18_Flags & (1 << 3)) != 0;
        }

        public static bool IsSnoType(this ValueTypeDescriptor descriptor)
        {
            return (descriptor.x18_Flags & (1 << 1)) != 0;
        }

        public static bool IsMeshType(this ValueTypeDescriptor descriptor)
        {
            return (descriptor.x18_Flags & (1 << 6)) != 0;
        }
    }
}
