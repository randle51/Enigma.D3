using Enigma.D3.ApplicationModel.Caching;
using Enigma.D3.AttributeModel;
using Enigma.D3.DataTypes;
using Enigma.D3.Enums;
using Enigma.D3.MemoryModel.Core;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.ApplicationModel
{
    public class Actor
    {
        private readonly IAttributeReader _attributeReader;

        public Actor()
        {
            _attributeReader = AttributeCache.Current;
        }

        public ACD ACD { get; set; }

        public SNO ActorSNO => ACD.ActorSNO;

        public ActorType Type => ACD.ActorType;

        public WorldLocation Location { get; } = new WorldLocation();

        public virtual string Slug => AssetCache.GetSlug(SNOType.Actor, ActorSNO);

        public virtual string Name => AssetCache.GetSlug(SNOType.Actor, ActorSNO);

        public T Read<T>(Attribute<T> attribute) where T : struct
        {
            return Read(attribute, -1);
        }

        public T Read<T>(Attribute<T> attribute, int modifier) where T : struct
        {
            if (_attributeReader == null || ACD == null)
                return attribute.DefaultValue;
            return attribute.GetValue(_attributeReader, ACD.FastAttribGroupID);
        }
    }
}
