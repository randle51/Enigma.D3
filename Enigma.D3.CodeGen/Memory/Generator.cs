using Enigma.D3.MemoryModel;
using Enigma.Memory;
using Enigma.Memory.Analytics.Patterns;
using Enigma.Memory.Analytics.PE;
using Enigma.Memory.PE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.CodeGen.Memory
{
	internal static class Generator
	{
		private static CodePatternContext _ctx;
		private static SymbolTable _symbols;
		private static MethodTable _methods = new MethodTable();

		private class MethodTable
		{
			public uint Allocate;
		}

		public static void Run()
		{
			var path = Environment.ExpandEnvironmentVariables(@"%TEMP%\Diablo III.DMP");
			var dump = new MiniDumpMemoryReader(path);
			var pe = new PEHeaderReader(dump.ReadBytes(dump.ImageBase, 1024));
			_ctx = new CodePatternContext(dump, pe);

			_symbols = new SymbolTable();
			_symbols.Version = dump.MainModuleVersion;
			_symbols.DataSegment.Address = _ctx.Data.Start;

			FindObjectManager();
			FindActors();
			FindACDs();
			FindSNOs();
			FindAttributeDescriptors();
			FindApplicationCore();
			FindLevelArea();
			FindPreferences();
			FindMapActId();
			FindContainerManager();
			FindMessageDescriptors();
			FindPlayerData();

			var dir = new DirectoryInfo("enigma-d3-memory-" + new Version(_symbols.Version.ToString()));
			dir.Create();
			WriteObjectPtrFile(dir);
			WriteGlobalsFile(dir);

			var project = new SharedProject("862a67ee-9ceb-42fe-9406-d7feafc55b00", "Enigma.D3.Memory");
			project.AddCompileFile(Path.Combine(dir.FullName, "Globals.cs"));
			//project.AddCompileFile(Path.Combine(dir.FullName, "MethodPtr.cs"));
			project.AddCompileFile(Path.Combine(dir.FullName, "ObjectPtr.cs"));
			project.Save(Path.Combine(dir.FullName, "Enigma.D3.Memory.Generated.*"));

			if (Program.DeployGeneratedCode)
			{
				project.Deploy(
					dir,
					Program.SolutionDirectory.CreateSubdirectory(project.RootNamespace + ".Generated"));
			}
		}

		private static void WriteObjectPtrFile(DirectoryInfo dir)
		{
			var content = GenerateObjectPtrContent(new
			{
				VideoPreferences = _symbols.DataSegment.VideoPreferences,
				SoundPreferences = _symbols.DataSegment.SoundPreferences,
				HotkeyPreferences = _symbols.DataSegment.HotkeyPreferences,
				GameplayPreferences = _symbols.DataSegment.GameplayPreferences,
				SocialPreferences = _symbols.DataSegment.SocialPreferences,
				ChatPreferences = _symbols.DataSegment.ChatPreferences,
				LevelArea = _symbols.DataSegment.LevelArea,
				LevelAreaName = _symbols.DataSegment.LevelAreaName,
				MapActId = _symbols.DataSegment.MapActID,
				SNOGroupsByCode = _symbols.DataSegment.SNOGroupsByCode,
				SNOGroups = _symbols.DataSegment.SNOGroups,
				ObjectManager = _symbols.DataSegment.ObjectManager,
				ObjectManagerPristine = _symbols.DataSegment.ObjectManagerPristine,
				ApplicationLoopCount = _symbols.DataSegment.ApplicationLoopCount,
				LocalData = _symbols.DataSegment.LocalData,
				AttributeDescriptors = _symbols.DataSegment.AttributeDescriptors,
				ContainerManager = _symbols.DataSegment.ContainerManager,
				MessageDescriptor = _symbols.DataSegment.MessageDescriptor,
			});
			File.WriteAllText(Path.Combine(dir.FullName, "ObjectPtr.cs"), content);
		}

		private static void WriteGlobalsFile(DirectoryInfo dir)
		{
			var globals = Template(
@"using System;

namespace Enigma.D3.Memory
{
	public static class Globals
	{
		public static readonly Version SupportedVersion = new Version({version});
		public const int SNOGroupsCount = {sno_group_count};
		public const int AttributeDescriptorsCount = {attribute_count};
		public const int SizeOf_PlayerData = {sizeof_playerdata};
		public const int Offset_PlayerData_HeroName = {offset_playerdata_heroname};
		public const int Offset_PlayerData_LifePercentage = {offset_playerdata_lifepercentage};
	}
}", new
{
	version = _symbols.Version.ToString().Replace(".", ", "),
	sno_group_count = 60,
	attribute_count = _symbols.DataSegment.AttributeDescriptorsCount,
	sizeof_playerdata = "0x" + _symbols.PlayerData.SizeOf.ToString("X"),
	offset_playerdata_heroname = "0x" + _symbols.PlayerData.HeroName.ToString("X"),
	offset_playerdata_lifepercentage = "0x" + _symbols.PlayerData.LifePercentage.ToString("X")
});
			File.WriteAllText(Path.Combine(dir.FullName, "Globals.cs"), globals);
		}

		private static string Template(string format, object data)
		{
			var result = format;
			foreach (var prop in data.GetType().GetProperties())
			{
				result = result.Replace("{" + prop.Name + "}", prop.GetValue(data).ToString());
			}
			return result;
		}

		private static string GenerateObjectPtrContent(object obj)
		{
			var sb = new StringBuilder();
			sb.AppendLine("namespace Enigma.D3.Memory");
			sb.AppendLine("{");
			sb.AppendLine("    public static class ObjectPtr");
			sb.AppendLine("    {");
			foreach (var property in obj.GetType().GetProperties())
			{
				sb.AppendLine($"        public const int {property.Name} = 0x{Convert.ToInt64(property.GetValue(obj)):X8};");
			}
			sb.AppendLine("    }");
			sb.AppendLine("}");
			return sb.ToString();
		}

		private static void FindObjectManager()
		{
			foreach (var match in TextSegmentMatches("6A01|6A00|6A04|68{sizeof}........|E8{allocate}........|50|A3{pristine}........|E8{init}........|A1{pristine2}........|83C414|A3{mgr}........|C3"))
			{
				if (match.Read<int>(_ctx.Dump, "pristine") !=
					match.Read<int>(_ctx.Dump, "pristine2"))
					continue;

				var mgr = match.Read<uint>(_ctx.Dump, "mgr");
				if (_ctx.Data.Contains(mgr) == false)
					continue;

				_methods.Allocate = match.DecodeDisp32(_ctx.Dump, "allocate");
				_symbols.DataSegment.ObjectManager = mgr;
				_symbols.DataSegment.ObjectManagerPristine = match.Read<uint>(_ctx.Dump, "pristine");
				_symbols.ObjectManager.SizeOf = match.Read<int>(_ctx.Dump, "sizeof");

				var init = match.DecodeDisp32(_ctx.Dump, "init");
				_symbols.ObjectManager.Storage = _ctx.FirstMatchInTextSegment<int>(
					init, 512, "8D8F{storage}........", "storage");

				return;
			}
		}

		private static void FindActors()
		{
			var ctor = GetSystemConstructor("RActors");

			var actor_mgr_size = _ctx.FirstMatchInTextSegment<int>(ctor, 512, "68{size}....0000", "size");
			var offsets = TextSegmentMatches("8986{offset}....0000", ctor, 2048)
				.Select(x => x.Read<int>(_ctx.Dump, "offset")).ToArray();
			var actor_mgr_offset = offsets[0];

			_symbols.ObjectManager.Actors = offsets[1];
		}

		private static void FindACDs()
		{
			var ctor = GetSystemConstructor("ACD");
			var init = FirstTextSegmentMatch("E8{init}........", ctor, 64)
				.DecodeDisp32(_ctx.Dump, "init");

			_symbols.ACDManager.SizeOf = FirstTextSegmentMatch<int>("68{size}........|E8",
				init, 512, "size");

			_symbols.ObjectManager.ACDManager = FirstTextSegmentMatch<int>("8986{offset}........",
				init, 512, "offset");
		}

		private static void FindSNOs()
		{
			var init = FirstTextSegmentMatch(
				"56|57|6A00|6A00|6A04|68F4000000|E8........|6818010000|68........|A3......")
				.Position;

			_symbols.DataSegment.SNOGroups = FirstTextSegmentMatch<uint>(
				"A3{groups}........|E8........", init, 512, "groups");
			_symbols.DataSegment.SNOGroupsByCode = FirstTextSegmentMatch<uint>(
				"890C85{bycode}........", init, 512, "bycode");
		}

		private static void FindAttributeDescriptors()
		{
			var pText = FindString("StringToAttrib:");
			var xref = FirstTextSegmentMatch("68" + PatternFormat(pText)).Position;

			_symbols.DataSegment.AttributeDescriptors = FirstTextSegmentMatch<uint>(
				"8B04C5{descriptors}........", xref, 512, "descriptors");

			var first = _symbols.DataSegment.AttributeDescriptors + 0x1C;
			var limit = FirstTextSegmentMatch<uint>("81FE{limit}........", xref - 64, 64, "limit");
			var sizeof_descriptor = 40;
			_symbols.DataSegment.AttributeDescriptorsCount = (int)(limit - first) / sizeof_descriptor;
		}

		private static void FindApplicationCore()
		{
			var aCommandLine = FindString("CommandLine\0");

			var xref = FirstTextSegmentMatch("68" + PatternFormat(aCommandLine)).Position;

			var app_do = FirstTextSegmentMatch("83E802|74..|E8........|E8{do}........")
				.DecodeDisp32(_ctx.Dump, "do");

			_symbols.DataSegment.LocalData = FirstTextSegmentMatch<uint>(
				"68{localdata}........|E8{localdata_update}........", app_do, 512, "localdata");

			_symbols.DataSegment.ApplicationLoopCount =
				_ctx.FirstMatchInTextSegment<uint>(
					app_do, 512, "40|A3{count}........", "count");
		}

		private static void FindLevelArea()
		{
			var xref = FirstTextSegmentMatch(
				"68" + PatternFormat(FindString("GameDifficultyChanged")))
				.Position;

			_symbols.DataSegment.LevelArea = FirstTextSegmentMatch<uint>(
				"A1{levelarea}........|FF", xref, 512, "levelarea");

			_symbols.DataSegment.LevelAreaName = FirstTextSegmentMatch<uint>(
				"68{name}........|E8........|85C0", xref - 512, 512, "name");
		}

		private static void FindPreferences()
		{
			var m = FirstTextSegmentMatch("55|8BEC|56|8B7508|6A06|68........|68........|56|E8........|83C410|85C0|0F84");
			var groups = TextSegmentMatches("6A{count}..|68{descriptors}........|68{values}........|56", m.Position, 512).ToArray();

			_symbols.DataSegment.VideoPreferences = groups[1].Read<uint>(_ctx.Dump, "values");
			_symbols.DataSegment.SoundPreferences = groups[2].Read<uint>(_ctx.Dump, "values");
			_symbols.DataSegment.GameplayPreferences = groups[3].Read<uint>(_ctx.Dump, "values");
			_symbols.DataSegment.HotkeyPreferences = groups[7].Read<uint>(_ctx.Dump, "values");
			_symbols.DataSegment.SocialPreferences = groups[5].Read<uint>(_ctx.Dump, "values");
			_symbols.DataSegment.ChatPreferences = groups[6].Read<uint>(_ctx.Dump, "values");
		}

		private static void FindMapActId()
		{
			var a = FindString("WaypointMap:WorldMapInstructions");
			_symbols.DataSegment.MapActID = FirstTextSegmentMatch<uint>(
				"C705{map_act_id}........|FFFFFFFF|68" + PatternFormat(a), "map_act_id");
		}

		private static void FindContainerManager()
		{
			var init = FirstTextSegmentMatch(
				"68" + PatternFormat(FindString("RActors")) + "|E8{init}........")
				.DecodeDisp32(_ctx.Dump, "init");

			_symbols.DataSegment.ContainerManager = FirstTextSegmentMatch<uint>(
				"8B1D{mgr}........", init, 512, "mgr");
		}

		private static void FindMessageDescriptors()
		{
			var a = FindString("GameSetupMessage");
			var b = FirstDataSegmentMatch(PatternFormat(a)).Position;
			var vt = b - 4;
			var c = FirstTextSegmentMatch(PatternFormat(vt)).Position;

			_symbols.DataSegment.MessageDescriptor = FirstTextSegmentMatch<uint>(
				"C705{descriptor}........" + PatternFormat(vt), c, 512, "descriptor");
		}

		private static void FindPlayerData()
		{
			var a = FirstTextSegmentMatch(
				"68" + PatternFormat(FindString("CGameGlobalsInit()\n\0")));

			var m1 = FirstTextSegmentMatch(
				"8D89........|E8{method}........", a.Position, 512)
				.DecodeDisp32(_ctx.Dump, "method");

			var m2 = FirstTextSegmentMatch(
				"E8{method}........|83", m1, 512)
				.DecodeDisp32(_ctx.Dump, "method");

			_symbols.PlayerDataManager.SizeOf = FirstTextSegmentMatch<int>(
				"68{size}........|E8{allocate}........", m2, 512, "size");

			_symbols.ObjectManager.PlayerDataManager = _symbols.ObjectManager.Storage + FirstTextSegmentMatch<int>(
				"8987{offset}........", m2, 512, "offset");

			var sum = FirstTextSegmentMatch<uint>("81FB{sum}........", m2, 512, "sum");
			_symbols.PlayerDataManager.Items = _symbols.PlayerDataManager.SizeOf - (int)sum;
			_symbols.PlayerData.SizeOf = (int)sum / 8;

			var m3 = FirstTextSegmentMatch("E8{method}........|8B4D08", m2, 512)
				.DecodeDisp32(_ctx.Dump, "method");

			var aDefault = FindString("Default\0");

			var offset = FirstTextSegmentMatch<int>(
				"A1" + PatternFormat(aDefault) + "|8987{offset}........",
				m3, 512, "offset");
			_symbols.PlayerData.HeroName = offset - 49;


			_symbols.LocalData = new LocalDataSymbols(Platform.X86);
			var memory = new MemoryContext(_ctx.Dump.Memory);
			SymbolTable.Current = _symbols;
			var p = memory.DataSegment.ObjectManager.PlayerDataManager[0];
			var buffer = p.GetPointer().Cast<byte>().ToArray(_symbols.PlayerData.SizeOf);
			var actorSNO = memory.DataSegment.LocalData.PlayerActorSNO;
			var idx = new BinaryPattern(BitConverter.GetBytes(actorSNO)).NextMatch(buffer, 0);
			_symbols.PlayerData.LifePercentage = idx + 4;
		}



		private static IEnumerable<CodePatternMatch> TextSegmentMatches(string pattern)
		{
			return CodePattern.Parse(pattern)
				.Matches(_ctx.Text.Start, _ctx.TextBuffer);
		}

		private static IEnumerable<CodePatternMatch> TextSegmentMatches(string pattern, MemoryAddress start, int count)
		{
			return CodePattern.Parse(pattern)
				.Matches(_ctx.Text.Start, _ctx.TextBuffer, start, count);
		}

		private static CodePatternMatch FirstTextSegmentMatch(string pattern)
		{
			return CodePattern.Parse(pattern)
				.Matches(_ctx.Text.Start, _ctx.TextBuffer)
				.First();
		}

		private static CodePatternMatch FirstTextSegmentMatch(string pattern, MemoryAddress start, int count)
		{
			return CodePattern.Parse(pattern)
				.Matches(_ctx.Text.Start, _ctx.TextBuffer, start, count)
				.First();
		}

		private static T FirstTextSegmentMatch<T>(string pattern, string label)
		{
			return CodePattern.Parse(pattern)
				.Matches(_ctx.Text.Start, _ctx.TextBuffer)
				.First()
				.Read<T>(_ctx.Dump, label);
		}

		private static T FirstTextSegmentMatch<T>(string pattern, MemoryAddress start, int count, string label)
		{
			return CodePattern.Parse(pattern)
				.Matches(_ctx.Text.Start, _ctx.TextBuffer, start, count)
				.First()
				.Read<T>(_ctx.Dump, label);
		}

		private static MemoryAddress GetSystemConstructor(string name)
		{
			var pName = new BinaryPattern(Encoding.ASCII.GetBytes("\0" + name + "\0"))
				.NextMatch(_ctx.ResourcesBuffer, 0) + _ctx.Resources.Start + 1;

			var cls = new BinaryPattern(BitConverter.GetBytes((uint)pName))
				.NextMatch(_ctx.DataBuffer, 0) + _ctx.Data.Start;
			var ctor = _ctx.Dump.Read<Ptr>(cls + 0x04);
			var dtor = _ctx.Dump.Read<Ptr>(cls + 0x08);

			return ctor.ValueAddress;
		}

		private static MemoryAddress GetSystemDestructor(string name)
		{
			var pName = new BinaryPattern(Encoding.ASCII.GetBytes("\0" + name + "\0"))
				.NextMatch(_ctx.ResourcesBuffer, 0) + _ctx.Resources.Start + 1;

			var cls = new BinaryPattern(BitConverter.GetBytes((uint)pName))
				.NextMatch(_ctx.DataBuffer, 0) + _ctx.Data.Start;
			var ctor = _ctx.Dump.Read<Ptr>(cls + 0x04);
			var dtor = _ctx.Dump.Read<Ptr>(cls + 0x08);

			return dtor.ValueAddress;
		}

		private static MemoryAddress FindString(string value)
		{
			var pText = new BinaryPattern(Encoding.ASCII.GetBytes(value))
				.NextMatch(_ctx.ResourcesBuffer, 0) + _ctx.Resources.Start;
			return pText;
		}

		private static string PatternFormat(int value)
		{
			return string.Concat(
				BitConverter.GetBytes(value)
				.Select(x => x.ToString("X2")));
		}

		private static CodePatternMatch FirstDataSegmentMatch(string pattern)
		{
			return CodePattern.Parse(pattern)
				.Matches(_ctx.Data.Start, _ctx.DataBuffer)
				.First();
		}
	}
}
