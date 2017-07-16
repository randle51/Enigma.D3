using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel
{
    public partial class SymbolTable
    {
        public static SymbolTable Current;

        public static int PlatformSize(int x86, int x64, bool align = false)
        {
            var size = Current.Platform == Platform.X86 ? x86 : x64;
            if (align)
                size = MemoryObject.AlignedSize(size, Current.Platform == Platform.X86 ? 4 : 8);
            return size;
        }

        public SymbolTable() { }

        public SymbolTable(MemoryContext ctx)
            : this(ctx.Memory.Reader.PointerSize == 8 ? Platform.X64 : Platform.X86) { }

        public SymbolTable(Platform platform)
        {
            Platform = platform;
            if (Platform == Platform.X86)
                InitX86();
            else if (Platform == Platform.X64)
                InitX64();
            else throw new NotImplementedException();
        }
        
        public Version Version;
        public Platform Platform;

        public DataSegmentSymbols DataSegment;
        public ObjectManagerSymbols ObjectManager;
        public GameGlobalsSymbols GameGlobals;
        public StorageSymbols Storage;
        public ActorSymbols Actor;
        public ACDManagerSymbols ACDManager;
        public ACDSymbols ACD;
        public LocalDataSymbols LocalData;
        public FastAttribSymbols FastAttrib;
        public FastAttribGroupSymbols FastAttribGroup;
        public PlayerDataManagerSymbols PlayerDataManager;
        public PlayerDataSymbols PlayerData;
        public PlayerSavedDataSymbols PlayerSavedData;
        public ActiveSkillSavedDataSymbols ActiveSkillSavedData;
        public SceneSymbols Scene;
        public WorldSymbols World;
        public QuestManagerSymbols QuestManager;
        public QuestSymbols Quest;
        public WaypointManagerSymbols WaypointManager;
        public WaypointSymbols Waypoint;
        public TrickleManagerSymbols TrickleManager;
        public TrickleSymbols Trickle;
        public UIManagerSymbols UIManager;
        public LevelAreaSymbols LevelArea;
        public PlayerSymbols Player;
        public AttributeDescriptorSymbols AttributeDescriptor;
        public FloatingNumberSymbols FloatingNumber;
        public TimedEventSymbols TimedEvent;
        public MemoryManagerSymbols MemoryManager;
        public LocalHeapSymbols LocalHeap;
        public HeapNodeSymbols HeapNode;
        public TexAnimSymbols TexAnim;
        public RWindowMgrSymbols RWindowMgr;
        public SubObjectGfxSymbols SubObjectGfx;
        public SNOFilesSymbols SNOFiles;
        public SNOGroupStorage SNOGroupStorage;
    }

    public struct DataSegmentSymbols
    {
        public ulong Address;
        public ulong VideoPreferences;
        public ulong SoundPreferences;
        public ulong HotkeyPreferences;
        public ulong GameplayPreferences;
        public ulong SocialPreferences;
        public ulong ChatPreferences;
        public ulong LevelArea;
        public ulong LevelAreaName;
        public int LevelAreaNameLength;
        public ulong MapActID;
        public ulong ScreenManagerRoot;
        public ulong TrickleManager;
        public ulong LocalData;
        public ulong ObjectManager;
        public ulong ApplicationLoopCount;
        public ulong AttributeDescriptors;
        public int AttributeDescriptorsCount;
        public ulong MemoryManager;
        public ulong SNOFiles;
        public ulong SNOGroups;
        public ulong SNOGroupsByCode;
        public ulong ContainerManager;
        public ulong MessageDescriptor;
    }

    public struct ObjectManagerSymbols
    {
        public int SizeOf;
        public int RenderTick;
        public int GameGlobals;
        public int GameState;
        public int Storage;
        public int Actors;
        public int Scenes;
        public int SubObjectGfx;
        public int RWindowMgr;
        public int UIManager;
        public int Worlds;
        public int Player;
        public int TexAnim;
        public int TimedEvents;
    }

    public struct GameGlobalsSymbols
    {
        public int SizeOf;
        public int GameServerAddress;
        public int GameServerAddressLength;
    }

    public struct StorageSymbols
    {
        public int GameDifficulty;
        public int GameTick;
        public int PlayerDataManager;
        public int FastAttrib;
        public int ACDManager;
        public int QuestManager;
        public int WaypointManager;
    }

    public struct ActorSymbols
    {
        public int SizeOf;
        public int ID;
        public int Name;
        public int NameLength;
        public int SSceneID;
    }

    public struct ACDManagerSymbols
    {
        public int SizeOf;
        public int ActorCommonData;
    }

    public struct ACDSymbols
    {
        public int SizeOf;
        public int ID;
        public int Name;
        public int NameLength;
        public int ActorID;
        public int ActorSNO;
        public int MonsterQuality;
        public int Position;
        public int Radius;
        public int SWorldID;
        public int SSceneID;
        public int ItemLocation;
        public int ItemSlotX;
        public int ItemSlotY;
        public int FastAttribGroupID;
        public int ActorType;
        public int GizmoType;
        public int Hitpoints;
        public int TeamID;
        public int ObjectFlags;
        public int Animation;
        public int CollisionFlags;
    }

    public struct LocalDataSymbols
    {
        public int SizeOf;
        public int IsPlayerValid;
        public int IsStartUpGame;
        public int SceneSNO;
        public int WorldSNO;
        public int ActorSNO;
        public int ActID;
        public int WorldSeed;
        public int QuestSNO;
        public int QuestStepUID;
        public int WorldPos;
        public int PlayerCount;
        public int LocalPlayerCount;
    }

    public struct FastAttribSymbols
    {
        public int SizeOf;
        public int FastAttribGroups;
    }

    public struct FastAttribGroupSymbols
    {
        public int SizeOf;
        public int ID;
        public int Flags;
        public int PtrMap;
        public int Map;
    }

    public struct PlayerDataManagerSymbols
    {
        public int SizeOf;
        public int Items;
    }

    public struct PlayerDataSymbols
    {
        public int SizeOf;
        public int Index;
        public int ACDID;
        public int ActorID;
        public int PlayerSavedData;
        public int HeroID;
        public int HeroName;
        public int ActorSNO;
        public int LifePercentage;
        public int HeroClass;
        public int Level;
        public int AltLevel;
    }

    public struct PlayerSavedDataSymbols
    {
        public int SizeOf;
        public int ActiveSkillSavedData;
        public int PassiveSkills;
    }

    public struct ActiveSkillSavedDataSymbols
    {
        public int SizeOf;
        public int PowerSNO;
        public int Modifier;
    }

    public struct SceneSymbols
    {
        public int SizeOf;
    }

    public struct WorldSymbols
    {
        public int SizeOf;
    }

    public struct QuestManagerSymbols
    {
        public int SizeOf;
        public int Quests;
    }

    public struct QuestSymbols
    {
        public int SizeOf;
    }

    public struct WaypointManagerSymbols
    {
        public int SizeOf;
        public int Array;
        public int Count;
    }

    public struct WaypointSymbols
    {
        public int SizeOf;
        public int ActID;
        public int LevelAreaSNO;
        public int X;
        public int Y;
    }

    public struct TrickleManagerSymbols
    {
        public int SizeOf;
        public int Allocator;
        public int Items;
    }

    public struct TrickleSymbols
    {
        public int SizeOf;
    }

    public struct UIManagerSymbols
    {
        public int SizeOf;
    }

    public struct LevelAreaSymbols
    {
        public int SizeOf;
    }

    public struct PlayerSymbols
    {
        public int SizeOf;
        public int LocalPlayerIndex;
        public int FloatingNumbers;
        public int LatencySamples;
    }

    public struct AttributeDescriptorSymbols
    {
        public int SizeOf;
        public int ID;
        public int DefaultValue;
        public int DataType;
        public int Name;
        public int NameLength;
    }

    public struct FloatingNumberSymbols
    {
        public int SizeOf;
        public int Type;
        public int WorldPos;
        public int SWorldID;
        public int Value;
    }

    public struct TimedEventSymbols
    {
        public int SizeOf;
    }

    public struct MemoryManagerSymbols
    {
        public int SizeOf;
        public int LocalHeap;
    }

    public struct LocalHeapSymbols
    {
        public int FirstNode;
        public int TotalSize;
        public int NodeCount;
        public int LastNode;
    }

    public struct HeapNodeSymbols
    {
        public int HeaderSize;
        public int SizeAndFlag;
    }

    public struct TexAnimSymbols
    {
        public int SizeOf;
    }

    public struct RWindowMgrSymbols
    {
        public int SizeOf;
    }

    public struct SubObjectGfxSymbols
    {
        public int SizeOf;
    }

    public struct SNOFilesSymbols
    {
        public int SizeOf;
        public int SNODiskEntries;
    }

    public struct SNOGroupStorage
    {
        public int SizeOf;
        public int Container;
        public int Name;
        public int NameLength;
    }
}
