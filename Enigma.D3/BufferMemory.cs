using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma
{
	public class BufferMemory : MemoryBase
	{
		private readonly byte[] _buffer;

		public BufferMemory(byte[] buffer)
		{
			if (buffer == null)
				throw new ArgumentNullException("buffer");
			_buffer = buffer;
		}

		public override uint MinValidAddress { get { return 0; } }

		public override uint MaxValidAddress { get { return (uint)_buffer.Length; } }

		public override bool IsValid { get { return true; } }

		public override void ReadBytes(int address, byte[] buffer, int offset, int count)
		{
			Buffer.BlockCopy(_buffer, address, buffer, offset, count);
		}

		public override void Dispose()
		{
			; // Nothing to dispose.
		}
	}
}
