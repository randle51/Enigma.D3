using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class SceneHelper
	{
		public static Scene GetCurrentScene()
		{
			var playerActor = ActorHelper.GetLocalActor();
			if (playerActor == null)
				return null;

			return Engine.Current.ObjectManager.x944_Scenes.FirstOrDefault(a => a.x004_NavMeshId == playerActor.x0DC_SceneId);
		}
	}
}
