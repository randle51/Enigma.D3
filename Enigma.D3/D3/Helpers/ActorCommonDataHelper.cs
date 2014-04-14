using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;

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

		public static ActorCommonData GetGoldAcd()
		{
			return Enumerate(a => a.x114_ItemLocation == Enums.ItemLocation.Gold).FirstOrDefault();
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

		public static IEnumerable<ActorCommonData> EnumerateItems()
		{
			return Enumerate(a => a.x0B0_GameBalanceType == Enums.GameBalanceType.Items);
		}

		public static IEnumerable<ActorCommonData> EnumerateInventoryItems()
		{
			return Enumerate(a => a.x114_ItemLocation == Enums.ItemLocation.PlayerBackpack);
		}

		public static IEnumerable<ActorCommonData> EnumerateStashItems()
		{
			return Enumerate(a => a.x114_ItemLocation == Enums.ItemLocation.Stash);
		}

		public static IEnumerable<ActorCommonData> EnumerateEquippedItems()
		{
			// Don't want to read ItemLocation twice just to compare it twice.
			Predicate<Enums.ItemLocation> isEquipped = (location) =>
				location >= Enums.ItemLocation.PlayerHead &&
				location <= Enums.ItemLocation.PlayerNeck;
			return Enumerate(a => isEquipped(a.x114_ItemLocation));
		}

		public static IEnumerable<ActorCommonData> EnumerateMonsters()
		{
			return Enumerate(a => a.x098_MonsterSnoId != -1);
		}

		public static IEnumerable<ActorCommonData> Enumerate(Predicate<ActorCommonData> filter)
		{
			var acds = GetContainer();
			if (acds == null)
				return Enumerable.Empty<ActorCommonData>();
			return acds.Where(a => a.x000_Id != -1 && filter(a)).AsEnumerable();
		}

		private static ExpandableContainer<ActorCommonData> GetContainer()
		{
			return Engine.TryGet(a => a.ObjectManager.x798_Storage.x110_ActorCommonDataManager.x00_ActorCommonData);
		}
	}
}
