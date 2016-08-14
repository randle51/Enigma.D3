using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.D3.Preferences;
using Enigma.D3.UI;
using Enigma.D3.Assets;
using Enigma.D3.Memory.TypeSystem;
using Enigma.D3.Memory.Input;

namespace Enigma.D3
{
	public class Engine : MemoryObject, IDisposable
	{
		[Obsolete("Values are only valid if they come from the generated ObjectPtr class.")]
		private static class Addr
		{
			public const int SnoGroupInitializers = 0x01C36944 - 4;
			public const int SnoGroupByCode = ObjectPtr.SNOGroupsByCode;
			public const int SnoGroups = ObjectPtr.SNOGroups;
			public const int SnoGroupSearch = 0x01E2021C; // Not updated.
			public const int SnoFilesAsync = 0x01F12644;
			public const int ObjectManager = ObjectPtr.ObjectManager;
			public const int ObjectManagerPristine = ObjectPtr.ObjectManagerPristine;
			public const int MessageDescriptor = ObjectPtr.MessageDescriptor;
			public const int MapActId = ObjectPtr.MapActId;
			public const int LocalData = ObjectPtr.LocalData;
			public const int LevelArea = ObjectPtr.LevelArea;
			public const int LevelAreaName = ObjectPtr.LevelAreaName;
			public const int ContainerManager = ObjectPtr.ContainerManager;
			public const int BuffManager = 0x01DB4990; // Not updated.
			public const int ApplicationLoopCount = ObjectPtr.ApplicationLoopCount;
			public const int AttributeDescriptors = ObjectPtr.AttributeDescriptors;
			public const int VideoPreferences = ObjectPtr.VideoPreferences;
			public const int SoundPreferences = ObjectPtr.SoundPreferences;
			public const int HotkeyPreferences = ObjectPtr.HotkeyPreferences;
			public const int GameplayPreferences = ObjectPtr.GameplayPreferences;
			public const int ChatPreferences = ObjectPtr.ChatPreferences;
			public const int SocialPreferences = ObjectPtr.SocialPreferences;
			public const int UIHandlers = 0x01B684D0; // Not updated.
			public const int UIReferences = 0x01BBB8F8; // Not updated. 0x01C70368 or 0x01CEF2A8
			public const int SnoIdToEntityId = 0x00000000; // Not updated.
			public const int TrickleManager = 0x01D8BF88; // Not updated.
			public const int PtrSnoFiles = 0x01DD1610; // Not updated.
		}

		[Obsolete("Values should come from the generated Globals class instead.")]
		private static class Const
		{
			public const int CountUIReferences = 2767; // Not updated.
			public const int SizeOfUIHandler = 12; // Not updated.
			public const int CountUIHandlers = 0x3AEC / SizeOfUIHandler; // Not updated.
		}


		private static Engine _lastCreated;

		[ThreadStatic]
		private static Engine _current;

		public static readonly Version SupportedVersion = Globals.SupportedVersion;

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

		[ArraySize(70)]
		public Hotkey[] Hotkeys { get { return Read<Hotkey>(Addr.HotkeyPreferences, 70); } }

		[ArraySize(Globals.AttributeDescriptorsCount)]
		public AttributeDescriptor[] AttributeDescriptors { get { return Read<AttributeDescriptor>(Addr.AttributeDescriptors, Globals.AttributeDescriptorsCount); } }

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

		[ArraySize(Globals.SNOGroupsCount)] // In reality it's +1 count with last item set to null.
		public SnoGroupManager[] SNOGroups { get { return ReadPointer<Ptr<SnoGroupManager>>(Addr.SnoGroups).ToArray(Globals.SNOGroupsCount).Select(ptr => ptr.Dereference()).ToArray(); } }

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
