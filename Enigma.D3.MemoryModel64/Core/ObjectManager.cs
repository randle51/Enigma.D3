using Enigma.D3.MemoryModel.Core;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.D3.MemoryModel.Collections;
using Enigma.D3.MemoryModel64.Collections;

namespace Enigma.D3.MemoryModel64.Core
{
	public class ObjectManager : MemoryObject, IObjectManager
	{
		public int RenderTick
			=> Read<int>(Constants.ObjectManager.RenderTick);

		public int GameState
			=> Read<int>(Constants.ObjectManager.GameState);

		public string GameServerAddress
			=> ReadString(Constants.ObjectManager.GameServerAddress, Constants.ObjectManager.GameServerAddressLength);

		public int GameHandicap
			=> Read<int>(Constants.ObjectManager.GameHandicap);

		public int GameStartingAct
			=> Read<int>(Constants.ObjectManager.GameStartingAct);

		public int GameBountyBonus
			=> Read<int>(Constants.ObjectManager.GameBountyBonus);

		public int GameTick
			=> Read<int>(Constants.ObjectManager.GameTick);

		public IPlayerDataManager PlayerDataManager
			=> Read<Ptr<PlayerDataManager>>(Constants.ObjectManager.PlayerDataManager).Dereference();

		public IFastAttrib FastAttrib
			=> Read<Ptr<FastAttrib>>(Constants.ObjectManager.FastAttrib).Dereference();

		public IACDManager ACDManager
			=> Read<Ptr<ACDManager>>(Constants.ObjectManager.ACDManager).Dereference();

		public IQuestManager QuestManager
			=> Read<Ptr<QuestManager>>(Constants.ObjectManager.QuestManager).Dereference();

		public IWaypointManager WaypointManager
			=> Read<Ptr<WaypointManager>>(Constants.ObjectManager.WaypointManager).Dereference();

		public IContainer<IActor> Actors
			=> Read<Ptr<ExpandableContainer<Actor>>>(Constants.ObjectManager.Actors).Dereference();

		public IContainer<IScene> Scenes
			=> Read<Ptr<Container<Scene>>>(Constants.ObjectManager.Scenes).Dereference();

		public IUIManager UIManager
			=> Read<Ptr<UIManager>>(Constants.ObjectManager.UIManager).Dereference();

		public IContainer<IWorld> Worlds
			=> Read<Ptr<Container<World>>>(Constants.ObjectManager.Worlds).Dereference();

		public IPlayer Player
			=> Read<Ptr<Player>>(Constants.ObjectManager.Player).Dereference();

		public IReadOnlyCollection<ITimedEvent> TimedEvents
			=> Read<Ptr<LinkedListWithAllocator<TimedEvent>>>(Constants.ObjectManager.TimedEvents).Dereference();
	}
}
