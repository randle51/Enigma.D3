using Enigma.D3.MemoryModel.Core;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel64.Core
{
	public class Waypoint : MemoryObject, IWaypoint
	{
		public const int SizeOf = Constants.Waypoint.SizeOf;

		public int ActID => Read<int>(Constants.Waypoint.ActID);
		public int LevelAreaSNO => Read<int>(Constants.Waypoint.LevelAreaSNO);
		public int X => Read<int>(Constants.Waypoint.X);
		public int Y => Read<int>(Constants.Waypoint.Y);
	}
}
