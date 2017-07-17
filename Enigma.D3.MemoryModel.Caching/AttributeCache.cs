using Enigma.D3.AttributeModel;
using Enigma.D3.MemoryModel.Collections;
using Enigma.D3.MemoryModel.Core;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.D3.Enums;
using Enigma.D3.MemoryModel.TypeSystem;

namespace Enigma.D3.MemoryModel.Caching
{
    public class AttributeCache : IAttributeReader
    {
        [ThreadStatic]
        public static AttributeCache Current;

        private readonly MemoryContext _ctx;
        private readonly FastAttrib _attrib;
        private readonly AllocationCache<Map<AttributeKey, AttributeValue>.Entry> _allocationCache;
        private readonly ContainerCache<FastAttribGroup> _groupCache;
        private AttributeDescriptor[] _descriptors;

        public AttributeCache(MemoryContext ctx, FastAttrib attrib)
        {
            _ctx = ctx ?? throw new ArgumentNullException(nameof(ctx));
            _attrib = attrib ?? throw new ArgumentNullException(nameof(attrib));
            _allocationCache = new AllocationCache<Map<AttributeKey, AttributeValue>.Entry>(attrib.BucketAllocator);
            _groupCache = new ContainerCache<FastAttribGroup>(attrib.FastAttribGroups);
        }

        public void Update()
        {
            if (_descriptors == null)
            {
                _descriptors = _ctx.DataSegment.AttributeDescriptors.ToArray();
                foreach (var item in _descriptors)
                    item.TakeSnapshot();
            }
            _allocationCache.Update();
            _groupCache.Update();
        }

        public bool TryGetAttributeValue(int groupId, AttributeId attribId, int modifier, out AttributeValue value)
        {
            var group = _groupCache.Items[(short)groupId];

            var key = (AttributeKey)((modifier << 12) + ((int)attribId & 0xFFF));
            var map = (group.Flags & 4) != 0 ? group.PtrMap.Dereference() : null;
            if (map == null)
                map = group.Map;

            map.TakeSnapshot();
            if (map.Count == 0)
            {
                value = default(AttributeValue);
                return false;
            }

            var hash = key.GetHashCode();
            var index = map.Mask & hash;
            var address = map.Buckets[index].ValueAddress;
            if (address == 0)
            {
                value = default(AttributeValue);
                return false;
            }

            while (true)
            {
                if (address == 0)
                {
                    value = default(AttributeValue);
                    return false;
                }

                var entry = _allocationCache.Read(address);
                if (entry.Key == key)
                {
                    value = entry.Value;
                    return true;
                }
                address = entry.Next.ValueAddress;
            }
        }

        public Dictionary<AttributeKey, AttributeValue> GetValues(int groupId)
        {
            var group = _groupCache.Items[(short)groupId];

            var values = new Dictionary<AttributeKey, AttributeValue>();

            // TODO: Add 2nd map
            foreach (var map in new[] { new Ptr<Map<int, AttributeValue>>(_ctx.Memory, group.PtrMap.ValueAddress).Dereference() })
            {
                if (map != null)
                {
                    var buckets = _ctx.Memory.Reader.Read<Map<int, AttributeValue>>(map.Address).Buckets.ToArray();
                    foreach (var bucket in buckets)
                    {
                        var address = bucket.ValueAddress;
                        while (address != 0)
                        {
                            var entry = _allocationCache.Read(address);
                            values[entry.Key] = entry.Value;
                            address = entry.Next.ValueAddress;
                        }
                    }
                }
            }

            return values;
        }

        public AttributeDescriptor GetDescriptor(AttributeId id)
        {
            return _descriptors[(int)id];
        }
    }
}
