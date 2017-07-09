using Enigma.D3.DataTypes;
using Enigma.D3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.ApplicationModel
{
    public class Scene
    {
        public MemoryModel.Core.Scene Memory { get; internal set; }

        public SNO SceneSNO { get; internal set; }

        public string SceneSlug => AssetCache.GetSlug(SNOType.Scene, SceneSNO);

        public World World { get; internal set; }

        public SNO LevelAreaSNO { get; internal set; }

        public string LevelAreaSlug => AssetCache.GetSlug(SNOType.LevelArea, LevelAreaSNO);

        public string LevelAreaName => AssetCache.GetLevelAreaName(LevelAreaSlug);
    }
}
