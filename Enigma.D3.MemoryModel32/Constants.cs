using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel32
{
	internal static class Constants
	{
		public static class DataSegment
		{
			public const uint ObjectManager = 0x0203D2C8;
			public const uint MemoryManager = 0x020FFC2C;
		}

		public static class MemoryManager
		{
			public const int SizeOf = 0x38;
			public const int LocalHeap = 0x30;
		}

		public static class LocalHeap
		{
			public const int FirstNode = 0x04;
			public const int TotalSize = 0x08;
			public const int NodeCount = 0x10;
			public const int LastNode = 0x38;
		}

		public static class HeapNode
		{
			public const int HeaderSize = 0x10;
			public const int SizeAndFlag = 0x0C;
		}
	}
}
