using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Core
{
	public class PlayerData : MemoryObject
	{
		public static int SizeOf => SymbolTable.Current.PlayerData.SizeOf;

		public int Index => Read<int>(SymbolTable.Current.PlayerData.Index);
		public int ACDID => Read<int>(SymbolTable.Current.PlayerData.ACDID);
		public int ActorID => Read<int>(SymbolTable.Current.PlayerData.ActorID);
	}
}
