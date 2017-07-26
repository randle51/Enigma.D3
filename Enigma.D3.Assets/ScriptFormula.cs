using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
    public class ScriptFormula
    {
        public int x00;
        public int x04;
        public int x08;
        public int x0C;
        public int x10;
        public int OpCodeNameSize;
        public int x18;
        public int OpCodeSize;
        public string OpCodeName;
        public byte[] OpCode;

        public ScriptFormula(BufferMemoryReader reader, ref int offset)
        {
            x00 = reader.Read<int>(offset + 0x00);
            x04 = reader.Read<int>(offset + 0x04);
            x08 = reader.Read<int>(offset + 0x08);
            x0C = reader.Read<int>(offset + 0x0C);
            x10 = reader.Read<int>(offset + 0x10);
            OpCodeNameSize = reader.Read<int>(offset + 0x14);
            x18 = reader.Read<int>(offset + 0x18);
            OpCodeSize = reader.Read<int>(offset + 0x1C);
            OpCodeName = reader.ReadString(offset + 0x20, OpCodeNameSize);
            OpCode = reader.ReadBytes(offset + 0x20 + MemoryObject.AlignedSize(OpCodeNameSize, 4), OpCodeSize);
            offset += 0x20 + MemoryObject.AlignedSize(OpCodeNameSize, 4) + MemoryObject.AlignedSize(OpCodeSize, 4);
        }
    }
}
