using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Helpers
{
	public static class ActorCommonDataHelper
	{
		public static ActorCommonData GetLocalAcd()
		{
			var localData = Engine.Current.LocalData;
			localData.TakeSnapshot();
			if (localData.x00_IsLocalActorCreated != 0)
			{
				var objMgr = Engine.Current.ObjectManager;
				var localPlayerData = objMgr.x798_Storage.x0E4_PlayerDataCollection.x0058_Items[localData.x34_LocalPlayerDataIndex - 1];
				var localAcd = objMgr.x798_Storage.x110_ActorCommonDataManager.x00_ActorCommonData[(short)localPlayerData.x0004_AcdId];
				return localAcd;
			}
			return default(ActorCommonData);
		}

		public static ActorCommonData GetAcd(int acdId)
		{
			try
			{
				return Engine.Current.ObjectManager.x798_Storage.x110_ActorCommonDataManager.x00_ActorCommonData[(short)acdId];
			}
			catch
			{
				return default(ActorCommonData);
			}
		}
	}
}
