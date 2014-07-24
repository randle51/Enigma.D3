using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Preferences
{
	public class GameplayPreferences : MemoryObject
	{
		// 2.0.0.20874
		public const int SizeOf = 0x50; // = 80

		public GameplayPreferences(MemoryBase memory, int address)
			: base(memory, address) { }

		public int x00_ItemsOnGroundSetting { get { return Field<int>(0x00); } }  // default = 3, min = 0, max = 3
		public int x04_ItemTagsAsIcons { get { return Field<int>(0x04); } }  // default = 0, min = 0, max = 1
		public int x08_ShowItemTooltipOnDrop { get { return Field<int>(0x08); } }  // default = 1, min = 0, max = 1
		public int x0C_ShowMonsterHPBars { get { return Field<int>(0x0C); } }  // default = 0, min = 0, max = 1
		public int x10_ShowPlayerHPBars { get { return Field<int>(0x10); } }  // default = 1, min = 0, max = 1
		public int x14_ShowItemsOnGround { get { return Field<int>(0x14); } }  // default = 0, min = 0, max = 1
		public int x18_ShowPlayerNames { get { return Field<int>(0x18); } }  // default = 1, min = 0, max = 1
		public int x1C_ShowDamageNumbers { get { return Field<int>(0x1C); } }  // default = 0, min = 0, max = 1
		public int x20_ShowHealNumbers { get { return Field<int>(0x20); } }  // default = 0, min = 0, max = 1
		public int x24_ShowHPBarNumbers { get { return Field<int>(0x24); } }  // default = 0, min = 0, max = 1
		public int x28_ShowCriticals { get { return Field<int>(0x28); } }  // default = 1, min = 0, max = 1
		public int x2C_ShowDefensiveMessages { get { return Field<int>(0x2C); } }  // default = 1, min = 0, max = 1
		public int x30_InventoryZoom { get { return Field<int>(0x30); } }  // default = 0, min = 0, max = 1
		public int x34_AutoEquipItems { get { return Field<int>(0x34); } }  // default = 0, min = 0, max = 1
		public int x38_ShowTutorials { get { return Field<int>(0x38); } }  // default = 1, min = 0, max = 1
		public int x3C_ShowBreadCrumbs { get { return Field<int>(0x3C); } }  // default = 1, min = 0, max = 1
		public int x40_ShowClock { get { return Field<int>(0x40); } }  // default = 1, min = 0, max = 1
		public int x44_ShowAdvancedTooltips { get { return Field<int>(0x44); } }  // default = 0, min = 0, max = 1
		public int x48_ElectiveMode { get { return Field<int>(0x48); } }  // default = 0, min = 0, max = 1
		public int x4C_DisableCutscenes { get { return Field<int>(0x4C); } }  // default = 0, min = 0, max = 1
	}
}
