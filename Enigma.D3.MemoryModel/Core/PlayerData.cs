using Enigma.D3.DataTypes;
using Enigma.D3.Enums;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Core
{
    public class PlayerData : MemoryObject
    {
        public static int SizeOf => SymbolTable.Current.PlayerData.SizeOf;

        public int Index => Read<int>(SymbolTable.Current.PlayerData.Index);
        public int ACDID => Read<int>(SymbolTable.Current.PlayerData.ACDID);
        public int ActorID => Read<int>(SymbolTable.Current.PlayerData.ActorID);
        public PlayerSavedData PlayerSavedData => Read<PlayerSavedData>(SymbolTable.Current.PlayerData.PlayerSavedData);
        public ulong HeroID => Read<ulong>(SymbolTable.Current.PlayerData.HeroID);
        public string HeroName => ReadString(SymbolTable.Current.PlayerData.HeroName, 49);
        public SNO ActorSNO => Read<SNO>(SymbolTable.Current.PlayerData.ActorSNO);
        public float LifePercentage => Read<float>(SymbolTable.Current.PlayerData.LifePercentage);
        public HeroClass HeroClass => Read<HeroClass>(SymbolTable.Current.PlayerData.HeroClass);
        public int Level => Read<int>(SymbolTable.Current.PlayerData.Level);
        public int AltLevel => Read<int>(SymbolTable.Current.PlayerData.AltLevel);

        public SNO PowerUse => this.PlatformRead<SNO>(0xCE28, 0xD000);
        public SNO PowerCast => this.PlatformRead<SNO>(0xCE3C, 0xD014);
    }
}
