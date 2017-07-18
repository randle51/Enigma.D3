using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.D3.MemoryModel.Segments;
using Enigma.Memory;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Enigma.D3.MemoryModel
{
    public class MemoryContext : IDisposable
    {
        public static MemoryContext Current;

        public static MemoryContext FromMiniDump()
        {
            string path;

            path = Environment.ExpandEnvironmentVariables(@"%TEMP%\Diablo III64.dmp");
            if (File.Exists(path))
                return FromMiniDump(path);

            path = Environment.ExpandEnvironmentVariables(@"%TEMP%\Diablo III.dmp");
            if (File.Exists(path))
                return FromMiniDump(path);

            throw new FileNotFoundException("Could not find a minidump file.");
        }

        public static MemoryContext FromMiniDump(string path)
        {
            if (path == null)
                throw new ArgumentNullException(nameof(path));

            return new MemoryContext(new MiniDumpMemoryReader(path));
        }

        /// <summary>
        /// Attempts to create a memory context by looking for default process names (64-bit prioritized).
        /// If no matching process is found, null is returned.
        /// </summary>
        public static MemoryContext FromProcess()
        {
            var process = Process.GetProcessesByName("Diablo III64").FirstOrDefault();
            if (process == null)
                process = Process.GetProcessesByName("Diablo III").FirstOrDefault();
            if (process == null)
                return null;

            return new MemoryContext(new ProcessMemoryReader(process));
        }

        public static MemoryContext FromProcess(Process process)
        {
            if (process == null)
                throw new ArgumentNullException(nameof(process));

            return new MemoryContext(new ProcessMemoryReader(process));
        }

        /// <summary>
        /// Attempts to create a memory context by looking for default process names (64-bit prioritized).
        /// This method will block until a matching process is found. To cancel the operation, raise 
        /// the stop signal.
        /// </summary>
        /// <param name="stopSignal">Stop signal that can be raised to break out of the blocking method.</param>
        /// <returns>An instance of a <see cref="MemoryContext"/> or null if stop signal was raised and caused the return.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="stopSignal"/> parameter is null.</exception>
        public static MemoryContext FromProcess(WaitHandle stopSignal)
        {
            if (stopSignal == null)
                throw new ArgumentNullException(nameof(stopSignal));

            do
            {
                var ctx = FromProcess();
                if (ctx != null)
                    return ctx;
            }
            while (stopSignal.WaitOne(1000) == false);

            return null;
        }

        public IMemory Memory { get; }

        public DataSegment DataSegment { get; }

        public Version MainModuleVersion { get; }

        public MemoryContext(MemoryReader reader)
            : this((reader ?? throw new ArgumentNullException(nameof(reader))).Memory) { }

        public MemoryContext(IMemory memory)
        {
            Memory = memory ?? throw new ArgumentNullException(nameof(memory));
            MainModuleVersion = (Memory.Reader as IHasMainModuleVersion)?.MainModuleVersion;

            TypeHelper.PointerSize = Memory.Reader.PointerSize;
            SymbolTable.Current = new SymbolTable(this);
            DataSegment = Memory.Reader.Read<DataSegment>(SymbolTable.Current.DataSegment.Address);
            TypeHelper.InvalidateCache(); // Required in case we make a switch between 32-bit and 64-bit context.

            Current = this;
        }

        public void Dispose()
        {
            Memory.Dispose();
        }
    }
}
