using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Enigma.D3.MemoryModel.Core
{
    public class WaypointManager : MemoryObject, IEnumerable<Waypoint>
    {
        public Waypoint this[int index]
            => Read<Ptr<Waypoint>>(SymbolTable.Current.WaypointManager.Array)[index];

        public int Count
            => Read<int>(SymbolTable.Current.WaypointManager.Count);

        public IEnumerator<Waypoint> GetEnumerator()
            => Read<Ptr<Waypoint>>(SymbolTable.Current.WaypointManager.Array).ToArray(Count).Cast<Waypoint>().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
