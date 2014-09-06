using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.Graphics;
using Enigma.D3.Memory;
using Enigma.D3.Preferences;
using Enigma.D3.UI;
using Enigma.D3.Win32;
using Enigma.D3.Sno;

namespace Enigma.D3
{
	public class Engine : MemoryObject, IDisposable
	{
		private static Engine _lastCreated;

		[ThreadStatic]
		private static Engine _current;

		public static readonly Version SupportedVersion = new Version(2, 1, 0, 26451);

		public static Engine Create()
		{
			var process = Process.GetProcessesByName("Diablo III")
				.FirstOrDefault();
			return process == null ? null : new Engine(process);
		}

		public static Engine Create(MiniDumpMemoryReader miniDumpMemory)
		{
			if (miniDumpMemory == null)
				throw new ArgumentNullException("miniDumpMemory");
			return new Engine(new ReadOnlyMemory(miniDumpMemory));
		}

		public static Engine Current
		{
			get
			{
				return _current ?? _lastCreated;
			}
			set
			{
				_current = value;
			}
		}

		public static void Unload()
		{
			var current = Current;
			Current = null;
			if (current != null)
				current.Dispose();
		}

		public static T TryGet<T>(Func<Engine, T> getter)
		{
			try
			{
				return getter.Invoke(Engine.Current);
			}
			catch
			{
				return default(T);
			}
		}

		public Engine(Process process)
			: this(new ReadOnlyMemory(new ProcessMemoryReader(process))) { }

		public Engine(IMemory memory)
		{
			base.Initialize(memory, 0);
			if (memory.Reader is IHasMainModuleVersion)
				EnsureSupportedProcessVersion();
			_lastCreated = this;
		}

		private void EnsureSupportedProcessVersion()
		{
			if (ProcessVersion != SupportedVersion)
			{
				throw new NotSupportedException(string.Format(
					"The process ({0}) is running a different version ({1}) that what is supported ({2}).",
					Process.ProcessName,
					Process.GetFileVersion(),
					SupportedVersion));
			}
		}

		public Version ProcessVersion
		{
			get
			{
				var module = Memory.Reader as IHasMainModuleVersion;
				if (module != null)
					return module.MainModuleVersion;

				throw new NotSupportedException("The current memory source does not contain any process version info.");
			}
		}

		public Process Process
		{
			get
			{
				var processMemory = base.Memory.Reader as ProcessMemoryReader;
				return processMemory == null ? null : processMemory.Process;
			}
		}

		public AttributeDescriptor[] AttributeDescriptors { get { return Read<AttributeDescriptor>(0x01A04400, 1371); } }

		public VideoPreferences VideoPreferences { get { return Read<VideoPreferences>(0x01A2DAA8); } }
		public SoundPreferences SoundPreferences { get { return Read<SoundPreferences>(0x01A2DB38); } }

		public GameplayPreferences GameplayPreferences { get { return Read<GameplayPreferences>(0x01A2DFC8); } }

		public SocialPreferences SocialPreferences { get { return Read<SocialPreferences>(0x01A2E028); } }

		public ChatPreferences ChatPreferences { get { return Read<ChatPreferences>(0x01A2E054); } }

		public int MapActId { get { return Read<int>(0x01A7A308); } }

		public UIReference[] UIReferences { get { return Read<UIReference>(0x01A7A6E0, 2316); } } // 1 + 1000 + 909 + 256 + 150 = 2316

		public UISystems UISystems { get { return Dereference<UISystems>(0x01BA2DA4); } }

		[Obsolete]
		public Ptr<GlobalStruct013> Ptr_GlobalStruct013 { get { return ReadPointer<GlobalStruct013>(0x01C4141C); } }

		public LevelArea LevelArea { get { return Dereference<LevelArea>(0x01BACE7C); } }

		public string LevelAreaName { get { return ReadString(0x01BACEA8, 128); } }

		public PetPortraitInfo PetPortraitInfo { get { return Dereference<PetPortraitInfo>(0x01BACF44); } }

		[ArraySize(10)]
		public PortraitData[] PortraitData { get { return Read<PortraitData>(0x01BACF60, 10); } }

		[Obsolete]
		public Vector Array { get { return Read<Vector>(0x01CA2EA8); } } // No idea what this is..

		public BuffManager BuffManager { get { return Dereference<BuffManager>(0x01C367DC); } }

		[ArraySize(70)]
		public SnoGroupManager[] SnoGroupsByCode { get { return Read<Ptr<SnoGroupManager>>(0x01C4F038, 70).Select(a => a.Dereference()).ToArray(); } }

		[ArraySize(60)] // In reality it's 61 with last item set to null.
		public SnoGroupManager[] SnoGroups { get { return ReadPointer<Ptr<SnoGroupManager>>(0x01C4F154).ToArray(60).Select(a => a.Dereference()).ToArray(); } }

		public ObjectManager ObjectManager { get { return Dereference<ObjectManager>(0x01C51184); } }
		public ObjectManager ObjectManagerPristine { get { return Dereference<ObjectManager>(0x01C51188); } } // This address is used in initialization and finalization methods.

		public int ApplicationLoopCount { get { return Read<int>(0x01C511F4); } }

		[Obsolete]
		public Ptr<GlobalStruct012> GlobalStruct012 { get { return ReadPointer<GlobalStruct012>(0x01CE4A48); } }

		public LocalData LocalData { get { return Read<LocalData>(0x01C52420); } }

		public Ptr<SnoFiles> PtrSnoFiles { get { return ReadPointer<SnoFiles>(0x01C53350); } }

		public SnoGroupSearch SnoGroupSearch { get { return Dereference<SnoGroupSearch>(0x01CA4094); } }

		public Ptr<SnoFilesAsync> SnoFilesAsync { get { return ReadPointer<SnoFilesAsync>(0x01CCE030); } }

		[Obsolete]
		public RefStringDataAllocators RefStringDataAllocators { get { return Dereference<RefStringDataAllocators>(0x01D94150); } }

		[Obsolete]
		public int NumberOfRefStringDataInstances { get { return Read<int>(0x01D94C88); } }
		[Obsolete]
		public int IsRefStringSystemInitialized { get { return Read<int>(0x01D94C8C); } }
		[Obsolete]
		public CriticalSection RefStringDataLock { get { return Dereference<CriticalSection>(0x01D94C90); } }

		public MessageDescriptor MessageDescriptor { get { return Dereference<MessageDescriptor>(0x01D09588); } }

		public ContainerManager ContainerManager { get { return Dereference<ContainerManager>(0x01D09734); } }

		public UIHandler[] UIHandlers { get { return Read<UIHandler>(0x019F7340, 1180); } }

		public SnoGroupInitializer[] SnoGroupInitializers { get { return Read<SnoGroupInitializer>(0x01A002B8, 60); } }

		[Obsolete]
		public GlobalStruct010 GlobalStruct010 { get { return Dereference<GlobalStruct010>(0x01C38C5C); } }

		// ↑ 2.0.6.24641 ↑
		// ↓ 2.0.5.24017 ↓

		// ↑ 2.0.5.24017 ↑
		// ↓ 2.0.5.23920 ↓

		// ↑ 2.0.5.23920 ↑
		// ↓ 2.0.4.23119 ↓

		// ↑ 2.0.4.23119 ↑
		// ↓ 2.0.3.22427 ↓

		// ↑ 2.0.3.22427 ↑
		// ↓ 2.0.2.22274 ↓

		// ↑ 2.0.2.22274 ↑
		// ↓ 2.0.1.22044 ↓

		// ADDRESSES ABOVE THIS LINE IS UPDATED FOR 2.0.1.22044
		// ADDRESSES UNDER THIS LINE IS NOT UPDATED FOR 2.0.1.22044

		// ADDRESSES ABOVE THIS LINE IS UPDATED FOR 2.0.0.21962
		// ADDRESSES UNDER THIS LINE IS NOT UPDATED FOR 2.0.0.21962

		// ADDRESSES ABOVE THIS LINE IS UPDATED FOR 2.0.0.21806
		// ADDRESSES UNDER THIS LINE IS NOT UPDATED FOR 2.0.0.21806

		// ADDRESSES ABOVE THIS LINE IS UPDATED FOR 2.0.0.21390
		// ADDRESSES UNDER THIS LINE IS NOT UPDATED FOR 2.0.0.21390

		[Obsolete]
		public DisplayMode DefaultDisplayMode { get { return Read<DisplayMode>(0x0174A800); } }

		[Obsolete]
		public ValueTypeDescriptor[] DataTypes { get { return Read<Ptr<ValueTypeDescriptor>>(0x01A74090, 21).Select(a => a.Dereference()).ToArray(); } }

		[Obsolete]
		public NamedCriticalSection BlizzardInode { get { return Read<NamedCriticalSection>(0x01A7D1D4); } }

		[Obsolete]
		public MemoryObject GameAsyncRender { get { return Dereference<MemoryObject>(0x01A8D084); } } // 16760 bytes

		[Obsolete]
		public GraphicsSubsystem GraphicsSubsystem { get { return Dereference<GraphicsSubsystem>(0x01A89298); } }

		[Obsolete]
		public NetworkManager NetworkManager { get { return Dereference<NetworkManager>(0x01C46408); } }

		[Obsolete]
		public MemoryObject SoundSubsystem { get { return Dereference<MemoryObject>(0x01C46680); } } // 488 bytes
		[Obsolete]
		public Container Sounds { get { return Dereference<Container>(0x01C46684); } } // Each item is 260 bytes

		[Obsolete]
		public int GameType { get { return Read<int>(0x01CB1E8C); } }

		[Obsolete]
		public GameBalanceManager GameBalanceManager { get { return Dereference<GameBalanceManager>(0x01CB1FC8); } }

		[Obsolete]
		public MemoryManager MemoryManager { get { return Dereference<MemoryManager>(0x01D68928); } }

		[Obsolete]
		public long PerformanceFrequency { get { return Read<long>(0x01D69FE0); } }
		[Obsolete]
		public long PerformanceFrequencyDivider { get { return Read<long>(0x01D69FE8); } }
		[Obsolete]
		public long ReducedPerformanceFrequency { get { return Read<long>(0x01D69FF0); } }
		[Obsolete]
		public int PerformanceFrequencyDividerInSeconds { get { return Read<int>(0x01D69FF8); } }
		[Obsolete]
		public int TimebaseInitState { get { return Read<int>(0x01D69FFC); } }
		[Obsolete]
		public int TimerFrequencyMode { get { return Read<int>(0x01D6A000); } }

		[Obsolete]
		public long InitPerformanceFrequency { get { return Read<long>(0x01D6A878); } } // written during static constructors

		public void Dispose()
		{
			base.Memory.Dispose();
		}
	}
}
