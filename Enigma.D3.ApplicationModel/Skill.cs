using Enigma.D3.DataTypes;
using Enigma.D3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.ApplicationModel
{
    public class Skill
    {
        public string Slug => AssetCache.GetSlug(SNOType.Power, PowerSNO);

        public string Name => AssetCache.GetPowerName(Slug);

        public string Description => AssetCache.GetPowerDescription(Slug);

        public SNO PowerSNO { get; internal set; }

        public Rune Rune { get; internal set; } // null for passive skills
    }
}
