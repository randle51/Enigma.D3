using System;

namespace Enigma.D3.Memory
{
	public static class Globals
	{
		public static readonly Version SupportedVersion = new Version(2, 5, 0, 44247);
		public const int SNOGroupsCount = 60;
		public const int AttributeDescriptorsCount = 1445;
		public const int SizeOf_PlayerData = 0xC0E0;
		public const int Offset_PlayerData_HeroName = 0x0;
		public const int Offset_PlayerData_LifePercentage = 0x0;
	}
}
