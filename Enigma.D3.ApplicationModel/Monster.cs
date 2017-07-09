using Enigma.D3.Enums;
using Enigma.D3.MemoryModel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.ApplicationModel
{
    public class Monster : Actor
    {
        public MonsterQuality Rarity => ACD.MonsterQuality;

        public bool IsEnemy => ACD.TeamID == 10;

        public bool IsAlive => ACD.Hitpoints > 0.00001;

        public bool IsTargetable => (ACD.ObjectFlags & 1) == 0;
    }
}
