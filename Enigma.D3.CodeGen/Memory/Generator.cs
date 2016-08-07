using Enigma.D3.CodeGen.Memory.PatternScanning;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.CodeGen.Memory
{
	internal static class Generator
	{
		private static PEHeaderReader PE;

		internal static void Run()
		{
			var exe = Program.GetExeFile();
			var data = File.ReadAllBytes(exe.FullName);
			var mem = new BufferMemoryReader(data);
			var version = FileVersionInfo.GetVersionInfo(exe.FullName).FileVersion;

			PE = new PEHeaderReader(data);

			var symbols = SymbolLocator.FindAll(data, mem);
			uint containerManager;

			var dir = new DirectoryInfo("enigma-d3-memory-" + new Version(version.Replace(", ", ".")));
			dir.Create();

			var objPtrs = new Dictionary<string, uint>();
			objPtrs.Add("SNOGroups", symbols.BestMatch("SnoGroups"));
			objPtrs.Add("SNOGroupsByCode", symbols.BestMatch("SnoGroupsByCode"));
			objPtrs.Add("AttributeDescriptors", symbols.BestMatch("AttributeDescriptors"));
			objPtrs.Add("MessageDescriptor", symbols.BestMatch("MessageDescriptor"));
			objPtrs.Add("LocalData", symbols.BestMatch("LocalData"));
			objPtrs.Add("ContainerManager", containerManager = symbols.BestMatch("ContainerManager"));
			objPtrs.Add("ApplicationLoopCount", symbols.BestMatch("ApplicationLoopCount"));
			objPtrs.Add("ObjectManager", symbols.BestMatch("ObjectManager"));
			objPtrs.Add("ObjectManagerPristine", symbols.BestMatch("ObjectManagerPristine"));
			objPtrs.Add("MapActId", symbols.BestMatch("MapActId"));
			objPtrs.Add("VideoPreferences", symbols.BestMatch("VideoPreferences"));
			objPtrs.Add("SoundPreferences", symbols.BestMatch("SoundPreferences"));
			objPtrs.Add("GameplayPreferences", symbols.BestMatch("GameplayPreferences"));
			objPtrs.Add("SocialPreferences", symbols.BestMatch("SocialPreferences"));
			objPtrs.Add("ChatPreferences", symbols.BestMatch("ChatPreferences"));
			objPtrs.Add("HotkeyPreferences", objPtrs["SoundPreferences"] == 0 ? 0 : objPtrs["SoundPreferences"] + 0x50);
			WriteObjectPtrFile(Path.Combine(dir.FullName, "ObjectPtr.cs"), objPtrs);

			var methodPtrs = new Dictionary<string, uint>();
			methodPtrs.Add("SNOGroups_Initialize", TranslateToVA(symbols.BestMatch("CSnoGroups::Initialize")));
			methodPtrs.Add("GameMessage_GetHandlerInfo", TranslateToVA(symbols.BestMatch("CGameMessage::GetHandlerInfo")));
			WriteMethodPtrFile(Path.Combine(dir.FullName, "MethodPtr.cs"), methodPtrs);

			var globals = new Dictionary<string, string>();
			globals.Add("static readonly Version SupportedVersion", $"new Version({version})");
			globals.Add("const int SNOGroupsCount", "60"); // TODO: Don't hardcode.
			globals.Add("const int AttributeDescriptorsCount", GetAttributeDescriptorsCount(symbols).ToString());
			WriteGlobalsFile(Path.Combine(dir.FullName, "Globals.cs"), globals);

			var project = new SharedProject("862a67ee-9ceb-42fe-9406-d7feafc55b00", "Enigma.D3.Memory");
			project.AddCompileFile(Path.Combine(dir.FullName, "Globals.cs"));
			project.AddCompileFile(Path.Combine(dir.FullName, "MethodPtr.cs"));
			project.AddCompileFile(Path.Combine(dir.FullName, "ObjectPtr.cs"));
			project.Save(Path.Combine(dir.FullName, "Enigma.D3.Memory.Generated.*"));

			if (Program.DeployGeneratedCode)
			{
				project.Deploy(
					dir,
					Program.SolutionDirectory.CreateSubdirectory(project.RootNamespace + ".Generated"));
			}
		}

		private static int TranslateToIndex(uint va)
		{
			var rva = va - PE.OptionalHeader32.ImageBase;
			var section = PE.ImageSectionHeaders.First(a => rva >= a.VirtualAddress && rva <= a.VirtualAddress + a.VirtualSize);
			return (int)(section.PointerToRawData + rva - section.VirtualAddress);
		}

		private static uint TranslateToVA(uint index)
		{
			var section = PE.ImageSectionHeaders.First(a => index >= a.PointerToRawData && index <= a.PointerToRawData + a.SizeOfRawData);
			var rva = index - section.PointerToRawData;
			var va = section.VirtualAddress + rva;
			return PE.OptionalHeader32.ImageBase + va;
		}

		private static int GetAttributeDescriptorsCount(Dictionary<string, List<uint>> symbols)
		{
			const int SizeOfAttributeDescriptor = 40;
			var maxPlus1 = symbols.BestMatch("AttributeDescriptors.MaxName++");
			var first = symbols.BestMatch("AttributeDescriptors.FirstName");
			if (first == 0 || maxPlus1 == 0)
				return 0;
			return (int)(maxPlus1 - first) / SizeOfAttributeDescriptor;
		}

		private static void WriteObjectPtrFile(string path, Dictionary<string, uint> objPtrs)
		{
			var sb = new StringBuilder();
			sb.AppendLine("namespace Enigma.D3.Memory");
			sb.AppendLine("{");
			sb.AppendLine("\tpublic static class ObjectPtr");
			sb.AppendLine("\t{");
			foreach (var pair in objPtrs.OrderBy(a => a.Value))
			{
				if (pair.Value == 0)
					sb.AppendLine($"\t\t#error Could not find {pair.Key} :(");
				sb.AppendLine($"\t\tpublic const int {pair.Key} = 0x{pair.Value:X8};");
			}
			sb.AppendLine("\t}");
			sb.AppendLine("}");
			File.WriteAllText(path, sb.ToString());
		}

		private static void WriteMethodPtrFile(string path, Dictionary<string, uint> methodPtrs)
		{
			var sb = new StringBuilder();
			sb.AppendLine("namespace Enigma.D3.Memory");
			sb.AppendLine("{");
			sb.AppendLine("\tpublic static class MethodPtr");
			sb.AppendLine("\t{");
			foreach (var pair in methodPtrs)
			{
				if (pair.Value == 0)
					sb.AppendLine($"\t\t#error Could not find {pair.Key} :(");
				sb.AppendLine($"\t\tpublic const int {pair.Key} = 0x{pair.Value:X8};");
			}
			sb.AppendLine("\t}");
			sb.AppendLine("}");
			File.WriteAllText(path, sb.ToString());
		}

		private static void WriteGlobalsFile(string path, Dictionary<string, string> globals)
		{
			var sb = new StringBuilder();
			sb.AppendLine("using System;");
			sb.AppendLine();
			sb.AppendLine("namespace Enigma.D3.Memory");
			sb.AppendLine("{");
			sb.AppendLine("\tpublic static class Globals");
			sb.AppendLine("\t{");
			foreach (var pair in globals)
				sb.AppendLine($"\t\tpublic {pair.Key} = {pair.Value};");
			sb.AppendLine("\t}");
			sb.AppendLine("}");
			File.WriteAllText(path, sb.ToString());
		}
	}
}
