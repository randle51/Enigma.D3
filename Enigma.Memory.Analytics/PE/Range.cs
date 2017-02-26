using Enigma.Memory.PE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Memory.Analytics.PE
{
	public class Range
	{
		public Range(MemoryAddress start, ulong size)
		{
			Start = start;
			Size = size;
		}

		public Range(MemoryAddress image_base, PEHeaderReader.IMAGE_SECTION_HEADER image_section_header)
			: this(image_base + image_section_header.VirtualAddress, image_section_header.VirtualSize) { }

		public MemoryAddress Start;
		public ulong Size;

		public bool Contains(MemoryAddress address)
		{
			return Start <= address
				&& address < Start + Size;
		}

		public override string ToString()
		{
			return $"[{Start}, {Start + Size})";
		}
	}
}
