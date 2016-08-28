using System;

namespace Enigma.D3.Memory
{
	public static class Globals
	{
		public static readonly Version SupportedVersion = new Version(2, 4, 2, 39192);
		public const int SNOGroupsCount = 60;
		public const int AttributeDescriptorsCount = 1442;
		public const int SizeOf_PlayerData = 0xB370;
		public const int Offset_PlayerData_HeroName = 0xA040;
		public const int Offset_PlayerData_LifePercentage = 0xA4FC;
	}
}
