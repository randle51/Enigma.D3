using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Core
{
	public interface IWaypoint
	{
		int ActID { get; }
		int LevelAreaSNO { get; }
		int X { get; }
		int Y { get; }
	}
}
