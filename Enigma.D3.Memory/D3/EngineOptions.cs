using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.Memory
{
	public class EngineOptions
	{
		public static EngineOptions Default => new EngineOptions();

		public EngineOptions() { }

		public VersionMatching VersionMatching = VersionMatching.ExactMatch;
	}
}
