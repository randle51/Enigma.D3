using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Core
{
	public interface IQuestManager
	{
		IReadOnlyCollection<IQuest> Quests { get; }
	}
}
