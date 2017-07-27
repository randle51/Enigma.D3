using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Memory
{
    public class Ptr
    {
        public Ptr(IMemory memory, MemoryAddress value)
        {
            Memory = memory;
            ValueAddress = value;
            IsInvalid = !Memory.Reader.IsValidAddress(ValueAddress);
        }

        public IMemory Memory { get; private set; }

        public MemoryAddress ValueAddress { get; private set; }

        public bool IsInvalid { get; private set; }

        public Ptr<TCast> Cast<TCast>()
        {
            return new Ptr<TCast>(Memory, ValueAddress);
        }

        public Ptr<string> CastToStringPointer(int maxLength)
        {
            return new StringPointer(Memory, ValueAddress, maxLength);
        }

        public Ptr<string> CastToStringPointer(int maxLength, Encoding encoding)
        {
            return new StringPointer(Memory, ValueAddress, maxLength, encoding);
        }

        public override string ToString()
        {
            return "[" + ValueAddress + "]" + (IsInvalid ? "[INVALID]" : string.Empty);
        }
    }

    public class Ptr<T> : Ptr
    {
        public Ptr(IMemory memory, MemoryAddress value)
            : base(memory, value) { }

        public virtual T this[int index]
        {
            get
            {
                if (IsInvalid)
                    return default(T);

                int itemSize = TypeHelper<T>.IsMemoryPointerType ? Memory.Reader.PointerSize
                    : TypeHelper<T>.SizeOf;
                return Memory.Reader.Read<T>(ValueAddress + index * itemSize);
            }
        }

        // This is added just for debugger.
        private T _Dereference { get { return Dereference(); } }

        public virtual T Dereference()
        {
            if (IsInvalid)
                return default(T);

            return Memory.Reader.Read<T>(ValueAddress);
        }

        public virtual T[] ToArray(int count)
        {
            if (IsInvalid)
                return default(T[]);

            return Memory.Reader.Read<T>(ValueAddress, count);
        }
    }
}
