using Enigma.D3.AttributeModel;
using Enigma.D3.MemoryModel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.ApplicationModel
{
    public static class AttributeExtensions
    {
        public static T GetMemoryValue<T>(this Attribute<T> attribute, ACD acd, int modifier = -1) where T : struct
        {
            return attribute.GetValue(AttributeReader.Instance, acd.FastAttribGroupID, modifier);
        }
    }
}
