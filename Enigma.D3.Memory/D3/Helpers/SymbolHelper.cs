using Enigma.D3.Memory.TypeSystem;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Helpers
{
	public static class SymbolHelper
	{
		public static List<SymbolDescriptor> GetAllSymbols(int address)
		{
			List<SymbolDescriptor> symbols = new List<SymbolDescriptor>();
			var symbol = Engine.Current.Memory.Reader.Read<SymbolDescriptor>(address);
			while (symbol != null)
			{
				if (symbol.x04_PtrName.Dereference() == null)
					break;

				symbols.Add(symbol);

				address += SymbolDescriptor.SizeOf;
				symbol = Engine.Current.Memory.Reader.Read<SymbolDescriptor>(address);
			}
			return symbols;
		}
	}
}
