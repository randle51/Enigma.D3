using Enigma.D3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.AttributeModel
{
    public class ComplexAttribute : Attribute<ulong>
    {
        private readonly SimpleAttribute<int> _highAttribute;
        private readonly SimpleAttribute<int> _lowAttribute;

        public SimpleAttribute<int> High => _highAttribute;
        public SimpleAttribute<int> Low => _lowAttribute;

        public ComplexAttribute(AttributeId highAttributeId, uint highDefaultValue, AttributeId lowAttributeId, uint lowDefaultValue)
        {
            _highAttribute = new SimpleAttribute<int>((int)highAttributeId, (int)lowDefaultValue);
            _lowAttribute = new SimpleAttribute<int>((int)lowAttributeId, (int)lowDefaultValue);
        }

        public override ulong DefaultValue { get { return (uint)_highAttribute.DefaultValue << 32 | (uint)_lowAttribute.DefaultValue; } }

        public override ulong GetValue(IAttributeReader reader, int groupId, int modifier)
        {
            var high = (uint)_highAttribute.GetValue(reader, groupId, modifier);
            var low = (uint)_lowAttribute.GetValue(reader, groupId, modifier);
            return ((ulong)high << 32) | low;
        }
    }
}
