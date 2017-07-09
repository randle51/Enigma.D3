using Enigma.D3.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.ApplicationModel
{
    public class WorldLocation
    {
        public World World { get; internal set; }

        public Scene Scene { get; internal set; }

        public Vector3 Position { get; internal set; }
    }
}
