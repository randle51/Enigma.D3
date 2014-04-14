using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Helpers
{
	public static class SymbolHelper
	{
		public static List<Symbol> GetAllSymbols(int address)
		{
			List<Symbol> symbols = new List<Symbol>();
			var symbol = Engine.Current.Memory.Read<Symbol>(address);
			while (symbol != null)
			{
				if (symbol.x00_Id == 0 && Engine.Current.Memory.Read<int>(symbol.Address + 4) == 0)
					break;

				symbols.Add(symbol);

				address += Symbol.SizeOf;
				symbol = Engine.Current.Memory.Read<Symbol>(address);
			}
			return symbols;
		}
	}
}
