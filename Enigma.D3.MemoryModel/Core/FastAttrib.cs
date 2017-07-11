using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.D3.MemoryModel.Collections;
using Enigma.D3.MemoryModel.MemoryManagement;
using Enigma.D3.AttributeModel;

namespace Enigma.D3.MemoryModel.Core
{
    public class FastAttrib : MemoryObject
    {
        public static int SizeOf => SymbolTable.Current.FastAttrib.SizeOf;

        public Allocator<Map<AttributeKey, AttributeValue>.Entry> BucketAllocator => Read<Allocator<Map<AttributeKey, AttributeValue>.Entry>>(0x00);
        public Allocator<Map<AttributeKey, AttributeValue>.Entry> BucketAllocator2 => Read<Allocator<Map<AttributeKey, AttributeValue>.Entry>>(TypeHelper<Allocator<Map<int, AttributeValue>.Entry>>.SizeOf * 1);
        public Allocator<Map<AttributeKey, AttributeValue>.Entry> BucketAllocator3 => Read<Allocator<Map<AttributeKey, AttributeValue>.Entry>>(TypeHelper<Allocator<Map<int, AttributeValue>.Entry>>.SizeOf * 2);

        public ExpandableContainer<FastAttribGroup> FastAttribGroups
            => Read<Ptr<ExpandableContainer<FastAttribGroup>>>(SymbolTable.Current.FastAttrib.FastAttribGroups).Dereference();
    }
}
