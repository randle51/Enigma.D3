using Enigma.D3.Enums;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Assets
{
    public class SNODefinition<T> : MemoryObject
    {
        public static int SizeOf => SymbolTable.Current.Platform == Platform.X86 ? 0x10 : 0x18;

        public int ID { get { return Read<int>(0x00); } }
        public int LastTouched { get { return Read<int>(0x04); } }
        public SNOType SNOType { get { return (SNOType)Read<byte>(0x07); } }
        public int Size { get { return Read<int>(0x08); } }
        public Ptr<T> PtrValue { get { return this.PlatformRead<Ptr<T>>(0x0C, 0x10); } }
    }
}
