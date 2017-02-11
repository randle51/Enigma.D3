using Enigma.D3.MemoryModel.Core;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel64.Core
{
	public class FastAttribGroup : MemoryObject, IFastAttribGroup
	{
		public const int SizeOf = Constants.FastAttribGroup.SizeOf;

		public int ID => Read<int>(Constants.FastAttribGroup.ID);
	}
}
