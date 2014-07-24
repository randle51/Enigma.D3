using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Enigma
{
	public class FileMemory : MemoryBase
	{
		private readonly FileStream _file;

		public FileMemory(string path)
		{
			_file = File.OpenRead(path);
		}

		protected override uint MinValidAddress { get { return 0; } }

		protected override uint MaxValidAddress { get { return (uint)_file.Length; } }

		public override bool IsValid { get { return true; } }

		public override byte[] ReadBytes(int address, byte[] buffer, int offset, int count)
		{
			_file.Position = address;
			_file.Read(buffer, offset, count);
			return buffer;
		}

		public override void Dispose()
		{
			_file.Dispose();
		}
	}
}
