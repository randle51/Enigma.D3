using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Enigma.Memory
{
    public static class StructHelper<T>
    {
        public static readonly int SizeOf;
        public static readonly bool IsPrimitive;

        static StructHelper()
        {
            if (!TypeHelper<T>.IsValueType)
                throw new NotSupportedException("Type must be a value type.");

            SizeOf = TypeHelper<T>.SizeOf;
            IsPrimitive = typeof(T).IsPrimitive;
        }

        /// <summary>
        /// Read a struct from a buffer at given offset.
        /// </summary>
        public static T Read(byte[] buffer, int offset)
        {
            if (buffer == null)
                throw new ArgumentNullException("buffer");
            if (buffer.Length == 0)
                throw new ArgumentOutOfRangeException("buffer");
            if (offset < 0)
                throw new ArgumentOutOfRangeException("offset");
            if (offset + SizeOf > buffer.Length)
                throw new ArgumentOutOfRangeException();

            return UnsafeRead(buffer, offset);
        }

        /// <summary>
        /// Read a struct from a buffer at given offset.
        /// </summary>
        /// <remarks>No validation is made.</remarks>
        [MethodImpl(MethodImplOptions.ForwardRef | MethodImplOptions.AggressiveInlining)]
        public static extern T UnsafeRead(byte[] buffer, int offset);

        public static void CopyFromBuffer(byte[] source, int sourceOffset, T[] destination, int destinationOffset, int destinationCount)
        {
            if (IsPrimitive)
            {
                Buffer.BlockCopy(source, sourceOffset, destination, destinationOffset * SizeOf, destinationCount * SizeOf);
            }
            else
            {
                for (int i = 0; i < destinationCount; i++)
                {
                    destination[destinationOffset + i] = UnsafeRead(source, sourceOffset + i * SizeOf);
                }
            }
        }

        public static void CopyToBuffer(T[] source, int sourceOffset, int sourceCount, byte[] destination, int destinationOffset)
        {
            if (IsPrimitive)
            {
                Buffer.BlockCopy(source, sourceOffset * SizeOf, destination, destinationOffset, sourceCount * SizeOf);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
