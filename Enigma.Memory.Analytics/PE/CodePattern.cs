using Enigma.Memory.Analytics.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Memory.Analytics.PE
{
	public class CodePattern
	{
		public static CodePattern Parse(string pattern)
		{
			var bp = new StringBuilder(pattern.Length);
			var marker = default(string);
			var markers = new Lazy<List<CodePatternMarker>>();
			var op = new Range(0, 0);
			var ops = new List<Range>();

			foreach (var c in pattern)
			{
				if (c == '{')
				{
					if (marker != null)
						throw new FormatException();
					marker = "";
				}
				else if (marker != null)
				{
					if (c == '}')
					{
						var position = bp.Length;
						if ((position & 1) != 0)
							throw new FormatException();
						markers.Value.Add(new CodePatternMarker { Name = marker, Position = position / 2 });
						marker = null;
					}
					else marker += c;
				}
				else if (IsClean(c))
				{
					bp.Append(c);
				}
				else if (c == '|')
				{
					var position = bp.Length;
					if (op != default(Range))
					{
						if ((position & 1) != 0)
							throw new FormatException();
						op.Size = position / 2 - op.Start;
						ops.Add(op);
					}
					op = new Range(position / 2, 0);
				}
			}
			if (marker != null) throw new FormatException();
			if (op != default(Range))
			{
				var position = bp.Length;
				if ((position & 1) != 0)
					throw new FormatException();
				op.Size = position / 2 - op.Start;
				ops.Add(op);
			}

			var binary = BinaryPattern.Parse(bp.ToString());
			var x = new CodePattern { Markers = markers.IsValueCreated ? markers.Value : null, Binary = binary, Operations = ops };
			return x;
		}

		private static bool IsClean(char c)
		{
			return char.IsDigit(c) || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f') || c == '.' || c == '?';
		}

		public List<CodePatternMarker> Markers;
		public BinaryPattern Binary;
		public List<Range> Operations = new List<Range>();

		public IEnumerable<CodePatternMatch> Matches(MemoryAddress baseAddress, byte[] data)
		{
			foreach (var match in Binary.Matches(data))
			{
				yield return new CodePatternMatch { Pattern = this, Position = baseAddress + match };
			}
		}

		public IEnumerable<CodePatternMatch> Matches(MemoryAddress baseAddress, byte[] data, MemoryAddress start, int count)
		{
			foreach (var match in Binary.Matches(data, start - baseAddress, count))
			{
				yield return new CodePatternMatch { Pattern = this, Position = baseAddress + match };
			}
		}
	}
}
