using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.ApplicationModel
{
    public class LocalPlayer : Player
    {
        internal Game Game { get; set; }

        public ActionBar ActionBar { get; } = new ActionBar();

        public IEnumerable<Item> Equipment => Game.Items.Where(x => x.IsEquipped);

        public IEnumerable<Item> Inventory => Game.Items.Where(x => x.IsInInventory);

        public IEnumerable<Item> Stash => Game.Items.Where(x => x.IsStashed);
    }
}
