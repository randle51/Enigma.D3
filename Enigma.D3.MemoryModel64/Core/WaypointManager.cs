using Enigma.D3.MemoryModel.Core;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Enigma.D3.MemoryModel64.Core
{
	public class WaypointManager : MemoryObject, IWaypointManager
	{
		public IWaypoint this[int index]
			=> Read<Ptr<Waypoint>>(Constants.WaypointManager.Array)[index];

		public int Count
			=> Read<int>(Constants.WaypointManager.Count);

		public IEnumerator<IWaypoint> GetEnumerator()
			=> Read<Ptr<Waypoint>>(Constants.WaypointManager.Array).ToArray(Count).Cast<IWaypoint>().GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
}
