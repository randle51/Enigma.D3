using System;

namespace Enigma.D3.Memory
{
	public static class Globals
	{
		public static readonly Version SupportedVersion = new Version(2, 6, 0, 46494);
        public const int SNOGroupsCount = 60;
		public const int AttributeDescriptorsCount = 0x5B9;
		public const int SizeOf_PlayerData = 0xD158;
		public const int Offset_PlayerData_HeroName = 0xB1C0;
		public const int Offset_PlayerData_LifePercentage = 0xC1BC;
	}
}
