using Enigma.D3.Enums;
using Enigma.D3.MemoryModel.Collections;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Core
{
    public class ObjectManager : MemoryObject
    {
        public static int SizeOf => SymbolTable.Current.ObjectManager.SizeOf;

        public int RenderTick
            => Read<int>(SymbolTable.Current.ObjectManager.RenderTick);

        public int GameState
            => Read<int>(SymbolTable.Current.ObjectManager.GameState);

        public string GameServerAddress
            => ReadString(SymbolTable.Current.ObjectManager.GameGlobals + SymbolTable.Current.GameGlobals.GameServerAddress, SymbolTable.Current.GameGlobals.GameServerAddressLength);

        public GameDifficulty GameDifficulty
            => Read<GameDifficulty>(SymbolTable.Current.ObjectManager.Storage + SymbolTable.Current.Storage.GameDifficulty);

        public int GameTick
            => Read<int>(SymbolTable.Current.ObjectManager.Storage + SymbolTable.Current.Storage.GameTick);

        public PlayerDataManager PlayerDataManager
            => Read<Ptr<PlayerDataManager>>(SymbolTable.Current.ObjectManager.Storage + SymbolTable.Current.Storage.PlayerDataManager).Dereference();

        public FastAttrib FastAttrib
            => Read<Ptr<FastAttrib>>(SymbolTable.Current.ObjectManager.Storage + SymbolTable.Current.Storage.FastAttrib).Dereference();

        public ACDManager ACDManager
            => Read<Ptr<ACDManager>>(SymbolTable.Current.ObjectManager.Storage + SymbolTable.Current.Storage.ACDManager).Dereference();

        public QuestManager QuestManager
            => Read<Ptr<QuestManager>>(SymbolTable.Current.ObjectManager.Storage + SymbolTable.Current.Storage.QuestManager).Dereference();

        public WaypointManager WaypointManager
            => Read<Ptr<WaypointManager>>(SymbolTable.Current.ObjectManager.Storage + SymbolTable.Current.Storage.WaypointManager).Dereference();

        public ExpandableContainer<Actor> Actors
            => Read<Ptr<ExpandableContainer<Actor>>>(SymbolTable.Current.ObjectManager.Actors).Dereference();

        public Container<Scene> Scenes
            => Read<Ptr<Container<Scene>>>(SymbolTable.Current.ObjectManager.Scenes).Dereference();

        public UIManager UIManager
            => Read<Ptr<UIManager>>(SymbolTable.Current.ObjectManager.UIManager).Dereference();

        public Container<World> Worlds
            => Read<Ptr<Container<World>>>(SymbolTable.Current.ObjectManager.Worlds).Dereference();

        public Player Player
            => Read<Ptr<Player>>(SymbolTable.Current.ObjectManager.Player).Dereference();

        public IReadOnlyCollection<TimedEvent> TimedEvents
            => Read<Ptr<LinkedListWithAllocatorB<TimedEvent>>>(SymbolTable.Current.ObjectManager.TimedEvents).Dereference();
    }
}
