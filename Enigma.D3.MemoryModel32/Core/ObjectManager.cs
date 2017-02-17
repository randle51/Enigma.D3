using Enigma.D3.MemoryModel.Core;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.D3.MemoryModel.Collections;

namespace Enigma.D3.MemoryModel32.Core
{
	public class ObjectManager : MemoryObject, IObjectManager
	{
		public IACDManager ACDManager
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public IContainer<IActor> Actors
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public IFastAttrib FastAttrib
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int GameBountyBonus
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int GameHandicap
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public string GameServerAddress
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int GameStartingAct
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int GameState
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int GameTick
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public IPlayer Player
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public IPlayerDataManager PlayerDataManager
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public IQuestManager QuestManager
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int RenderTick
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public IContainer<IScene> Scenes
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public IReadOnlyCollection<ITimedEvent> TimedEvents
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public IUIManager UIManager
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public IWaypointManager WaypointManager
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public IContainer<IWorld> Worlds
		{
			get
			{
				throw new NotImplementedException();
			}
		}
	}
}
