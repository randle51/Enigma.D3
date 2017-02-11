using Enigma.D3.MemoryModel.Core;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.D3.MemoryModel.Collections;
using Enigma.D3.MemoryModel64.Collections;

namespace Enigma.D3.MemoryModel64.Core
{
	public class FastAttrib : MemoryObject, IFastAttrib
	{
		public const int SizeOf = Constants.FastAttrib.SizeOf;

		public IContainer<IFastAttribGroup> FastAttribGroups
			=> Read<Ptr<ExpandableContainer<FastAttribGroup>>>(Constants.FastAttrib.FastAttribGroups).Dereference();
	}
}
