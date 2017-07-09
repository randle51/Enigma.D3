using Enigma.D3.DataTypes;
using Enigma.D3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.ApplicationModel
{
    public class World
    {
        public MemoryModel.Core.World Memory { get; internal set; }

        public SNO WorldSNO { get; internal set; }

        public string Slug => AssetCache.GetSlug(SNOType.Worlds, WorldSNO);
    }
}
