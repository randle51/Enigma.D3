using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.AttributeModel
{
    [StructLayout(LayoutKind.Explicit)]
    public struct AttributeValue
    {
        [FieldOffset(0)]
        public int Int32;
        [FieldOffset(0)]
        public float Single;

        public override string ToString()
        {
            return "int32: " + Int32 + ", float: " + Single;
        }
    }
}
