using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.D3.UI;
using Enigma.Memory;

namespace Enigma.D3
{
	[Obsolete]
	public class PortraitData : MemoryObject
	{
		public const int SizeOf = 0x3920; // 14624 TODO: 14752, 0x39A0

		public UIReference x0000_UIRef { get { return Read<UIReference>(0x0000); } } // Root.NormalLayer.portraits.stack.pet_stack.portrait_0
		public UIReference x0208_UIRef { get { return Read<UIReference>(0x0208); } } // Root.NormalLayer.portraits.stack.party_stack.portrait_0.follower_stack.buff_anchor
		public int x0410_PlayerIndex { get { return Read<int>(0x0410); } } // 0
		public int x0414_Index { get { return Read<int>(0x0414); } } // Seems to be -1 unless Party Portrait.
		public int _x0418 { get { return Read<int>(0x0418); } } // 0
		public int _x041C { get { return Read<int>(0x041C); } } // 0
		public int _x0420 { get { return Read<int>(0x0420); } } // 0
		public int _x0424 { get { return Read<int>(0x0424); } } // 0
		public int _x0428 { get { return Read<int>(0x0428); } } // 0
		public int _x042C { get { return Read<int>(0x042C); } } // 0
		public UIReference x0430_UIRef { get { return Read<UIReference>(0x0430); } } // Root.NormalLayer.portraits.stack.party_stack.portrait_0.Background
		public UIReference x0638_UIRef { get { return Read<UIReference>(0x0638); } } // Root.NormalLayer.portraits.stack.party_stack.portrait_0.Banner
		public UIReference x0840_UIRef { get { return Read<UIReference>(0x0840); } } // Root.NormalLayer.portraits.stack.party_stack.portrait_0.icon
		public UIReference x0A48_UIRef { get { return Read<UIReference>(0x0A48); } } // Root.NormalLayer.portraits.stack.party_stack.portrait_0.Frame
		public UIReference x0C50_UIRef { get { return Read<UIReference>(0x0C50); } } // Root.NormalLayer.portraits.stack.party_stack.portrait_0.HealthBar
		public UIReference x0E58_UIRef { get { return Read<UIReference>(0x0E58); } } // Root.NormalLayer.portraits.stack.party_stack.portrait_0.hpbar
		public UIReference x1060_UIRef { get { return Read<UIReference>(0x1060); } } // Root.NormalLayer.portraits.stack.party_stack.portrait_0.leaderIcon
		public UIReference x1268_UIRef { get { return Read<UIReference>(0x1268); } } // Root.NormalLayer.portraits.stack.party_stack.portrait_0.busy
		public UIReference x1470_UIRef { get { return Read<UIReference>(0x1470); } } // Root.NormalLayer.portraits.stack.party_stack.portrait_0.townportal
		public UIReference x1678_UIRef { get { return Read<UIReference>(0x1678); } } // Root.NormalLayer.portraits.stack.party_stack.portrait_0.accept_state
		public UIReference x1880_UIRef { get { return Read<UIReference>(0x1880); } } // Root.NormalLayer.portraits.stack.party_stack.portrait_0.pendingState
		public UIReference x1A88_UIRef { get { return Read<UIReference>(0x1A88); } } // Root.NormalLayer.portraits.stack.party_stack.portrait_0.pendingState.CancelButton
		public UIReference x1C90_UIRef { get { return Read<UIReference>(0x1C90); } } // Root.NormalLayer.portraits.stack.party_stack.portrait_0.InvitePending
		public UIReference x1E98_UIRef { get { return Read<UIReference>(0x1E98); } } // Root.NormalLayer.portraits.stack.party_stack.portrait_0.text
		public UIReference x20A0_UIRef { get { return Read<UIReference>(0x20A0); } } // Root.NormalLayer.portraits.stack.party_stack.portrait_0.level
		public UIReference x22A8_UIRef { get { return Read<UIReference>(0x22A8); } } // Root.NormalLayer.portraits.stack.party_stack.portrait_0.alt_level
		public UIReference x24B0_UIRef { get { return Read<UIReference>(0x24B0); } } // Root.NormalLayer.portraits.stack.party_stack.portrait_0.chapteroptin
		public UIReference x26B8_UIRef { get { return Read<UIReference>(0x26B8); } } // Root.NormalLayer.portraits.stack.party_stack.portrait_0.follower_stack.icon_0
		public UIReference x28C0_UIRef { get { return Read<UIReference>(0x28C0); } } // Root.NormalLayer.portraits.stack.party_stack.portrait_0.follower_stack.icon_1
		public UIReference x2AC8_UIRef { get { return Read<UIReference>(0x2AC8); } } // Root.NormalLayer.portraits.stack.party_stack.portrait_0.gamemode
		public UIReference x2CD0_UIRef { get { return Read<UIReference>(0x2CD0); } } // Root.NormalLayer.portraits.stack.party_stack.portrait_0.HardcoreGlow
		public int _x2ED8 { get { return Read<int>(0x2ED8); } } // 0
		public int _x2EDC { get { return Read<int>(0x2EDC); } } // 0
		public int x2EE0_Color { get { return Read<int>(0x2EE0); } } // -16777217
		public int x2EE4_Color { get { return Read<int>(0x2EE4); } } // -1
		public int _x2EE8 { get { return Read<int>(0x2EE8); } } // -1
		public int x2EEC_Index { get { return Read<int>(0x2EEC); } } // Seems to be -1 unless Pet Portrait.
		public UIReference x2EF0_UIRef { get { return Read<UIReference>(0x2EF0); } } // Root.NormalLayer.portraits.stack.pet_stack.portrait_0.icon
		public UIReference x30F8_UIRef { get { return Read<UIReference>(0x30F8); } } // Root.NormalLayer.portraits.stack.pet_stack.portrait_0.background
		public UIReference x3300_UIRef { get { return Read<UIReference>(0x3300); } } // Root.NormalLayer.portraits.stack.pet_stack.portrait_0.hpbar
		public UIReference x3508_UIRef { get { return Read<UIReference>(0x3508); } } // Root.NormalLayer.portraits.stack.pet_stack.portrait_0.text
		public UIReference x3710_UIRef { get { return Read<UIReference>(0x3710); } } // Root.NormalLayer.portraits.stack.pet_stack.portrait_0.count_text
		public int _x3918 { get { return Read<int>(0x3918); } } // 0
		public int _x391C { get { return Read<int>(0x391C); } } // -1	
	}
}
