using Enigma.Memory;

namespace Enigma.D3.Messages
{
	public class FloatingNumberMessage : MemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x14; // 20

		public RequiredMessageHeader x00 { get { return Read<RequiredMessageHeader>(0x00); } }
		public int x08_AnnId { get { return Read<int>(0x08); } }
		public float x0C_Value { get { return Read<float>(0x0C); } }
		public int x10_Type { get { return Read<int>(0x10); } }
	}
}