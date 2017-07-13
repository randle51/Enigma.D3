using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel
{
    public interface ISegment
    {
        MemoryAddress Start { get; }
        MemoryAddress End { get; }
    }
}
