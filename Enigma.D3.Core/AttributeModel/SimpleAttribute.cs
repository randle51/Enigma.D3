using Enigma.D3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.AttributeModel
{
    public class SimpleAttribute<T> : Attribute<T> where T : struct
    {
        private readonly AttributeId _attributeId;
        private readonly T _defaultValue;

        public SimpleAttribute(int attributeId, T defaultValue)
            : this((AttributeId)attributeId, defaultValue) { }

        public SimpleAttribute(AttributeId attributeId, T defaultValue)
        {
            _attributeId = attributeId;
            _defaultValue = defaultValue;

            if (typeof(T) != typeof(int) && typeof(T) != typeof(float))
                throw new NotSupportedException("Generic type T must be either int or float.");
        }

        public override T GetValue(IAttributeReader reader, int groupId, int modifier)
        {
            AttributeValue value;
            if (reader.TryGetAttributeValue(groupId, _attributeId, modifier, out value))
                return (T)(typeof(T) == typeof(int) ? (object)value.Int32 : (object)value.Single);
            return _defaultValue;
        }

        public override T DefaultValue { get { return _defaultValue; } }

        public AttributeId ID => _attributeId;
    }
}
