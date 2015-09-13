using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	public class SnoFile<T> : MemoryObject
	{
		public SnoFileHeader Header { get { return Read<SnoFileHeader>(0x00); } }
		public T Content { get { return Read<T>(0x10); } }
	}
}
