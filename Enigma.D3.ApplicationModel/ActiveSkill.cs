using Enigma.D3.MemoryModel.Preferences;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.ApplicationModel
{
    public class ActiveSkill : Skill
    {
        public Hotkey Hotkey { get; internal set; }
    }
}
