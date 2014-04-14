using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class WorldHelper
	{
		public static World GetCurrentWorld()
		{
			return Engine.Current.ObjectManager.x97C_Worlds[(short)ActorHelper.GetLocalActor().x0D8_WorldId];
		}
	}
}
