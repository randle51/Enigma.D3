using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Helpers
{
	public static class ActorHelper
	{
		public static Actor GetLocalActor()
		{
			var localData = Engine.Current.LocalData;
			localData.TakeSnapshot();
			if (localData.x00_IsLocalActorCreated != 0)
			{
				var objMgr = Engine.Current.ObjectManager;
				var localPlayerData = objMgr.x798_Storage.x0E4_PlayerDataCollection.x0058_Items[localData.x34_LocalPlayerDataIndex - 1];
				var localActor = objMgr.x910_RActors[(short)localPlayerData.x0008_ActorId];
				return localActor;
			}
			return null;
		}
	}
}
