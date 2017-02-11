using Enigma.D3.MemoryModel64;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel64Demo
{
	class Program
	{
		static void Main(string[] args)
		{
			var path = Environment.ExpandEnvironmentVariables(@"%TEMP%\Diablo III64.DMP");
			var ctx = new MemoryContext(new MiniDumpMemoryReader(path).Memory);
			var actors = ctx.DataSegment.ObjectManager.Actors.ToArray();
			var acds = ctx.DataSegment.ObjectManager.ACDManager.ActorCommonData.ToArray();
			var localdata = ctx.DataSegment.LocalData;
			var loopcount = ctx.DataSegment.ApplicationLoopCount;
			var fags = ctx.DataSegment.ObjectManager.FastAttrib.FastAttribGroups.ToArray();
			var playerdatas = ctx.DataSegment.ObjectManager.PlayerDataManager.ToArray();
			var scenes = ctx.DataSegment.ObjectManager.Scenes.ToArray();
			var worlds = ctx.DataSegment.ObjectManager.Worlds.ToArray();
			var quests = ctx.DataSegment.ObjectManager.QuestManager.Quests.ToArray();
			var waypoints = ctx.DataSegment.ObjectManager.WaypointManager.ToArray();
			var trickles = ctx.DataSegment.TrickleManager.Items.ToArray();
			var uimgr = ctx.DataSegment.ObjectManager.UIManager;
			var timedevents = ctx.DataSegment.ObjectManager.TimedEvents.ToArray();
			var levelarea = ctx.DataSegment.LevelArea;
			var levelareaname = ctx.DataSegment.LevelAreaName;
			var mapactid = ctx.DataSegment.MapActID;
			var attribs = ctx.DataSegment.AttributeDescriptors;
			var gamestate = ctx.DataSegment.ObjectManager.GameState;
			var localindex = ctx.DataSegment.ObjectManager.Player.LocalPlayerIndex;
			var latency = ctx.DataSegment.ObjectManager.Player.LatencySamples.Average();
			var floaters = ctx.DataSegment.ObjectManager.Player.FloatingNumbers.ToArray();
		}
	}
}
