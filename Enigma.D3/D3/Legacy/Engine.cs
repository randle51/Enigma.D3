using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Enigma.D3.Legacy
{
	public static class CodeGenerator
	{
		public static string GetSnoGroupFields()
		{
			StringBuilder sb = new StringBuilder();
			var snoGroups = Engine.Current.SnoGroups;
			int index = 0;
			var snoGroup = snoGroups[index];
			while (snoGroup != null)
			{
				string name = snoGroup.x1C_Name;
				sb.Append("public SnoGroup<MemoryObject> ").Append(name).Append("SnoGroup { get { return SnoGroups[").Append(index).Append("]; } }");
				sb.AppendLine();
				snoGroup = snoGroups[++index];
			}
			return sb.ToString();
		}

		public static string GetSnoGroupTypes()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("public enum SnoGroupType");
			sb.AppendLine("{");
			foreach (var g in Engine.Current.SnoGroups.OrderBy(a => a.x3C_SnoGroupType))
			{
				sb.Append("\t").Append(g.x1C_Name).Append(" = ").Append(g.x3C_SnoGroupType).Append(",");
			}
			sb.AppendLine("}");
			return sb.ToString();
		}

		public static string GetSnoGroupDump()
		{
			return GetCascadingDump(Engine.Current.SnoGroups);
		}

		public static string GetDump<T>(T[] array)
		{
			var sb = new StringBuilder();
			var properties = typeof(T).GetProperties();
			sb.AppendLine(string.Join("\t", properties.Select(a => a.Name)));
			foreach (var item in array.Where(a => a != null))
			{
				sb.AppendLine(string.Join("\t", properties.Select(a => a.GetValue(item, null))));
			}
			return sb.ToString();
		}

		public static string GetCascadingDump<T>(T[] array)
		{
			var sb = new StringBuilder();
			sb.AppendLine(string.Join("\t", GetPropertyNames(typeof(T))));
			foreach (var item in array)
			{
				sb.AppendLine(string.Join("\t", GetPropertyValues(item)));
			}
			return sb.ToString();
		}

		private static IEnumerable<string> GetPropertyNames(Type type)
		{
			var list = new List<string>();
			GetPropertyNames(type, null, list);
			return list;
		}

		private static void GetPropertyNames(Type type, string path, List<string> list)
		{
			foreach (var property in type.GetProperties())
			{
				if (property.PropertyType.IsSubclassOf(typeof(MemoryObject)) &&
					!typeof(System.Collections.IEnumerable).IsAssignableFrom(property.PropertyType))
				{
					GetPropertyNames(property.PropertyType, (path != null ? path + "." : "") + property.Name, list);
				}
				else
				{
					list.Add((path != null ? path + "." : "") + property.Name);
				}
			}
		}

		private static IEnumerable<object> GetPropertyValues(object instance)
		{
			if (instance == null)
				return new object[] { };

			var list = new List<object>();
			GetPropertyValues(instance.GetType(), instance, list);
			return list;
		}

		private static void GetPropertyValues(Type type, object instance, List<object> list)
		{
			foreach (var property in type.GetProperties())
			{
				if (property.PropertyType.IsSubclassOf(typeof(MemoryObject)) &&
					!typeof(System.Collections.IEnumerable).IsAssignableFrom(property.PropertyType))
				{
					GetPropertyValues(property.PropertyType, property.GetValue(instance, null), list);
				}
				else
				{
					list.Add(property.GetValue(instance, null));
				}
			}
		}
	}

	public class Engine : MemoryObject, IDisposable
	{
		// interesting methods:
		// EA20E0
		// EA3DD0

		public static Engine Create()
		{
			var process = Process.GetProcessesByName("Diablo III")
				.FirstOrDefault();
			return process == null ? null : new Engine(process);
		}

		public static Engine Current { get; private set; }

		public Engine(Process process)
			: base(new ProcessMemory(process), 0)
		{
			Engine.Current = this;
		}

		public Process Process { get { return base.Memory.Process; } }


		// private Pair<int,char*>[6] x14F4650_ActSymbolTable;

		public int TlsIndex { get { return Field<int>(0x016E2FA0); } }

		public int InstanceHandle { get { return Field<int>(0x016FB7C4); } }

		public int IsInitialized { get { return Field<int>(0x016FB7CC); } } // <-- This is set to 1 when initial data is loaded and just before splash screen disappears.

		//public int PhysicalCores { get { return Field<int>(0x016FC22C); } }

		//public int PhysicalPackages { get { return Field<int>(0x016FC234); } }

		public GraphicsSubsystem GraphicsSubsystem { get { return Dereference<GraphicsSubsystem>(0x017081EC); } }

		public GraphicsPreferences GraphicsPreferences { get { return Field<GraphicsPreferences>(0x01709DF4); } }
		public SoundPreferences SoundPreferences { get { return Field<SoundPreferences>(0x01709E88); } }

		public GameplayPreferences GameplayPreferences { get { return Field<GameplayPreferences>(0x0170A298); } }

		public SocialPreferences SocialPreferences { get { return Field<SocialPreferences>(0x0170A2F0); } }
		public ChatPreferences ChatPreferences { get { return Field<ChatPreferences>(0x0170A318); } }

		public ScreenManager ScreenManager { get { return Dereference<ScreenManager>(0x01833EC4); } }

		public int MouseKeysDown { get { return Field<int>(0x0183B8C8); } } // 1: Left, 2: Right, 4: Middle
		public int MouseX { get { return Field<int>(0x0183B8CC); } } // <-- Relative to client
		public int MouseY { get { return Field<int>(0x0183B8D0); } } // <-- Relative to client

		public LevelArea LevelArea { get {return Dereference<LevelArea>(0x0183E9E4);}}

		public BattleNetInterface BattleNetInterface { get { return Dereference<BattleNetInterface>(0x0186EC4C); } }
		public SoundSubsystem SoundSubsystem { get { return Dereference<SoundSubsystem>(0x0186EC50); } }
		public Container<MemoryObject> Sounds { get { return Dereference<Container<MemoryObject>>(0x0186EC54); } }

		public int IsClippingCursorToWindow { get { return Field<int>(0x0186ED8C); } } // <-- Nonzero if full screen window is active and the Lock Cursor option is set.

		public ClientSocket ClientSocket { get { return Dereference<ClientSocket>(0x01892AC0); } }

		public BuffManager BuffManager { get { return Dereference<BuffManager>(0x018B8C20); } }

		public int FModTotalMemory { get { return Field<int>(0x018C7414); } }

		public int FModAllocatedMemory { get { return Field<int>(0x018C74D4); } }
		public int FModMaxAllocatedMemory { get { return Field<int>(0x018C74D8); } }

		public int MessageLoopState { get { return Field<int>(0x018CE2C0); } } // 0: Not Started, 1: Active, 2: Abort

		public DisplayMode DisplayMode { get { return Field<DisplayMode>(0x018CE2E0); } }
		public DisplayMonitor DisplayMonitor { get { return Field<DisplayMonitor>(0x018CE310); } }

		public SnoGroup<int>[] SnoGroups { get { return Dereference<Pointer<SnoGroup<int>>>(0x018CE360, 61).Select(a => a.Value).ToArray(); } }
		public SnoGroup<int> TexturesSnoGroup { get { return SnoGroups[0]; } }
		public SnoGroup<int> ShaderMapSnoGroup { get { return SnoGroups[1]; } }
		public SnoGroup<int> AppearanceSnoGroup { get { return SnoGroups[2]; } }
		public SnoGroup<int> PhysMeshSnoGroup { get { return SnoGroups[3]; } }
		public SnoGroup<int> GlobalsSnoGroup { get { return SnoGroups[4]; } }
		public SnoGroup<int> ObserverSnoGroup { get { return SnoGroups[5]; } }
		public SnoGroup<int> SceneSnoGroup { get { return SnoGroups[6]; } }
		public SnoGroup<int> WorldsSnoGroup { get { return SnoGroups[7]; } }
		public SnoGroup<int> ActorSnoGroup { get { return SnoGroups[8]; } }
		public SnoGroup<int> AnimSetSnoGroup { get { return SnoGroups[9]; } }
		public SnoGroup<int> AnimSnoGroup { get { return SnoGroups[10]; } }
		public SnoGroup<int> StringListSnoGroup { get { return SnoGroups[11]; } }
		public SnoGroup<int> PowerSnoGroup { get { return SnoGroups[12]; } }
		public SnoGroup<int> MarkerSetSnoGroup { get { return SnoGroups[13]; } }
		public SnoGroup<int> HeroSnoGroup { get { return SnoGroups[14]; } }
		public SnoGroup<int> GameBalanceSnoGroup { get { return SnoGroups[15]; } }
		public SnoGroup<int> EncounterSnoGroup { get { return SnoGroups[16]; } }
		public SnoGroup<int> AdventureSnoGroup { get { return SnoGroups[17]; } }
		public SnoGroup<int> ConversationSnoGroup { get { return SnoGroups[18]; } }
		public SnoGroup<int> ConversationListSnoGroup { get { return SnoGroups[19]; } }
		public SnoGroup<int> FlagSetSnoGroup { get { return SnoGroups[20]; } }
		public SnoGroup<int> SceneGroupSnoGroup { get { return SnoGroups[21]; } }
		public SnoGroup<int> LevelAreaSnoGroup { get { return SnoGroups[22]; } }
		public SnoGroup<int> QuestSnoGroup { get { return SnoGroups[23]; } }
		public SnoGroup<int> QuestRangeSnoGroup { get { return SnoGroups[24]; } }
		public SnoGroup<int> SkillKitSnoGroup { get { return SnoGroups[25]; } }
		public SnoGroup<int> MonsterSnoGroup { get { return SnoGroups[26]; } }
		public SnoGroup<int> RecipeSnoGroup { get { return SnoGroups[27]; } }
		public SnoGroup<int> TimedEventSnoGroup { get { return SnoGroups[28]; } }
		public SnoGroup<int> ActSnoGroup { get { return SnoGroups[29]; } }
		public SnoGroup<int> LoreSnoGroup { get { return SnoGroups[30]; } }
		public SnoGroup<int> ConditionSnoGroup { get { return SnoGroups[31]; } }
		public SnoGroup<int> AccountSnoGroup { get { return SnoGroups[32]; } }
		public SnoGroup<int> TreasureClassSnoGroup { get { return SnoGroups[33]; } }
		public SnoGroup<int> BossEncounterSnoGroup { get { return SnoGroups[34]; } }
		public SnoGroup<int> TutorialSnoGroup { get { return SnoGroups[35]; } }
		public SnoGroup<int> AccoladeSnoGroup { get { return SnoGroups[36]; } }
		public SnoGroup<int> AmbientSoundSnoGroup { get { return SnoGroups[37]; } }
		public SnoGroup<int> PhysicsSnoGroup { get { return SnoGroups[38]; } }
		public SnoGroup<int> ExplosionSnoGroup { get { return SnoGroups[39]; } }
		public SnoGroup<int> SurfaceSnoGroup { get { return SnoGroups[40]; } }
		public SnoGroup<int> EffectGroupSnoGroup { get { return SnoGroups[41]; } }
		public SnoGroup<int> ClothSnoGroup { get { return SnoGroups[42]; } }
		public SnoGroup<int> TrailSnoGroup { get { return SnoGroups[43]; } }
		public SnoGroup<int> ParticleSnoGroup { get { return SnoGroups[44]; } }
		public SnoGroup<int> FontSnoGroup { get { return SnoGroups[45]; } }
		public SnoGroup<int> Anim2DSnoGroup { get { return SnoGroups[46]; } }
		public SnoGroup<int> ShadersSnoGroup { get { return SnoGroups[47]; } }
		public SnoGroup<int> UISnoGroup { get { return SnoGroups[48]; } }
		public SnoGroup<int> LightSnoGroup { get { return SnoGroups[49]; } }
		public SnoGroup<int> SoundBankSnoGroup { get { return SnoGroups[50]; } }
		public SnoGroup<int> SoundSnoGroup { get { return SnoGroups[51]; } }
		public SnoGroup<int> MusicSnoGroup { get { return SnoGroups[52]; } }
		public SnoGroup<int> RopeSnoGroup { get { return SnoGroups[53]; } }
		public SnoGroup<int> WeatherSnoGroup { get { return SnoGroups[54]; } }
		public SnoGroup<int> ShakesSnoGroup { get { return SnoGroups[55]; } }
		public SnoGroup<int> VibrationsSnoGroup { get { return SnoGroups[56]; } }
		public SnoGroup<int> MaterialSnoGroup { get { return SnoGroups[57]; } }
		public SnoGroup<int> ReverbSnoGroup { get { return SnoGroups[58]; } }
		public SnoGroup<int> AnimTreeSnoGroup { get { return SnoGroups[59]; } }

		public ObjectManager ObjectManager { get { return Dereference<ObjectManager>(0x018CE394); } }

		public int LastApplicationLoopTimestamp { get { return Field<int>(0x018CE368); } }

		public int ApplicationLoopCounter { get { return Field<int>(0x018CE448); } }

		public SnoFileManager SnoFileManager { get { return Dereference<SnoFileManager>(0x018D0510); } }

		public string LauncherFilePath { get { return Field(0x018D1310, 0x800); } }
		public string CommandLine { get { return Field(0x018D1B10, 0x800); } }

		public int SnoFilesAsyncThreadContext { get { return Field<int>(0x0192E9EC); } }

		public MemoryManager MemoryManager { get { return Dereference<MemoryManager>(0x01964DF4); } }

		public Environment Environment { get { return Dereference<Environment>(0x01964DFC); } }

		public LocaleId Locale { get { return (LocaleId)Field<int>(0x01965378); } }

		public Pointer<LogFile>[] LogFiles { get { return Field<Pointer<LogFile>>(0x01965380, 9); } }
		public LogFile DebugLogFile { get { return LogFiles[0].Value; } }
		public LogFile BootLogFile { get { return LogFiles[1].Value; } } // <-- not used?
		public LogFile SyncLogFile { get { return LogFiles[2].Value; } } // <-- not used?
		public LogFile FilesReadLogFile { get { return LogFiles[3].Value; } } // <-- not used?
		public LogFile StreamingLogFile { get { return LogFiles[4].Value; } } // <-- not used?
		public LogFile BattleNetLogFile { get { return LogFiles[5].Value; } } // <-- not used?
		public LogFile LocksLogFile { get { return LogFiles[6].Value; } } // <-- not used?
		public LogFile DBCleanupLogFile { get { return LogFiles[7].Value; } } // <-- not used?
		public LogFile TradeLogFile { get { return LogFiles[8].Value; } } // <-- not used?

		public string LogFolder { get { return Field(0x019653B0, 260); } }

		public long PerformanceFrequency { get { return Field<long>(0x01966498); } }

		public LinkedList<Pointer<Container<MemoryObject>>> Containers { get { return Dereference<LinkedList<Pointer<Container<MemoryObject>>>>(0x01967454); } }

		public SnoHelper SnoHelper { get { return new SnoHelper(this); } }

		public void Dispose()
		{
			base.Memory.Dispose();
		}
	}
}
