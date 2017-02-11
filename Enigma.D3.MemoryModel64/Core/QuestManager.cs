using Enigma.D3.MemoryModel.Core;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel64.Core
{
	public class QuestManager : MemoryObject, IQuestManager
	{
		public IReadOnlyCollection<IQuest> Quests
			=> Read<Collections.LinkedList<Quest>>(Constants.QuestManager.Quests);
	}
}
