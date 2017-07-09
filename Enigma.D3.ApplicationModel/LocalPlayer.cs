using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.ApplicationModel
{
    public class LocalPlayer : Player
    {
        public ActionBar ActionBar { get; } = new ActionBar();
    }
}
