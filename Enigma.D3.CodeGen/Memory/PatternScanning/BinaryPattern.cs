using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.CodeGen.Memory.PatternScanning
{
	internal class BinaryPattern
	{
		public static BinaryPattern Parse(string pattern)
		{
			if (pattern == null)
				throw new ArgumentNullException("pattern");
			pattern = pattern.Replace(" ", "").Replace("|", "").Replace('?', '.');
			if (pattern.Length == 0 || pattern.Length % 2 != 0)
				throw new ArgumentOutOfRangeException(pattern);

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

		public BinaryPattern(byte[] bytes, byte[] mask)
		{
			if (bytes == null)
				throw new ArgumentNullException("bytes");
			if (bytes.Length == 0)
				throw new ArgumentOutOfRangeException("bytes");
			if (mask == null)
				throw new ArgumentNullException("mask");
			if (mask.Length == 0)
				throw new ArgumentOutOfRangeException("mask");
			if (mask.Length != bytes.Length)
				throw new ArgumentOutOfRangeException();

			Bytes = bytes;
			Mask = mask;
		}

		public IEnumerable<int> Matches(byte[] data)
		{
			for (int i = 0; i < data.Length - Bytes.Length; i++)
			{
				if (IsMatch(data, i))
				{
					yield return i;
				}
			}
		}

		public bool IsMatch(byte[] data, int offset)
		{
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
		{
			int position = offset;
			while (!IsMatch(data, position))
				position++;
			return position;
		}
	}
}
