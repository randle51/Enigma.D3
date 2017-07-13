using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.TypeSystem
{
    public class AttributeDescriptor : MemoryObject
    {
        public static int SizeOf => SymbolTable.Current.AttributeDescriptor.SizeOf;

        public int ID
            => Read<int>(SymbolTable.Current.AttributeDescriptor.ID);

        public int DefaultValue
            => Read<int>(SymbolTable.Current.AttributeDescriptor.DefaultValue);

        public Type DataType
            => Read<int>(SymbolTable.Current.AttributeDescriptor.DataType) == 0 ? typeof(float) : typeof(int);

        public string Name
            => ReadStringPointer(SymbolTable.Current.AttributeDescriptor.Name, SymbolTable.Current.AttributeDescriptor.NameLength).Dereference();
    }
}
