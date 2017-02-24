using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.D3.MemoryModel.Collections;

namespace Enigma.D3.MemoryModel.Core
{
	public class FastAttrib : MemoryObject
	{
		public static int SizeOf => SymbolTable.Current.FastAttrib.SizeOf;

		public IContainer<FastAttribGroup> FastAttribGroups
			=> Read<Ptr<ExpandableContainer<FastAttribGroup>>>(SymbolTable.Current.FastAttrib.FastAttribGroups).Dereference();
	}
}
