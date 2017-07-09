using Enigma.D3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.AttributeModel
{
    public interface IAttributeReader
    {
        bool TryGetAttributeValue(int groupId, AttributeId attribId, int modifier, out AttributeValue value);
    }
}
