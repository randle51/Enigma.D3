using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Core
{
	public class World : MemoryObject
	{
		public static int SizeOf => SymbolTable.Current.World.SizeOf;
	}
}
