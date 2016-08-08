using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3
{
	[Obsolete("Fields most likely wrong. Size is accurate.")]
	public partial class PlayerData : MemoryObject
	{
		public const int SizeOf = Globals.SizeOf_PlayerData;

		public int x0000_Index { get { return Read<int>(0x0000); } }
		public int x0004_AcdId { get { return Read<int>(0x0004); } }
		public int x0008_ActorId { get { return Read<int>(0x0008); } }
		public int x000C_Neg1 { get { return Read<int>(0x000C); } }
		public int x0010_Neg1 { get { return Read<int>(0x0010); } }
		public int x0014_Neg1 { get { return Read<int>(0x0014); } }
		public int x0018_Neg1 { get { return Read<int>(0x0018); } }
		public long x001C_Int64_ { get { return Read<long>(0x001C); } }
		public int x0024 { get { return Read<int>(0x0024); } }
		public int x0028 { get { return Read<int>(0x0028); } }
		public int x002C_Neg1 { get { return Read<int>(0x002C); } }
		public int x0030_Neg1 { get { return Read<int>(0x0030); } }
		public int x0034_Neg1 { get { return Read<int>(0x0034); } }
		public int x0038_Neg1 { get { return Read<int>(0x0038); } }
		public int x003C_Neg1_TeamId { get { return Read<int>(0x003C); } }
		public int x0040_Neg1 { get { return Read<int>(0x0040); } }
		public int x0044_Neg1 { get { return Read<int>(0x0044); } }
		public int x0048 { get { return Read<int>(0x0048); } }
		public int x004C { get { return Read<int>(0x004C); } }
		public int x0050 { get { return Read<int>(0x0050); } }
		public int x0054 { get { return Read<int>(0x0054); } }
		public int x0058 { get { return Read<int>(0x0058); } }
		public int x005C { get { return Read<int>(0x005C); } }
		public int x0060_KillCount { get { return Read<int>(0x0060); } }
		public int x0064_KillCount { get { return Read<int>(0x0064); } }
		public int x0068_KillCount { get { return Read<int>(0x0068); } }
		public int x006C { get { return Read<int>(0x006C); } }
		public int x0070 { get { return Read<int>(0x0070); } }
		public int x0074 { get { return Read<int>(0x0074); } }
		public int x0078 { get { return Read<int>(0x0078); } }
		public int x007C_Neg1 { get { return Read<int>(0x007C); } }
		public int _x0080 { get { return Read<int>(0x0080); } }
		public int _x0084 { get { return Read<int>(0x0084); } }
		public int _x0088 { get { return Read<int>(0x0088); } }
		public int _x008C { get { return Read<int>(0x008C); } }
		public int _x0090 { get { return Read<int>(0x0090); } }
		public int _x0094 { get { return Read<int>(0x0094); } }
		public int _x0098 { get { return Read<int>(0x0098); } }
		public int _x009C { get { return Read<int>(0x009C); } }
		public ServerData x00A0_ServerData { get { return Read<ServerData>(0x00A0); } }
		public int _x4858 { get { return Read<int>(0x4858); } }
		// ...
		public VendorToken[] x88A4_VendorTokens { get { return Read<VendorToken>(0x88A4, 256); } }
		public int x90A4_VendorTokenCount { get { return Read<int>(0x90A4); } }
		public int x90A8_StructStart_Min152Bytes { get { return Read<int>(0x90A8); } }
		public int x90AC { get { return Read<int>(0x90AC); } }
		public long x90B0_ItemTradePlayer { get { return Read<long>(0x90B0); } }
		public int x90B8_String_ { get { return Read<int>(0x90B8); } }
		public int _x90BC { get { return Read<int>(0x90BC); } }
		public int _x90C0 { get { return Read<int>(0x90C0); } }
		public int _x90C4 { get { return Read<int>(0x90C4); } }
		public int _x90C8 { get { return Read<int>(0x90C8); } }
		public int _x90CC { get { return Read<int>(0x90CC); } }
		public int _x90D0 { get { return Read<int>(0x90D0); } }
		public int _x90D4 { get { return Read<int>(0x90D4); } }
		public int _x90D8 { get { return Read<int>(0x90D8); } }
		public int _x90DC { get { return Read<int>(0x90DC); } }
		public int _x90E0 { get { return Read<int>(0x90E0); } }
		public int _x90E4 { get { return Read<int>(0x90E4); } }
		public int _x90E8 { get { return Read<int>(0x90E8); } }
		public int _x90EC { get { return Read<int>(0x90EC); } }
		public int _x90F0 { get { return Read<int>(0x90F0); } }
		public int _x90F4 { get { return Read<int>(0x90F4); } }
		public int _x90F8 { get { return Read<int>(0x90F8); } }
		public int _x90FC { get { return Read<int>(0x90FC); } }
		public int _x9100 { get { return Read<int>(0x9100); } }
		public int _x9104 { get { return Read<int>(0x9104); } }
		public int _x9108 { get { return Read<int>(0x9108); } }
		public int _x910C { get { return Read<int>(0x910C); } }
		public int _x9110 { get { return Read<int>(0x9110); } }
		public int _x9114 { get { return Read<int>(0x9114); } }
		public int _x9118 { get { return Read<int>(0x9118); } }
		public int _x911C { get { return Read<int>(0x911C); } }
		public int _x9120 { get { return Read<int>(0x9120); } }
		public int _x9124 { get { return Read<int>(0x9124); } }
		public int _x9128 { get { return Read<int>(0x9128); } }
		public int _x912C { get { return Read<int>(0x912C); } }
		public int _x9130 { get { return Read<int>(0x9130); } }
		public int _x9134 { get { return Read<int>(0x9134); } }
		public int _x9138 { get { return Read<int>(0x9138); } }
		public int _x913C { get { return Read<int>(0x913C); } }
		public int _x9140 { get { return Read<int>(0x9140); } }
		public int _x9144 { get { return Read<int>(0x9144); } }
		public int _x9148 { get { return Read<int>(0x9148); } }
		public int _x914C { get { return Read<int>(0x914C); } }
		public int _x9150 { get { return Read<int>(0x9150); } }
		public int _x9154 { get { return Read<int>(0x9154); } }
		public int _x9158 { get { return Read<int>(0x9158); } }
		public int _x915C { get { return Read<int>(0x915C); } }
		public int _x9160 { get { return Read<int>(0x9160); } }
		public int _x9164 { get { return Read<int>(0x9164); } }
		public int _x9168 { get { return Read<int>(0x9168); } }
		public int _x916C { get { return Read<int>(0x916C); } }
		public int _x9170 { get { return Read<int>(0x9170); } }
		public int _x9174 { get { return Read<int>(0x9174); } }
		public long x9178 { get { return Read<long>(0x9178); } }
		public long x9180_HeroId { get { return Read<long>(0x9180); } }
		public string x9188_HeroName { get { return ReadString(0x9188, 49); } }
		public string x91B9_Default { get { return ReadString(0x91B9, 7); } }
		public int _x91C0 { get { return Read<int>(0x91C0); } }
		public int _x91C4 { get { return Read<int>(0x91C4); } }
		public int _x91C8 { get { return Read<int>(0x91C8); } }
		public int _x91CC { get { return Read<int>(0x91CC); } }
		public int _x91D0 { get { return Read<int>(0x91D0); } }
		public int _x91D4 { get { return Read<int>(0x91D4); } }
		public int _x91D8 { get { return Read<int>(0x91D8); } }
		public int _x91DC { get { return Read<int>(0x91DC); } }
		public int _x91E0 { get { return Read<int>(0x91E0); } }
		public int _x91E4 { get { return Read<int>(0x91E4); } }
		public int x91E8_GameTick { get { return Read<int>(0x91E8); } }
		public int x91EC_Neg1 { get { return Read<int>(0x91EC); } }
		public int x91F0_Neg1 { get { return Read<int>(0x91F0); } }
		public int x91F4_Neg1 { get { return Read<int>(0x91F4); } }
		public int x91F8 { get { return Read<int>(0x91F8); } }
		public float x91FC_X { get { return Read<float>(0x91FC); } }
		public float x9200_Y { get { return Read<float>(0x9200); } }
		public float x9204_Z { get { return Read<float>(0x9204); } }
		public int x9208_Neg1 { get { return Read<int>(0x9208); } } // Scene or World Entry ID?
		public ListB x920C_ListB { get { return Read<ListB>(0x920C); } }
		public ListB x9220_ListB { get { return Read<ListB>(0x9220); } }
		public ListB x9234_ListB { get { return Read<ListB>(0x9234); } }
		public int x9248 { get { return Read<int>(0x9248); } }
		public int _x924C { get { return Read<int>(0x924C); } }
		public int x9250_Neg1_PlayerAcdId { get { return Read<int>(0x9250); } }
		public int x9254 { get { return Read<int>(0x9254); } }
		public int x9258_Neg1_PlayerAcdId { get { return Read<int>(0x9258); } }
		public int _x925C { get { return Read<int>(0x925C); } }
		public int x9260 { get { return Read<int>(0x9260); } }
		public int x9264 { get { return Read<int>(0x9264); } }
		public int x9268 { get { return Read<int>(0x9268); } }
		public int x926C_Neg1_ArrayStart_AnnId { get { return Read<int>(0x926C); } }
		public int x9270_Neg1 { get { return Read<int>(0x9270); } }
		public int x9274_Neg1 { get { return Read<int>(0x9274); } }
		public int x9278_Neg1 { get { return Read<int>(0x9278); } }
		public int x927C_Neg1 { get { return Read<int>(0x927C); } }
		public int x9280_StructStart_Min4Bytes { get { return Read<int>(0x9280); } }
		public int x9284_Neg1 { get { return Read<int>(0x9284); } }
		public int x9288_Neg1 { get { return Read<int>(0x9288); } }
		public int _x928C { get { return Read<int>(0x928C); } }
		public int _x9290 { get { return Read<int>(0x9290); } }
		public int _x9294 { get { return Read<int>(0x9294); } }
		public int x9298_Neg1 { get { return Read<int>(0x9298); } }
		public int _x929C { get { return Read<int>(0x929C); } }
		public int _x92A0 { get { return Read<int>(0x92A0); } }
		public int _x92A4 { get { return Read<int>(0x92A4); } }
		public int _x92A8 { get { return Read<int>(0x92A8); } }
		public int _x92AC { get { return Read<int>(0x92AC); } }
		public int _x92B0 { get { return Read<int>(0x92B0); } }
		public int _x92B4 { get { return Read<int>(0x92B4); } }
		public int _x92B8 { get { return Read<int>(0x92B8); } }
		public int _x92BC { get { return Read<int>(0x92BC); } }
		public int _x92C0 { get { return Read<int>(0x92C0); } }
		public byte[] x92C4_StructStart_128Bytes { get { return Read<byte>(0x92C4, 128); } }
		[ArraySize(64)]
		public XC084[] x9344_Array { get { return Read<XC084>(0x9344, 64); } }
		public int x9544_Neg1 { get { return Read<int>(0x9544); } }
		public int x9548_StructStart_Min232Bytes { get { return Read<int>(0x9548); } }
		public int x954C_StructStart { get { return Read<int>(0x954C); } }
		public int x9550_StructStart { get { return Read<int>(0x9550); } }
		public int _x9554 { get { return Read<int>(0x9554); } }
		public int _x9558 { get { return Read<int>(0x9558); } }
		public int _x955C { get { return Read<int>(0x955C); } }
		public int _x9560 { get { return Read<int>(0x9560); } }
		public int _x9564 { get { return Read<int>(0x9564); } }
		public int _x9568 { get { return Read<int>(0x9568); } }
		public int _x956C { get { return Read<int>(0x956C); } }
		public int _x9570 { get { return Read<int>(0x9570); } }
		public int _x9574 { get { return Read<int>(0x9574); } }
		public int _x9578 { get { return Read<int>(0x9578); } }
		public int _x957C { get { return Read<int>(0x957C); } }
		public int _x9580 { get { return Read<int>(0x9580); } }
		public int _x9584 { get { return Read<int>(0x9584); } }
		public int _x9588 { get { return Read<int>(0x9588); } }
		public int _x958C { get { return Read<int>(0x958C); } }
		public int _x9590 { get { return Read<int>(0x9590); } }
		public int _x9594 { get { return Read<int>(0x9594); } }
		public int _x9598 { get { return Read<int>(0x9598); } }
		public int _x959C { get { return Read<int>(0x959C); } }
		public int _x95A0 { get { return Read<int>(0x95A0); } }
		public int _x95A4 { get { return Read<int>(0x95A4); } }
		public int _x95A8 { get { return Read<int>(0x95A8); } }
		public int _x95AC { get { return Read<int>(0x95AC); } }
		public int _x95B0 { get { return Read<int>(0x95B0); } }
		public int _x95B4 { get { return Read<int>(0x95B4); } }
		public int _x95B8 { get { return Read<int>(0x95B8); } }
		public int _x95BC { get { return Read<int>(0x95BC); } }
		public int _x95C0 { get { return Read<int>(0x95C0); } }
		public int _x95C4 { get { return Read<int>(0x95C4); } }
		public int _x95C8 { get { return Read<int>(0x95C8); } }
		public int _x95CC { get { return Read<int>(0x95CC); } }
		public int _x95D0 { get { return Read<int>(0x95D0); } }
		public int _x95D4 { get { return Read<int>(0x95D4); } }
		public int _x95D8 { get { return Read<int>(0x95D8); } }
		public int _x95DC { get { return Read<int>(0x95DC); } }
		public int _x95E0 { get { return Read<int>(0x95E0); } }
		public int _x95E4 { get { return Read<int>(0x95E4); } }
		public int _x95E8 { get { return Read<int>(0x95E8); } }
		public int _x95EC { get { return Read<int>(0x95EC); } }
		public int _x95F0 { get { return Read<int>(0x95F0); } }
		public int _x95F4 { get { return Read<int>(0x95F4); } }
		public int _x95F8 { get { return Read<int>(0x95F8); } }
		public int _x95FC { get { return Read<int>(0x95FC); } }
		public int _x9600 { get { return Read<int>(0x9600); } }
		public int _x9604 { get { return Read<int>(0x9604); } }
		public int _x9608 { get { return Read<int>(0x9608); } }
		public int _x960C { get { return Read<int>(0x960C); } }
		public int _x9610 { get { return Read<int>(0x9610); } }
		public int _x9614 { get { return Read<int>(0x9614); } }
		public int _x9618 { get { return Read<int>(0x9618); } }
		public int _x961C { get { return Read<int>(0x961C); } }
		public int _x9620 { get { return Read<int>(0x9620); } }
		public int _x9624 { get { return Read<int>(0x9624); } }
		public int _x9628 { get { return Read<int>(0x9628); } }
		public int _x962C { get { return Read<int>(0x962C); } }
		public int x9630_Neg1 { get { return Read<int>(0x9630); } }
		public int x9634 { get { return Read<int>(0x9634); } }
		public int x9638 { get { return Read<int>(0x9638); } }
		public int x963C_ActorSnoId { get { return Read<int>(0x963C); } }
		public float x9640_LifePercentage { get { return Read<float>(0x9640); } }
		public int x9644_LevelAreaSnoId { get { return Read<int>(0x9644); } }
		public int x9648_LevelAreaSnoId { get { return Read<int>(0x9648); } }
		public int x964C_HeroClass { get { return Read<int>(0x964C); } }
		public int x9650_Level { get { return Read<int>(0x9650); } }
		public int x9654_AltLevel { get { return Read<int>(0x9654); } }
		public int x9658 { get { return Read<int>(0x9658); } }
		public int _x965C { get { return Read<int>(0x965C); } }
		public ListB x9660_List8B { get { return Read<ListB>(0x9660); } }
		public int _x9674 { get { return Read<int>(0x9674); } }
		public int x9678_StructStart_Min252Bytes { get { return Read<int>(0x9678); } }
		public int _x967C { get { return Read<int>(0x967C); } }
		public int _x9680 { get { return Read<int>(0x9680); } }
		public int _x9684 { get { return Read<int>(0x9684); } }
		public int _x9688 { get { return Read<int>(0x9688); } }
		public int _x968C { get { return Read<int>(0x968C); } }
		public int _x9690 { get { return Read<int>(0x9690); } }
		public int _x9694 { get { return Read<int>(0x9694); } }
		public int _x9698 { get { return Read<int>(0x9698); } }
		public int _x969C { get { return Read<int>(0x969C); } }
		public int _x96A0 { get { return Read<int>(0x96A0); } }
		public int _x96A4 { get { return Read<int>(0x96A4); } }
		public int _x96A8 { get { return Read<int>(0x96A8); } }
		public int _x96AC { get { return Read<int>(0x96AC); } }
		public int _x96B0 { get { return Read<int>(0x96B0); } }
		public int _x96B4 { get { return Read<int>(0x96B4); } }
		public int _x96B8 { get { return Read<int>(0x96B8); } }
		public int _x96BC { get { return Read<int>(0x96BC); } }
		public int _x96C0 { get { return Read<int>(0x96C0); } }
		public int _x96C4 { get { return Read<int>(0x96C4); } }
		public int _x96C8 { get { return Read<int>(0x96C8); } }
		public int _x96CC { get { return Read<int>(0x96CC); } }
		public int _x96D0 { get { return Read<int>(0x96D0); } }
		public int _x96D4 { get { return Read<int>(0x96D4); } }
		public int _x96D8 { get { return Read<int>(0x96D8); } }
		public int _x96DC { get { return Read<int>(0x96DC); } }
		public int _x96E0 { get { return Read<int>(0x96E0); } }
		public int _x96E4 { get { return Read<int>(0x96E4); } }
		public int _x96E8 { get { return Read<int>(0x96E8); } }
		public int _x96EC { get { return Read<int>(0x96EC); } }
		public int _x96F0 { get { return Read<int>(0x96F0); } }
		public int _x96F4 { get { return Read<int>(0x96F4); } }
		public int _x96F8 { get { return Read<int>(0x96F8); } }
		public int _x96FC { get { return Read<int>(0x96FC); } }
		public int _x9700 { get { return Read<int>(0x9700); } }
		public int _x9704 { get { return Read<int>(0x9704); } }
		public int _x9708 { get { return Read<int>(0x9708); } }
		public int _x970C { get { return Read<int>(0x970C); } }
		public int _x9710 { get { return Read<int>(0x9710); } }
		public int _x9714 { get { return Read<int>(0x9714); } }
		public int _x9718 { get { return Read<int>(0x9718); } }
		public int _x971C { get { return Read<int>(0x971C); } }
		public int _x9720 { get { return Read<int>(0x9720); } }
		public int _x9724 { get { return Read<int>(0x9724); } }
		public int _x9728 { get { return Read<int>(0x9728); } }
		public int _x972C { get { return Read<int>(0x972C); } }
		public int _x9730 { get { return Read<int>(0x9730); } }
		public int _x9734 { get { return Read<int>(0x9734); } }
		public int _x9738 { get { return Read<int>(0x9738); } }
		public int _x973C { get { return Read<int>(0x973C); } }
		public int _x9740 { get { return Read<int>(0x9740); } }
		public int _x9744 { get { return Read<int>(0x9744); } }
		public int _x9748 { get { return Read<int>(0x9748); } }
		public int _x974C { get { return Read<int>(0x974C); } }
		public int _x9750 { get { return Read<int>(0x9750); } }
		public int _x9754 { get { return Read<int>(0x9754); } }
		public int _x9758 { get { return Read<int>(0x9758); } }
		public int _x975C { get { return Read<int>(0x975C); } }
		public int _x9760 { get { return Read<int>(0x9760); } }
		public int _x9764 { get { return Read<int>(0x9764); } }
		public int _x9768 { get { return Read<int>(0x9768); } }
		public int _x976C { get { return Read<int>(0x976C); } }
		public int _x9770 { get { return Read<int>(0x9770); } }
		public int _x9774 { get { return Read<int>(0x9774); } }
		public int _x9778 { get { return Read<int>(0x9778); } }
		public int _x977C { get { return Read<int>(0x977C); } }
		public int _x9780 { get { return Read<int>(0x9780); } }
		public int _x9784 { get { return Read<int>(0x9784); } }
		public int _x9788 { get { return Read<int>(0x9788); } }
		public int _x978C { get { return Read<int>(0x978C); } }
		public int _x9790 { get { return Read<int>(0x9790); } }
		public int _x9794 { get { return Read<int>(0x9794); } }
		public int _x9798 { get { return Read<int>(0x9798); } }
		public int _x979C { get { return Read<int>(0x979C); } }
		public int _x97A0 { get { return Read<int>(0x97A0); } }
		public int _x97A4 { get { return Read<int>(0x97A4); } }
		public int _x97A8 { get { return Read<int>(0x97A8); } }
		public int _x97AC { get { return Read<int>(0x97AC); } }
		public int _x97B0 { get { return Read<int>(0x97B0); } }
		public int _x97B4 { get { return Read<int>(0x97B4); } }
		public int _x97B8 { get { return Read<int>(0x97B8); } }
		public int _x97BC { get { return Read<int>(0x97BC); } }
		public int _x97C0 { get { return Read<int>(0x97C0); } }
		public int _x97C4 { get { return Read<int>(0x97C4); } }
		public int _x97C8 { get { return Read<int>(0x97C8); } }
		public int _x97CC { get { return Read<int>(0x97CC); } }
		public int _x97D0 { get { return Read<int>(0x97D0); } }
		public int _x97D4 { get { return Read<int>(0x97D4); } }
		public int _x97D8 { get { return Read<int>(0x97D8); } }
		public int _x97DC { get { return Read<int>(0x97DC); } }
		public int _x97E0 { get { return Read<int>(0x97E0); } }
		public int _x97E4 { get { return Read<int>(0x97E4); } }
		public int _x97E8 { get { return Read<int>(0x97E8); } }
		public int _x97EC { get { return Read<int>(0x97EC); } }
		public int _x97F0 { get { return Read<int>(0x97F0); } }
		public int _x97F4 { get { return Read<int>(0x97F4); } }
		public int _x97F8 { get { return Read<int>(0x97F8); } }
		public int _x97FC { get { return Read<int>(0x97FC); } }
		public int _x9800 { get { return Read<int>(0x9800); } }
		public int _x9804 { get { return Read<int>(0x9804); } }
		public int _x9808 { get { return Read<int>(0x9808); } }
		public int _x980C { get { return Read<int>(0x980C); } }
		public int _x9810 { get { return Read<int>(0x9810); } }
		public int _x9814 { get { return Read<int>(0x9814); } }
		public int _x9818 { get { return Read<int>(0x9818); } }
		public int _x981C { get { return Read<int>(0x981C); } }
		public int _x9820 { get { return Read<int>(0x9820); } }
		public int _x9824 { get { return Read<int>(0x9824); } }
		public int _x9828 { get { return Read<int>(0x9828); } }
		public int _x982C { get { return Read<int>(0x982C); } }
		public int _x9830 { get { return Read<int>(0x9830); } }
		public int _x9834 { get { return Read<int>(0x9834); } }
		public int _x9838 { get { return Read<int>(0x9838); } }
		public int _x983C { get { return Read<int>(0x983C); } }
		public int _x9840 { get { return Read<int>(0x9840); } }
		public int _x9844 { get { return Read<int>(0x9844); } }
		public int _x9848 { get { return Read<int>(0x9848); } }
		public int _x984C { get { return Read<int>(0x984C); } }
		public int _x9850 { get { return Read<int>(0x9850); } }
		public int _x9854 { get { return Read<int>(0x9854); } }
		public int _x9858 { get { return Read<int>(0x9858); } }
		public int _x985C { get { return Read<int>(0x985C); } }
		public int _x9860 { get { return Read<int>(0x9860); } }
		public int _x9864 { get { return Read<int>(0x9864); } }
		public int _x9868 { get { return Read<int>(0x9868); } }
		public int _x986C { get { return Read<int>(0x986C); } }
		public int _x9870 { get { return Read<int>(0x9870); } }
		public int _x9874 { get { return Read<int>(0x9874); } }
		public int _x9878 { get { return Read<int>(0x9878); } }
		public int _x987C { get { return Read<int>(0x987C); } }
		public int _x9880 { get { return Read<int>(0x9880); } }
		public int _x9884 { get { return Read<int>(0x9884); } }
		public int _x9888 { get { return Read<int>(0x9888); } }
		public int _x988C { get { return Read<int>(0x988C); } }
		public int _x9890 { get { return Read<int>(0x9890); } }
		public int _x9894 { get { return Read<int>(0x9894); } }
		public int _x9898 { get { return Read<int>(0x9898); } }
		public int _x989C { get { return Read<int>(0x989C); } }
		public int _x98A0 { get { return Read<int>(0x98A0); } }
		public int _x98A4 { get { return Read<int>(0x98A4); } }
		public int _x98A8 { get { return Read<int>(0x98A8); } }
		public int _x98AC { get { return Read<int>(0x98AC); } }
		public int _x98B0 { get { return Read<int>(0x98B0); } }
		public int _x98B4 { get { return Read<int>(0x98B4); } }
		public int _x98B8 { get { return Read<int>(0x98B8); } }
		public int _x98BC { get { return Read<int>(0x98BC); } }
		public int _x98C0 { get { return Read<int>(0x98C0); } }
		public int _x98C4 { get { return Read<int>(0x98C4); } }
		public int _x98C8 { get { return Read<int>(0x98C8); } }
		public int _x98CC { get { return Read<int>(0x98CC); } }
		public int _x98D0 { get { return Read<int>(0x98D0); } }
		public int _x98D4 { get { return Read<int>(0x98D4); } }
		public int _x98D8 { get { return Read<int>(0x98D8); } }
		public int _x98DC { get { return Read<int>(0x98DC); } }
		public int _x98E0 { get { return Read<int>(0x98E0); } }
		public int _x98E4 { get { return Read<int>(0x98E4); } }
		public int _x98E8 { get { return Read<int>(0x98E8); } }
		public int _x98EC { get { return Read<int>(0x98EC); } }
		public int _x98F0 { get { return Read<int>(0x98F0); } }
		public int _x98F4 { get { return Read<int>(0x98F4); } }
		public int _x98F8 { get { return Read<int>(0x98F8); } }
		public int _x98FC { get { return Read<int>(0x98FC); } }
		public int _x9900 { get { return Read<int>(0x9900); } }
		public int _x9904 { get { return Read<int>(0x9904); } }
		public int _x9908 { get { return Read<int>(0x9908); } }
		public int _x990C { get { return Read<int>(0x990C); } }
		public int _x9910 { get { return Read<int>(0x9910); } }
		public int _x9914 { get { return Read<int>(0x9914); } }
		public int _x9918 { get { return Read<int>(0x9918); } }
		public int _x991C { get { return Read<int>(0x991C); } }
		public int _x9920 { get { return Read<int>(0x9920); } }
		public int _x9924 { get { return Read<int>(0x9924); } }
		public int _x9928 { get { return Read<int>(0x9928); } }
		public int _x992C { get { return Read<int>(0x992C); } }
		public int _x9930 { get { return Read<int>(0x9930); } }
		public int _x9934 { get { return Read<int>(0x9934); } }
		public int _x9938 { get { return Read<int>(0x9938); } }
		public int _x993C { get { return Read<int>(0x993C); } }
		public int _x9940 { get { return Read<int>(0x9940); } }
		public int _x9944 { get { return Read<int>(0x9944); } }
		public int _x9948 { get { return Read<int>(0x9948); } }
		public int _x994C { get { return Read<int>(0x994C); } }
		public int _x9950 { get { return Read<int>(0x9950); } }
		public int _x9954 { get { return Read<int>(0x9954); } }
		public int _x9958 { get { return Read<int>(0x9958); } }
		public int _x995C { get { return Read<int>(0x995C); } }
		public int _x9960 { get { return Read<int>(0x9960); } }
		public int _x9964 { get { return Read<int>(0x9964); } }
		public int _x9968 { get { return Read<int>(0x9968); } }
		public int _x996C { get { return Read<int>(0x996C); } }
		public int _x9970 { get { return Read<int>(0x9970); } }
		public int _x9974 { get { return Read<int>(0x9974); } }
		public int _x9978 { get { return Read<int>(0x9978); } }
		public int _x997C { get { return Read<int>(0x997C); } }
		public int _x9980 { get { return Read<int>(0x9980); } }
		public int _x9984 { get { return Read<int>(0x9984); } }
		public int _x9988 { get { return Read<int>(0x9988); } }
		public int _x998C { get { return Read<int>(0x998C); } }
		public int _x9990 { get { return Read<int>(0x9990); } }
		public int _x9994 { get { return Read<int>(0x9994); } }
		public int _x9998 { get { return Read<int>(0x9998); } }
		public int _x999C { get { return Read<int>(0x999C); } }
		public int _x99A0 { get { return Read<int>(0x99A0); } }
		public int _x99A4 { get { return Read<int>(0x99A4); } }
		public int _x99A8 { get { return Read<int>(0x99A8); } }
		public int _x99AC { get { return Read<int>(0x99AC); } }
		public int _x99B0 { get { return Read<int>(0x99B0); } }
		public int _x99B4 { get { return Read<int>(0x99B4); } }
		public int _x99B8 { get { return Read<int>(0x99B8); } }
		public int _x99BC { get { return Read<int>(0x99BC); } }
		public int _x99C0 { get { return Read<int>(0x99C0); } }
		public int _x99C4 { get { return Read<int>(0x99C4); } }
		public int _x99C8 { get { return Read<int>(0x99C8); } }
		public int _x99CC { get { return Read<int>(0x99CC); } }
		public int _x99D0 { get { return Read<int>(0x99D0); } }
		public int _x99D4 { get { return Read<int>(0x99D4); } }
		public int _x99D8 { get { return Read<int>(0x99D8); } }
		public int _x99DC { get { return Read<int>(0x99DC); } }
		public int _x99E0 { get { return Read<int>(0x99E0); } }
		public int _x99E4 { get { return Read<int>(0x99E4); } }
		public int _x99E8 { get { return Read<int>(0x99E8); } }
		public int _x99EC { get { return Read<int>(0x99EC); } }
		public int _x99F0 { get { return Read<int>(0x99F0); } }
		public int _x99F4 { get { return Read<int>(0x99F4); } }
		public int _x99F8 { get { return Read<int>(0x99F8); } }
		public int _x99FC { get { return Read<int>(0x99FC); } }
		public int _x9A00 { get { return Read<int>(0x9A00); } }
		public int _x9A04 { get { return Read<int>(0x9A04); } }
		public int _x9A08 { get { return Read<int>(0x9A08); } }
		public int _x9A0C { get { return Read<int>(0x9A0C); } }
		public int _x9A10 { get { return Read<int>(0x9A10); } }
		public int _x9A14 { get { return Read<int>(0x9A14); } }
		public int _x9A18 { get { return Read<int>(0x9A18); } }
		public int _x9A1C { get { return Read<int>(0x9A1C); } }
		public int _x9A20 { get { return Read<int>(0x9A20); } }
		public int _x9A24 { get { return Read<int>(0x9A24); } }
		public int _x9A28 { get { return Read<int>(0x9A28); } }
		public int _x9A2C { get { return Read<int>(0x9A2C); } }
		public int _x9A30 { get { return Read<int>(0x9A30); } }
		public int _x9A34 { get { return Read<int>(0x9A34); } }
		public int _x9A38 { get { return Read<int>(0x9A38); } }
		public int _x9A3C { get { return Read<int>(0x9A3C); } }
		public int _x9A40 { get { return Read<int>(0x9A40); } }
		public int _x9A44 { get { return Read<int>(0x9A44); } }
		public int _x9A48 { get { return Read<int>(0x9A48); } }
		public int _x9A4C { get { return Read<int>(0x9A4C); } }
		public int _x9A50 { get { return Read<int>(0x9A50); } }
		public int _x9A54 { get { return Read<int>(0x9A54); } }
		public int _x9A58 { get { return Read<int>(0x9A58); } }
		public int _x9A5C { get { return Read<int>(0x9A5C); } }
		public int _x9A60 { get { return Read<int>(0x9A60); } }
		public int _x9A64 { get { return Read<int>(0x9A64); } }
		public int _x9A68 { get { return Read<int>(0x9A68); } }
		public int _x9A6C { get { return Read<int>(0x9A6C); } }
		public int _x9A70 { get { return Read<int>(0x9A70); } }
		public int _x9A74 { get { return Read<int>(0x9A74); } }
		public int _x9A78 { get { return Read<int>(0x9A78); } }
		public int _x9A7C { get { return Read<int>(0x9A7C); } }
		public int _x9A80 { get { return Read<int>(0x9A80); } }
		public int _x9A84 { get { return Read<int>(0x9A84); } }
		public int _x9A88 { get { return Read<int>(0x9A88); } }
		public int _x9A8C { get { return Read<int>(0x9A8C); } }
		public int _x9A90 { get { return Read<int>(0x9A90); } }
		public int _x9A94 { get { return Read<int>(0x9A94); } }
		public int _x9A98 { get { return Read<int>(0x9A98); } }
		public int _x9A9C { get { return Read<int>(0x9A9C); } }
		public int _x9AA0 { get { return Read<int>(0x9AA0); } }
		public int _x9AA4 { get { return Read<int>(0x9AA4); } }
		public int _x9AA8 { get { return Read<int>(0x9AA8); } }
		public int _x9AAC { get { return Read<int>(0x9AAC); } }
		public int _x9AB0 { get { return Read<int>(0x9AB0); } }
		public int _x9AB4 { get { return Read<int>(0x9AB4); } }
		public int _x9AB8 { get { return Read<int>(0x9AB8); } }
		public int _x9ABC { get { return Read<int>(0x9ABC); } }
		public int _x9AC0 { get { return Read<int>(0x9AC0); } }
		public int _x9AC4 { get { return Read<int>(0x9AC4); } }
		public int _x9AC8 { get { return Read<int>(0x9AC8); } }
		public int _x9ACC { get { return Read<int>(0x9ACC); } }
		public int _x9AD0 { get { return Read<int>(0x9AD0); } }
		public int _x9AD4 { get { return Read<int>(0x9AD4); } }
		public int _x9AD8 { get { return Read<int>(0x9AD8); } }
		public int _x9ADC { get { return Read<int>(0x9ADC); } }
		public int _x9AE0 { get { return Read<int>(0x9AE0); } }
		public int _x9AE4 { get { return Read<int>(0x9AE4); } }
		public int _x9AE8 { get { return Read<int>(0x9AE8); } }
		public int _x9AEC { get { return Read<int>(0x9AEC); } }
		public int _x9AF0 { get { return Read<int>(0x9AF0); } }
		public int _x9AF4 { get { return Read<int>(0x9AF4); } }
		public int _x9AF8 { get { return Read<int>(0x9AF8); } }
		public int _x9AFC { get { return Read<int>(0x9AFC); } }
		public int _x9B00 { get { return Read<int>(0x9B00); } }
		public int _x9B04 { get { return Read<int>(0x9B04); } }
		public int _x9B08 { get { return Read<int>(0x9B08); } }
		public int _x9B0C { get { return Read<int>(0x9B0C); } }
		public int _x9B10 { get { return Read<int>(0x9B10); } }
		public int _x9B14 { get { return Read<int>(0x9B14); } }
		public int _x9B18 { get { return Read<int>(0x9B18); } }
		public int _x9B1C { get { return Read<int>(0x9B1C); } }
		public int _x9B20 { get { return Read<int>(0x9B20); } }
		public int _x9B24 { get { return Read<int>(0x9B24); } }
		public int _x9B28 { get { return Read<int>(0x9B28); } }
		public int _x9B2C { get { return Read<int>(0x9B2C); } }
		public int _x9B30 { get { return Read<int>(0x9B30); } }
		public int _x9B34 { get { return Read<int>(0x9B34); } }
		public int _x9B38 { get { return Read<int>(0x9B38); } }
		public int _x9B3C { get { return Read<int>(0x9B3C); } }
		public int _x9B40 { get { return Read<int>(0x9B40); } }
		public int _x9B44 { get { return Read<int>(0x9B44); } }
		public int _x9B48 { get { return Read<int>(0x9B48); } }
		public int _x9B4C { get { return Read<int>(0x9B4C); } }
		public int _x9B50 { get { return Read<int>(0x9B50); } }
		public int _x9B54 { get { return Read<int>(0x9B54); } }
		public int _x9B58 { get { return Read<int>(0x9B58); } }
		public int _x9B5C { get { return Read<int>(0x9B5C); } }
		public int _x9B60 { get { return Read<int>(0x9B60); } }
		public int _x9B64 { get { return Read<int>(0x9B64); } }
		public int _x9B68 { get { return Read<int>(0x9B68); } }
		public int _x9B6C { get { return Read<int>(0x9B6C); } }
		public int _x9B70 { get { return Read<int>(0x9B70); } }
		public int _x9B74 { get { return Read<int>(0x9B74); } }
		public int _x9B78 { get { return Read<int>(0x9B78); } }
		public int _x9B7C { get { return Read<int>(0x9B7C); } }
		public int _x9B80 { get { return Read<int>(0x9B80); } }
		public int _x9B84 { get { return Read<int>(0x9B84); } }
		public int _x9B88 { get { return Read<int>(0x9B88); } }
		public int _x9B8C { get { return Read<int>(0x9B8C); } }
		public int _x9B90 { get { return Read<int>(0x9B90); } }
		public int _x9B94 { get { return Read<int>(0x9B94); } }
		public int _x9B98 { get { return Read<int>(0x9B98); } }
		public int _x9B9C { get { return Read<int>(0x9B9C); } }
		public int _x9BA0 { get { return Read<int>(0x9BA0); } }
		public int _x9BA4 { get { return Read<int>(0x9BA4); } }
		public int _x9BA8 { get { return Read<int>(0x9BA8); } }
		public int _x9BAC { get { return Read<int>(0x9BAC); } }
		public int _x9BB0 { get { return Read<int>(0x9BB0); } }
		public int _x9BB4 { get { return Read<int>(0x9BB4); } }
		public int _x9BB8 { get { return Read<int>(0x9BB8); } }
		public int _x9BBC { get { return Read<int>(0x9BBC); } }
		public int _x9BC0 { get { return Read<int>(0x9BC0); } }
		public int _x9BC4 { get { return Read<int>(0x9BC4); } }
		public int _x9BC8 { get { return Read<int>(0x9BC8); } }
		public int _x9BCC { get { return Read<int>(0x9BCC); } }
		public int _x9BD0 { get { return Read<int>(0x9BD0); } }
		public int _x9BD4 { get { return Read<int>(0x9BD4); } }
		public int _x9BD8 { get { return Read<int>(0x9BD8); } }
		public int _x9BDC { get { return Read<int>(0x9BDC); } }
		public int _x9BE0 { get { return Read<int>(0x9BE0); } }
		public int _x9BE4 { get { return Read<int>(0x9BE4); } }
		public int _x9BE8 { get { return Read<int>(0x9BE8); } }
		public int _x9BEC { get { return Read<int>(0x9BEC); } }
		public int _x9BF0 { get { return Read<int>(0x9BF0); } }
		public int _x9BF4 { get { return Read<int>(0x9BF4); } }
		public int _x9BF8 { get { return Read<int>(0x9BF8); } }
		public int _x9BFC { get { return Read<int>(0x9BFC); } }
		public int _x9C00 { get { return Read<int>(0x9C00); } }
		public int _x9C04 { get { return Read<int>(0x9C04); } }
		public int _x9C08 { get { return Read<int>(0x9C08); } }
		public int _x9C0C { get { return Read<int>(0x9C0C); } }
		public int _x9C10 { get { return Read<int>(0x9C10); } }
		public int _x9C14 { get { return Read<int>(0x9C14); } }
		public int _x9C18 { get { return Read<int>(0x9C18); } }
		public int _x9C1C { get { return Read<int>(0x9C1C); } }
		public int _x9C20 { get { return Read<int>(0x9C20); } }
		public int _x9C24 { get { return Read<int>(0x9C24); } }
		public int _x9C28 { get { return Read<int>(0x9C28); } }
		public int _x9C2C { get { return Read<int>(0x9C2C); } }
		public int _x9C30 { get { return Read<int>(0x9C30); } }
		public int _x9C34 { get { return Read<int>(0x9C34); } }
		public int _x9C38 { get { return Read<int>(0x9C38); } }
		public int _x9C3C { get { return Read<int>(0x9C3C); } }
		public int _x9C40 { get { return Read<int>(0x9C40); } }
		public int _x9C44 { get { return Read<int>(0x9C44); } }
		public int _x9C48 { get { return Read<int>(0x9C48); } }
		public int _x9C4C { get { return Read<int>(0x9C4C); } }
		public int _x9C50 { get { return Read<int>(0x9C50); } }
		public int _x9C54 { get { return Read<int>(0x9C54); } }
		public int _x9C58 { get { return Read<int>(0x9C58); } }
		public int _x9C5C { get { return Read<int>(0x9C5C); } }
		public int _x9C60 { get { return Read<int>(0x9C60); } }
		public int _x9C64 { get { return Read<int>(0x9C64); } }
		public int _x9C68 { get { return Read<int>(0x9C68); } }
		public int _x9C6C { get { return Read<int>(0x9C6C); } }
		public int _x9C70 { get { return Read<int>(0x9C70); } }
		public int _x9C74 { get { return Read<int>(0x9C74); } }
		public int _x9C78 { get { return Read<int>(0x9C78); } }
		public int _x9C7C { get { return Read<int>(0x9C7C); } }
		public int _x9C80 { get { return Read<int>(0x9C80); } }
		public int _x9C84 { get { return Read<int>(0x9C84); } }
		public int _x9C88 { get { return Read<int>(0x9C88); } }
		public int _x9C8C { get { return Read<int>(0x9C8C); } }
		public int _x9C90 { get { return Read<int>(0x9C90); } }
		public int _x9C94 { get { return Read<int>(0x9C94); } }
		public int _x9C98 { get { return Read<int>(0x9C98); } }
		public int _x9C9C { get { return Read<int>(0x9C9C); } }
		public int _x9CA0 { get { return Read<int>(0x9CA0); } }
		public int _x9CA4 { get { return Read<int>(0x9CA4); } }
		public int _x9CA8 { get { return Read<int>(0x9CA8); } }
		public int _x9CAC { get { return Read<int>(0x9CAC); } }
		public int _x9CB0 { get { return Read<int>(0x9CB0); } }
		public int _x9CB4 { get { return Read<int>(0x9CB4); } }
		public int _x9CB8 { get { return Read<int>(0x9CB8); } }
		public int _x9CBC { get { return Read<int>(0x9CBC); } }
		public int _x9CC0 { get { return Read<int>(0x9CC0); } }
		public int _x9CC4 { get { return Read<int>(0x9CC4); } }
		public int _x9CC8 { get { return Read<int>(0x9CC8); } }
		public int _x9CCC { get { return Read<int>(0x9CCC); } }
		public int _x9CD0 { get { return Read<int>(0x9CD0); } }
		public int _x9CD4 { get { return Read<int>(0x9CD4); } }
		public int _x9CD8 { get { return Read<int>(0x9CD8); } }
		public int _x9CDC { get { return Read<int>(0x9CDC); } }
		public int _x9CE0 { get { return Read<int>(0x9CE0); } }
		public int _x9CE4 { get { return Read<int>(0x9CE4); } }
		public int _x9CE8 { get { return Read<int>(0x9CE8); } }
		public int _x9CEC { get { return Read<int>(0x9CEC); } }
		public int _x9CF0 { get { return Read<int>(0x9CF0); } }
		public int _x9CF4 { get { return Read<int>(0x9CF4); } }
		public int _x9CF8 { get { return Read<int>(0x9CF8); } }
		public int _x9CFC { get { return Read<int>(0x9CFC); } }
		public int _x9D00 { get { return Read<int>(0x9D00); } }
		public int _x9D04 { get { return Read<int>(0x9D04); } }
		public int _x9D08 { get { return Read<int>(0x9D08); } }
		public int _x9D0C { get { return Read<int>(0x9D0C); } }
		public int _x9D10 { get { return Read<int>(0x9D10); } }
		public int _x9D14 { get { return Read<int>(0x9D14); } }
		public int _x9D18 { get { return Read<int>(0x9D18); } }
		public int _x9D1C { get { return Read<int>(0x9D1C); } }
		public int _x9D20 { get { return Read<int>(0x9D20); } }
		public int _x9D24 { get { return Read<int>(0x9D24); } }
		public int _x9D28 { get { return Read<int>(0x9D28); } }
		public int _x9D2C { get { return Read<int>(0x9D2C); } }
		public int _x9D30 { get { return Read<int>(0x9D30); } }
		public int _x9D34 { get { return Read<int>(0x9D34); } }
		public int _x9D38 { get { return Read<int>(0x9D38); } }
		public int _x9D3C { get { return Read<int>(0x9D3C); } }
		public int _x9D40 { get { return Read<int>(0x9D40); } }
		public int _x9D44 { get { return Read<int>(0x9D44); } }
		public int _x9D48 { get { return Read<int>(0x9D48); } }
		public int _x9D4C { get { return Read<int>(0x9D4C); } }
		public int _x9D50 { get { return Read<int>(0x9D50); } }
		public int _x9D54 { get { return Read<int>(0x9D54); } }
		public int _x9D58 { get { return Read<int>(0x9D58); } }
		public int _x9D5C { get { return Read<int>(0x9D5C); } }
		public int _x9D60 { get { return Read<int>(0x9D60); } }
		public int _x9D64 { get { return Read<int>(0x9D64); } }
		public int _x9D68 { get { return Read<int>(0x9D68); } }
		public int _x9D6C { get { return Read<int>(0x9D6C); } }
		public int _x9D70 { get { return Read<int>(0x9D70); } }
		public int _x9D74 { get { return Read<int>(0x9D74); } }
		public int _x9D78 { get { return Read<int>(0x9D78); } }
		public int _x9D7C { get { return Read<int>(0x9D7C); } }
		public int _x9D80 { get { return Read<int>(0x9D80); } }
		public int _x9D84 { get { return Read<int>(0x9D84); } }
		public int _x9D88 { get { return Read<int>(0x9D88); } }
		public int _x9D8C { get { return Read<int>(0x9D8C); } }
		public int _x9D90 { get { return Read<int>(0x9D90); } }
		public int _x9D94 { get { return Read<int>(0x9D94); } }
		public int _x9D98 { get { return Read<int>(0x9D98); } }
		public int _x9D9C { get { return Read<int>(0x9D9C); } }
		public int _x9DA0 { get { return Read<int>(0x9DA0); } }
		public int _x9DA4 { get { return Read<int>(0x9DA4); } }
		public int _x9DA8 { get { return Read<int>(0x9DA8); } }
		public int _x9DAC { get { return Read<int>(0x9DAC); } }
		public int _x9DB0 { get { return Read<int>(0x9DB0); } }
		public int _x9DB4 { get { return Read<int>(0x9DB4); } }
		public int _x9DB8 { get { return Read<int>(0x9DB8); } }
		public int _x9DBC { get { return Read<int>(0x9DBC); } }
		public int _x9DC0 { get { return Read<int>(0x9DC0); } }
		public int _x9DC4 { get { return Read<int>(0x9DC4); } }
		public int _x9DC8 { get { return Read<int>(0x9DC8); } }
		public int _x9DCC { get { return Read<int>(0x9DCC); } }
		public int _x9DD0 { get { return Read<int>(0x9DD0); } }
		public int _x9DD4 { get { return Read<int>(0x9DD4); } }
		public int _x9DD8 { get { return Read<int>(0x9DD8); } }
		public int _x9DDC { get { return Read<int>(0x9DDC); } }
		public int _x9DE0 { get { return Read<int>(0x9DE0); } }
		public int _x9DE4 { get { return Read<int>(0x9DE4); } }
		public int _x9DE8 { get { return Read<int>(0x9DE8); } }
		public int _x9DEC { get { return Read<int>(0x9DEC); } }
		public int _x9DF0 { get { return Read<int>(0x9DF0); } }
		public int _x9DF4 { get { return Read<int>(0x9DF4); } }
		public int _x9DF8 { get { return Read<int>(0x9DF8); } }
		public int _x9DFC { get { return Read<int>(0x9DFC); } }
		public int _x9E00 { get { return Read<int>(0x9E00); } }
		public int _x9E04 { get { return Read<int>(0x9E04); } }
		public int _x9E08 { get { return Read<int>(0x9E08); } }
		public int _x9E0C { get { return Read<int>(0x9E0C); } }
		public int _x9E10 { get { return Read<int>(0x9E10); } }
		public int _x9E14 { get { return Read<int>(0x9E14); } }
		public int _x9E18 { get { return Read<int>(0x9E18); } }
		public int _x9E1C { get { return Read<int>(0x9E1C); } }
		public int _x9E20 { get { return Read<int>(0x9E20); } }
		public int _x9E24 { get { return Read<int>(0x9E24); } }
		public int _x9E28 { get { return Read<int>(0x9E28); } }
		public int _x9E2C { get { return Read<int>(0x9E2C); } }
		public int _x9E30 { get { return Read<int>(0x9E30); } }
		public int _x9E34 { get { return Read<int>(0x9E34); } }
		public int _x9E38 { get { return Read<int>(0x9E38); } }
		public int _x9E3C { get { return Read<int>(0x9E3C); } }
		public int _x9E40 { get { return Read<int>(0x9E40); } }
		public int _x9E44 { get { return Read<int>(0x9E44); } }
		public int _x9E48 { get { return Read<int>(0x9E48); } }
		public int _x9E4C { get { return Read<int>(0x9E4C); } }
		public int _x9E50 { get { return Read<int>(0x9E50); } }
		public int _x9E54 { get { return Read<int>(0x9E54); } }
		public int _x9E58 { get { return Read<int>(0x9E58); } }
		public int _x9E5C { get { return Read<int>(0x9E5C); } }
		public int _x9E60 { get { return Read<int>(0x9E60); } }
		public int _x9E64 { get { return Read<int>(0x9E64); } }
		public int _x9E68 { get { return Read<int>(0x9E68); } }
		public int _x9E6C { get { return Read<int>(0x9E6C); } }
		public int _x9E70 { get { return Read<int>(0x9E70); } }
		public int _x9E74 { get { return Read<int>(0x9E74); } }
		public int _x9E78 { get { return Read<int>(0x9E78); } }
		public int _x9E7C { get { return Read<int>(0x9E7C); } }
		public int _x9E80 { get { return Read<int>(0x9E80); } }
		public int _x9E84 { get { return Read<int>(0x9E84); } }
		public int _x9E88 { get { return Read<int>(0x9E88); } }
		public int _x9E8C { get { return Read<int>(0x9E8C); } }
		public int _x9E90 { get { return Read<int>(0x9E90); } }
		public int _x9E94 { get { return Read<int>(0x9E94); } }
		public int _x9E98 { get { return Read<int>(0x9E98); } }
		public int _x9E9C { get { return Read<int>(0x9E9C); } }
		public int _x9EA0 { get { return Read<int>(0x9EA0); } }
		public int _x9EA4 { get { return Read<int>(0x9EA4); } }
		public int _x9EA8 { get { return Read<int>(0x9EA8); } }
		public int _x9EAC { get { return Read<int>(0x9EAC); } }
		public int _x9EB0 { get { return Read<int>(0x9EB0); } }
		public int _x9EB4 { get { return Read<int>(0x9EB4); } }
		public int _x9EB8 { get { return Read<int>(0x9EB8); } }
		public int _x9EBC { get { return Read<int>(0x9EBC); } }
		public int _x9EC0 { get { return Read<int>(0x9EC0); } }
		public int _x9EC4 { get { return Read<int>(0x9EC4); } }
		public int _x9EC8 { get { return Read<int>(0x9EC8); } }
		public int _x9ECC { get { return Read<int>(0x9ECC); } }
		public int _x9ED0 { get { return Read<int>(0x9ED0); } }
		public int _x9ED4 { get { return Read<int>(0x9ED4); } }
		public int _x9ED8 { get { return Read<int>(0x9ED8); } }
		public int _x9EDC { get { return Read<int>(0x9EDC); } }
		public int _x9EE0 { get { return Read<int>(0x9EE0); } }
		public int _x9EE4 { get { return Read<int>(0x9EE4); } }
		public int _x9EE8 { get { return Read<int>(0x9EE8); } }
		public int _x9EEC { get { return Read<int>(0x9EEC); } }
		public int _x9EF0 { get { return Read<int>(0x9EF0); } }
		public int _x9EF4 { get { return Read<int>(0x9EF4); } }
		public int _x9EF8 { get { return Read<int>(0x9EF8); } }
		public int _x9EFC { get { return Read<int>(0x9EFC); } }
		public int _x9F00 { get { return Read<int>(0x9F00); } }
		public int _x9F04 { get { return Read<int>(0x9F04); } }
		public int _x9F08 { get { return Read<int>(0x9F08); } }
		public int _x9F0C { get { return Read<int>(0x9F0C); } }
		public int _x9F10 { get { return Read<int>(0x9F10); } }
		public int _x9F14 { get { return Read<int>(0x9F14); } }
		public int _x9F18 { get { return Read<int>(0x9F18); } }
		public int _x9F1C { get { return Read<int>(0x9F1C); } }
		public int _x9F20 { get { return Read<int>(0x9F20); } }
		public int _x9F24 { get { return Read<int>(0x9F24); } }
		public int _x9F28 { get { return Read<int>(0x9F28); } }
		public int _x9F2C { get { return Read<int>(0x9F2C); } }
		public int _x9F30 { get { return Read<int>(0x9F30); } }
		public int _x9F34 { get { return Read<int>(0x9F34); } }
		public int _x9F38 { get { return Read<int>(0x9F38); } }
		public int _x9F3C { get { return Read<int>(0x9F3C); } }
		public int _x9F40 { get { return Read<int>(0x9F40); } }
		public int _x9F44 { get { return Read<int>(0x9F44); } }
		public int _x9F48 { get { return Read<int>(0x9F48); } }
		public int _x9F4C { get { return Read<int>(0x9F4C); } }
		public int _x9F50 { get { return Read<int>(0x9F50); } }
		public int _x9F54 { get { return Read<int>(0x9F54); } }
		public int _x9F58 { get { return Read<int>(0x9F58); } }
		public int _x9F5C { get { return Read<int>(0x9F5C); } }
		public int _x9F60 { get { return Read<int>(0x9F60); } }
		public int _x9F64 { get { return Read<int>(0x9F64); } }
		public int _x9F68 { get { return Read<int>(0x9F68); } }
		public int _x9F6C { get { return Read<int>(0x9F6C); } }
		public int _x9F70 { get { return Read<int>(0x9F70); } }
		public int _x9F74 { get { return Read<int>(0x9F74); } }
		public int _x9F78 { get { return Read<int>(0x9F78); } }
		public int _x9F7C { get { return Read<int>(0x9F7C); } }
		public int _x9F80 { get { return Read<int>(0x9F80); } }
		public int _x9F84 { get { return Read<int>(0x9F84); } }
		public int _x9F88 { get { return Read<int>(0x9F88); } }
		public int _x9F8C { get { return Read<int>(0x9F8C); } }
		public int _x9F90 { get { return Read<int>(0x9F90); } }
		public int _x9F94 { get { return Read<int>(0x9F94); } }
		public int _x9F98 { get { return Read<int>(0x9F98); } }
		public int _x9F9C { get { return Read<int>(0x9F9C); } }
		public int _x9FA0 { get { return Read<int>(0x9FA0); } }
		public int _x9FA4 { get { return Read<int>(0x9FA4); } }
		public int _x9FA8 { get { return Read<int>(0x9FA8); } }
		public int _x9FAC { get { return Read<int>(0x9FAC); } }
		public int _x9FB0 { get { return Read<int>(0x9FB0); } }
		public int _x9FB4 { get { return Read<int>(0x9FB4); } }
		public int _x9FB8 { get { return Read<int>(0x9FB8); } }
		public int _x9FBC { get { return Read<int>(0x9FBC); } }
		public int _x9FC0 { get { return Read<int>(0x9FC0); } }
		public int _x9FC4 { get { return Read<int>(0x9FC4); } }
		public int _x9FC8 { get { return Read<int>(0x9FC8); } }
		public int _x9FCC { get { return Read<int>(0x9FCC); } }
		public int _x9FD0 { get { return Read<int>(0x9FD0); } }
		public int _x9FD4 { get { return Read<int>(0x9FD4); } }
		//...
		public int x9FF8_InputFlags { get { return Read<int>(0x9FF8); } }
		public int _x9FFC { get { return Read<int>(0x9FFC); } }
		public int _xA000 { get { return Read<int>(0xA000); } } // Related to Player Map Pos?
		public int _xA004 { get { return Read<int>(0xA004); } }
		public int _xA008 { get { return Read<int>(0xA008); } }
		public int _xA00C { get { return Read<int>(0xA00C); } }
		public int _xA010 { get { return Read<int>(0xA010); } }
		public int _xA014 { get { return Read<int>(0xA014); } }
		public int _xA018 { get { return Read<int>(0xA018); } }
		public int _xA01C { get { return Read<int>(0xA01C); } }
		public int _xA020 { get { return Read<int>(0xA020); } }
		public int _xA024 { get { return Read<int>(0xA024); } }
		public int _xA028 { get { return Read<int>(0xA028); } }
		public int _xA02C { get { return Read<int>(0xA02C); } }
		public int _xA030 { get { return Read<int>(0xA030); } }
		public int _xA034 { get { return Read<int>(0xA034); } }
		public int _xA038 { get { return Read<int>(0xA038); } }
		public int _xA03C { get { return Read<int>(0xA03C); } }
		public int _xA040 { get { return Read<int>(0xA040); } }
		public int _xA044 { get { return Read<int>(0xA044); } }
		public int _xA048 { get { return Read<int>(0xA048); } }
		public int _xA04C { get { return Read<int>(0xA04C); } }
		public int _xA050 { get { return Read<int>(0xA050); } }
		public int _xA054 { get { return Read<int>(0xA054); } }
		public int _xA058 { get { return Read<int>(0xA058); } }
		public int _xA05C { get { return Read<int>(0xA05C); } }
		public int _xA060 { get { return Read<int>(0xA060); } }
		public int _xA064 { get { return Read<int>(0xA064); } }
		public int _xA068 { get { return Read<int>(0xA068); } }
		public int _xA06C { get { return Read<int>(0xA06C); } }
		public int _xA070 { get { return Read<int>(0xA070); } }
		public int _xA074 { get { return Read<int>(0xA074); } }
		public int _xA078 { get { return Read<int>(0xA078); } }
		public int _xA07C { get { return Read<int>(0xA07C); } }
		public int _xA080 { get { return Read<int>(0xA080); } }
		public int _xA084 { get { return Read<int>(0xA084); } }
		public int _xA088 { get { return Read<int>(0xA088); } }
		public int _xA08C { get { return Read<int>(0xA08C); } }
		public int _xA090 { get { return Read<int>(0xA090); } }
		public int _xA094 { get { return Read<int>(0xA094); } }
		public int _xA098 { get { return Read<int>(0xA098); } }
		public int _xA09C { get { return Read<int>(0xA09C); } }
		public int _xA0A0 { get { return Read<int>(0xA0A0); } }
		public int _xA0A4 { get { return Read<int>(0xA0A4); } }
		public int _xA0A8 { get { return Read<int>(0xA0A8); } }
		public int _xA0AC { get { return Read<int>(0xA0AC); } }
		public int _xA0B0 { get { return Read<int>(0xA0B0); } }
		public int _xA0B4 { get { return Read<int>(0xA0B4); } }
		public int _xA0B8 { get { return Read<int>(0xA0B8); } }
		public int _xA0BC { get { return Read<int>(0xA0BC); } }
		public int _xA0C0 { get { return Read<int>(0xA0C0); } }
		public int _xA0C4 { get { return Read<int>(0xA0C4); } }
		public int _xA0C8 { get { return Read<int>(0xA0C8); } }
		public int _xA0CC { get { return Read<int>(0xA0CC); } }
		public int _xA0D0 { get { return Read<int>(0xA0D0); } }
		public int _xA0D4 { get { return Read<int>(0xA0D4); } }
		public int _xA0D8 { get { return Read<int>(0xA0D8); } }
		public int _xA0DC { get { return Read<int>(0xA0DC); } }
		public int xA0E0_PowerUse { get { return Read<int>(0xA0E0); } }
		public int xA0E4_PowerUse { get { return Read<int>(0xA0E4); } }
		public int xA0E8_PowerUse { get { return Read<int>(0xA0E8); } }
		public int _xA0EC { get { return Read<int>(0xA0EC); } }
		public int _xA0F0 { get { return Read<int>(0xA0F0); } }
		public int xA0F4_PowerCast { get { return Read<int>(0xA0F4); } } // Used at least for TP.
		public int _xA0F8 { get { return Read<int>(0xA0F8); } }
		public int _xA0FC { get { return Read<int>(0xA0FC); } }
		public int _xA100 { get { return Read<int>(0xA100); } }
		public int _xA104 { get { return Read<int>(0xA104); } }
		public int _xA108 { get { return Read<int>(0xA108); } }
		public int _xA10C { get { return Read<int>(0xA10C); } }
		public int _xA110 { get { return Read<int>(0xA110); } }
		public int _xA114 { get { return Read<int>(0xA114); } }
		public int _xA118 { get { return Read<int>(0xA118); } }
		public int _xA11C { get { return Read<int>(0xA11C); } }
		public int _xA120 { get { return Read<int>(0xA120); } }
		public int _xA124 { get { return Read<int>(0xA124); } }
		public int _xA128 { get { return Read<int>(0xA128); } }
		public int _xA12C { get { return Read<int>(0xA12C); } }
		public int _xA130 { get { return Read<int>(0xA130); } }
		public int _xA134 { get { return Read<int>(0xA134); } }
		public int _xA138 { get { return Read<int>(0xA138); } }
		public int _xA13C { get { return Read<int>(0xA13C); } }
		public int _xA140 { get { return Read<int>(0xA140); } }
		public int _xA144 { get { return Read<int>(0xA144); } }
		public int _xA148 { get { return Read<int>(0xA148); } }
		public int _xA14C { get { return Read<int>(0xA14C); } }
		public int xA150_Power { get { return Read<int>(0xA150); } } // Used at least for Walk.
		public int xA154_Power { get { return Read<int>(0xA154); } } // Used at least for Walk.
		public int _xA158 { get { return Read<int>(0xA158); } }
		public int _xA15C { get { return Read<int>(0xA15C); } }
		public float xA160_X { get { return Read<float>(0xA160); } }
		public float xA164_Y { get { return Read<float>(0xA164); } }
		public float xA168_Z { get { return Read<float>(0xA168); } }
		public int xA16C { get { return Read<int>(0xA16C); } } // Scene or World Entry ID.
		public int _xA170 { get { return Read<int>(0xA170); } }
		public int _xA174 { get { return Read<int>(0xA174); } }
		public int _xA178 { get { return Read<int>(0xA178); } }
		public int _xA17C { get { return Read<int>(0xA17C); } }
		public int _xA180 { get { return Read<int>(0xA180); } }
		public int _xA184 { get { return Read<int>(0xA184); } }
		public int _xA188 { get { return Read<int>(0xA188); } }
		public int _xA18C { get { return Read<int>(0xA18C); } }
		public int _xA190 { get { return Read<int>(0xA190); } }
		public int _xA194 { get { return Read<int>(0xA194); } }
		public int _xA198 { get { return Read<int>(0xA198); } }
		public int _xA19C { get { return Read<int>(0xA19C); } }
		public int _xA1A0 { get { return Read<int>(0xA1A0); } }
		public int _xA1A4 { get { return Read<int>(0xA1A4); } }
		public int _xA1A8 { get { return Read<int>(0xA1A8); } }
		public int _xA1AC { get { return Read<int>(0xA1AC); } }
		public int _xA1B0 { get { return Read<int>(0xA1B0); } }
		public int _xA1B4 { get { return Read<int>(0xA1B4); } }
		public int _xA1B8 { get { return Read<int>(0xA1B8); } }
		[ArraySize(16)]
		public XCF14[] xA1C4 { get { return Read<XCF14>(0xA1C4, 16); } }
		public int xA3C4_StructStart_Min20Bytes { get { return Read<int>(0xA3C4); } }
		public int xA3C8_BitSizeOf_xE66C { get { return Read<int>(0xA3C8); } }
		public int xA3CC_SizeOf_xE66C { get { return Read<int>(0xA3CC); } }
		public Ptr xA3D0_Ptr_ { get { return Read<Ptr>(0xA3D0); } }
		public Ptr xA3D4_Ptr_ { get { return Read<Ptr>(0xA3D4); } }
		public Ptr xA3D8_Ptr_ { get { return Read<Ptr>(0xA3D8); } }
		public int _xA3DC { get { return Read<int>(0xA3DC); } }
		public int xA3E0_GameTick { get { return Read<int>(0xA3E0); } }
		public int _xA3E4 { get { return Read<int>(0xA3E4); } }
		public int _xA3E8 { get { return Read<int>(0xA3E8); } }
		public int _xA3EC { get { return Read<int>(0xA3EC); } }
		public int _xA3F0 { get { return Read<int>(0xA3F0); } }
		public int _xA3F4 { get { return Read<int>(0xA3F4); } }
		public int _xA3F8 { get { return Read<int>(0xA3F8); } }
		public int _xA3FC { get { return Read<int>(0xA3FC); } }
		public int _xA400 { get { return Read<int>(0xA400); } }
		public int _xA404 { get { return Read<int>(0xA404); } }

		public class VendorToken : MemoryObject
		{
			public const int SizeOf = 8;

			public int x00_GameBalanceId { get { return Read<int>(0x00); } }
			public int x04_Value { get { return Read<int>(0x04); } }
		}

		public class ServerData : MemoryObject
		{
			public const int SizeOf = 0x47B8;

			public int x0000 { get { return Read<int>(0x0000); } }
			public int x0004 { get { return Read<int>(0x0004); } }
			public int x0008_Flags_Gender { get { return Read<int>(0x0008); } }
			public PlayerSavedData x000C_PlayerSavedData { get { return Read<PlayerSavedData>(0x000C); } }
			public int x12AC { get { return Read<int>(0x12AC); } }
			[ArraySize(100)]
			public X12B0[] x12B0_CompletedQuests { get { return Read<X12B0>(0x12B0, 100); } }
			[ArraySize(200)]
			public X1760[] x1760 { get { return Read<X1760>(0x1760, 200); } }
			[ArraySize(64)]
			public X1DA0[] x1DA0 { get { return Read<X1DA0>(0x1DA0, 64); } }
			public int x47A0 { get { return Read<int>(0x47A0); } }
			public int x47A4 { get { return Read<int>(0x47A4); } }
			public int x47A8 { get { return Read<int>(0x47A8); } }
			public int x47AC { get { return Read<int>(0x47AC); } }
			public int x47B0 { get { return Read<int>(0x47B0); } }
			public int x47B4 { get { return Read<int>(0x47B4); } }

			public class X12B0 : MemoryObject
			{
				public const int SizeOf = 12;

				public int x00_Neg1_QuestSnoId { get { return Read<int>(0x00); } }
				public int x04_Neg1_QuestStep { get { return Read<int>(0x04); } }
				public int x08 { get { return Read<int>(0x08); } }
			}

			public class X1760 : MemoryObject
			{
				public const int SizeOf = 8;

				public int x00_Neg1 { get { return Read<int>(0x00); } }
				public int x04_Neg1 { get { return Read<int>(0x04); } }
			}

			public class X1DA0 : MemoryObject
			{
				public const int SizeOf = 0xA8;

				public int x00_Neg1 { get { return Read<int>(0x00); } }
				public int x04_Neg1 { get { return Read<int>(0x04); } }
				public int _x08 { get { return Read<int>(0x08); } }
				public int _x0C { get { return Read<int>(0x0C); } }
				public int _x10 { get { return Read<int>(0x10); } }
				public int _x14 { get { return Read<int>(0x14); } }
				public int _x18 { get { return Read<int>(0x18); } }
				public int _x1C { get { return Read<int>(0x1C); } }
				public int _x20 { get { return Read<int>(0x20); } }
				public int _x24 { get { return Read<int>(0x24); } }
				public int _x28 { get { return Read<int>(0x28); } }
				public int _x2C { get { return Read<int>(0x2C); } }
				public int _x30 { get { return Read<int>(0x30); } }
				public int _x34 { get { return Read<int>(0x34); } }
				public int _x38 { get { return Read<int>(0x38); } }
				public int _x3C { get { return Read<int>(0x3C); } }
				public int _x40 { get { return Read<int>(0x40); } }
				public int _x44 { get { return Read<int>(0x44); } }
				public int _x48 { get { return Read<int>(0x48); } }
				public int _x4C { get { return Read<int>(0x4C); } }
				public int _x50 { get { return Read<int>(0x50); } }
				public int _x54 { get { return Read<int>(0x54); } }
				public int _x58 { get { return Read<int>(0x58); } }
				public int _x5C { get { return Read<int>(0x5C); } }
				public int _x60 { get { return Read<int>(0x60); } }
				public int _x64 { get { return Read<int>(0x64); } }
				public int _x68 { get { return Read<int>(0x68); } }
				public int _x6C { get { return Read<int>(0x6C); } }
				public int _x70 { get { return Read<int>(0x70); } }
				public int _x74 { get { return Read<int>(0x74); } }
				public int _x78 { get { return Read<int>(0x78); } }
				public int _x7C { get { return Read<int>(0x7C); } }
				public int _x80 { get { return Read<int>(0x80); } }
				public int _x84 { get { return Read<int>(0x84); } }
				public int _x88 { get { return Read<int>(0x88); } }
				public int _x8C { get { return Read<int>(0x8C); } }
				public int _x90 { get { return Read<int>(0x90); } }
				public int _x94 { get { return Read<int>(0x94); } }
				public int _x98 { get { return Read<int>(0x98); } }
				public int _x9C { get { return Read<int>(0x9C); } }
				public int _xA0 { get { return Read<int>(0xA0); } }
				public int _xA4 { get { return Read<int>(0xA4); } }
			}
		}

		public class PlayerSavedData : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x12A0; // 4768 - OLD: 0x11A8;

			[ArraySize(6)]
			public HotbarButtonData[] x0000_HotbarButtonData { get { return Read<HotbarButtonData>(0x0000, 6); } }
			public HotbarButtonData x0060_HotbarButtonData { get { return Read<HotbarButtonData>(0x0060); } }
			public int x0070_Byte { get { return Read<int>(0x0070); } }
			public int x0074 { get { return Read<int>(0x0074); } }
			public int x0078 { get { return Read<int>(0x0078); } }
			public HirelingSavedData x007C_HirelingSavedData { get { return Read<HirelingSavedData>(0x007C); } }
			public int x0104 { get { return Read<int>(0x0104); } }
			public LearnedLore x0108_LearnedLore { get { return Read<LearnedLore>(0x0108); } }
			#region 0x090C - 0x1218
			public int _x090C { get { return Read<int>(0x090C); } }
			public int _x0910 { get { return Read<int>(0x0910); } }
			public int _x0914 { get { return Read<int>(0x0914); } }
			public int _x0918 { get { return Read<int>(0x0918); } }
			public int _x091C { get { return Read<int>(0x091C); } }
			public int _x0920 { get { return Read<int>(0x0920); } }
			public int _x0924 { get { return Read<int>(0x0924); } }
			public int _x0928 { get { return Read<int>(0x0928); } }
			public int _x092C { get { return Read<int>(0x092C); } }
			public int _x0930 { get { return Read<int>(0x0930); } }
			public int _x0934 { get { return Read<int>(0x0934); } }
			public int _x0938 { get { return Read<int>(0x0938); } }
			public int _x093C { get { return Read<int>(0x093C); } }
			public int _x0940 { get { return Read<int>(0x0940); } }
			public int _x0944 { get { return Read<int>(0x0944); } }
			public int _x0948 { get { return Read<int>(0x0948); } }
			public int _x094C { get { return Read<int>(0x094C); } }
			public int _x0950 { get { return Read<int>(0x0950); } }
			public int _x0954 { get { return Read<int>(0x0954); } }
			public int _x0958 { get { return Read<int>(0x0958); } }
			public int _x095C { get { return Read<int>(0x095C); } }
			public int _x0960 { get { return Read<int>(0x0960); } }
			public int _x0964 { get { return Read<int>(0x0964); } }
			public int _x0968 { get { return Read<int>(0x0968); } }
			public int _x096C { get { return Read<int>(0x096C); } }
			public int _x0970 { get { return Read<int>(0x0970); } }
			public int _x0974 { get { return Read<int>(0x0974); } }
			public int _x0978 { get { return Read<int>(0x0978); } }
			public int _x097C { get { return Read<int>(0x097C); } }
			public int _x0980 { get { return Read<int>(0x0980); } }
			public int _x0984 { get { return Read<int>(0x0984); } }
			public int _x0988 { get { return Read<int>(0x0988); } }
			public int _x098C { get { return Read<int>(0x098C); } }
			public int _x0990 { get { return Read<int>(0x0990); } }
			public int _x0994 { get { return Read<int>(0x0994); } }
			public int _x0998 { get { return Read<int>(0x0998); } }
			public int _x099C { get { return Read<int>(0x099C); } }
			public int _x09A0 { get { return Read<int>(0x09A0); } }
			public int _x09A4 { get { return Read<int>(0x09A4); } }
			public int _x09A8 { get { return Read<int>(0x09A8); } }
			public int _x09AC { get { return Read<int>(0x09AC); } }
			public int _x09B0 { get { return Read<int>(0x09B0); } }
			public int _x09B4 { get { return Read<int>(0x09B4); } }
			public int _x09B8 { get { return Read<int>(0x09B8); } }
			public int _x09BC { get { return Read<int>(0x09BC); } }
			public int _x09C0 { get { return Read<int>(0x09C0); } }
			public int _x09C4 { get { return Read<int>(0x09C4); } }
			public int _x09C8 { get { return Read<int>(0x09C8); } }
			public int _x09CC { get { return Read<int>(0x09CC); } }
			public int _x09D0 { get { return Read<int>(0x09D0); } }
			public int _x09D4 { get { return Read<int>(0x09D4); } }
			public int _x09D8 { get { return Read<int>(0x09D8); } }
			public int _x09DC { get { return Read<int>(0x09DC); } }
			public int _x09E0 { get { return Read<int>(0x09E0); } }
			public int _x09E4 { get { return Read<int>(0x09E4); } }
			public int _x09E8 { get { return Read<int>(0x09E8); } }
			public int _x09EC { get { return Read<int>(0x09EC); } }
			public int _x09F0 { get { return Read<int>(0x09F0); } }
			public int _x09F4 { get { return Read<int>(0x09F4); } }
			public int _x09F8 { get { return Read<int>(0x09F8); } }
			public int _x09FC { get { return Read<int>(0x09FC); } }
			public int _x0A00 { get { return Read<int>(0x0A00); } }
			public int _x0A04 { get { return Read<int>(0x0A04); } }
			public int _x0A08 { get { return Read<int>(0x0A08); } }
			public int _x0A0C { get { return Read<int>(0x0A0C); } }
			public int _x0A10 { get { return Read<int>(0x0A10); } }
			public int _x0A14 { get { return Read<int>(0x0A14); } }
			public int _x0A18 { get { return Read<int>(0x0A18); } }
			public int _x0A1C { get { return Read<int>(0x0A1C); } }
			public int _x0A20 { get { return Read<int>(0x0A20); } }
			public int _x0A24 { get { return Read<int>(0x0A24); } }
			public int _x0A28 { get { return Read<int>(0x0A28); } }
			public int _x0A2C { get { return Read<int>(0x0A2C); } }
			public int _x0A30 { get { return Read<int>(0x0A30); } }
			public int _x0A34 { get { return Read<int>(0x0A34); } }
			public int _x0A38 { get { return Read<int>(0x0A38); } }
			public int _x0A3C { get { return Read<int>(0x0A3C); } }
			public int _x0A40 { get { return Read<int>(0x0A40); } }
			public int _x0A44 { get { return Read<int>(0x0A44); } }
			public int _x0A48 { get { return Read<int>(0x0A48); } }
			public int _x0A4C { get { return Read<int>(0x0A4C); } }
			public int _x0A50 { get { return Read<int>(0x0A50); } }
			public int _x0A54 { get { return Read<int>(0x0A54); } }
			public int _x0A58 { get { return Read<int>(0x0A58); } }
			public int _x0A5C { get { return Read<int>(0x0A5C); } }
			public int _x0A60 { get { return Read<int>(0x0A60); } }
			public int _x0A64 { get { return Read<int>(0x0A64); } }
			public int _x0A68 { get { return Read<int>(0x0A68); } }
			public int _x0A6C { get { return Read<int>(0x0A6C); } }
			public int _x0A70 { get { return Read<int>(0x0A70); } }
			public int _x0A74 { get { return Read<int>(0x0A74); } }
			public int _x0A78 { get { return Read<int>(0x0A78); } }
			public int _x0A7C { get { return Read<int>(0x0A7C); } }
			public int _x0A80 { get { return Read<int>(0x0A80); } }
			public int _x0A84 { get { return Read<int>(0x0A84); } }
			public int _x0A88 { get { return Read<int>(0x0A88); } }
			public int _x0A8C { get { return Read<int>(0x0A8C); } }
			public int _x0A90 { get { return Read<int>(0x0A90); } }
			public int _x0A94 { get { return Read<int>(0x0A94); } }
			public int _x0A98 { get { return Read<int>(0x0A98); } }
			public int _x0A9C { get { return Read<int>(0x0A9C); } }
			public int _x0AA0 { get { return Read<int>(0x0AA0); } }
			public int _x0AA4 { get { return Read<int>(0x0AA4); } }
			public int _x0AA8 { get { return Read<int>(0x0AA8); } }
			public int _x0AAC { get { return Read<int>(0x0AAC); } }
			public int _x0AB0 { get { return Read<int>(0x0AB0); } }
			public int _x0AB4 { get { return Read<int>(0x0AB4); } }
			public int _x0AB8 { get { return Read<int>(0x0AB8); } }
			public int _x0ABC { get { return Read<int>(0x0ABC); } }
			public int _x0AC0 { get { return Read<int>(0x0AC0); } }
			public int _x0AC4 { get { return Read<int>(0x0AC4); } }
			public int _x0AC8 { get { return Read<int>(0x0AC8); } }
			public int _x0ACC { get { return Read<int>(0x0ACC); } }
			public int _x0AD0 { get { return Read<int>(0x0AD0); } }
			public int _x0AD4 { get { return Read<int>(0x0AD4); } }
			public int _x0AD8 { get { return Read<int>(0x0AD8); } }
			public int _x0ADC { get { return Read<int>(0x0ADC); } }
			public int _x0AE0 { get { return Read<int>(0x0AE0); } }
			public int _x0AE4 { get { return Read<int>(0x0AE4); } }
			public int _x0AE8 { get { return Read<int>(0x0AE8); } }
			public int _x0AEC { get { return Read<int>(0x0AEC); } }
			public int _x0AF0 { get { return Read<int>(0x0AF0); } }
			public int _x0AF4 { get { return Read<int>(0x0AF4); } }
			public int _x0AF8 { get { return Read<int>(0x0AF8); } }
			public int _x0AFC { get { return Read<int>(0x0AFC); } }
			public int _x0B00 { get { return Read<int>(0x0B00); } }
			public int _x0B04 { get { return Read<int>(0x0B04); } }
			public int _x0B08 { get { return Read<int>(0x0B08); } }
			public int _x0B0C { get { return Read<int>(0x0B0C); } }
			public int _x0B10 { get { return Read<int>(0x0B10); } }
			public int _x0B14 { get { return Read<int>(0x0B14); } }
			public int _x0B18 { get { return Read<int>(0x0B18); } }
			public int _x0B1C { get { return Read<int>(0x0B1C); } }
			public int _x0B20 { get { return Read<int>(0x0B20); } }
			public int _x0B24 { get { return Read<int>(0x0B24); } }
			public int _x0B28 { get { return Read<int>(0x0B28); } }
			public int _x0B2C { get { return Read<int>(0x0B2C); } }
			public int _x0B30 { get { return Read<int>(0x0B30); } }
			public int _x0B34 { get { return Read<int>(0x0B34); } }
			public int _x0B38 { get { return Read<int>(0x0B38); } }
			public int _x0B3C { get { return Read<int>(0x0B3C); } }
			public int _x0B40 { get { return Read<int>(0x0B40); } }
			public int _x0B44 { get { return Read<int>(0x0B44); } }
			public int _x0B48 { get { return Read<int>(0x0B48); } }
			public int _x0B4C { get { return Read<int>(0x0B4C); } }
			public int _x0B50 { get { return Read<int>(0x0B50); } }
			public int _x0B54 { get { return Read<int>(0x0B54); } }
			public int _x0B58 { get { return Read<int>(0x0B58); } }
			public int _x0B5C { get { return Read<int>(0x0B5C); } }
			public int _x0B60 { get { return Read<int>(0x0B60); } }
			public int _x0B64 { get { return Read<int>(0x0B64); } }
			public int _x0B68 { get { return Read<int>(0x0B68); } }
			public int _x0B6C { get { return Read<int>(0x0B6C); } }
			public int _x0B70 { get { return Read<int>(0x0B70); } }
			public int _x0B74 { get { return Read<int>(0x0B74); } }
			public int _x0B78 { get { return Read<int>(0x0B78); } }
			public int _x0B7C { get { return Read<int>(0x0B7C); } }
			public int _x0B80 { get { return Read<int>(0x0B80); } }
			public int _x0B84 { get { return Read<int>(0x0B84); } }
			public int _x0B88 { get { return Read<int>(0x0B88); } }
			public int _x0B8C { get { return Read<int>(0x0B8C); } }
			public int _x0B90 { get { return Read<int>(0x0B90); } }
			public int _x0B94 { get { return Read<int>(0x0B94); } }
			public int _x0B98 { get { return Read<int>(0x0B98); } }
			public int _x0B9C { get { return Read<int>(0x0B9C); } }
			public int _x0BA0 { get { return Read<int>(0x0BA0); } }
			public int _x0BA4 { get { return Read<int>(0x0BA4); } }
			public int _x0BA8 { get { return Read<int>(0x0BA8); } }
			public int _x0BAC { get { return Read<int>(0x0BAC); } }
			public int _x0BB0 { get { return Read<int>(0x0BB0); } }
			public int _x0BB4 { get { return Read<int>(0x0BB4); } }
			public int _x0BB8 { get { return Read<int>(0x0BB8); } }
			public int _x0BBC { get { return Read<int>(0x0BBC); } }
			public int _x0BC0 { get { return Read<int>(0x0BC0); } }
			public int _x0BC4 { get { return Read<int>(0x0BC4); } }
			public int _x0BC8 { get { return Read<int>(0x0BC8); } }
			public int _x0BCC { get { return Read<int>(0x0BCC); } }
			public int _x0BD0 { get { return Read<int>(0x0BD0); } }
			public int _x0BD4 { get { return Read<int>(0x0BD4); } }
			public int _x0BD8 { get { return Read<int>(0x0BD8); } }
			public int _x0BDC { get { return Read<int>(0x0BDC); } }
			public int _x0BE0 { get { return Read<int>(0x0BE0); } }
			public int _x0BE4 { get { return Read<int>(0x0BE4); } }
			public int _x0BE8 { get { return Read<int>(0x0BE8); } }
			public int _x0BEC { get { return Read<int>(0x0BEC); } }
			public int _x0BF0 { get { return Read<int>(0x0BF0); } }
			public int _x0BF4 { get { return Read<int>(0x0BF4); } }
			public int _x0BF8 { get { return Read<int>(0x0BF8); } }
			public int _x0BFC { get { return Read<int>(0x0BFC); } }
			public int _x0C00 { get { return Read<int>(0x0C00); } }
			public int _x0C04 { get { return Read<int>(0x0C04); } }
			public int _x0C08 { get { return Read<int>(0x0C08); } }
			public int _x0C0C { get { return Read<int>(0x0C0C); } }
			public int _x0C10 { get { return Read<int>(0x0C10); } }
			public int _x0C14 { get { return Read<int>(0x0C14); } }
			public int _x0C18 { get { return Read<int>(0x0C18); } }
			public int _x0C1C { get { return Read<int>(0x0C1C); } }
			public int _x0C20 { get { return Read<int>(0x0C20); } }
			public int _x0C24 { get { return Read<int>(0x0C24); } }
			public int _x0C28 { get { return Read<int>(0x0C28); } }
			public int _x0C2C { get { return Read<int>(0x0C2C); } }
			public int _x0C30 { get { return Read<int>(0x0C30); } }
			public int _x0C34 { get { return Read<int>(0x0C34); } }
			public int _x0C38 { get { return Read<int>(0x0C38); } }
			public int _x0C3C { get { return Read<int>(0x0C3C); } }
			public int _x0C40 { get { return Read<int>(0x0C40); } }
			public int _x0C44 { get { return Read<int>(0x0C44); } }
			public int _x0C48 { get { return Read<int>(0x0C48); } }
			public int _x0C4C { get { return Read<int>(0x0C4C); } }
			public int _x0C50 { get { return Read<int>(0x0C50); } }
			public int _x0C54 { get { return Read<int>(0x0C54); } }
			public int _x0C58 { get { return Read<int>(0x0C58); } }
			public int _x0C5C { get { return Read<int>(0x0C5C); } }
			public int _x0C60 { get { return Read<int>(0x0C60); } }
			public int _x0C64 { get { return Read<int>(0x0C64); } }
			public int _x0C68 { get { return Read<int>(0x0C68); } }
			public int _x0C6C { get { return Read<int>(0x0C6C); } }
			public int _x0C70 { get { return Read<int>(0x0C70); } }
			public int _x0C74 { get { return Read<int>(0x0C74); } }
			public int _x0C78 { get { return Read<int>(0x0C78); } }
			public int _x0C7C { get { return Read<int>(0x0C7C); } }
			public int _x0C80 { get { return Read<int>(0x0C80); } }
			public int _x0C84 { get { return Read<int>(0x0C84); } }
			public int _x0C88 { get { return Read<int>(0x0C88); } }
			public int _x0C8C { get { return Read<int>(0x0C8C); } }
			public int _x0C90 { get { return Read<int>(0x0C90); } }
			public int _x0C94 { get { return Read<int>(0x0C94); } }
			public int _x0C98 { get { return Read<int>(0x0C98); } }
			public int _x0C9C { get { return Read<int>(0x0C9C); } }
			public int _x0CA0 { get { return Read<int>(0x0CA0); } }
			public int _x0CA4 { get { return Read<int>(0x0CA4); } }
			public int _x0CA8 { get { return Read<int>(0x0CA8); } }
			public int _x0CAC { get { return Read<int>(0x0CAC); } }
			public int _x0CB0 { get { return Read<int>(0x0CB0); } }
			public int _x0CB4 { get { return Read<int>(0x0CB4); } }
			public int _x0CB8 { get { return Read<int>(0x0CB8); } }
			public int _x0CBC { get { return Read<int>(0x0CBC); } }
			public int _x0CC0 { get { return Read<int>(0x0CC0); } }
			public int _x0CC4 { get { return Read<int>(0x0CC4); } }
			public int _x0CC8 { get { return Read<int>(0x0CC8); } }
			public int _x0CCC { get { return Read<int>(0x0CCC); } }
			public int _x0CD0 { get { return Read<int>(0x0CD0); } }
			public int _x0CD4 { get { return Read<int>(0x0CD4); } }
			public int _x0CD8 { get { return Read<int>(0x0CD8); } }
			public int _x0CDC { get { return Read<int>(0x0CDC); } }
			public int _x0CE0 { get { return Read<int>(0x0CE0); } }
			public int _x0CE4 { get { return Read<int>(0x0CE4); } }
			public int _x0CE8 { get { return Read<int>(0x0CE8); } }
			public int _x0CEC { get { return Read<int>(0x0CEC); } }
			public int _x0CF0 { get { return Read<int>(0x0CF0); } }
			public int _x0CF4 { get { return Read<int>(0x0CF4); } }
			public int _x0CF8 { get { return Read<int>(0x0CF8); } }
			public int _x0CFC { get { return Read<int>(0x0CFC); } }
			public int _x0D00 { get { return Read<int>(0x0D00); } }
			public int _x0D04 { get { return Read<int>(0x0D04); } }
			public int _x0D08 { get { return Read<int>(0x0D08); } }
			public int _x0D0C { get { return Read<int>(0x0D0C); } }
			public int _x0D10 { get { return Read<int>(0x0D10); } }
			public int _x0D14 { get { return Read<int>(0x0D14); } }
			public int _x0D18 { get { return Read<int>(0x0D18); } }
			public int _x0D1C { get { return Read<int>(0x0D1C); } }
			public int _x0D20 { get { return Read<int>(0x0D20); } }
			public int _x0D24 { get { return Read<int>(0x0D24); } }
			public int _x0D28 { get { return Read<int>(0x0D28); } }
			public int _x0D2C { get { return Read<int>(0x0D2C); } }
			public int _x0D30 { get { return Read<int>(0x0D30); } }
			public int _x0D34 { get { return Read<int>(0x0D34); } }
			public int _x0D38 { get { return Read<int>(0x0D38); } }
			public int _x0D3C { get { return Read<int>(0x0D3C); } }
			public int _x0D40 { get { return Read<int>(0x0D40); } }
			public int _x0D44 { get { return Read<int>(0x0D44); } }
			public int _x0D48 { get { return Read<int>(0x0D48); } }
			public int _x0D4C { get { return Read<int>(0x0D4C); } }
			public int _x0D50 { get { return Read<int>(0x0D50); } }
			public int _x0D54 { get { return Read<int>(0x0D54); } }
			public int _x0D58 { get { return Read<int>(0x0D58); } }
			public int _x0D5C { get { return Read<int>(0x0D5C); } }
			public int _x0D60 { get { return Read<int>(0x0D60); } }
			public int _x0D64 { get { return Read<int>(0x0D64); } }
			public int _x0D68 { get { return Read<int>(0x0D68); } }
			public int _x0D6C { get { return Read<int>(0x0D6C); } }
			public int _x0D70 { get { return Read<int>(0x0D70); } }
			public int _x0D74 { get { return Read<int>(0x0D74); } }
			public int _x0D78 { get { return Read<int>(0x0D78); } }
			public int _x0D7C { get { return Read<int>(0x0D7C); } }
			public int _x0D80 { get { return Read<int>(0x0D80); } }
			public int _x0D84 { get { return Read<int>(0x0D84); } }
			public int _x0D88 { get { return Read<int>(0x0D88); } }
			public int _x0D8C { get { return Read<int>(0x0D8C); } }
			public int _x0D90 { get { return Read<int>(0x0D90); } }
			public int _x0D94 { get { return Read<int>(0x0D94); } }
			public int _x0D98 { get { return Read<int>(0x0D98); } }
			public int _x0D9C { get { return Read<int>(0x0D9C); } }
			public int _x0DA0 { get { return Read<int>(0x0DA0); } }
			public int _x0DA4 { get { return Read<int>(0x0DA4); } }
			public int _x0DA8 { get { return Read<int>(0x0DA8); } }
			public int _x0DAC { get { return Read<int>(0x0DAC); } }
			public int _x0DB0 { get { return Read<int>(0x0DB0); } }
			public int _x0DB4 { get { return Read<int>(0x0DB4); } }
			public int _x0DB8 { get { return Read<int>(0x0DB8); } }
			public int _x0DBC { get { return Read<int>(0x0DBC); } }
			public int _x0DC0 { get { return Read<int>(0x0DC0); } }
			public int _x0DC4 { get { return Read<int>(0x0DC4); } }
			public int _x0DC8 { get { return Read<int>(0x0DC8); } }
			public int _x0DCC { get { return Read<int>(0x0DCC); } }
			public int _x0DD0 { get { return Read<int>(0x0DD0); } }
			public int _x0DD4 { get { return Read<int>(0x0DD4); } }
			public int _x0DD8 { get { return Read<int>(0x0DD8); } }
			public int _x0DDC { get { return Read<int>(0x0DDC); } }
			public int _x0DE0 { get { return Read<int>(0x0DE0); } }
			public int _x0DE4 { get { return Read<int>(0x0DE4); } }
			public int _x0DE8 { get { return Read<int>(0x0DE8); } }
			public int _x0DEC { get { return Read<int>(0x0DEC); } }
			public int _x0DF0 { get { return Read<int>(0x0DF0); } }
			public int _x0DF4 { get { return Read<int>(0x0DF4); } }
			public int _x0DF8 { get { return Read<int>(0x0DF8); } }
			public int _x0DFC { get { return Read<int>(0x0DFC); } }
			public int _x0E00 { get { return Read<int>(0x0E00); } }
			public int _x0E04 { get { return Read<int>(0x0E04); } }
			public int _x0E08 { get { return Read<int>(0x0E08); } }
			public int _x0E0C { get { return Read<int>(0x0E0C); } }
			public int _x0E10 { get { return Read<int>(0x0E10); } }
			public int _x0E14 { get { return Read<int>(0x0E14); } }
			public int _x0E18 { get { return Read<int>(0x0E18); } }
			public int _x0E1C { get { return Read<int>(0x0E1C); } }
			public int _x0E20 { get { return Read<int>(0x0E20); } }
			public int _x0E24 { get { return Read<int>(0x0E24); } }
			public int _x0E28 { get { return Read<int>(0x0E28); } }
			public int _x0E2C { get { return Read<int>(0x0E2C); } }
			public int _x0E30 { get { return Read<int>(0x0E30); } }
			public int _x0E34 { get { return Read<int>(0x0E34); } }
			public int _x0E38 { get { return Read<int>(0x0E38); } }
			public int _x0E3C { get { return Read<int>(0x0E3C); } }
			public int _x0E40 { get { return Read<int>(0x0E40); } }
			public int _x0E44 { get { return Read<int>(0x0E44); } }
			public int _x0E48 { get { return Read<int>(0x0E48); } }
			public int _x0E4C { get { return Read<int>(0x0E4C); } }
			public int _x0E50 { get { return Read<int>(0x0E50); } }
			public int _x0E54 { get { return Read<int>(0x0E54); } }
			public int _x0E58 { get { return Read<int>(0x0E58); } }
			public int _x0E5C { get { return Read<int>(0x0E5C); } }
			public int _x0E60 { get { return Read<int>(0x0E60); } }
			public int _x0E64 { get { return Read<int>(0x0E64); } }
			public int _x0E68 { get { return Read<int>(0x0E68); } }
			public int _x0E6C { get { return Read<int>(0x0E6C); } }
			public int _x0E70 { get { return Read<int>(0x0E70); } }
			public int _x0E74 { get { return Read<int>(0x0E74); } }
			public int _x0E78 { get { return Read<int>(0x0E78); } }
			public int _x0E7C { get { return Read<int>(0x0E7C); } }
			public int _x0E80 { get { return Read<int>(0x0E80); } }
			public int _x0E84 { get { return Read<int>(0x0E84); } }
			public int _x0E88 { get { return Read<int>(0x0E88); } }
			public int _x0E8C { get { return Read<int>(0x0E8C); } }
			public int _x0E90 { get { return Read<int>(0x0E90); } }
			public int _x0E94 { get { return Read<int>(0x0E94); } }
			public int _x0E98 { get { return Read<int>(0x0E98); } }
			public int _x0E9C { get { return Read<int>(0x0E9C); } }
			public int _x0EA0 { get { return Read<int>(0x0EA0); } }
			public int _x0EA4 { get { return Read<int>(0x0EA4); } }
			public int _x0EA8 { get { return Read<int>(0x0EA8); } }
			public int _x0EAC { get { return Read<int>(0x0EAC); } }
			public int _x0EB0 { get { return Read<int>(0x0EB0); } }
			public int _x0EB4 { get { return Read<int>(0x0EB4); } }
			public int _x0EB8 { get { return Read<int>(0x0EB8); } }
			public int _x0EBC { get { return Read<int>(0x0EBC); } }
			public int _x0EC0 { get { return Read<int>(0x0EC0); } }
			public int _x0EC4 { get { return Read<int>(0x0EC4); } }
			public int _x0EC8 { get { return Read<int>(0x0EC8); } }
			public int _x0ECC { get { return Read<int>(0x0ECC); } }
			public int _x0ED0 { get { return Read<int>(0x0ED0); } }
			public int _x0ED4 { get { return Read<int>(0x0ED4); } }
			public int _x0ED8 { get { return Read<int>(0x0ED8); } }
			public int _x0EDC { get { return Read<int>(0x0EDC); } }
			public int _x0EE0 { get { return Read<int>(0x0EE0); } }
			public int _x0EE4 { get { return Read<int>(0x0EE4); } }
			public int _x0EE8 { get { return Read<int>(0x0EE8); } }
			public int _x0EEC { get { return Read<int>(0x0EEC); } }
			public int _x0EF0 { get { return Read<int>(0x0EF0); } }
			public int _x0EF4 { get { return Read<int>(0x0EF4); } }
			public int _x0EF8 { get { return Read<int>(0x0EF8); } }
			public int _x0EFC { get { return Read<int>(0x0EFC); } }
			public int _x0F00 { get { return Read<int>(0x0F00); } }
			public int _x0F04 { get { return Read<int>(0x0F04); } }
			public int _x0F08 { get { return Read<int>(0x0F08); } }
			public int _x0F0C { get { return Read<int>(0x0F0C); } }
			public int _x0F10 { get { return Read<int>(0x0F10); } }
			public int _x0F14 { get { return Read<int>(0x0F14); } }
			public int _x0F18 { get { return Read<int>(0x0F18); } }
			public int _x0F1C { get { return Read<int>(0x0F1C); } }
			public int _x0F20 { get { return Read<int>(0x0F20); } }
			public int _x0F24 { get { return Read<int>(0x0F24); } }
			public int _x0F28 { get { return Read<int>(0x0F28); } }
			public int _x0F2C { get { return Read<int>(0x0F2C); } }
			public int _x0F30 { get { return Read<int>(0x0F30); } }
			public int _x0F34 { get { return Read<int>(0x0F34); } }
			public int _x0F38 { get { return Read<int>(0x0F38); } }
			public int _x0F3C { get { return Read<int>(0x0F3C); } }
			public int _x0F40 { get { return Read<int>(0x0F40); } }
			public int _x0F44 { get { return Read<int>(0x0F44); } }
			public int _x0F48 { get { return Read<int>(0x0F48); } }
			public int _x0F4C { get { return Read<int>(0x0F4C); } }
			public int _x0F50 { get { return Read<int>(0x0F50); } }
			public int _x0F54 { get { return Read<int>(0x0F54); } }
			public int _x0F58 { get { return Read<int>(0x0F58); } }
			public int _x0F5C { get { return Read<int>(0x0F5C); } }
			public int _x0F60 { get { return Read<int>(0x0F60); } }
			public int _x0F64 { get { return Read<int>(0x0F64); } }
			public int _x0F68 { get { return Read<int>(0x0F68); } }
			public int _x0F6C { get { return Read<int>(0x0F6C); } }
			public int _x0F70 { get { return Read<int>(0x0F70); } }
			public int _x0F74 { get { return Read<int>(0x0F74); } }
			public int _x0F78 { get { return Read<int>(0x0F78); } }
			public int _x0F7C { get { return Read<int>(0x0F7C); } }
			public int _x0F80 { get { return Read<int>(0x0F80); } }
			public int _x0F84 { get { return Read<int>(0x0F84); } }
			public int _x0F88 { get { return Read<int>(0x0F88); } }
			public int _x0F8C { get { return Read<int>(0x0F8C); } }
			public int _x0F90 { get { return Read<int>(0x0F90); } }
			public int _x0F94 { get { return Read<int>(0x0F94); } }
			public int _x0F98 { get { return Read<int>(0x0F98); } }
			public int _x0F9C { get { return Read<int>(0x0F9C); } }
			public int _x0FA0 { get { return Read<int>(0x0FA0); } }
			public int _x0FA4 { get { return Read<int>(0x0FA4); } }
			public int _x0FA8 { get { return Read<int>(0x0FA8); } }
			public int _x0FAC { get { return Read<int>(0x0FAC); } }
			public int _x0FB0 { get { return Read<int>(0x0FB0); } }
			public int _x0FB4 { get { return Read<int>(0x0FB4); } }
			public int _x0FB8 { get { return Read<int>(0x0FB8); } }
			public int _x0FBC { get { return Read<int>(0x0FBC); } }
			public int _x0FC0 { get { return Read<int>(0x0FC0); } }
			public int _x0FC4 { get { return Read<int>(0x0FC4); } }
			public int _x0FC8 { get { return Read<int>(0x0FC8); } }
			public int _x0FCC { get { return Read<int>(0x0FCC); } }
			public int _x0FD0 { get { return Read<int>(0x0FD0); } }
			public int _x0FD4 { get { return Read<int>(0x0FD4); } }
			public int _x0FD8 { get { return Read<int>(0x0FD8); } }
			public int _x0FDC { get { return Read<int>(0x0FDC); } }
			public int _x0FE0 { get { return Read<int>(0x0FE0); } }
			public int _x0FE4 { get { return Read<int>(0x0FE4); } }
			public int _x0FE8 { get { return Read<int>(0x0FE8); } }
			public int _x0FEC { get { return Read<int>(0x0FEC); } }
			public int _x0FF0 { get { return Read<int>(0x0FF0); } }
			public int _x0FF4 { get { return Read<int>(0x0FF4); } }
			public int _x0FF8 { get { return Read<int>(0x0FF8); } }
			public int _x0FFC { get { return Read<int>(0x0FFC); } }
			public int _x1000 { get { return Read<int>(0x1000); } }
			public int _x1004 { get { return Read<int>(0x1004); } }
			public int _x1008 { get { return Read<int>(0x1008); } }
			public int _x100C { get { return Read<int>(0x100C); } }
			public int _x1010 { get { return Read<int>(0x1010); } }
			public int _x1014 { get { return Read<int>(0x1014); } }
			public int _x1018 { get { return Read<int>(0x1018); } }
			public int _x101C { get { return Read<int>(0x101C); } }
			public int _x1020 { get { return Read<int>(0x1020); } }
			public int _x1024 { get { return Read<int>(0x1024); } }
			public int _x1028 { get { return Read<int>(0x1028); } }
			public int _x102C { get { return Read<int>(0x102C); } }
			public int _x1030 { get { return Read<int>(0x1030); } }
			public int _x1034 { get { return Read<int>(0x1034); } }
			public int _x1038 { get { return Read<int>(0x1038); } }
			public int _x103C { get { return Read<int>(0x103C); } }
			public int _x1040 { get { return Read<int>(0x1040); } }
			public int _x1044 { get { return Read<int>(0x1044); } }
			public int _x1048 { get { return Read<int>(0x1048); } }
			public int _x104C { get { return Read<int>(0x104C); } }
			public int _x1050 { get { return Read<int>(0x1050); } }
			public int _x1054 { get { return Read<int>(0x1054); } }
			public int _x1058 { get { return Read<int>(0x1058); } }
			public int _x105C { get { return Read<int>(0x105C); } }
			public int _x1060 { get { return Read<int>(0x1060); } }
			public int _x1064 { get { return Read<int>(0x1064); } }
			public int _x1068 { get { return Read<int>(0x1068); } }
			public int _x106C { get { return Read<int>(0x106C); } }
			public int _x1070 { get { return Read<int>(0x1070); } }
			public int _x1074 { get { return Read<int>(0x1074); } }
			public int _x1078 { get { return Read<int>(0x1078); } }
			public int _x107C { get { return Read<int>(0x107C); } }
			public int _x1080 { get { return Read<int>(0x1080); } }
			public int _x1084 { get { return Read<int>(0x1084); } }
			public int _x1088 { get { return Read<int>(0x1088); } }
			public int _x108C { get { return Read<int>(0x108C); } }
			public int _x1090 { get { return Read<int>(0x1090); } }
			public int _x1094 { get { return Read<int>(0x1094); } }
			public int _x1098 { get { return Read<int>(0x1098); } }
			public int _x109C { get { return Read<int>(0x109C); } }
			public int _x10A0 { get { return Read<int>(0x10A0); } }
			public int _x10A4 { get { return Read<int>(0x10A4); } }
			public int _x10A8 { get { return Read<int>(0x10A8); } }
			public int _x10AC { get { return Read<int>(0x10AC); } }
			public int _x10B0 { get { return Read<int>(0x10B0); } }
			public int _x10B4 { get { return Read<int>(0x10B4); } }
			public int _x10B8 { get { return Read<int>(0x10B8); } }
			public int _x10BC { get { return Read<int>(0x10BC); } }
			public int _x10C0 { get { return Read<int>(0x10C0); } }
			public int _x10C4 { get { return Read<int>(0x10C4); } }
			public int _x10C8 { get { return Read<int>(0x10C8); } }
			public int _x10CC { get { return Read<int>(0x10CC); } }
			public int _x10D0 { get { return Read<int>(0x10D0); } }
			public int _x10D4 { get { return Read<int>(0x10D4); } }
			public int _x10D8 { get { return Read<int>(0x10D8); } }
			public int _x10DC { get { return Read<int>(0x10DC); } }
			public int _x10E0 { get { return Read<int>(0x10E0); } }
			public int _x10E4 { get { return Read<int>(0x10E4); } }
			public int _x10E8 { get { return Read<int>(0x10E8); } }
			public int _x10EC { get { return Read<int>(0x10EC); } }
			public int _x10F0 { get { return Read<int>(0x10F0); } }
			public int _x10F4 { get { return Read<int>(0x10F4); } }
			public int _x10F8 { get { return Read<int>(0x10F8); } }
			public int _x10FC { get { return Read<int>(0x10FC); } }
			public int _x1100 { get { return Read<int>(0x1100); } }
			public int _x1104 { get { return Read<int>(0x1104); } }
			public int _x1108 { get { return Read<int>(0x1108); } }
			public int _x110C { get { return Read<int>(0x110C); } }
			public int _x1110 { get { return Read<int>(0x1110); } }
			public int _x1114 { get { return Read<int>(0x1114); } }
			public int _x1118 { get { return Read<int>(0x1118); } }
			public int _x111C { get { return Read<int>(0x111C); } }
			public int _x1120 { get { return Read<int>(0x1120); } }
			public int _x1124 { get { return Read<int>(0x1124); } }
			public int _x1128 { get { return Read<int>(0x1128); } }
			public int _x112C { get { return Read<int>(0x112C); } }
			public int _x1130 { get { return Read<int>(0x1130); } }
			public int _x1134 { get { return Read<int>(0x1134); } }
			public int _x1138 { get { return Read<int>(0x1138); } }
			public int _x113C { get { return Read<int>(0x113C); } }
			public int _x1140 { get { return Read<int>(0x1140); } }
			public int _x1144 { get { return Read<int>(0x1144); } }
			public int _x1148 { get { return Read<int>(0x1148); } }
			public int _x114C { get { return Read<int>(0x114C); } }
			public int _x1150 { get { return Read<int>(0x1150); } }
			public int _x1154 { get { return Read<int>(0x1154); } }
			public int _x1158 { get { return Read<int>(0x1158); } }
			public int _x115C { get { return Read<int>(0x115C); } }
			public int _x1160 { get { return Read<int>(0x1160); } }
			public int _x1164 { get { return Read<int>(0x1164); } }
			public int _x1168 { get { return Read<int>(0x1168); } }
			public int _x116C { get { return Read<int>(0x116C); } }
			public int _x1170 { get { return Read<int>(0x1170); } }
			public int _x1174 { get { return Read<int>(0x1174); } }
			public int _x1178 { get { return Read<int>(0x1178); } }
			public int _x117C { get { return Read<int>(0x117C); } }
			public int _x1180 { get { return Read<int>(0x1180); } }
			public int _x1184 { get { return Read<int>(0x1184); } }
			public int _x1188 { get { return Read<int>(0x1188); } }
			public int _x118C { get { return Read<int>(0x118C); } }
			public int _x1190 { get { return Read<int>(0x1190); } }
			public int _x1194 { get { return Read<int>(0x1194); } }
			public int _x1198 { get { return Read<int>(0x1198); } }
			public int _x119C { get { return Read<int>(0x119C); } }
			public int _x11A0 { get { return Read<int>(0x11A0); } }
			public int _x11A4 { get { return Read<int>(0x11A4); } }
			public int _x11A8 { get { return Read<int>(0x11A8); } }
			public int _x11AC { get { return Read<int>(0x11AC); } }
			public int _x11B0 { get { return Read<int>(0x11B0); } }
			public int _x11B4 { get { return Read<int>(0x11B4); } }
			public int _x11B8 { get { return Read<int>(0x11B8); } }
			public int _x11BC { get { return Read<int>(0x11BC); } }
			public int _x11C0 { get { return Read<int>(0x11C0); } }
			public int _x11C4 { get { return Read<int>(0x11C4); } }
			public int _x11C8 { get { return Read<int>(0x11C8); } }
			public int _x11CC { get { return Read<int>(0x11CC); } }
			public int _x11D0 { get { return Read<int>(0x11D0); } }
			public int _x11D4 { get { return Read<int>(0x11D4); } }
			public int _x11D8 { get { return Read<int>(0x11D8); } }
			public int _x11DC { get { return Read<int>(0x11DC); } }
			public int _x11E0 { get { return Read<int>(0x11E0); } }
			public int _x11E4 { get { return Read<int>(0x11E4); } }
			public int _x11E8 { get { return Read<int>(0x11E8); } }
			public int _x11EC { get { return Read<int>(0x11EC); } }
			public int _x11F0 { get { return Read<int>(0x11F0); } }
			public int _x11F4 { get { return Read<int>(0x11F4); } }
			public int _x11F8 { get { return Read<int>(0x11F8); } }
			public int _x11FC { get { return Read<int>(0x11FC); } }
			public int _x1200 { get { return Read<int>(0x1200); } }
			public int _x1204 { get { return Read<int>(0x1204); } }
			public int _x1208 { get { return Read<int>(0x1208); } }
			public int _x120C { get { return Read<int>(0x120C); } }
			public int _x1210 { get { return Read<int>(0x1210); } }
			public int _x1214 { get { return Read<int>(0x1214); } }
			#endregion
			[ArraySize(6)]
			public ActiveSkillSavedData[] x1218_ActiveSkillSavedData { get { return Read<ActiveSkillSavedData>(0x1218, 6); } }
			[ArraySize(4)]
			public int[] x1278_PassivePowerSnoIds { get { return Read<int>(0x1278, 4); } }
			public SavePointData x1288_SavePointData { get { return Read<SavePointData>(0x1288); } }
			public int x1298 { get { return Read<int>(0x1298); } }
			public int _x129C { get { return Read<int>(0x129C); } }
		}

		public class HotbarButtonData : MemoryObject
		{
			public const int SizeOf = 0x10;

			public int x00_PowerSnoId { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08_ItemsGameBalanceId { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
		}

		public class HirelingSavedData : MemoryObject
		{
			public const int SizeOf = 0x88;

			[ArraySize(4)]
			public HirelingInfo[] x000_HirelingInfo { get { return Read<HirelingInfo>(0x00, 4); } }
			public int x80 { get { return Read<int>(0x80); } }
			public int x84 { get { return Read<int>(0x84); } }
		}

		public class HirelingInfo : MemoryObject
		{
			public const int SizeOf = 0x20;

			public int x00 { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int x08 { get { return Read<int>(0x08); } }
			public int x0C { get { return Read<int>(0x0C); } }
			public int x10 { get { return Read<int>(0x10); } }
			public int x14 { get { return Read<int>(0x14); } }
			public int x18 { get { return Read<int>(0x18); } }
			public int x1C { get { return Read<int>(0x1C); } }
		}

		public class LearnedLore : MemoryObject
		{
			public const int SizeOf = 0x804;

			public int x000_Count { get { return Read<int>(0x00); } }
			[ArraySize(512)]
			public int[] x004_LoreSnoIds { get { return Read<int>(0x04, 512); } }
		}

		public class ActiveSkillSavedData : MemoryObject
		{
			// 2.1.0.26451
			public const int SizeOf = 0x10; // 16

			public int x00_PowerSnoId { get { return Read<int>(0x00); } }
			public int x04_RuneId { get { return Read<int>(0x04); } }
			public int _x08 { get { return Read<int>(0x08); } }
			public int _x0C { get { return Read<int>(0x0C); } }
		}


		public class SavePointData : MemoryObject
		{
			public const int SizeOf = 0x10;

			public int x00_WorldsSnoId { get { return Read<int>(0x00); } }
			public int x04 { get { return Read<int>(0x04); } }
			public int _x08 { get { return Read<int>(0x08); } }
			public int _x0C { get { return Read<int>(0x0C); } }
		}

		public class XC084 : MemoryObject
		{
			public const int SizeOf = 8;

			public int x00_Neg1_FollowerAcdId { get { return Read<int>(0x00); } }
			public int x04_Neg1 { get { return Read<int>(0x04); } }
		}

		public class XCF14 : MemoryObject
		{
			public const int SizeOf = 0x20; // 32

			public int x00_Neg1 { get { return Read<int>(0x00); } }
			public int _x04 { get { return Read<int>(0x04); } }
			public int _x08 { get { return Read<int>(0x08); } }
			public int _x0C { get { return Read<int>(0x0C); } }
			public int _x10 { get { return Read<int>(0x10); } }
			public int _x14 { get { return Read<int>(0x14); } }
			public int _x18 { get { return Read<int>(0x18); } }
			public int x1C { get { return Read<int>(0x1C); } }
		}
	}

	public partial class PlayerData
	{
		public static PlayerData Local { get { return Engine.TryGet(engine => PlayerDataManager.Instance.x0038_Items[Player.Instance.x00000_LocalDataIndex]); } }
		
		public static PlayerData GetByIndex(int index)
		{
			if (index < 0 || index >= 8)
				throw new ArgumentOutOfRangeException();

			return PlayerDataManager.Instance.IfNotNull(a => a.x0038_Items[index]);
		}

		[Obsolete]
		public int[] GetActivePowerSnoIds()
		{
			return x00A0_ServerData.x000C_PlayerSavedData.x1218_ActiveSkillSavedData.Select(a => a.x00_PowerSnoId).ToArray();
		}

		[Obsolete]
		public ActiveSkillSavedData[] GetActiveSkills()
		{
			return x00A0_ServerData.x000C_PlayerSavedData.x1218_ActiveSkillSavedData;
		}

		[Obsolete]
		public int[] GetPassivePowerSnoIds()
		{
			return x00A0_ServerData.x000C_PlayerSavedData.x1278_PassivePowerSnoIds;
		}

		[Obsolete("This is removed from the game, use GetCurrency instead.")]
		public IEnumerable<VendorToken> EnumerateVendorTokens()
		{
			return x88A4_VendorTokens.Take(x90A4_VendorTokenCount);
		}

		[Obsolete]
		public long GetCurrency(CurrencyType type)
		{
			return Read<long>((24 * (int)type) + 0x8520);
		}

		public long GetHeroId()
		{
			return Read<long>(Globals.Offset_PlayerData_HeroName - sizeof(long));
		}

		public string GetHeroName()
		{
			return ReadString(Globals.Offset_PlayerData_HeroName, 49);
		}

		public float GetLifePercentage()
		{
			return Read<float>(Globals.Offset_PlayerData_LifePercentage);
		}
	}

	public enum CurrencyType
	{
		Gold = 0,
		X1Shard = 1,
		BattleNetStore = 2
	}
}
