using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.CodeGen.Memory.PatternScanning
{
	internal static class PatternProvider
	{
		public static IEnumerable<string> GetPatterns()
		{
			// PlayerDataManager
			yield return PlayerDataManager_InitializeThroughStorage;

			// PlayerData.SizeOf
			yield return PlayerData_GetByAcdId;

			// ObjectManager, ObjectManager.Storage
			yield return ObjectManager_Initialize;
			yield return ObjectManager_InitializeFields;

			// ContainerManager
			yield return "55|8BEC|6AFF|68........|64A100000000|50|51|57|A1........|33C5|50|8D45F4|64A3 00 0000 0000 :0000 CContainerManager::Initialize ^008D .data:ContainerManager";
			yield return "55|8BEC|6AFF|68........|64A100000000|50|51|56|A1........|33C5|50|8D45F4|64A300000000|6A30 00 0000 0000 :0000 CContainerManager::Initialize ^0014 .data:___security_cookie ^0061 .data:ContainerManager";

			// ScreenManager
			yield return "55|8BEC|6AFF|68........|64A100000000|50|64892500000000|81ECA8000000|6A..| 00 0000 0000 :0000 CScreenManager::Initialize ^001F:1 sizeof(ScreenManager) ^003C .data:ScreenManager ^0041 .text:CScreenManager::InitializeFields ^0049 .text:CRefString::SetEmpty ^0058 .text:CRefString::SetEmpty ^0064 .text:CRefString::SetEmpty";

			// AttributeSystem
			yield return "55|8BEC|6AFF|68........|64A100000000|50|83EC1C535657A1........33C5508D 00 0000 0000 :0000 CAttributeSystem::Initialize ^0116 .data:AttributeDescriptors";
			yield return "55|8BEC|51|53|8B5D08|8BCB|56|57|8D5101|90|8A01|41|84C0|75F9|2BCA|7454 00 0000 0000 :0000 StringToAttrib ^001E .data:AttributeDescriptors.FirstName ^0055 .data:AttributeDescriptors.MaxName++ ^007F .data:AttributeDescriptors";

			// LocalData, ApplicationLoopCount
			yield return Application_Do;

			// BuffManager
			yield return "53|6A01|33DB|53|6A04|6A..|E8........|83C410|A3........|C740040A000000|C700 00 0000 00A0 :0000 CBuffManager::Initialize ^0009:1 sizeof(BuffManager) ^0013 .data:BuffManager ^0042 .data:BuffManager";

			// LevelArea
			yield return LevelArea_Initialize;

			// LevelAreaName
			yield return "55|8BEC|64A100000000|6AFF|68........|50|64892500000000|81EC........|53|56| 00 0000 0000 :0000 CLevelArea::Update ^02DB .data:LevelAreaName ^0312 .data:LevelAreaName";

			// Preferences
			yield return "55|8BEC|56|8B7508|6A06|68........|56|B9........|E8........|83C40C|85C0|0F84 00 0000 0000 :0000 CPreferences::Dump ^0027 .data:VideoPreferences ^0044 .data:SoundPreferences ^0061 .data:GameplayPreferences ^0093 .data:SocialPreferences ^00AC .data:ChatPreferences";
			yield return "55|8BEC|56|8B7508|6A06|68........|68........|56|E8........|83C410|85C0|0F84 00 0000 0000 :0000 CPreferences::Dump ^002C .data:VideoPreferences ^0049 .data:SoundPreferences ^0066 .data:GameplayPreferences ^0098 .data:SocialPreferences ^00B1 .data:ChatPreferences";

			// UIHandlers
			yield return "55|8BEC|83EC0C|56|57|E8........|8BF8|897DF4|C745FC00000000|33F6|EB03|8D4900 00 0000 0000 :0000 CUIManager::BindHandlers ^0022 .data:UIHandlers ^0091:1 sizeof(UIHandler) ^0094 UIHandlersSize";

			// SnoGroups, SnoGroupsByCode
			yield return "56|57|6A00|6A00|6A04|68F4000000|E8........|6818010000|68........|A3...... 00 0000 0074 :0000 CSnoGroups::Initialize ^0018 .data:SnoGroupsByCode ^001D .data:SnoGroups ^002C .data:SnoGroupInitializers+4 ^003F .data:SnoGroups ^0048 .data:SnoGroups ^005B .data:SnoGroupsByCode";

			// SnoFiles
			yield return "55|8BEC|6AFF|68........|64A100000000|50|83EC08|53|56|57|A1........|33C5|50|8D 0D 90FE 0356 :0000 CSnoFiles::Initialize ^0031 .data:SnoFiles ^008E .data:SnoFiles ^0105 .data:SnoFiles ^0124 .data:SnoFiles ^013B .data:SnoFiles ^0153 .data:SnoFiles ^0183 .data:SnoFiles ^01A7 .data:SnoFiles ^0276 .data:SnoFiles ^02DD .data:SnoFiles ^0304 .data:SnoFiles ^032B .data:SnoFiles";

			// SnoIdToEntityId
			yield return "558BEC8B4D083B0D........727B81F9EFD8FFFF721883F9FF740E83F9FE7409 03 0BDB 0094 :0000 CSno_GetGlobal ^0090 .data:SnoIdToEntityId";

			// SnoGroupSearch
			yield return "55|8BEC|A1........|53|56|33F6|57|3930|7E25|8B5D08|33FF|8D440704|53|50|FF15.... 00 0000 0050 :0000 CSnoGroupSearch::GetSnoGroupIdBySnoGroupName ^0004 .data:SnoGroupSearch ^002A .data:SnoGroupSearch ^0040 .data:SnoGroupSearch";

			// SnoFilesAsync
			yield return "558BEC6AFF68........64A1000000005051A1........33C5508D45F464A300 04 9013 008D :0000 CSnoFilesAsync::Initialize ^0072 .data:SnoFilesAsync";

			// WorldMap
			yield return "55|8BEC|64A100000000|6AFF|68........|50|64892500000000|83EC24|68........ 01 3E9B 0125 :0000 UI::ShowWorldMap ^004F .data:MapActId";

			// UIReferences
			yield return "55|8BEC|B8........|E8........|8D855806FCFF|68........|50|E8........|83C4 00 0000 BB91 :0000 CUIElement::InitializeReferences_Batch1 ^0004 UIReferences.Batch1Alloc ^0022 .data:UIReferences ^0034 .data:UIReferences";

			// MessageDescriptor
			yield return "55|8BEC|81ECA0000000|A1........|33C5|8945FC|56|57|68........|E8........|6A 00 0000 0000 :0000 CClientCommunication::Initialize ^0041 .data:MessageDescriptor";

			// MessageHandlers
			yield return GameMessage_GetHandlerInfo;

			// PrimaryAttributes
			yield return "55|8BEC|83EC10|53|56|57|33F6|56|8D45F8|68........|50|E8........|8B38|68...... 00 0000 0000 :0000 InitPrimaryAttributes ^003A .data:PrimaryAttributes";

			// SecondaryAttributes
			yield return "55|8BEC|83EC08|53|56|57|33FF|57|8D45FC|6A..|50|E8........|8B30|68........|E8.. 00 0000 0000 :0000 InitSecondaryAttributes ^0035 .data:SecondaryAttributes";

			// TrickleManager
			yield return "558BEC6AFF68........64A100000000506489250000000051536A0133DB536A 04 835D 0106 :0000 CTrickleManager::Initialize ^002B .data:TrickleManager ^0076 .data:TrickleManager ^00BA .data:TrickleManager";

			// PtrSnoFiles
			yield return "558BEC6AFF68........64A1000000005083EC1C535657A1........33C5508D 11 8F77 0178 :0000 GetMpqDirectory ^0031 .data:PtrSnoFiles";
		}

		public static string LevelArea_Initialize
			=> "55|8BEC|6AFF|68........|64A100000000|50|64892500000000|51|68........|E8........ 00 0000 0000 :0000 LevelArea::Initialize ^001A sizeof(LevelArea) ^004A .data:LevelArea";

		public static string Application_Do
			=> "68........|E8........|A1........|8B0D........|40|83C404|A3........|A3.. 00 0000 0188 :0000 Application::Do ^0001 .data:LocalData ^000B .data:ApplicationLoopCount ^001A .data:ApplicationLoopCount";

		public static string ObjectManager_Initialize
			=> "6A016A006A0468....0000E8........50A3........E8........A1........ 04 E6F8 0029 :0000 ObjectManager::Initialize ^0007 sizeof(ObjectManager) ^0012 .data:ObjectManagerPristine ^0017 ObjectManager::InitializeFields ^001C .data:ObjectManagerPristine ^0024 .data:ObjectManager";

		public static string ObjectManager_InitializeFields
			=> "55|8BEC|57|E8........|8B7D08|8907 00 0000 0000 :0000 ObjectManager::InitializeFields ^006A ObjectManager.Storage";

		public static string PlayerData_GetByAcdId
			=> "55|8BEC|56|8B7508|83FEFF|742B|A1........|50|FF15........|8B08|8B11|8B82........|33C9 00 0000 003C :0000 CPlayerData::GetByAcdId ^002E sizeof(PlayerData)";

		public static string PlayerDataManager_InitializeThroughStorage
			=> "558BEC6AFF68........64A1000000005051535657A1........33C5508D45F4 0C 2B37 01FE :0000 PlayerDataManager::InitializeThroughStorage ^0034 sizeof(PlayerDataManager) ^019D sizeof(PlayerData)";

		public static string GameMessage_GetHandlerInfo
			=> "55|8BEC|8B4508|8B4D0C|8B5510|48|C70100000000|C70200000000|3D....0000|0F87........| 00 0000 0000 :0000 CGameMessage::GetHandlerInfo";
	}
}
