using Enigma.D3.MemoryModel.Segments;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.D3.MemoryModel.Core;
using Enigma.D3.MemoryModel.Preferences;
using Enigma.D3.MemoryModel.TypeSystem;
using Enigma.D3.MemoryModel.MemoryManagement;
using Enigma.D3.MemoryModel32.MemoryManagement;

namespace Enigma.D3.MemoryModel32.Segments
{
	public class DataSegment : MemoryObject, IDataSegment
	{
		public int ApplicationLoopCount
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public IAttributeDescriptor[] AttributeDescriptors
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public IChatPreferences ChatPreferences
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public MemoryAddress End
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public IGameplayPreferences GameplayPreferences
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public IHotkeyPreferences HotkeyPreferences
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public ILevelArea LevelArea
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public string LevelAreaName
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public ILocalData LocalData
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int MapActID
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public IMemoryManager MemoryManager
			=> Memory.Reader.Read<Ptr<MemoryManager>>(Constants.DataSegment.MemoryManager).Dereference();
		
		public IObjectManager ObjectManager
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public ISocialPreferences SocialPreferences
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public ISoundPreferences SoundPreferences
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

		public ITrickleManager TrickleManager
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public IVideoPreferences VideoPreferences
		{
			get
			{
				throw new NotImplementedException();
			}
		}
	}
}
