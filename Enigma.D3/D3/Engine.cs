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

		public static readonly Version SupportedVersion = new Version(2, 1, 2, 28709);

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

		public AttributeDescriptor[] AttributeDescriptors { get { return Read<AttributeDescriptor>(0x01A2A928, 1378); } }

		public VideoPreferences VideoPreferences { get { return Read<VideoPreferences>(0x01A53DA8); } }
		public SoundPreferences SoundPreferences { get { return Read<SoundPreferences>(0x01A53E38); } }

		public GameplayPreferences GameplayPreferences { get { return Read<GameplayPreferences>(0x01A542C8); } }

		public SocialPreferences SocialPreferences { get { return Read<SocialPreferences>(0x01A54328); } }

		public ChatPreferences ChatPreferences { get { return Read<ChatPreferences>(0x01A54354); } }

		public int MapActId { get { return Read<int>(0x01AA0640); } }

		public UIReference[] UIReferences { get { return Read<UIReference>(0x01AA09E8, 2320); } } // 1 + 1000 + 911 + 202 + 206 = 2320

		public LevelArea LevelArea { get { return ReadPointer<LevelArea>(0x01BD3BAC).Dereference(); } }

		public string LevelAreaName { get { return ReadString(0x01BD3BD8, 128); } }
		

		public BuffManager BuffManager { get { return ReadPointer<BuffManager>(0x01C5D514).Dereference(); } }

		[ArraySize(70)]
		public SnoGroupManager[] SnoGroupsByCode { get { return Read<Ptr<SnoGroupManager>>(0x01C75D90, 70).Select(a => a.Dereference()).ToArray(); } }

		[ArraySize(60)] // In reality it's 61 with last item set to null.
		public SnoGroupManager[] SnoGroups { get { return ReadPointer<Ptr<SnoGroupManager>>(0x01C75EAC).ToArray(60).Select(a => a.Dereference()).ToArray(); } }

		public ObjectManager ObjectManager { get { return ReadPointer<ObjectManager>(0x01C77EDC).Dereference(); } }
		public ObjectManager ObjectManagerPristine { get { return ReadPointer<ObjectManager>(0x01C77EE0).Dereference(); } } // This address is used in initialization and finalization methods.

		public int ApplicationLoopCount { get { return Read<int>(0x01C77F4C); } }

		public LocalData LocalData { get { return Read<LocalData>(0x01C79178); } }

		public Ptr<SnoFiles> PtrSnoFiles { get { return ReadPointer<SnoFiles>(0x01C7A100); } }

		public SnoGroupSearch SnoGroupSearch { get { return ReadPointer<SnoGroupSearch>(0x01CCAE44).Dereference(); } }

		public Ptr<SnoFilesAsync> SnoFilesAsync { get { return ReadPointer<SnoFilesAsync>(0x01CCAE48); } }

		[Obsolete("Not updated for 2.1.2.28709")]
		public MessageDescriptor MessageDescriptor { get { return ReadPointer<MessageDescriptor>(0x01D14008).Dereference(); } }

		public ContainerManager ContainerManager { get { return ReadPointer<ContainerManager>(0x01D30C9C).Dereference(); } }

		public UIHandler[] UIHandlers { get { return Read<UIHandler>(0x01A1D3D8, 1177); } }

		public SnoGroupInitializer[] SnoGroupInitializers { get { return Read<SnoGroupInitializer>(0x01A26350, 60); } }

		public void Dispose()
		{
			base.Memory.Dispose();
		}
	}
}
