using Enigma.D3.MemoryModel.Collections;
using Enigma.D3.MemoryModel.TypeSystem;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Assets
{
    public class SNOGroupStorage<T> : MemoryObject
    {
        public static int SizeOf => SymbolTable.Current.SNOGroupStorage.SizeOf;

        public Container<SNODefinition<T>> Container
            => ReadPointer<Container<SNODefinition<T>>>(SymbolTable.Current.SNOGroupStorage.Container).Dereference();

        public string Name
            => ReadString(SymbolTable.Current.SNOGroupStorage.Name, SymbolTable.Current.SNOGroupStorage.NameLength);

        public Ptr<ValueTypeDescriptor> PtrDataType
            => this.PlatformRead<Ptr<ValueTypeDescriptor>>(0x6C, 0); // TODO: 64-bit
    }
}
