using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;

namespace Enigma.D3.Helpers
{
	public static class ActorHelper
	{
		public static Actor GetLocalActor()
		{
			var localData = Engine.Current.LocalData;
			localData.TakeSnapshot();
			if (localData.x00_IsActorCreated != 0)
			{
				var objMgr = Engine.Current.ObjectManager;
				var localPlayerData = PlayerData.Local;
				var localActor = Actor.Container[(short)localPlayerData.x0008_ActorId];
				return localActor;
			}
			return null;
		}

		public static IEnumerable<Actor> Enumerate()
		{
			var actors = GetContainer();
			if (actors == null)
				return Enumerable.Empty<Actor>();
			return actors.Where(a => a.x000_Id != -1).AsEnumerable();
		}

		public static IEnumerable<Actor> Enumerate(Predicate<Actor> filter)
		{
			var actors = GetContainer();
			if (actors == null)
				return Enumerable.Empty<Actor>();
			return actors.Where(a => a.x000_Id != -1 && filter(a)).AsEnumerable();
		}

		private static ExpandableContainer<Actor> GetContainer()
		{
			return Engine.TryGet(a => a.ObjectManager.x958_Ptr_RActors.Dereference());
		}
	}
}
