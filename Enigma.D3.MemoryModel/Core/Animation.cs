using Enigma.D3.DataTypes;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Core
{
    public class Animation : MemoryObject
    {
        public const int SizeOf = 0xDC;

        public SNO AnimSNO { get { return Read<SNO>(0x04); } }
        public int AnimTag { get { return Read<int>(0x08); } }
    }
}
