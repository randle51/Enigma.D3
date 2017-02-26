using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Memory.Analytics.PE
{
	public class CodePatternMatch
	{
		public CodePattern Pattern;
		public MemoryAddress Position;

		public MemoryAddress this[string label]
		{
			get
			{
				var marker = Pattern.Markers.FirstOrDefault(x => x.Name.Equals(label, StringComparison.Ordinal));
				if (marker == null)
					throw new KeyNotFoundException();
				return Position + marker.Position;
			}
		}

		public MemoryAddress DecodeDisp32(MemoryReader reader, string label)
		{
			var marker = Pattern.Markers.FirstOrDefault(x => x.Name.Equals(label, StringComparison.Ordinal));
			if (marker == null)
				throw new KeyNotFoundException();
			var displacement = Position + marker.Position;
			var op = Pattern.Operations.First(x => x.Contains(marker.Position));
			var op_end = op.Start + op.Size;

			return Position + op_end + reader.Read<int>(displacement);
		}

		public T Read<T>(MemoryReader dump, string label)
			=> dump.Read<T>(this[label]);
	}
}
