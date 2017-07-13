using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3.MemoryModel.Core
{
    public class LocalData : MemoryObject
    {
        public static int SizeOf => SymbolTable.Current.LocalData.SizeOf;

        public int ActID => Read<int>(SymbolTable.Current.LocalData.ActID);

        public int PlayerActorSNO => Read<int>(SymbolTable.Current.LocalData.ActorSNO);

        public bool IsPlayerValid => Read<int>(SymbolTable.Current.LocalData.IsPlayerValid) != 0;

        public bool IsStartUpGame => Read<int>(SymbolTable.Current.LocalData.IsStartUpGame) != 0;

        public int LocalPlayerCount => Read<int>(SymbolTable.Current.LocalData.LocalPlayerCount);

        public int PlayerCount => Read<int>(SymbolTable.Current.LocalData.PlayerCount);

        public int QuestSNO => Read<int>(SymbolTable.Current.LocalData.QuestSNO);

        public int QuestStepUID => Read<int>(SymbolTable.Current.LocalData.QuestStepUID);

        public int SceneSNO => Read<int>(SymbolTable.Current.LocalData.SceneSNO);

        public Vector3 WorldPos => Read<Vector3>(SymbolTable.Current.LocalData.WorldPos);

        public int WorldSeed => Read<int>(SymbolTable.Current.LocalData.WorldSeed);

        public int WorldSNO => Read<int>(SymbolTable.Current.LocalData.WorldSNO);
    }
}
