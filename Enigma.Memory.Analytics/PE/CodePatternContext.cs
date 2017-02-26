using Enigma.Memory.Analytics.Patterns;
using Enigma.Memory.PE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Memory.Analytics.PE
{
	public class CodePatternContext
	{
		public readonly MiniDumpMemoryReader Dump;
		private readonly PEHeaderReader _pe;

		public CodePatternContext(MiniDumpMemoryReader dump, PEHeaderReader pe)
		{
			Dump = dump;
			_pe = pe;

			Text = new Range(Dump.ImageBase, _pe.ImageSectionHeaders.First(s => new string(s.Name).StartsWith(".text")));
			Data = new Range(Dump.ImageBase, _pe.ImageSectionHeaders.First(s => new string(s.Name).StartsWith(".data")));
			Resources = new Range(Dump.ImageBase, _pe.ImageSectionHeaders.First(s => new string(s.Name).StartsWith(".rdata")));
			
			TextBuffer = Dump.ReadBytes(Text.Start, (int)Text.Size);
			DataBuffer = Dump.ReadBytes(Data.Start, (int)Data.Size);
			ResourcesBuffer = Dump.ReadBytes(Resources.Start, (int)Resources.Size);
		}

		public Range Text { get; }
		public Range Data { get; }
		public Range Resources { get; }
		public byte[] TextBuffer { get; }
		public byte[] DataBuffer { get; }
		public byte[] ResourcesBuffer { get; }

		public CodePatternMatch FirstMatchInTextSegment(MemoryAddress start, int length, string pattern)
		{
			if (start < Text.Start ||
				start >= Text.Start + Text.Size)
				throw new ArgumentOutOfRangeException(nameof(start));
			if (length <= 0)
				throw new ArgumentOutOfRangeException(nameof(length));
			if (pattern == null)
				throw new ArgumentNullException(nameof(pattern));

			return CodePattern.Parse(pattern).Matches(Text.Start, TextBuffer, start, length).First();
		}

		public T FirstMatchInTextSegment<T>(MemoryAddress start, int length, string pattern, string label)
			=> FirstMatchInTextSegment(start, length, pattern).Read<T>(Dump, label);
	}
}
