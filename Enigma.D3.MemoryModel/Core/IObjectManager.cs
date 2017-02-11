using Enigma.D3.MemoryModel.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Core
{
	public interface IObjectManager
	{
		int RenderTick { get; }
		int GameState { get; }
		string GameServerAddress { get; }
		int GameHandicap { get; }
		int GameStartingAct { get; }
		int GameBountyBonus { get; }
		int GameTick { get; }
		IPlayerDataManager PlayerDataManager { get; }
		IFastAttrib FastAttrib { get; }
		IACDManager ACDManager { get; }
		IQuestManager QuestManager { get; }
		IWaypointManager WaypointManager { get; }
		IContainer<IActor> Actors { get; }
		IContainer<IScene> Scenes { get; }
		IUIManager UIManager { get; }
		IContainer<IWorld> Worlds { get; }
		IPlayer Player { get; }
		IReadOnlyCollection<ITimedEvent> TimedEvents { get; }
	}
}
