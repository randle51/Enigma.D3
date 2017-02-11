using Enigma.D3.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Core
{
	public interface ILocalData
	{
		bool IsPlayerValid { get; }   //bPlayerValid
		bool IsStartUpGame { get; }   //bGameIsStartUp
		int SceneSNO { get; }         //snoScene
		int WorldSNO { get; }         //snoWorld
		int PlayerActorSNO { get; }   //snoPlayerActor
	 	int ActID { get; }            //eAct
		int WorldSeed { get; }        //dwSeed
		int QuestSNO { get; }         //snoQuest
		int QuestStepUID { get; }     //nQuestStepUID
		Vector3 WorldPos { get; }     //tWorldPos.x, tWorldPos.y, tWorldPos.z
		int PlayerCount { get; }      //nPlayers
		int LocalPlayerCount { get; } //nLocalPlayers
	}
}
