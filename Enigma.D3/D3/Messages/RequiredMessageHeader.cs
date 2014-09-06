using Enigma.Memory;

namespace Enigma.D3.Messages
{
	public class RequiredMessageHeader : MemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x08; // 8

		public int _x00 { get { return Read<int>(0x00); } }
		public int x04 { get { return Read<int>(0x04); } }
	}
}