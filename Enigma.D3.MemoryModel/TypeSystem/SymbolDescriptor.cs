using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.TypeSystem
{
    // TODO: 64-bit
    public class SymbolDescriptor : MemoryObject
    {
        public const int SizeOf = 8;

        public int x00_Id => Read<int>(0x00);
        public StringPointer x04_PtrName => ReadStringPointer(0x04, 256); // Max size unknown.

        public string GetName() => x04_PtrName.Dereference();

        public override string ToString()
            => x00_Id + " = " + GetName();

        public static IEnumerable<SymbolDescriptor> GetAllSymbols(MemoryAddress address)
        {
            var symbol = MemoryContext.Current.Memory.Reader.Read<SymbolDescriptor>(address);
            while (symbol != null)
            {
                if (symbol.GetName() == null)
                    break;

                yield return symbol;
                address += SizeOf;
                symbol = MemoryContext.Current.Memory.Reader.Read<SymbolDescriptor>(address);
            }
        }
    }
}
