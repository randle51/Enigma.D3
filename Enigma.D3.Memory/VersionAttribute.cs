using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
	[AttributeUsage(AttributeTargets.Class)]
	public class VersionAttribute : Attribute
	{
		public VersionAttribute(string value)
		{
			Value = Version.Parse(value);
		}

		public VersionAttribute(Version value)
		{
			Value = value;
		}

		public Version Value { get; set; }
	}
}
