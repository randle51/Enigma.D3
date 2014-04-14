using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class GameplayPreferences : MemoryObject
	{
		public const int SizeOf = 0x4C; // 1.0.8.16603 : [008FFA20]

		public GameplayPreferences(ProcessMemory memory, int address)
			: base(memory, address) { }

		// See field names at [0x01477B28] (1.0.8.16603).
		public bool x00_ItemsOnGroundSetting { get { return Field<bool>(0x00); } }
		public bool x04_ShowItemTooltipOnDrop { get { return Field<bool>(0x04); } }
		public bool x08_ShowMonsterHPBars { get { return Field<bool>(0x08); } }
		public bool x0C_ShowPlayerHPBars { get { return Field<bool>(0x0C); } }
		public int _x10_ShowItemsOnGround { get { return Field<int>(0x10); } }
		public bool x14_ShowPlayerNames { get { return Field<bool>(0x14); } }
		public bool x18_ShowDamageNumbers { get { return Field<bool>(0x18); } }
		public bool x1C_ShowHealNumbers { get { return Field<bool>(0x1C); } }
		public bool x20_ShowHPBarNumbers { get { return Field<bool>(0x20); } }
		public bool x24_ShowCriticals { get { return Field<bool>(0x24); } }
		public bool x28_ShowDefensiveMessages { get { return Field<bool>(0x28); } }
		public bool x2C_InventoryZoom { get { return Field<bool>(0x2C); } }
		public bool x30_AutoEquipItems { get { return Field<bool>(0x30); } }
		public bool x34_ShowTutorials { get { return Field<bool>(0x34); } }
		public int _x38_ShowBreadCrumbs { get { return Field<int>(0x38); } }
		public bool x3C_ShowClock { get { return Field<bool>(0x3C); } }
		public bool x40_ShowAdvancedTooltips { get { return Field<bool>(0x40); } }
		public bool x44_ElectiveMode { get { return Field<bool>(0x44); } }
		public bool x48_DisableWarningOnRareSalvage { get { return Field<bool>(0x48); } }
	}
}
