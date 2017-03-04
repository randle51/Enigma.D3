using Enigma.D3.MemoryModel;
using Enigma.D3.MemoryModel32.BattleNet;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel32Demo
{
	public static class MemoryReaderExtensions
	{
		public static T ReadChain<T>(this MemoryReader reader, MemoryAddress address, params int[] offsets)
		{
			for (int i = 0; i < offsets.Length; i++)
			{
				address = reader.Read<MemoryAddress>(address);
				address += offsets[i];
			}
			return reader.Read<T>(address);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			//var path = Environment.ExpandEnvironmentVariables(@"%TEMP%\Diablo III.DMP");
			//var ctx = new MemoryContext(new MiniDumpMemoryReader(path).Memory);
			var ctx = new MemoryContext(new ProcessMemoryReader(Process.GetProcessesByName("Diablo III").First()).Memory);

			//var nodes = ctx.DataSegment.MemoryManager.LocalHeap.ToArray();
			
			//var heroes = ctx.Memory.Reader.ReadChain<Map<Hero>>(0x01FC8D28, 0x10, 0xA8, 0x38).ToArray();

			var engine = new Engine(ctx);
			engine.Start();
			while (Console.ReadKey(true).Key != ConsoleKey.Escape) { }
			engine.Stop();
		}
	}
}
