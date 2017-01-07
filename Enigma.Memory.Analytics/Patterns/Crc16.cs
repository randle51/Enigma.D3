using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Memory.Analytics.Patterns
{
	internal class Crc16
	{
		public const ushort Polynomial = 0x8408;
		public const ushort InitialCrc = 0xFFFF;

		public static ushort ComputeChecksum(byte[] bytes)
		{
			return ComputeChecksum(bytes, 0, bytes.Length);
		}

		public static ushort ComputeChecksum(byte[] bytes, int offset, int length)
		{
			int current_crc_value = InitialCrc;
			for (int i = offset; i < offset + length; i++)
			{
				current_crc_value ^= bytes[i] & 0xFF;
				for (int j = 0; j < 8; j++)
				{
					if ((current_crc_value & 1) != 0)
					{
						current_crc_value = (current_crc_value >> 1) ^ Polynomial;
					}
					else
					{
						current_crc_value = current_crc_value >> 1;
					}
				}
			}
			current_crc_value = ~current_crc_value;

			return (ushort)current_crc_value;
		}

		public static byte[] ComputeChecksumBytes(byte[] bytes)
		{
			ushort crc = ComputeChecksum(bytes);
			return BitConverter.GetBytes(crc);
		}
	}
}
