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

		public static readonly Version SupportedVersion = new Version(2, 1, 1, 27255);

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

		public AttributeDescriptor[] AttributeDescriptors { get { return Read<AttributeDescriptor>(0x01A0E458, 1371); } }

		public VideoPreferences VideoPreferences { get { return Read<VideoPreferences>(0x01A37B38); } }
		public SoundPreferences SoundPreferences { get { return Read<SoundPreferences>(0x01A2DB38); } }

		public GameplayPreferences GameplayPreferences { get { return Read<GameplayPreferences>(0x01A2DFC8); } }

		public SocialPreferences SocialPreferences { get { return Read<SocialPreferences>(0x01A2E028); } }

		public ChatPreferences ChatPreferences { get { return Read<ChatPreferences>(0x01A2E054); } }

		[Obsolete("Not updated for 2.1.1.27255")]
		public int MapActId { get { return Read<int>(0x01A7A308); } }

		public UIReference[] UIReferences { get { return Read<UIReference>(0x01A84770, 2316); } } // 1 + 1000 + 909 + 205 + 203 = 2318

		public UISystems UISystems { get { return ReadPointer<UISystems>(0x01BAD244).Dereference(); } }

		[Obsolete]
		public Ptr<GlobalStruct013> Ptr_GlobalStruct013 { get { return ReadPointer<GlobalStruct013>(0x01C4141C); } }

		public LevelArea LevelArea { get { return ReadPointer<LevelArea>(0x01BB7524).Dereference(); } }

		public string LevelAreaName { get { return ReadString(0x01BB7550, 128); } }

		[Obsolete("Not updated for 2.1.1.27255")]
		public PetPortraitInfo PetPortraitInfo { get { return ReadPointer<PetPortraitInfo>(0x01BACF44).Dereference(); } }

		[Obsolete("Not updated for 2.1.1.27255")]
		[ArraySize(10)]
		public PortraitData[] PortraitData { get { return Read<PortraitData>(0x01BACF60, 10); } }

		[Obsolete]
		public Vector Array { get { return Read<Vector>(0x01CA2EA8); } } // No idea what this is..

		public BuffManager BuffManager { get { return ReadPointer<BuffManager>(0x01C40E7C).Dereference(); } }

		[ArraySize(70)]
		public SnoGroupManager[] SnoGroupsByCode { get { return Read<Ptr<SnoGroupManager>>(0x01C596D8, 70).Select(a => a.Dereference()).ToArray(); } }

		[ArraySize(60)] // In reality it's 61 with last item set to null.
		public SnoGroupManager[] SnoGroups { get { return ReadPointer<Ptr<SnoGroupManager>>(0x01C597F4).ToArray(60).Select(a => a.Dereference()).ToArray(); } }

		public ObjectManager ObjectManager { get { return ReadPointer<ObjectManager>(0x01C5B824).Dereference(); } }
		public ObjectManager ObjectManagerPristine { get { return ReadPointer<ObjectManager>(0x01C5B828).Dereference(); } } // This address is used in initialization and finalization methods.

		public int ApplicationLoopCount { get { return Read<int>(0x01C5B894); } }

		[Obsolete("Not updated for 2.1.1.27255")]
		public Map SnoMapTest { get { return Read<Map>(0x01C63570); } }

		[Obsolete]
		public Ptr<GlobalStruct012> GlobalStruct012 { get { return ReadPointer<GlobalStruct012>(0x01CE4A48); } }

		public LocalData LocalData { get { return Read<LocalData>(0x01C5CAC0); } }

		public Ptr<SnoFiles> PtrSnoFiles { get { return ReadPointer<SnoFiles>(0x01C5DA48); } }

		public SnoGroupSearch SnoGroupSearch { get { return ReadPointer<SnoGroupSearch>(0x01CAE814).Dereference(); } }

		public Ptr<SnoFilesAsync> SnoFilesAsync { get { return ReadPointer<SnoFilesAsync>(0x01CAE818); } }

		[Obsolete]
		public RefStringDataAllocators RefStringDataAllocators { get { return ReadPointer<RefStringDataAllocators>(0x01D94150).Dereference(); } }

		[Obsolete]
		public int NumberOfRefStringDataInstances { get { return Read<int>(0x01D94C88); } }
		[Obsolete]
		public int IsRefStringSystemInitialized { get { return Read<int>(0x01D94C8C); } }
		[Obsolete]
		public CriticalSection RefStringDataLock { get { return ReadPointer<CriticalSection>(0x01D94C90).Dereference(); } }

		[Obsolete("Not updated for 2.1.1.27255")]
		public MessageDescriptor MessageDescriptor { get { return ReadPointer<MessageDescriptor>(0x01D09588).Dereference(); } }

		public ContainerManager ContainerManager { get { return ReadPointer<ContainerManager>(0x01D141B4).Dereference(); } }

		public UIHandler[] UIHandlers { get { return Read<UIHandler>(0x01A01340, 1180); } }

		public SnoGroupInitializer[] SnoGroupInitializers { get { return Read<SnoGroupInitializer>(0x01A0A2C0, 60); } }

		[Obsolete]
		public GlobalStruct010 GlobalStruct010 { get { return ReadPointer<GlobalStruct010>(0x01C38C5C).Dereference(); } }

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
		public MemoryObject GameAsyncRender { get { return ReadPointer<MemoryObject>(0x01A8D084).Dereference(); } } // 16760 bytes

		[Obsolete]
		public GraphicsSubsystem GraphicsSubsystem { get { return ReadPointer<GraphicsSubsystem>(0x01A89298).Dereference(); } }

		[Obsolete]
		public NetworkManager NetworkManager { get { return ReadPointer<NetworkManager>(0x01C46408).Dereference(); } }

		[Obsolete]
		public MemoryObject SoundSubsystem { get { return ReadPointer<MemoryObject>(0x01C46680).Dereference(); } } // 488 bytes
		[Obsolete]
		public Container Sounds { get { return ReadPointer<Container>(0x01C46684).Dereference(); } } // Each item is 260 bytes

		[Obsolete]
		public int GameType { get { return Read<int>(0x01CB1E8C); } }

		[Obsolete]
		public GameBalanceManager GameBalanceManager { get { return ReadPointer<GameBalanceManager>(0x01CB1FC8).Dereference(); } }

		[Obsolete]
		public MemoryManager MemoryManager { get { return ReadPointer<MemoryManager>(0x01D68928).Dereference(); } }

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
