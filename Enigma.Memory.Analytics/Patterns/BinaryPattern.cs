using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Memory.Analytics.Patterns
{
	public class BinaryPattern
	{
		public static BinaryPattern Parse(string pattern)
		{
			if (pattern == null)
				throw new ArgumentNullException(nameof(pattern));
			pattern = pattern.Replace(" ", "").Replace("|", "").Replace('?', '.').Replace("\r", "").Replace("\n", "");
			if (pattern.Length == 0 || pattern.Length % 2 != 0)
				throw new ArgumentOutOfRangeException(nameof(pattern));

			int byteCount = pattern.Length / 2;
			byte[] bytes = new byte[byteCount];
			byte[] mask = new byte[byteCount];
			for (int i = 0; i < byteCount; i++)
			{
				string octet = pattern.Substring(i * 2, 2);
				if (octet == "..")
				{
					bytes[i] = 0x00;
					mask[i] = 0x00;
				}
				else
				{
					bytes[i] = byte.Parse(octet, NumberStyles.HexNumber, null);
					mask[i] = 0xFF;
				}
			}
			return new BinaryPattern(bytes, mask);
		}

		public readonly byte[] Bytes;
		public readonly byte[] Mask;

		public BinaryPattern(byte[] bytes)
			: this(bytes, Enumerable.Range(0, bytes?.Length ?? 0).Select(i => (byte)0xFF).ToArray()) { }

		public BinaryPattern(byte[] bytes, byte[] mask)
		{
			if (bytes == null)
				throw new ArgumentNullException(nameof(bytes));
			if (bytes.Length == 0)
				throw new ArgumentOutOfRangeException(nameof(bytes));
			if (mask == null)
				throw new ArgumentNullException(nameof(mask));
			if (mask.Length == 0)
				throw new ArgumentOutOfRangeException(nameof(mask));
			if (mask.Length != bytes.Length)
				throw new ArgumentOutOfRangeException();

			Bytes = bytes;
			Mask = mask;
		}

		public IEnumerable<int> Matches(byte[] data)
			=> Matches(data, 0, data.Length);

		public IEnumerable<int> Matches(byte[] data, int offset, int count)
		{
			if (data == null)
				throw new ArgumentNullException(nameof(data));
			if (offset < 0 || offset >= data.Length)
				throw new ArgumentOutOfRangeException(nameof(offset));
			if (count < 0 || count > (data.Length + offset))
				throw new ArgumentOutOfRangeException(nameof(count));

			var last = offset + count - Bytes.Length;
			for (int i = offset; i <= last; i++)
			{
				if (IsMatch(data, i))
				{
					yield return i;
				}
			}
		}

		public bool IsMatch(byte[] data, int offset)
		{
			if (data == null)
				throw new ArgumentNullException(nameof(data));
			if (offset < 0 || offset >= data.Length)
				throw new ArgumentOutOfRangeException(nameof(offset));

			for (int i = 0; i < Bytes.Length; i++)
			{
				var n = offset + i;
				if ((Mask[i] & data[n]) != (Mask[i] & Bytes[i]))
				{
					return false;
				}
			}
			return true;
		}

		public int NextMatch(byte[] data, int offset)
			=> NextMatch(data, offset, data.Length - offset);

		public int NextMatch(byte[] data, int offset, int count)
		{
			if (data == null)
				throw new ArgumentNullException(nameof(data));
			if (offset < 0 || offset >= data.Length)
				throw new ArgumentOutOfRangeException(nameof(offset));
			if (count < 0)
				throw new ArgumentOutOfRangeException(nameof(count));
			if (offset + count > data.Length)
				throw new ArgumentException();

			int position = offset;
			int last = position + count - Bytes.Length;
			while (position <= last && !IsMatch(data, position))
				position++;
			return position > last ? -1 : position;
		}
	}
}
