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
	public class ACDManager : MemoryObject, IACDManager
	{
		public IContainer<IACD> ActorCommonData
			=> Read<Ptr<ExpandableContainer<ACD>>>(Constants.ACDManager.ActorCommonData).Dereference();
	}
}
