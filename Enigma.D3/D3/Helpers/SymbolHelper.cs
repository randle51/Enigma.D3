using Enigma.Memory;
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
			var symbol = Engine.Current.Memory.Reader.Read<Symbol>(address);
			while (symbol != null)
			{
				if (symbol.x04_Name == null)
					break;

				symbols.Add(symbol);

				address += Symbol.SizeOf;
				symbol = Engine.Current.Memory.Reader.Read<Symbol>(address);
			}
			return symbols;
		}
	}
}
