using Enigma.D3.MemoryModel.TypeSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.CodeGen.Assets.TypeSystem
{
    public static class FieldDescriptorExtensions
    {
        public static string GetRawTypeName(this FieldDescriptor field)
        {
            return field.x04_PtrType.Dereference().x04_Name;
        }

        public static string GetTypeName(this FieldDescriptor field)
        {
            if (field.IsArray())
            {
                return TranslateName(field.x1C_PtrBaseType.Dereference().GetName());
            }
            else
            {
                if (field.IsTagMap())
                    return "TagMap";

                string name = TranslateName(field.x04_PtrType.Dereference().GetName());
                if (!field.x1C_PtrBaseType.Dereference().IsNull() && !field.IsStringArray())
                {
                    if (field.GetRawTypeName() == "DT_INT")
                    {
                        ; // TODO: Why would this happen? NumberOfX for SerializeData???
                    }
                    else
                    {
                        name += "<" + TranslateName(field.x1C_PtrBaseType.Dereference().GetName()) + ">";
                    }
                }
                return name;
            }
        }

        public static bool IsNative(this FieldDescriptor field)
        {
            return NativeTypes.Contains(field.GetFieldType().x04_Name);
        }

        public static bool IsArray(this FieldDescriptor field)
        {
            return field.IsVariableArray() || field.IsFixedArray();
        }

        public static bool IsStringArray(this FieldDescriptor field)
        {
            return field.IsCharArray() ||
                field.IsString() ||
                field.IsFormula();
        }

        public static bool IsVariableArray(this FieldDescriptor field)
        {
            return field.GetRawTypeName() == "DT_VARIABLEARRAY";
        }

        public static bool IsCharArray(this FieldDescriptor field)
        {
            return field.GetRawTypeName() == "DT_CHARARRAY";
        }

        public static bool IsString(this FieldDescriptor field)
        {
            return field.GetRawTypeName() == "DT_CSTRING";
        }

        public static bool IsFixedArray(this FieldDescriptor field)
        {
            return field.GetRawTypeName() == "DT_FIXEDARRAY";
        }

        public static bool IsTagMap(this FieldDescriptor field)
        {
            return field.GetRawTypeName() == "DT_TAGMAP";
        }

        public static bool IsEnum(this FieldDescriptor field)
        {
            return field.GetRawTypeName() == "DT_ENUM";
        }

        public static bool IsFlag(this FieldDescriptor field)
        {
            return field.GetRawTypeName() == "DT_FLAG";
        }

        public static bool IsTranslateable(this FieldDescriptor field)
        {
            return field.GetRawTypeName() == "DT_TRANSLATEABLE";
        }

        public static bool IsAttributeParameter(this FieldDescriptor field)
        {
            return field.GetRawTypeName() == "DT_ATTRIBUTEPARAM";
        }

        public static bool IsFormula(this FieldDescriptor field)
        {
            return field.GetRawTypeName() == "DT_FORMULA";
        }

        public static bool IsSnoGroup(this FieldDescriptor field)
        {
            return field.GetRawTypeName() == "DT_SNO_GROUP";
        }

        public static bool IsSnoNameHandle(this FieldDescriptor field)
        {
            return field.GetRawTypeName() == "DT_SNONAME_HANDLE";
        }

        public static bool IsGameBalanceId(this FieldDescriptor field)
        {
            return field.GetRawTypeName() == "DT_GBID";
        }

        public static bool IsSno(this FieldDescriptor field)
        {
            return field.GetRawTypeName() == "DT_SNO";
        }

        public static string GetBaseTypeName(this FieldDescriptor field)
        {
            return TranslateName(field.GetBaseType().GetName());
        }

        public static int GetVariableArraySerializeOffset(this FieldDescriptor field)
        {
            return field.x20_VariableArraySerializeOffsetDiff + field.x08_Offset;
        }

        public static int GetFixedArrayLength(this FieldDescriptor field)
        {
            return field.x24_FixedArrayLength;
        }

        private static string TranslateName(string rawName)
        {
            string name;
            if (PrimitiveType.TryGetName(rawName, out name))
                return name;
            if (NativeTypes.TryGetName(rawName, out name))
                return name;

            switch (rawName)
            {
                case "DT_CSTRING":
                case "DT_FORMULA":
                case "DT_CHARARRAY": return "string";
                default:
                    return rawName;
            }
        }
    }
}
