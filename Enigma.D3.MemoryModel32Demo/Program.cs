using Enigma.D3.MemoryModel32;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel32Demo
{
	class Program
	{
		static void Main(string[] args)
		{
			var path = Environment.ExpandEnvironmentVariables(@"%TEMP%\Diablo III.DMP");
			var ctx = new MemoryContext(new MiniDumpMemoryReader(path).Memory);

			var nodes = ctx.DataSegment.MemoryManager.LocalHeap.ToArray();
		}
	}
}
