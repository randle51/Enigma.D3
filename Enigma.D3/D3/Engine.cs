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

		public Engine(Process process)
			: base(new ProcessMemory(process), 0)
		{
			Engine.Current = this;
		}

		public Process Process { get { return base.Memory.Process; } }

		public AttributeDescriptor[] AttributeDescriptors { get { return Field<AttributeDescriptor>(0x01A97600, 1336); } }

		public VideoPreferences VideoPreferences { get { return Field<VideoPreferences>(0x01AC0440); } }
		public SoundPreferences SoundPreferences { get { return Field<SoundPreferences>(0x01AC04CC); } }

		public GameplayPreferences GameplayPreferences { get { return Field<GameplayPreferences>(0x01AC093C); } }

		public SocialPreferences SocialPreferences { get { return Field<SocialPreferences>(0x01AC0998); } }

		public ChatPreferences ChatPreferences { get { return Field<ChatPreferences>(0x01AC09C4); } }

		public ScreenManager ScreenManager { get { return Dereference<ScreenManager>(0x01B0B8D0); } }

		public UIReference[] UIReferences { get { return Field<UIReference>(0x01B0BC88, 2465); } }

		public LevelArea LevelArea { get { return Dereference<LevelArea>(0x01C4D498); } }

		public string LevelAreaName { get { return Field(0x01C4D4C0, 128); } }

		public BuffManager BuffManager { get { return Dereference<BuffManager>(0x01CD79B8); } }

		public SnoGroup[] SnoGroupsByCode { get { return Field<Pointer<SnoGroup>>(0x01CEF708, 70).Select(a => a.Value).ToArray(); } }

		public SnoGroup[] SnoGroups { get { return Dereference<Pointer<SnoGroup>>(0x01CEF824, 61).Select(a => a.Value).ToArray(); } }
		
		public ObjectManager ObjectManager { get { return Dereference<ObjectManager>(0x01CEF854); } }
		public ObjectManager ObjectManagerPristine { get { return Dereference<ObjectManager>(0x01CEF858); } } // This address is used in initialization and finalization methods.
		
		public LocalData LocalData { get { return Field<LocalData>(0x01CF0AE8); } }

		public SnoGroupSearch SnoGroupSearch { get { return Dereference<SnoGroupSearch>(0x01D43B50); } }

		public ContainerManager ContainerManager { get { return Dereference<ContainerManager>(0x01DA2BB4); } }

		public UIHandler[] UIHandlers { get { return Field<UIHandler>(0x01A8A038, 1181); } }

		public SnoGroupInitializer[] SnoGroupInitializers { get { return Field<SnoGroupInitializer>(0x01A93158, 60); } }

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
