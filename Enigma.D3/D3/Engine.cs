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

namespace Enigma.D3
{
	public class Engine : MemoryObject, IDisposable
	{
		public static Engine Create()
		{
			var process = Process.GetProcessesByName("Diablo III")
				.FirstOrDefault();
			return process == null ? null : new Engine(process);
		}

		public static Engine Current { get; private set; }

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
			: base(new ProcessMemory(process), 0)
		{
			Engine.Current = this;
		}

		public Process Process { get { return base.Memory.Process; } }

		public AttributeDescriptor[] AttributeDescriptors { get { return Field<AttributeDescriptor>(0x01A85620, 1338); } }

		public VideoPreferences VideoPreferences { get { return Field<VideoPreferences>(0x01AAE3A0); } }
		public SoundPreferences SoundPreferences { get { return Field<SoundPreferences>(0x01AAE42C); } }

		public GameplayPreferences GameplayPreferences { get { return Field<GameplayPreferences>(0x01AAE89C); } }

		public SocialPreferences SocialPreferences { get { return Field<SocialPreferences>(0x01AAE8F8); } }

		public ChatPreferences ChatPreferences { get { return Field<ChatPreferences>(0x01AAE924); } }

		public int MapActId { get { return Field<int>(0x01AF9628); } }

		public ScreenManager ScreenManager { get { return Dereference<ScreenManager>(0x01AF9838); } }

		public UIReference[] UIReferences { get { return Field<UIReference>(0x01AF99E8, 2466); } } // 1 + 1000 + 1000 + 324 + 141 = 2466

		public LevelArea LevelArea { get { return Dereference<LevelArea>(0x01C3B400); } }

		public string LevelAreaName { get { return Field(0x01C3B428, 128); } }

		public PetPortraitInfo PetPortraitInfo { get { return Dereference<PetPortraitInfo>(0x01C3B4C4); } }

		public BuffManager BuffManager { get { return Dereference<BuffManager>(0x01CC5950); } }

		public SnoGroup[] SnoGroupsByCode { get { return Field<Pointer<SnoGroup>>(0x01CDD6A8, 70).Select(a => a.Value).ToArray(); } }

		public SnoGroup[] SnoGroups { get { return Dereference<Pointer<SnoGroup>>(0x01CDD7C4, 61).Select(a => a.Value).ToArray(); } }

		public ObjectManager ObjectManager { get { return Dereference<ObjectManager>(0x01CDD7F4); } }
		public ObjectManager ObjectManagerPristine { get { return Dereference<ObjectManager>(0x01CDD7F8); } } // This address is used in initialization and finalization methods.

		public LocalData LocalData { get { return Field<LocalData>(0x01CDEA88); } }

		public SnoGroupSearch SnoGroupSearch { get { return Dereference<SnoGroupSearch>(0x01D31AF0); } }

		public ContainerManager ContainerManager { get { return Dereference<ContainerManager>(0x01D90BD4); } }

		public UIHandler[] UIHandlers { get { return Field<UIHandler>(0x01A78038, 1181); } }

		public SnoGroupInitializer[] SnoGroupInitializers { get { return Field<SnoGroupInitializer>(0x01A81160, 60); } }

		public GlobalStruct010 GlobalStruct010 { get { return Dereference<GlobalStruct010>(0x01C32C3C); } }

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

		public DisplayMode DefaultDisplayMode { get { return Field<DisplayMode>(0x0174A800); } }

		public MessageDescriptor[] MessageHandlers { get { return Field<Pointer<MessageDescriptor>>(0x01A6E860, 137).Select(a => a.Value).ToArray(); } }

		public ValueTypeDescriptor[] DataTypes { get { return Field<Pointer<ValueTypeDescriptor>>(0x01A74090, 21).Select(a => a.Value).ToArray(); } }

		public NamedCriticalSection BlizzardInode { get { return Field<NamedCriticalSection>(0x01A7D1D4); } }

		public MemoryObject GameAsyncRender { get { return Dereference<MemoryObject>(0x01A8D084); } } // 16760 bytes

		public GraphicsSubsystem GraphicsSubsystem { get { return Dereference<GraphicsSubsystem>(0x01A89298); } }

		public NetworkManager NetworkManager { get { return Dereference<NetworkManager>(0x01C46408); } }

		public MemoryObject SoundSubsystem { get { return Dereference<MemoryObject>(0x01C46680); } } // 488 bytes
		public Container Sounds { get { return Dereference<Container>(0x01C46684); } } // Each item is 260 bytes

		public int GameType { get { return Field<int>(0x01CB1E8C); } }

		public GameBalanceManager GameBalanceManager { get { return Dereference<GameBalanceManager>(0x01CB1FC8); } }

		public MemoryManager MemoryManager { get { return Dereference<MemoryManager>(0x01D68928); } }

		public long PerformanceFrequency { get { return Field<long>(0x01D69FE0); } }
		public long PerformanceFrequencyDivider { get { return Field<long>(0x01D69FE8); } }
		public long ReducedPerformanceFrequency { get { return Field<long>(0x01D69FF0); } }
		public int PerformanceFrequencyDividerInSeconds { get { return Field<int>(0x01D69FF8); } }
		public int TimebaseInitState { get { return Field<int>(0x01D69FFC); } }
		public int TimerFrequencyMode { get { return Field<int>(0x01D6A000); } }

		public long InitPerformanceFrequency { get { return Field<long>(0x01D6A878); } } // written during static constructors

		public void Dispose()
		{
			base.Memory.Dispose();
		}
	}
}
