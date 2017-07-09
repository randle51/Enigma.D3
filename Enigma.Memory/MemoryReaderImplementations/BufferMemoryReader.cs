using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Memory
{
	public class BufferMemoryReader : MemoryReader
	{
		private int _pointerSize;

		internal readonly ArraySegment<byte> Segment;

		public BufferMemoryReader(byte[] buffer)
			: this(buffer, 0, buffer.Length, 0) { }

		public BufferMemoryReader(byte[] buffer, int offset, int count)
			: this(buffer, offset, count, 0) { }

		public BufferMemoryReader(byte[] buffer, int offset, int count, int pointerSize)
		{
			if (buffer == null)
				throw new ArgumentNullException("buffer");
			if (offset < 0)
				throw new ArgumentOutOfRangeException("offset");
			if (offset > buffer.Length)
				throw new ArgumentOutOfRangeException("offset");
			if (count < 0)
				throw new ArgumentOutOfRangeException("count");
			if (offset + count > buffer.Length)
				throw new ArgumentException();
			if (pointerSize < 0)
				throw new ArgumentOutOfRangeException("pointerSize");

			Segment = new ArraySegment<byte>(buffer, offset, count);
			_pointerSize = pointerSize;
		}

		public override MemoryAddress MinValidAddress { get { return 0; } }

		public override MemoryAddress MaxValidAddress { get { return Segment.Count; } }

		public override bool IsValid { get { return true; } }

		public override int PointerSize
		{
			get
			{
				if (_pointerSize == 0)
					throw new InvalidOperationException();
				return _pointerSize;
			}
		}

		protected override void UnsafeReadBytesCore(MemoryAddress address, byte[] buffer, int offset, int count)
		{
			Buffer.BlockCopy(Segment.Array, Segment.Offset + address, buffer, offset, count);
		}

		public override void Dispose()
		{
			// Nothing to dispose.
		}
	}
}
