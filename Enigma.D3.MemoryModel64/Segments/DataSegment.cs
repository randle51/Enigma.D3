using Enigma.D3.MemoryModel.Segments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.Memory;
using Enigma.D3.MemoryModel.Core;
using Enigma.D3.MemoryModel64.Core;
using Enigma.D3.MemoryModel.Preferences;
using Enigma.D3.MemoryModel64.Preferences;
using Enigma.D3.MemoryModel.TypeSystem;
using Enigma.D3.MemoryModel64.TypeSystem;
using Enigma.D3.MemoryModel.MemoryManagement;

namespace Enigma.D3.MemoryModel64.Segments
{
	public class DataSegment : MemoryObject, IDataSegment
	{
		public MemoryAddress End
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public MemoryAddress Start
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public IVideoPreferences VideoPreferences
			=> Memory.Reader.Read<VideoPreferences>(Constants.DataSegment.VideoPreferences);

		public ISoundPreferences SoundPreferences
			=> Memory.Reader.Read<SoundPreferences>(Constants.DataSegment.SoundPreferences);

		public IHotkeyPreferences HotkeyPreferences
			=> Memory.Reader.Read<HotkeyPreferences>(Constants.DataSegment.HotkeyPreferences);

		public IGameplayPreferences GameplayPreferences
			=> Memory.Reader.Read<GameplayPreferences>(Constants.DataSegment.GameplayPreferences);

		public ISocialPreferences SocialPreferences
			=> Memory.Reader.Read<SocialPreferences>(Constants.DataSegment.SocialPreferences);

		public IChatPreferences ChatPreferences
			=> Memory.Reader.Read<ChatPreferences>(Constants.DataSegment.ChatPreferences);

		public ILevelArea LevelArea
			=> Memory.Reader.Read<Ptr<LevelArea>>(Constants.DataSegment.LevelArea).Dereference();

		public string LevelAreaName
			=> Memory.Reader.ReadString(Constants.DataSegment.LevelAreaName, Constants.DataSegment.LevelAreaNameLength);

		public int MapActID
			=> Memory.Reader.Read<int>(Constants.DataSegment.MapActID);

		public ITrickleManager TrickleManager
			=> Memory.Reader.Read<Ptr<TrickleManager>>(Constants.DataSegment.TrickleManager).Dereference();

		public ILocalData LocalData
			=> Memory.Reader.Read<LocalData>(Constants.DataSegment.LocalData);

		public IObjectManager ObjectManager
			=> Memory.Reader.Read<Ptr<ObjectManager>>(Constants.DataSegment.ObjectManager).Dereference();

		public int ApplicationLoopCount
			=> Memory.Reader.Read<int>(Constants.DataSegment.ApplicationLoopCount);

		public IAttributeDescriptor[] AttributeDescriptors
			=> Memory.Reader.Read<AttributeDescriptor>(Constants.DataSegment.AttributeDescriptors, Constants.DataSegment.AttributeDescriptorsCount);

		public IMemoryManager MemoryManager
		{
			get
			{
				throw new NotImplementedException();
			}
		}
	}
}
