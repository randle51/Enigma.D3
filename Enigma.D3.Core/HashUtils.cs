using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3
{
    public static class HashUtils
    {
        public static uint Fnv32(int data)
        {
            return Fnv32(BitConverter.GetBytes(data));
        }

        public static uint Fnv32(byte[] data)
        {
            if (data == null)
                throw new ArgumentNullException("data");

            var hash = 0x811C9DC5;
            foreach (var b in data)
            {
                hash = hash ^ b;
                hash = hash * 0x1000193;
            }
            return hash;
        }

        public static ulong Fnv64(byte[] data)
        {
            if (data == null)
                throw new ArgumentNullException("data");

            var hash = 0xCBF29CE484222325;
            foreach (var b in data)
            {
                hash = hash ^ b;
                hash = hash * 0x100000001B3;
            }
            return hash;
        }

        public static uint Lcg(string data)
        {
            uint hash = 0;
            foreach (var c in Encoding.ASCII.GetBytes(data))
            {
                hash = hash * 33 + c;
            }
            return hash;
        }
    }
}
