using Enigma.D3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.ApplicationModel
{
    public class HeroProfile
    {
        public ulong ID { get; internal set; }

        public string Name { get; internal set; }

        public HeroClass Class { get; internal set; }

        public int Level { get; internal set; }

        public int Paragon { get; internal set; }

        public Skill[] ActiveSkills { get; } = Enumerable.Range(0, 6).Select(x => new Skill()).ToArray();

        public Skill[] PassiveSkills { get; } = Enumerable.Range(0, 4).Select(x => new Skill()).ToArray();
    }
}
