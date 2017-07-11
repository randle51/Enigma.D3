using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel
{
    public static class MemoryObjectExtensions
    {
        public static T PlatformRead<T>(this MemoryObject memoryObject, int x86, int x64)
        {
            var offset = SymbolTable.Current.Platform == Platform.X86 ? x86 : x64;
            return memoryObject.Read<T>(offset);
        }

        public static StringPointer PlatformReadStringPointer(this MemoryObject memoryObject, int x86, int x64, int maxLength)
        {
            var offset = SymbolTable.Current.Platform == Platform.X86 ? x86 : x64;
            return memoryObject.ReadStringPointer(offset, maxLength);
        }
    }
}
