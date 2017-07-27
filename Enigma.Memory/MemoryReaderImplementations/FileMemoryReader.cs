using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Memory
{
    public class FileMemoryReader : MemoryReader
    {
        private readonly FileStream _fileStream;

        public FileMemoryReader(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException("path");

            _fileStream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        }

        public override MemoryAddress MinValidAddress { get { return 0; } }

        public override MemoryAddress MaxValidAddress { get { return _fileStream.Length; } }

        public override bool IsValid { get { return !_fileStream.SafeFileHandle.IsInvalid; } }

        public override int PointerSize { get { throw new NotSupportedException(); } }

        protected override void UnsafeReadBytesCore(MemoryAddress address, byte[] buffer, int offset, int count)
        {
            _fileStream.Position = address;
            _fileStream.Read(buffer, offset, count);
        }

        public override void Dispose()
        {
            _fileStream.Dispose();
        }
    }
}
