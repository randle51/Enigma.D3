using Enigma.D3.DataTypes;
using Enigma.D3.Enums;
using Enigma.D3.MemoryModel;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.BattleNet
{
    public class Hero : MemoryObject
    {
        //public static int SizeOf => SymbolTable.Current.Platform == Platform.X86 ?
        //    0 : 0x1A8;
        
        public ulong HeroId => this.PlatformRead<ulong>(0xB8, 0xC0);
        public string Name => this.PlatformReadStringPointer(0xC4, 0xD0, maxLength: 512).Dereference();
        public HeroClass Class => this.PlatformRead<HeroClass>(0xD4, 0xE8);
        public int Level => this.PlatformRead<int>(0xDC, 0xF0);
        public int Paragon => this.PlatformRead<int>(0xE0, 0xF4);
        public int HighestSoloRift => this.PlatformRead<int>(0xE8, 0xFC);
        public int PvpRank => this.PlatformRead<int>(0xEC, 0x100);
        public int HighestAct => this.PlatformRead<int>(0xF4, 0x108);
        public int Flags => this.PlatformRead<int>(0x124, 0x138);
        public int LastPlayedAct => this.PlatformRead<int>(0x130, 0x14C);
        public SNO Quest => this.PlatformRead<SNO>(0x134, 0x150);
        public int QuestStep => this.PlatformRead<int>(0x138, 0x154);
        public TimeSpan Played => TimeSpan.FromSeconds(this.PlatformRead<int>(0x13C, 0x158));

        public bool IsHardcore => (Flags & 1) != 0;
        public bool IsDeceased => (Flags & 8) != 0;

        public override string ToString() => Name;
    }
}
