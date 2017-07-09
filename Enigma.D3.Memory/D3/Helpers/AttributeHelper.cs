using System;
using Enigma.D3.Collections;
using Enigma.D3.Enums;
using System.Collections.Generic;
using Enigma.D3.AttributeModel;

namespace Enigma.D3.Helpers
{
    public class AttributeReader : IAttributeReader
    {
        public static readonly AttributeReader Instance = new AttributeReader();

        public bool TryGetAttributeValue(int groupId, AttributeId attribId, int modifier, out AttributeValue value)
        {
            int key = (modifier << 12) + ((int)attribId & 0xFFF);
            var group = FastAttribGroup.Get(groupId);
            if (group != null)
            {
                if (((group.x004_Flags & 4) != 0 && group.x00C_PtrMap != null && group.x00C_PtrMap.TryGetValue(key, out value, GetHashOfKey)) ||
                    group.x010_Map.TryGetValue(key, out value, GetHashOfKey))
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

    public static class AttributeHelper
    {
        public static double GetAttributeValue(this ActorCommonData acd, AttributeId attribId, int modifier = -1)
        {
            var attribDef = Engine.Current.AttributeDescriptors[(int)attribId];
            if (attribDef == null)
                throw new ArgumentOutOfRangeException("attribId");

            AttributeValue value;
            if (!TryGetAttributeValue(acd, attribId, modifier, out value))
                return Int32OrSingleToDouble(attribDef.x04_DefaultValue, attribDef.x10_DataType == 1);

            return attribDef.x10_DataType == 1 ? value.Int32 : value.Single;
        }

        public static IEnumerable<Map<int, AttributeValue>.Entry> EnumerateAttributes(this ActorCommonData acd)
        {
            var groupId = acd.x120_FastAttribGroupId;
            var group = FastAttrib.Instance.x54_Groups[(short)groupId];
            if (group != null)
            {
                var smallMap = group.x00C_PtrMap;
                if ((group.x004_Flags & 4) != 0 && smallMap != null)
                {
                    foreach (var bucket in smallMap.x10_Buckets)
                    {
                        var immutableBucket = bucket.Dereference();
                        while (immutableBucket != null)
                        {
                            immutableBucket.TakeSnapshot();
                            yield return immutableBucket;
                            immutableBucket = immutableBucket.x00_Next;
                        }
                    }
                }
                var map = group.x010_Map;
                if (map != null)
                {
                    foreach (var bucket in map.x10_Buckets)
                    {
                        var immutableBucket = bucket.Dereference();
                        while (immutableBucket != null)
                        {
                            immutableBucket.TakeSnapshot();
                            yield return immutableBucket;
                            immutableBucket = immutableBucket.x00_Next;
                        }
                    }
                }
            }
        }

        internal static bool TryGetAttributeValue(this ActorCommonData acd, AttributeId attribId, int modifier, out AttributeValue value)
        {
            return AttributeReader.Instance.TryGetAttributeValue(acd.x120_FastAttribGroupId, attribId, modifier, out value);
        }
        
        private static double Int32OrSingleToDouble(int value, bool isInteger)
        {
            return isInteger ? value : BitConverter.ToSingle(BitConverter.GetBytes(value), 0);
        }

        public static T GetValue<T>(this Attribute<T> attribute, ActorCommonData acd, int modifier = -1) where T : struct
        {
            return attribute.GetValue(AttributeReader.Instance, acd.x120_FastAttribGroupId, modifier);
        }
    }
}
