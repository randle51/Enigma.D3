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
		public int RenderTick
			=> Read<int>(SymbolTable.Current.ObjectManager.RenderTick);

		public int GameState
			=> Read<int>(SymbolTable.Current.ObjectManager.GameState);

		public string GameServerAddress
			=> ReadString(SymbolTable.Current.ObjectManager.GameServerAddress, SymbolTable.Current.ObjectManager.GameServerAddressLength);

		public int GameHandicap
			=> Read<int>(SymbolTable.Current.ObjectManager.GameHandicap);

		public int GameStartingAct
			=> Read<int>(SymbolTable.Current.ObjectManager.GameStartingAct);

		public int GameBountyBonus
			=> Read<int>(SymbolTable.Current.ObjectManager.GameBountyBonus);

		public int GameTick
			=> Read<int>(SymbolTable.Current.ObjectManager.GameTick);

		public PlayerDataManager PlayerDataManager
			=> Read<Ptr<PlayerDataManager>>(SymbolTable.Current.ObjectManager.PlayerDataManager).Dereference();

		public FastAttrib FastAttrib
			=> Read<Ptr<FastAttrib>>(SymbolTable.Current.ObjectManager.FastAttrib).Dereference();

		public ACDManager ACDManager
			=> Read<Ptr<ACDManager>>(SymbolTable.Current.ObjectManager.ACDManager).Dereference();

		public QuestManager QuestManager
			=> Read<Ptr<QuestManager>>(SymbolTable.Current.ObjectManager.QuestManager).Dereference();

		public WaypointManager WaypointManager
			=> Read<Ptr<WaypointManager>>(SymbolTable.Current.ObjectManager.WaypointManager).Dereference();

		public ExpandableContainer<Actor> Actors
			=> Read<Ptr<ExpandableContainer<Actor>>>(SymbolTable.Current.ObjectManager.Actors).Dereference();

		public IContainer<Scene> Scenes
			=> Read<Ptr<Container<Scene>>>(SymbolTable.Current.ObjectManager.Scenes).Dereference();

		public UIManager UIManager
			=> Read<Ptr<UIManager>>(SymbolTable.Current.ObjectManager.UIManager).Dereference();

		public IContainer<World> Worlds
			=> Read<Ptr<Container<World>>>(SymbolTable.Current.ObjectManager.Worlds).Dereference();

		public Player Player
			=> Read<Ptr<Player>>(SymbolTable.Current.ObjectManager.Player).Dereference();

		public IReadOnlyCollection<TimedEvent> TimedEvents
			=> Read<Ptr<LinkedListWithAllocator<TimedEvent>>>(SymbolTable.Current.ObjectManager.TimedEvents).Dereference();
	}
}
