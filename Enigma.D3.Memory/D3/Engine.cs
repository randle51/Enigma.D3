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
using Enigma.D3.Assets;

namespace Enigma.D3
{
	public class Engine : MemoryObject, IDisposable
	{
		private static class Addr
		{
			public const int SnoGroupInitializers = 0x01B71ABC - 4;
			public const int SnoGroupByCode = 0x01DCD048;
			public const int SnoGroups = 0x01DCD164;
			public const int SnoGroupSearch = 0x01E2021C;
			public const int SnoFilesAsync = 0x01E20220;
			public const int ObjectManager = 0x01DCF24C;
			public const int ObjectManagerPristine = 0x01DCF250;
			public const int MessageDescriptor = 0x01E8386C;
			public const int MapActId = 0x01BBB348;
			public const int LocalData = 0x01DD04F0;
			public const int LevelArea = 0x01D27778;
			public const int LevelAreaName = 0x01D277A8;
			public const int GameplayPreferences = 0x01BA1F94;
			public const int ContainerManager = 0x01E8456C;
			public const int BuffManager = 0x01DB4990;
			public const int ApplicationLoopCount = 0x01DCF2C0;
			public const int AttributeDescriptors = 0x01B76AC8;
			public const int VideoPreferences = 0x01BA1A50;
			public const int ChatPreferences = 0x01BA2024;
			public const int SoundPreferences = 0x01BA1AE4;
			public const int SocialPreferences = 0x01BA1FF4;
			public const int UIHandlers = 0x01B684D0;
			public const int UIReferences = 0x01BBB8F8;
			public const int SnoIdToEntityId = 0x00000000;
			public const int TrickleManager = 0x01D8BF88;
			public const int PtrSnoFiles = 0x01DD1610;
		}

		private static class Const
		{
			public const int SizeOfAttributeDescriptor = 40;
			public const int CountAttributeDescriptors = (0x01B8489C - 0x01B76AE4) / SizeOfAttributeDescriptor;

			public const int CountUIReferences = 2767;

			public const int SizeOfUIHandler = 12;
			public const int CountUIHandlers = 0x3AEC / SizeOfUIHandler;
		}


		private static Engine _lastCreated;

		[ThreadStatic]
		private static Engine _current;

		public static readonly Version SupportedVersion = new Version(2, 3, 0, 33567);

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
				// TODO: We don't have Process instance if reading a minidump.
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

		[ArraySize(Const.CountAttributeDescriptors)]
		public AttributeDescriptor[] AttributeDescriptors { get { return Read<AttributeDescriptor>(Addr.AttributeDescriptors, Const.CountAttributeDescriptors); } }

		public VideoPreferences VideoPreferences { get { return Read<VideoPreferences>(Addr.VideoPreferences); } }
		public SoundPreferences SoundPreferences { get { return Read<SoundPreferences>(Addr.SoundPreferences); } }

		public GameplayPreferences GameplayPreferences { get { return Read<GameplayPreferences>(Addr.GameplayPreferences); } }

		public SocialPreferences SocialPreferences { get { return Read<SocialPreferences>(Addr.SocialPreferences); } }

		public ChatPreferences ChatPreferences { get { return Read<ChatPreferences>(Addr.ChatPreferences); } }

		public int MapActId { get { return Read<int>(Addr.MapActId); } }

		[ArraySize(Const.CountUIReferences)]
		public UIReference[] UIReferences { get { return Read<UIReference>(Addr.UIReferences, Const.CountUIReferences); } }

		public LevelArea LevelArea { get { return ReadPointer<LevelArea>(Addr.LevelArea).Dereference(); } }

		public string LevelAreaName { get { return ReadString(Addr.LevelAreaName, 128); } }

		public TrickleManager TrickleManager { get { return ReadPointer<TrickleManager>(Addr.TrickleManager).Dereference(); } }

		public BuffManager BuffManager { get { return ReadPointer<BuffManager>(Addr.BuffManager).Dereference(); } }

		[ArraySize(70)]
		public SnoGroupManager[] SnoGroupsByCode { get { return Read<Ptr<SnoGroupManager>>(Addr.SnoGroupByCode, 70).Select(a => a.Dereference()).ToArray(); } }

		[ArraySize(60)] // In reality it's 61 with last item set to null.
		public SnoGroupManager[] SnoGroups { get { return ReadPointer<Ptr<SnoGroupManager>>(Addr.SnoGroups).ToArray(60).Select(a => a.Dereference()).ToArray(); } }

		public ObjectManager ObjectManager { get { return ReadPointer<ObjectManager>(Addr.ObjectManager).Dereference(); } }
		public ObjectManager ObjectManagerPristine { get { return ReadPointer<ObjectManager>(Addr.ObjectManagerPristine).Dereference(); } } // This address is used in initialization and finalization methods.

		public int ApplicationLoopCount { get { return Read<int>(Addr.ApplicationLoopCount); } }

		public LocalData LocalData { get { return Read<LocalData>(Addr.LocalData); } }

		public Ptr<SnoFiles> PtrSnoFiles { get { return ReadPointer<SnoFiles>(Addr.PtrSnoFiles); } }

		public FixedArray<int> SnoIdToEntityId { get { return Read<FixedArray<int>>(Addr.SnoIdToEntityId); } }

		public SnoGroupSearch SnoGroupSearch { get { return ReadPointer<SnoGroupSearch>(Addr.SnoGroupSearch).Dereference(); } }

		public Ptr<SnoFilesAsync> SnoFilesAsync { get { return ReadPointer<SnoFilesAsync>(Addr.SnoFilesAsync); } }

		public MessageDescriptor MessageDescriptor { get { return ReadPointer<MessageDescriptor>(Addr.MessageDescriptor).Dereference(); } }

		public ContainerManager ContainerManager { get { return ReadPointer<ContainerManager>(Addr.ContainerManager).Dereference(); } }

		[ArraySize(Const.CountUIHandlers)]
		public UIHandler[] UIHandlers { get { return Read<UIHandler>(Addr.UIHandlers, Const.CountUIHandlers); } }

		public SnoGroupInitializer[] SnoGroupInitializers { get { return Read<SnoGroupInitializer>(Addr.SnoGroupInitializers, 60); } }

		public void Dispose()
		{
			base.Memory.Dispose();
		}
	}
}
