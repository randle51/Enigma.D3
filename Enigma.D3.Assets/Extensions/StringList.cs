using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.Assets
{
	public partial class StringList
	{
		public Dictionary<string, string> ToDictionary()
		{
			return this.x10_StringTableEntries.ToDictionary(
				a => a.x00_Text,
				a => a.x10_Text);
		}
	}
}
