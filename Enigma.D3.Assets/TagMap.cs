using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Enigma.D3.DataTypes;
using Enigma.D3.Enums;

namespace Enigma.D3.Assets
{
    public class TagMap
    {
        public TagMap(byte[] data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            Reader = new BufferMemoryReader(data);
            if (data.Length > 0)
            {
                Count = Reader.Read<int>(0x00);
                Entries = new Entry[Count];

                var offset = 0x04;
                for (int i = 0; i < Count; i++)
                {
                    Entries[i] = new Entry();
                    Entries[i].Type = Reader.Read<int>(offset); offset += 4;
                    Entries[i].Key = Reader.Read<int>(offset); offset += 4;
                    switch (Entries[i].Type)
                    {
                        case 0:
                            Entries[i].Value = Reader.Read<int>(offset); offset += 4;
                            break;

                        case 1:
                            Entries[i].Value = Reader.Read<float>(offset); offset += 4;
                            break;

                        case 2:
                            Entries[i].Value = Reader.Read<SNO>(offset); offset += 4;
                            break;

                        case 3:
                            Entries[i].Value = Reader.Read<GBID>(offset); offset += 4;
                            break;

                        case 4:
                            Entries[i].Value = new ScriptFormula(Reader, ref offset);
                            break;

                        case 6:
                            Entries[i].Value = Reader.Read<AttributeId>(offset); offset += 4;
                            break;

                        default:
                            throw new NotImplementedException($"Entry type {Entries[i].Type} deserialization not implemented.");
                    }
                }
            }
        }

        protected BufferMemoryReader Reader { get; }

        public int Count { get; }
        public Entry[] Entries { get; }

        public class Entry
        {
            public int Type { get; internal set; }
            public int Key { get; internal set; }
            public object Value { get; internal set; }

            public override string ToString()
            {
                return $"[{Key}]({Value.GetType().Name}): {Value}";
            }
        }
    }
}
