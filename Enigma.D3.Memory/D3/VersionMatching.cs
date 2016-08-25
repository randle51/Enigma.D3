using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.Memory
{
	public class VersionMatching
	{
		public static readonly VersionMatching Disabled = new VersionMatching((engine, memory) => true);
		public static readonly VersionMatching ExactMatch = new VersionMatching((engine, memory) => engine == memory);
		public static readonly VersionMatching MajorMinorBuild = new VersionMatching((engine, memory) =>
			engine.Major == memory.Major &&
			engine.Minor == memory.Minor &&
			engine.Build == engine.Build);
		public static readonly VersionMatching Default = ExactMatch;

		private readonly Func<Version, Version, bool> _matcher;

		public VersionMatching(Func<Version, Version, bool> matcher)
		{
			if (matcher == null)
				throw new ArgumentNullException(nameof(matcher));
			_matcher = matcher;
		}

		public bool Check(Version engine, Version memory) => _matcher?.Invoke(engine, memory) ?? true;
	}
}
