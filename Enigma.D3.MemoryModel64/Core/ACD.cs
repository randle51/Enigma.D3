using Enigma.D3.MemoryModel.Core;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel64.Core
{
	public class ACD : MemoryObject, IACD
	{
		public const int SizeOf = Constants.ACD.SizeOf;

		public int ID
			=> Read<int>(Constants.ACD.ID);

		public string Name
			=> ReadString(Constants.ACD.Name, Constants.ACD.NameLength);
	}
}
