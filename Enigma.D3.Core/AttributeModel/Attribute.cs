using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.AttributeModel
{
    public abstract class Attribute<T> where T : struct
    {
        public abstract T DefaultValue { get; }

        public T GetValue(IAttributeReader reader, int groupId) => GetValue(reader, groupId, -1);

        public abstract T GetValue(IAttributeReader reader, int groupId, int modifier);
    }
}
