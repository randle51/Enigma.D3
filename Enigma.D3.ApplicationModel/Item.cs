using Enigma.D3.AttributeModel;
using Enigma.D3.Enums;
using Enigma.D3.MemoryModel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.ApplicationModel
{
    public class Item : Actor
    {
        public string ItemSlug => AssetCache.GetSlug(SNOType.Actor, ACD.ActorSNO);

        public string ItemName => AssetCache.GetItemName(ItemSlug);

        public ItemQuality Quality => (ItemQuality)GetAttributeValue(Attributes.ItemQualityLevel);

        public ItemLocation ItemLocation => ACD.ItemLocation;

        public int ItemSlotX => ACD.ItemSlotX;

        public int ItemSlotY => ACD.ItemSlotY;

        public bool IsEquipped => ItemLocation >= ItemLocation.PlayerHead && ItemLocation <= ItemLocation.PlayerNeck;

        public bool IsStashed => ItemLocation == ItemLocation.Stash;

        public bool IsInInventory => ItemLocation == ItemLocation.PlayerBackpack;
    }
}
