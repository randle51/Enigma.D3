using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class ActorHelper
	{
		public static Actor GetLocalActor()
		{
			Engine engine = Engine.Current;
			var objMgr = engine.ObjectManager;
			if (objMgr != null)
			{
				var playerIndex = objMgr.x984.x00000_PlayerIndex;
				if (playerIndex != -1 && playerIndex <= 8)
				{
					var player = objMgr.x7B0_Storage.x0C4_PlayerContainer.Players[playerIndex];
					var actorId = player.x0008_ActorId;
					if (actorId != -1)
					{
						return objMgr.x900_Actors[(short)actorId];
					}
				}
			}
			return null;
		}
	}
}
