using Enigma.D3.MemoryModel.Core;
using Enigma.D3.MemoryModel.Preferences;
using Enigma.D3.MemoryModel.TypeSystem;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Segments
{
	public interface IDataSegment : ISegment
	{
		IVideoPreferences VideoPreferences { get; }
		ISoundPreferences SoundPreferences { get; }
		IHotkeyPreferences HotkeyPreferences { get; }
		IGameplayPreferences GameplayPreferences { get; }
		ISocialPreferences SocialPreferences { get; }
		IChatPreferences ChatPreferences { get; }
		ILevelArea LevelArea { get; }
		string LevelAreaName { get; }
		int MapActID { get; }
		ITrickleManager TrickleManager { get; }
		ILocalData LocalData { get; }
		IObjectManager ObjectManager { get; }
		int ApplicationLoopCount { get; }
		IAttributeDescriptor[] AttributeDescriptors { get; }
	}
}
