using Enigma.D3.MemoryModel.Collections;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Caching
{
    public static class ContainerExtensions
    {
        public static List<T> GetCachedItems<T>(this Container<T> container) where T : MemoryObject
        {
            var cache = new ContainerCache<T>(container);
            cache.Update();
            return cache.NewItems;
        }
    }
}
