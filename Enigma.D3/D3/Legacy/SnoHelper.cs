using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class SnoHelper
	{
		private Engine _engine;

		public SnoHelper(Engine engine)
		{
			if (engine == null)
				throw new ArgumentNullException();
			_engine = engine;
		}

		public SnoGroup<SnoActor> GetActorGroup()
		{
			// NOTE: Search for "Actor Def" to find offset on new patch.
			int snoGroupPtrPtr = _engine.Memory.Read<int>(0x016E19FC); // 1.0.8.16603
			int snoGroupPtr = _engine.Memory.Read<int>(snoGroupPtrPtr); // should be 0x1922140

			return new SnoGroup<SnoActor>(_engine.Memory, snoGroupPtr);
		}
	}
}
