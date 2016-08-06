using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.CodeGen.Memory.PatternScanning
{
	internal class FlairPattern
	{
		private BinaryPattern patternBytes;
		private byte alen;
		private ushort asum;
		private short moduleLength;
		private List<Tuple<int, string>> publicNames;
		private List<Tuple<int, string, int>> references;
		private BinaryPattern tailBytes;

		public List<string> ReferenceNames { get { return references.Select(a => a.Item2).ToList(); } }
		public List<string> PublicNames { get { return publicNames.Select(a => a.Item2).ToList(); } }

		public FlairPattern(BinaryPattern patternBytes, byte alen, ushort asum, short moduleLength, List<Tuple<int, string>> publicNames, List<Tuple<int, string, int>> referenceNames, BinaryPattern tailBytes)
		{
			this.patternBytes = patternBytes;
			this.alen = alen;
			this.asum = asum;
			this.moduleLength = moduleLength;
			this.publicNames = publicNames;
			this.references = referenceNames;
			this.tailBytes = tailBytes;
		}

		public static FlairPattern Parse(string pattern)
		{
			var parts = pattern.Split(' ');
			try
			{
				var patternBytesHex = parts[0].Replace("|", "");
				//if (patternBytesHex.Length != 64)
				//	throw new FormatException();
				var patternBytes = BinaryPattern.Parse(patternBytesHex);

				var alen = byte.Parse(parts[1], NumberStyles.HexNumber);
				var asum = ushort.Parse(parts[2], NumberStyles.HexNumber);
				if (BitConverter.IsLittleEndian)
				{
					var asumBytes = BitConverter.GetBytes(asum);
					Array.Reverse(asumBytes);
					asum = BitConverter.ToUInt16(asumBytes, 0);
				}
				var moduleLength = short.Parse(parts[3], NumberStyles.HexNumber);

				var publicNames = new List<Tuple<int, string>>();
				var references = new List<Tuple<int, string, int>>();
				int i = 4;
				for (; i < parts.Length; i += 2)
				{
					string name = parts[i];
					if (name[0] != ':')
						break;
					if (name.Length != 5)
						throw new FormatException();
					int offset = ushort.Parse(name.Substring(1, 4), NumberStyles.HexNumber);
					string publicName = parts[i + 1];
					publicNames.Add(new Tuple<int, string>(offset, publicName));
				}
				for (; i < parts.Length; i += 2)
				{
					string name = parts[i].Split(':')[0];
					int len = name.Length != parts[i].Length ? int.Parse(parts[i].Split(':')[1]) : 4;
					if (name[0] != '^')
						break;
					if (name.Length != 5)
						throw new FormatException();
					int offset = ushort.Parse(name.Substring(1, 4), NumberStyles.HexNumber);
					string referenceName = parts[i + 1];
					references.Add(new Tuple<int, string, int>(offset, referenceName, len));
				}
				var tailBytes = i < parts.Length ? BinaryPattern.Parse(parts[i]) : null;

				return new FlairPattern(patternBytes, alen, asum, moduleLength, publicNames, references, tailBytes);
			}
			catch (Exception exception)
			{
				throw new FormatException(null, exception);
			}
		}

		public IEnumerable<int> Matches(byte[] data)
		{
			foreach (var match in this.patternBytes.Matches(data))
			{
				int postPattern = match + this.patternBytes.Bytes.Length;
				if (postPattern + this.alen < data.Length)
				{
					byte[] postPatternData = new byte[this.alen];
					Buffer.BlockCopy(data, postPattern, postPatternData, 0, this.alen);

					var crc = Crc16.ComputeChecksum(data, postPattern, this.alen);
					if (crc == this.asum)
					{
						yield return match;
					}

					if (tailBytes != null)
					{
						var tailPosition = postPattern + this.alen;
						tailBytes.IsMatch(data, tailPosition);
					}
				}
			}
		}

		public int AddressOfReference(string p, int match)
		{
			var r = this.references.FirstOrDefault(a => a.Item2 == p);
			if (r == null)
				throw new KeyNotFoundException();
			return match + r.Item1;
		}

		public int LengthOfReference(string p)
		{
			var r = this.references.FirstOrDefault(a => a.Item2 == p);
			if (r == null)
				throw new KeyNotFoundException();
			return r.Item3;
		}
	}
}
