using Enigma.D3.MemoryModel.MemoryManagement;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel32.MemoryManagement
{
	public class MemoryManager : MemoryObject, IMemoryManager
	{
		public const int SizeOf = Constants.MemoryManager.SizeOf;

		public ILocalHeap LocalHeap
			=> Read<Ptr<LocalHeap>>(Constants.MemoryManager.LocalHeap).Dereference();
	}
}
