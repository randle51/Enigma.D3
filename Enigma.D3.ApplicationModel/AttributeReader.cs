using Enigma.D3.AttributeModel;
using Enigma.D3.Enums;
using Enigma.D3.MemoryModel;
using Enigma.D3.MemoryModel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.ApplicationModel
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
                if (((group.Flags & 4) != 0 && group.PtrMap.Dereference()?.TryGetValue(key, out value, GetHashOfKey) == true) ||
                    group.Map != null && group.Map.TryGetValue(key, out value, GetHashOfKey))
                {
                    return true;
                }
            }
            value = default(AttributeValue);
            return false;
        }

        private static uint GetHashOfKey(int key)
        {
            return unchecked((uint)(key ^ (key >> 12)));
        }
    }

    public static class AttributeExtensions
    {
        public static T GetMemoryValue<T>(this Attribute<T> attribute, ACD acd, int modifier = -1) where T : struct
        {
            return attribute.GetValue(AttributeReader.Instance, acd.FastAttribGroupID, modifier);
        }
    }
}
