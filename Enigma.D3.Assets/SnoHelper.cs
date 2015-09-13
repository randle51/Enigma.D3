using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	public static class SnoHelper
	{
		public static SnoFile<T> LoadFile<T>(string path) where T : SerializeMemoryObject
		{
			var buffer = new BufferMemoryReader(File.ReadAllBytes(path));
			var file = buffer.Read<SnoFile<T>>(0x00);
			if (!file.Header.IsValid)
				throw new InvalidDataException("Invalid header bytes.");
			return file;
		}
	}
}
