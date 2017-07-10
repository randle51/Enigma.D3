using Enigma.D3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.ApplicationModel
{
    public class Game
    {
        internal Dictionary<int, Monster> MonsterProxies { get; } = new Dictionary<int, Monster>();
        internal Dictionary<int, Item> ItemProxies { get; } = new Dictionary<int, Item>();
        internal Dictionary<int, World> WorldProxies { get; } = new Dictionary<int, World>();
        internal Dictionary<int, Scene> SceneProxies { get; } = new Dictionary<int, Scene>();

        public int Tick { get; internal set; }

        public TimeSpan Clock => TimeSpan.FromSeconds((double)Tick / 60);

        public GameDifficulty Difficulty { get; internal set; }

        public LocalPlayer Player { get; internal set; }

        public IEnumerable<Monster> Monsters => MonsterProxies.Values;

        public IEnumerable<Item> Items => ItemProxies.Values;

        public IEnumerable<Item> Loot => Items.Where(x => (int)x.ItemLocation == -1);

        public IEnumerable<World> Worlds => WorldProxies.Values;
    }
}
