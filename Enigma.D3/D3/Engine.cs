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

		public static readonly Version SupportedVersion = new Version(2, 2, 0, 30894);

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


		public AttributeDescriptor[] AttributeDescriptors { get { return Read<AttributeDescriptor>(0x01AE5720, 1410); } }

		public VideoPreferences VideoPreferences { get { return Read<VideoPreferences>(0x01B10A98); } }
		public SoundPreferences SoundPreferences { get { return Read<SoundPreferences>(0x01B10B2C); } }

		public GameplayPreferences GameplayPreferences { get { return Read<GameplayPreferences>(0x01B10FCC); } }

		public SocialPreferences SocialPreferences { get { return Read<SocialPreferences>(0x01B1102C); } }

		public ChatPreferences ChatPreferences { get { return Read<ChatPreferences>(0x01B1105C); } }

		public int MapActId { get { return Read<int>(0x01B5D320); } }

		[ArraySize(2550)]
		public UIReference[] UIReferences { get { return Read<UIReference>(0x01B5D8D0, 2550); } } // 1000 + 1000 + 109 + 441 = 2550

		public LevelArea LevelArea { get { return ReadPointer<LevelArea>(0x01CADE44).Dereference(); } }

		public string LevelAreaName { get { return ReadString(0x01CADE70, 128); } }

		public TrickleManager TrickleManager { get { return ReadPointer<TrickleManager>(0x01C36400).Dereference(); } }

		public BuffManager BuffManager { get { return ReadPointer<BuffManager>(0x01D38388).Dereference(); } }

		[ArraySize(70)]
		public SnoGroupManager[] SnoGroupsByCode { get { return Read<Ptr<SnoGroupManager>>(0x01D509C0, 70).Select(a => a.Dereference()).ToArray(); } }

		[ArraySize(60)] // In reality it's 61 with last item set to null.
		public SnoGroupManager[] SnoGroups { get { return ReadPointer<Ptr<SnoGroupManager>>(0x01D50ADC).ToArray(60).Select(a => a.Dereference()).ToArray(); } }

		public ObjectManager ObjectManager { get { return ReadPointer<ObjectManager>(0x01D52BC4).Dereference(); } }
		public ObjectManager ObjectManagerPristine { get { return ReadPointer<ObjectManager>(0x01D52BC8).Dereference(); } } // This address is used in initialization and finalization methods.

		public int ApplicationLoopCount { get { return Read<int>(0x01D52C38); } }

		public LocalData LocalData { get { return Read<LocalData>(0x01D53E68); } }

		public Ptr<SnoFiles> PtrSnoFiles { get { return ReadPointer<SnoFiles>(0x01D54F08); } }

		public FixedArray<int> SnoIdToEntityId { get { return Read<FixedArray<int>>(0x01D65234); } }

		public SnoGroupSearch SnoGroupSearch { get { return ReadPointer<SnoGroupSearch>(0x01DA36E4).Dereference(); } }

		public Ptr<SnoFilesAsync> SnoFilesAsync { get { return ReadPointer<SnoFilesAsync>(0x01DA36E8); } }

		public MessageDescriptor MessageDescriptor { get { return ReadPointer<MessageDescriptor>(0x01E059E4).Dereference(); } }

		public ContainerManager ContainerManager { get { return ReadPointer<ContainerManager>(0x01E066E4).Dereference(); } }

		[ArraySize(1223)]
		public UIHandler[] UIHandlers { get { return Read<UIHandler>(0x01AD7458, 1223); } }

		public SnoGroupInitializer[] SnoGroupInitializers { get { return Read<SnoGroupInitializer>(0x01AE0808, 60); } }

		public void Dispose()
		{
			base.Memory.Dispose();
		}
	}
}
