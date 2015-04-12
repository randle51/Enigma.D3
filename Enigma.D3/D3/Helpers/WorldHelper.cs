using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Helpers
{
	public static class WorldHelper
	{
		public static World GetLocalWorld()
		{
			var worldSnoId = Engine.Current.LocalData.x0C_WorldSnoId;
			foreach (var world in World.Container)
			{
				if (world.x04_SnoId == worldSnoId)
					return world;
			}
			return null;
		}
	}
}
