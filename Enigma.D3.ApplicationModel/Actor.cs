using Enigma.D3.AttributeModel;
using Enigma.D3.DataTypes;
using Enigma.D3.Enums;
using Enigma.D3.MemoryModel.Caching;
using Enigma.D3.MemoryModel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.ApplicationModel
{
    public class Actor
    {
        private readonly IAttributeReader _attributeReader;

        public Actor()
        {
            _attributeReader = AttributeCache.Current;
        }

        public ACD ACD { get; set; }

        public SNO ActorSNO => ACD.ActorSNO;

        public ActorType Type => ACD.ActorType;

        public WorldLocation Location { get; } = new WorldLocation();

        public virtual string Slug => AssetCache.GetSlug(SNOType.Actor, ActorSNO);

        public virtual string Name => AssetCache.GetSlug(SNOType.Actor, ActorSNO);

        public T GetAttributeValue<T>(Attribute<T> attribute) where T : struct
        {
            return GetAttributeValue(attribute, -1);
        }

        public T GetAttributeValue<T>(Attribute<T> attribute, int modifier) where T : struct
        {
            if (_attributeReader == null || ACD == null)
                return attribute.DefaultValue;
            return attribute.GetValue(_attributeReader, ACD.FastAttribGroupID);
        }

        public double GetAttributeValue(AttributeId attributeId, int modifier = -1)
        {
            var descriptor = AttributeCache.Current.GetDescriptor(attributeId);
            var value = default(AttributeValue);
            if (_attributeReader == null || ACD == null || _attributeReader.TryGetAttributeValue(ACD.FastAttribGroupID, attributeId, modifier, out value) == false)
                return descriptor.DataType == typeof(int) ? descriptor.DefaultValue : new AttributeValue { Int32 = descriptor.DefaultValue }.Single;
            return descriptor.GetType() == typeof(int) ? value.Int32 : value.Single;
        }

        public Dictionary<AttributeKey, double> GetAttributes()
        {
            var attributes = new Dictionary<AttributeKey, double>();
            foreach (var kvp in AttributeCache.Current.GetValues(ACD.FastAttribGroupID))
            {
                var descriptor = AttributeCache.Current.GetDescriptor(kvp.Key.Id);
                attributes[kvp.Key] = descriptor.DataType == typeof(int) ? kvp.Value.Int32 : kvp.Value.Single;
            }
            return attributes;
        }
    }
}
