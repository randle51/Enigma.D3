using Enigma.D3.AttributeModel;
using Enigma.D3.Enums;
using Enigma.D3.MemoryModel;
using Enigma.D3.MemoryModel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Core
{
    public class AttributeReader : IAttributeReader
    {
        public static readonly AttributeReader Instance = new AttributeReader();

        public bool TryGetAttributeValue(int groupId, AttributeId attribId, int modifier, out AttributeValue value)
        {
            int key = (modifier << 12) + ((int)attribId & 0xFFF);
            var group = MemoryContext.Current.DataSegment.ObjectManager.FastAttrib.FastAttribGroups[groupId];
            if (group != null)
            {
                value = default(AttributeValue);
                if (((group.Flags & 4) != 0 && group.PtrMap.Dereference()?.TryGetValue(key, out value) == true) ||
                    group.Map != null && group.Map.TryGetValue(key, out value))
                {
                    return true;
                }
            }
            value = default(AttributeValue);
            return false;
        }
    }
}
