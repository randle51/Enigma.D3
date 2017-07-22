using Enigma.D3.MemoryModel;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Enigma.D3.ObjectDiffer
{
    internal class Program
    {
        internal static readonly HashSet<int> _ignoredOffsets = new HashSet<int>();

        internal static void Main(string[] args)
        {
            Console.WindowWidth = 120;
            Console.BufferWidth = 120;

            Console.WriteLine("Creating context.");
            var ctx = MemoryContext.FromProcess(new ManualResetEvent(false));
            Console.WriteLine("Context created.");

            Track(() => ctx.DataSegment.ObjectManager.PlayerDataManager[0]);
        }

        private static void Track<T>(Func<T> getter, int align = 4) where T : MemoryObject
        {
            var size = TypeHelper<T>.SizeOf;
            var digits = size.ToString("X").Length;
            var format = "X" + digits;

            byte[] previous = null;
            while (true)
            {
                var obj = getter.Invoke();
                if (obj != null)
                {
                    byte[] snapshot = obj.Read<byte>(0, size);
                    if (previous != null)
                    {
                        var timestamp = DateTime.Now.ToString("HH:mm:ss.fffffff");
                        for (int i = 0; i < snapshot.Length; i += align)
                        {
                            if (_ignoredOffsets.Contains(i))
                                continue;

                            for (int b = 0; b < align; b++)
                            {
                                if (snapshot[i + b] != previous[i + b])
                                {
                                    byte[] value = new byte[4];
                                    Buffer.BlockCopy(snapshot, i, value, 0, value.Length);
                                    Write(timestamp, ConsoleColor.DarkGray);
                                    Write(" 0x" + i.ToString(format));
                                    Write(" " + BitConverter.ToString(value), ConsoleColor.DarkGray);
                                    WriteValue(BitConverter.ToInt32(value, 0));
                                    WriteValue(BitConverter.ToSingle(value, 0));
                                    WriteLine();
                                    break;
                                }
                            }
                        }
                    }
                    previous = snapshot;
                }
                Thread.Sleep(1);
            }
        }

        private static void WriteValue(int value)
        {
            string output = value.ToString();
            if ((uint)value == 0x80000000 || Math.Abs(value) > 100000)
                output = "0x" + value.ToString("X");
            Write(" " + output.PadRight(10));
        }

        private static void WriteValue(float value)
        {
            var color = ConsoleColor.Gray;
            if (Math.Abs(value) > 100000 || Math.Abs(value) < 0.001)
                color = ConsoleColor.DarkGray;
            Write(" " + value, color);
        }

        private static void Write(string text, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }

        private static void WriteLine(string text = null, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
