using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Core
{
	public class ACD : MemoryObject
	{
		public static int SizeOf => SymbolTable.Current.ACD.SizeOf;

		public int ID
			=> Read<int>(SymbolTable.Current.ACD.ID);

		public string Name
			=> ReadString(SymbolTable.Current.ACD.Name, SymbolTable.Current.ACD.NameLength);
	}
}
