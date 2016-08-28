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
			objPtrs.Add("LevelArea", GetStatic_LevelArea(data, symbols));
			objPtrs.Add("LevelAreaName", GetStatic_LevelAreaName(data, symbols));
			WriteObjectPtrFile(Path.Combine(dir.FullName, "ObjectPtr.cs"), objPtrs);

			var methodPtrs = new Dictionary<string, uint>();
			methodPtrs.Add("SNOGroups_Initialize", TranslateToVA(symbols.BestMatch("CSnoGroups::Initialize")));
			methodPtrs.Add("GameMessage_GetHandlerInfo", TranslateToVA(symbols.BestMatch("CGameMessage::GetHandlerInfo")));
			WriteMethodPtrFile(Path.Combine(dir.FullName, "MethodPtr.cs"), methodPtrs);

			var globals = new Dictionary<string, string>();
			globals.Add("static readonly Version SupportedVersion", $"new Version({version})");
			globals.Add("const int SNOGroupsCount", "60"); // TODO: Don't hardcode.
			globals.Add("const int AttributeDescriptorsCount", GetAttributeDescriptorsCount(symbols).ToString());
			globals.Add("const int SizeOf_PlayerData", symbols.BestMatch("sizeof(PlayerData)").ToHex());
			globals.Add("const int Offset_PlayerData_HeroName", GetOffset_PlayerData_HeroName(symbols.BestMatch("sizeof(PlayerData)")).ToHex());
			globals.Add("const int Offset_PlayerData_LifePercentage", GetOffset_PlayerData_LifePercentage(symbols.BestMatch("sizeof(PlayerData)")).ToHex());
			// TODO: globals.Add("const int SizeOf_LevelArea", symbols.BestMatch("sizeof(LevelArea)").ToHex());
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

		private static uint GetStatic_LevelArea(byte[] data, SymbolMap symbols)
		{
			const string key = "LevelArea";

			var match = symbols.BestMatch(key);
			if (match != 0)
				return match;

			if (Engine.Current == null)
				return 0;

			try
			{
				var pe = new PEHeaderReader(data);
				var rdata = pe.ImageSectionHeaders.FirstOrDefault(h => h.Section.TrimEnd('\0') == ".rdata");
				var text = pe.ImageSectionHeaders.FirstOrDefault(h => h.Section.TrimEnd('\0') == ".text");

				uint offset = rdata.VirtualAddress - rdata.PointerToRawData + pe.OptionalHeader32.ImageBase;

				var pName = (uint)(offset + new BinaryPattern(Encoding.ASCII.GetBytes("UIMinimapToggle")).NextMatch(data, rdata));
				
				var pMethod = BitConverter.ToUInt32(data, BinaryPattern.Parse(
					$"68{pName.ToPattern()}" +
					"A3........" +
					"C705................" +
					"C705................" +
					"E8........" +
					"68........" +
					"A3........" +
					"C705........|........|").NextMatch(data, text) + 51);

				if (Engine.Current.Memory.Reader.Read<byte>(pMethod + 0x00) == 0x8B &&
					Engine.Current.Memory.Reader.Read<byte>(pMethod + 0x01) == 0x0D)
				{
					var address = Engine.Current.Memory.Reader.Read<uint>(pMethod + 0x02);
					symbols.Override(key, address);
					return address;
				}
			}
			catch { }

			return 0;
		}

		private static uint GetStatic_LevelAreaName(byte[] data, SymbolMap symbols)
		{
			const string key = "LevelAreaName";

			var match = symbols.BestMatch(key);
			if (match != 0)
				return match;

			var levelarea = symbols.BestMatch("LevelArea");
			if (levelarea != 0)
				return levelarea + 0x30;

			return 0;
		}

		private static uint GetOffset_PlayerData_LifePercentage(uint sizeof_playerdata)
		{
			if (sizeof_playerdata == 0 || Engine.Current == null)
				return 0;

			var actor = Actor.Local;
			var player = PlayerData.Local;
			var data = PlayerData.Local.GetPointer().Cast<byte>().ToArray((int)sizeof_playerdata);

			var signature = BitConverter.GetBytes(actor.x08C_ActorSnoId);
			var pattern = new BinaryPattern(signature);
			try
			{
				var match = pattern.NextMatch(data, 0);
				return (uint)match + 4;
			}
			catch
			{
				return 0;
			}
		}

		private static uint GetOffset_PlayerData_HeroName(uint sizeof_playerdata)
		{
			if (sizeof_playerdata == 0 || Engine.Current == null)
				return 0;

			var data = PlayerData.Local.GetPointer().Cast<byte>().ToArray((int)sizeof_playerdata);
			var pattern = new BinaryPattern(Encoding.ASCII.GetBytes("Default"));
			//new byte[] { (byte)'D', (byte)'e', (byte)'f', (byte)'a', (byte)'u', (byte)'l', (byte)'t' });

			try
			{
				var match = pattern.NextMatch(data, 0);
				return (uint)(match - 49);
			}
			catch
			{
				return 0;
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

		private static int GetAttributeDescriptorsCount(SymbolMap symbols)
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

		private static string ToHex(this uint value) => "0x" + value.ToString("X");

		private static string ToPattern(this uint value) => string.Concat(BitConverter.GetBytes(value).Select(b => b.ToString("X2")));
	}
}
