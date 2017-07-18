using Enigma.D3.CodeGen.Assets.TypeSystem;
using Enigma.D3.DataTypes;
using Enigma.D3.Enums;
using Enigma.D3.MemoryModel;
using Enigma.D3.MemoryModel.Assets;
using Enigma.D3.MemoryModel.TypeSystem;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.CodeGen.Assets
{
    internal static class Generator
    {
        private static int IndentLevel = 0;
        private static bool DeclarePartial = true;
        private static bool PrintToConsole = false;

        private const string ConsoleTitleBase = "Enigma.D3.CodeGen.Assets";

        internal static void Run()
        {
            PrimitiveType.Register<float>("DT_ACCEL", "Acceleration", "(Value * 3600.0f).ToString(\"0.00\") + \" ft/s^2\";");
            PrimitiveType.Register<float>("DT_ANGLE", "Angle", "(Value * RadianToDegree).ToString(\"0.00\") + \"-|\";", "public const float RadianToDegree = 180f / (float)Math.PI; //57.295776f;");
            PrimitiveType.Register<float>("DT_ANGULARVELOCITY", "AngularVelocity", "((Value * RadianToDegree) * 60.0f).ToString(\"0.00\") + \"-|/s\";", "public const float RadianToDegree = 180f / (float)Math.PI; //57.295776f;");
            PrimitiveType.Register<int>("DT_ATTRIBUTEPARAM", "AttributeParameter");
            PrimitiveType.Register<int>("DT_DATAID", "DataId", "\"0x\" + Value.ToString(\"X8\");");
            PrimitiveType.Register<int>("DT_GBID", "GBID");
            PrimitiveType.Register<float>("DT_HIGHPRECISIONPERCENT", "HighPrecisionPercent", "(Value * 100.0f).ToString(\"0.0000\") + \"%\";");
            PrimitiveType.Register<float>("DT_IMPULSE", "Impulse", "(Value * 60.0f).ToString(\"0.00\") + \" lb-sec\";");
            PrimitiveType.Register<float>("DT_MASS", "Mass", "(Value * 32.2f).ToString(\"0.00\") + \" lb\";");
            PrimitiveType.Register<byte>("DT_PERCENT", "Percent", "(((float)Value / 255.0f) * 100.0f).ToString(\"0.00\") + \"%\";");
            PrimitiveType.Register<int>("DT_SNO", "SNO");
            PrimitiveType.Register<int>("DT_SNO_GROUP", "SNOGroup", "((Enigma.D3.Enums.SNOType)Value).ToString().ToUpper() + \"_SNO\";");
            PrimitiveType.Register<int>("DT_SNONAME_HANDLE", "SNONameHandle");
            PrimitiveType.Register<float>("DT_TIME", "Time", "(Value / 60f).ToString(\"0.00 sec\");");
            PrimitiveType.Register<int>("DT_TRANSLATEABLE", "Translateable");
            PrimitiveType.Register<float>("DT_VELOCITY", "Velocity", "(Value * 60f).ToString(\"0.00\") + \" ft/s\";");

            NativeTypes.Register<bool>("DT_FLAG");
            NativeTypes.Register<byte>("DT_BYTE");
            NativeTypes.Register<short>("DT_WORD");
            NativeTypes.Register<int>("DT_INT");
            NativeTypes.Register<long>("DT_INT64");
            NativeTypes.Register<float>("DT_FLOAT");
            NativeTypes.Register<int>("DT_ENUM");
            NativeTypes.Register<Vector3>("DT_VECTOR3D");
            NativeTypes.Register<Vector2>("DT_VECTOR2D");
            NativeTypes.Register<Vector2I>("DT_IVECTOR2D");
            NativeTypes.Register<Quaternion>("Quaternion");
            NativeTypes.Register<QuaternionI>("Quaternion16");
            NativeTypes.Register<AABB>("AABB");
            NativeTypes.Register<Sphere>("Sphere");
            NativeTypes.Register<Vector3>("dmFloat3");
            NativeTypes.Register<Plane>("dmPlane");
            NativeTypes.Register<Matrix4x4>("Matrix4x4");
            NativeTypes.Register<SNOName>("SNOName");

            var groups = MemoryContext.Current.DataSegment.SNOGroupStorage
                .Select(p => p.Cast<SNOGroupStorage<MemoryObject>>().Dereference()).Where(a => a != null).ToList();

            var project = new SharedProject("966c65df-1054-4d67-91ee-31c155f0c8f8", "Enigma.D3.Assets");
            var outDir = Directory.CreateDirectory("enigma-d3-assets-" + MemoryContext.Current.MainModuleVersion);
            foreach (var group in groups.OrderBy(a => a.Name))
            {
                Console.WriteLine(ConsoleTitleBase + " - " + group.Name);

                var knownTypes = new List<KnownType>();
                knownTypes.AddRange(PrimitiveType.GetRawNames().Select(a => (KnownType)a));
                knownTypes.AddRange(NativeTypes.GetRawNames().Select(a => (KnownType)a));
                knownTypes.Add(group.PtrDataType.Dereference());
                knownTypes.Add("DT_VARIABLEARRAY");
                knownTypes.Add("DT_CHARARRAY");
                knownTypes.Add("DT_TAGMAP");
                knownTypes.Add("DT_CSTRING");
                knownTypes.Add("DT_FORMULA");
                knownTypes.Add("SerializeData");

                string filePath = Path.Combine(outDir.FullName, group.PtrDataType.Dereference().GetName() + ".cs");
                using (var output = File.CreateText(filePath))
                {
                    var baseType = group.PtrDataType.Dereference().ContainsSerializedData() ? "SerializeMemoryObject" : "MemoryObject";
                    AttachPrinterStream(output);
                    PrintLine("using System.Runtime.CompilerServices;");
                    PrintLine("using Enigma.D3.DataTypes;");
                    PrintLine("using Enigma.Memory;");
                    PrintLine();
                    PrintLine("namespace Enigma.D3.Assets");
                    PrintLine("{");
                    IndentLevel++;
                    PrintLine("[CompilerGenerated]");
                    PrintLine("public {2}class {0} : {1}", group.Name, baseType,
                        DeclarePartial ? "partial " : "");
                    PrintLine("{");
                    IndentLevel++;
                    PrintLine("public const int SizeOf = 0x{0:X}; // {0}", group.PtrDataType.Dereference().GetSizeOf());
                    PrintLine();
                    PrintLine("public SNOHeader x{0}_Header {{ get {{ return Read<SNOHeader>(0x{0}); }} }}", 0.ToString("X" + Math.Max(2, group.PtrDataType.Dereference().GetSizeOf().ToString("X").Length)));
                    Examine(knownTypes.Select(a => (KnownType)a).ToList(), group.PtrDataType.Dereference());
                    IndentLevel--;
                    PrintLine("}");
                    IndentLevel--;
                    PrintLine("}");
                    DetachPrinterStream(output);

                    project.AddCompileFile(filePath);
                }
            }

            Console.Title = ConsoleTitleBase + " - Creating shared project...";
            project.Save(Path.Combine(outDir.FullName, "Enigma.D3.Assets.Generated.*"));

            if (Program.DeployGeneratedCode)
            {
                Console.Title = ConsoleTitleBase + " - Deploying shared project...";
                project.Deploy(
                    outDir,
                    Program.SolutionDirectory.CreateSubdirectory(project.RootNamespace + ".Generated"));
            }
        }

        private static void PrintBaseTypes()
        {
            string filePath = "output-autogen-d3-" + MemoryContext.Current.MainModuleVersion + "\\_BaseTypes.cs";
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            using (var output = File.CreateText(filePath))
            {
                AttachPrinterStream(output);
                PrintLine("using System;");
                PrintLine("using System.Runtime.CompilerServices;");
                PrintLine("using Enigma.D3.Collections;");
                PrintLine("using Enigma.D3.Memory;");
                PrintLine("using Enigma.Memory;");
                PrintLine();
                PrintLine("namespace Enigma.D3.Sno");
                PrintLine("{");
                IndentLevel++;
                var primitives = PrimitiveType.Enumerate().ToList();
                foreach (var primitive in primitives)
                {
                    Print(primitive);
                    if (primitives.Last() != primitive)
                        PrintLine();
                }
                IndentLevel--;
                PrintLine("}");
                DetachPrinterStream(output);
                DetachPrinterStream(output);
            }
        }

        public static void Print(PrimitiveType type)
        {
            string paramName = char.ToLower(type.Name[0]) + type.Name.Substring(1);

            PrintLine("[CompilerGenerated]");
            PrintLine("public struct {0}", type.Name);
            PrintLine("{");
            IndentLevel++;
            if (type.Constants.Length > 0)
            {
                foreach (var constant in type.Constants)
                    PrintLine(constant);
                PrintLine();
            }
            PrintLine("public static implicit operator {0}({1} {2})", type.NativeName, type.Name, paramName);
            PrintLine("{");
            IndentLevel++;
            PrintLine("return {0}.Value;", paramName);
            IndentLevel--;
            PrintLine("}");
            PrintLine();
            PrintLine("public static implicit operator {0}({1} value)", type.Name, type.NativeName);
            PrintLine("{");
            IndentLevel++;
            PrintLine("return new {0} {{ Value = value }};", type.Name);
            IndentLevel--;
            PrintLine("}");
            PrintLine();
            PrintLine("public {0} Value;", type.NativeName);
            PrintLine();
            PrintLine("public override string ToString()");
            PrintLine("{");
            IndentLevel++;
            PrintLine("return {0}", type.ToStringBody ?? "Value.ToString();");
            IndentLevel--;
            PrintLine("}");
            IndentLevel--;
            PrintLine("}");
        }

        private static Dictionary<string, Dictionary<int, string>> _knownFieldNames = new Dictionary<string, Dictionary<int, string>>();

        private static void AddKnownFieldName(string typeName, int fieldOffset, string fieldName)
        {
            Dictionary<int, string> typeDic;
            if (!_knownFieldNames.TryGetValue(typeName, out typeDic))
            {
                typeDic = new Dictionary<int, string>();
                _knownFieldNames.Add(typeName, typeDic);
            }
            typeDic[fieldOffset] = fieldName;
        }

        private static void PrintLine(string format, params object[] args)
        {
            PrintLine(string.Format(format, args));
        }

        private static void PrintLine(string message)
        {
            string line = new string('\t', IndentLevel) + message;
            if (PrintToConsole) Console.WriteLine(line);
            foreach (var writer in _printers)
                writer.WriteLine(line);
        }

        private static void PrintLine()
        {
            PrintLine(string.Empty);
        }

        private static List<StreamWriter> _printers = new List<StreamWriter>();

        private static void AttachPrinterStream(StreamWriter writer)
        {
            _printers.Add(writer);
        }

        private static void DetachPrinterStream(StreamWriter writer)
        {
            _printers.Remove(writer);
        }

        private static void Examine(List<KnownType> knownTypes, ValueTypeDescriptor valueType)
        {
            var unknownTypes = new List<ValueTypeDescriptor>();
            foreach (var field in valueType.GetFieldDescriptors().OrderBy(a => a.x08_Offset).ThenBy(a => a.x3C_BitOffset).TakeWhile(a => !a.GetFieldType().IsNull())
                .GroupBy(a => a.x08_Offset + "." + a.x3C_BitOffset).Select(a => a.Last())) // TODO: Added grouping for quick "offset uniqueness". Why is this even needed?
            {
                string prefix = GeneratePrefix(field);
                string name = GenerateFieldName(valueType, field);
                string getter = GenerateGetter(valueType, field);
                string comment = GenerateComment(valueType, field);

                PrintLine(prefix + name + getter + comment);

                var importantType = (field.IsArray() && !field.IsTagMap()) ? field.GetBaseType() : field.GetFieldType();
                var isKnownType = knownTypes.Contains(new KnownType { Address = importantType.Address, Name = importantType.GetName() });
                var isAlreadyUnknownType = unknownTypes.Any(a => a.GetName() == importantType.GetName());
                if (!isKnownType && !isAlreadyUnknownType)
                    unknownTypes.Add(importantType);
            }

            knownTypes.AddRange(unknownTypes.Select(a => new KnownType { Address = a.Address, Name = a.GetName() }));
            for (int i = 0; i < unknownTypes.Count; i++)
            {
                ExamineUnknownTypes(unknownTypes[i], knownTypes, ref unknownTypes);
            }
            foreach (var type in unknownTypes)
            {
                string baseType = type.ContainsSerializedData() ? "SerializeMemoryObject" : "MemoryObject";
                int sizeOf = type.GetSizeOf();
                string hexFormat = "X" + Math.Max(2, sizeOf.ToString("X").Length);
                PrintLine();
                PrintLine("[CompilerGenerated]");
                PrintLine("public {2}class {0} : {1}", type.GetName(), baseType,
                    DeclarePartial ? "partial " : "");
                PrintLine("{");
                IndentLevel++;
                PrintLine("public const int SizeOf = 0x{0}; // {1}", sizeOf.ToString(hexFormat), sizeOf);
                PrintLine();

                //Examine(knownTypes, type);
                foreach (var field in type.GetFieldDescriptors().OrderBy(a => a.x08_Offset).ThenBy(a => a.x3C_BitOffset).TakeWhile(a => !a.GetFieldType().IsNull())
                    .GroupBy(a => a.x08_Offset + "." + a.x3C_BitOffset).Select(a => a.Last())) // TODO: Added grouping for quick "offset uniqueness". Why is this even needed?
                {
                    string prefix = GeneratePrefix(field);
                    string name = GenerateFieldName(type, field);
                    string getter = GenerateGetter(type, field);
                    string comment = GenerateComment(type, field);

                    PrintLine(prefix + name + getter + comment);
                }

                IndentLevel--;
                PrintLine("}");
            }
        }

        private static void ExamineUnknownTypes(ValueTypeDescriptor valueType, List<KnownType> knownTypes, ref List<ValueTypeDescriptor> unknownTypes)
        {
            foreach (var field in valueType.GetFieldDescriptors().OrderBy(a => a.x08_Offset).ThenBy(a => a.x3C_BitOffset).TakeWhile(a => !a.GetFieldType().IsNull()))
            {
                var importantType = (field.IsArray() && !field.IsTagMap()) ? field.GetBaseType() : field.GetFieldType();
                var isKnownType = knownTypes.Contains(importantType.GetName());
                var isAlreadyUnknownType = unknownTypes.Any(a => a.GetName() == importantType.GetName());
                if (!isKnownType && !isAlreadyUnknownType)
                    unknownTypes.Add(importantType);
            }
        }

        private static string GenerateComment(ValueTypeDescriptor type, FieldDescriptor field)
        {
            string comment = null;
            if (field.IsEnum())
            {
                comment = " // " + string.Join(", ", SymbolDescriptor.GetAllSymbols(field.x38_SymbolTable).Select(a => a.GetName() + " = " + a.x00_Id));
            }
            else if (field.IsTranslateable())
            {
                comment = string.Format(" // TranslateFromString = 0x{0:X8}, TranslateFromValue = 0x{1:X8}",
                    field.x40_TranslateFromString, field.x44_TranslateFromValue);
            }
            else if (field.IsTagMap())
            {
                comment = " // type: 0x" + field.x34.ToString("X8");
            }
            return comment;
        }

        private static string GenerateGetter(ValueTypeDescriptor type, FieldDescriptor field)
        {
            string hexFormat = "X" + Math.Max(2, type.GetSizeOf().ToString("X").Length);
            string getter;
            if (field.IsVariableArray())
            {
                getter = string.Format(" {{ get {{ return Deserialize<{0}>(x{1}_SerializeData); }} }}",
                    field.GetBaseTypeName(), field.GetVariableArraySerializeOffset().ToString(hexFormat));
            }
            else if (field.IsFixedArray())
            {
                getter = string.Format(" {{ get {{ return Read<{0}>(0x{1}, {2}); }} }}",
                    field.GetBaseTypeName(), field.x08_Offset.ToString(hexFormat), field.GetFixedArrayLength());
            }
            else if (field.IsCharArray())
            {
                getter = string.Format(" {{ get {{ return ReadString(0x{0}, {1}); }} }}",
                    field.x08_Offset.ToString(hexFormat), field.GetFixedArrayLength());
            }
            else if (field.IsString() || field.IsFormula())
            {
                getter = string.Format(" {{ get {{ return DeserializeString(x{1}_SerializeData); }} }}",
                    field.GetBaseTypeName(), field.GetVariableArraySerializeOffset().ToString(hexFormat));
            }
            else if (field.IsTagMap())
            {
                // TODO: Figure out what his really is... guessing it's array of ints
                getter = string.Format(" {{ get {{ return Deserialize<{0}>(x{1}_SerializeData); }} }}",
                    "int", field.GetVariableArraySerializeOffset().ToString(hexFormat));
            }
            else if (field.IsFlag())
            {
                string mask = "0x" + (1 << field.x3C_BitOffset).ToString("X8");
                getter = string.Format(" {{ get {{ return (Read<int>(0x{0}) & {1}) != 0; }} }}",
                    field.x08_Offset.ToString(hexFormat), mask);
            }
            else
            {
                getter = string.Format(" {{ get {{ return Read<{0}>(0x{1}); }} }}",
                    field.GetTypeName(), field.x08_Offset.ToString(hexFormat));
            }
            return getter;
        }

        private static string GeneratePrefix(FieldDescriptor field)
        {
            return "public " + field.GetTypeName() + (field.IsArray() ? "[]" : "") + " ";
        }

        private static string GenerateFieldName(ValueTypeDescriptor type, FieldDescriptor field)
        {
            string hexFormat = "X" + Math.Max(2, type.GetSizeOf().ToString("X").Length);
            string knownFieldName = null;
            if (_knownFieldNames.ContainsKey(type.GetName()))
            {
                if (!_knownFieldNames[type.GetName()].TryGetValue(field.x08_Offset, out knownFieldName))
                    knownFieldName = null;
            }

            string name = string.Format("x{0}", field.x08_Offset.ToString(hexFormat));
            if (knownFieldName != null)
            {
                name += "_" + knownFieldName;
            }
            else if (field.IsTagMap())
            {
                name += "_TagMap";
            }
            else if (field.IsSno())
            {
                name += "_" + (field.x30_GroupId == -1 ? "" : ((SNOType)field.x30_GroupId).ToString()) + "SNO";
            }
            else if (field.IsSnoGroup())
            {
                name += "_" + (field.x30_GroupId == -1 ? "" : ((SNOType)field.x30_GroupId).ToString()) + "SNOGroup";
            }
            else if (field.IsGameBalanceId())
            {
                name += "_" + (field.x30_GroupId == -1 ? "" : ((GBType)field.x30_GroupId).ToString()) + "GBID";
            }
            else if (field.IsStringArray())
            {
                name += "_Text";
            }
            else if (field.IsEnum())
            {
                name += "_Enum";
            }
            else if (field.IsFormula())
            {
                name += "_Formula";
            }
            else if (field.IsArray() && !field.GetBaseType().IsNative())
            {
                name += "_" + field.GetTypeName();
                if (name.Last() != 's')
                {
                    // Plurialize
                    if (!name.EndsWith("Data"))
                    {
                        if (name.Last() == 'y')
                        {
                            name = name.Substring(0, name.Length - 1) + "ies";
                        }
                        else
                        {
                            name += "s";
                        }
                    }
                }
            }
            else if (field.IsFlag())
            {
                name += "_Bit" + field.x3C_BitOffset;
            }
            else if (!field.IsNative())
            {
                name += "_" + field.GetTypeName();
            }
            return name;
        }
    }
}
