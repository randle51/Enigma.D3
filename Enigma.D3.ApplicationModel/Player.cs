using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.ApplicationModel
{
    public class Player : Actor
    {
        public int Index { get; internal set; }

        public HeroProfile HeroProfile { get; } = new HeroProfile();
    }
}
