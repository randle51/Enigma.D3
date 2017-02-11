using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Core
{
	public interface IPlayerData
	{
		int Index { get; }
		int ACDID { get; }
		int ActorID { get; }
	}
}
