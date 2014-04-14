using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class DisplayMonitor : MemoryObject
	{
		public const int SizeOf = 0x24; // 1.0.8.16603 : [0x00E89B80]

		public DisplayMonitor(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x00_MonitorHandle { get { return Field<int>(0x00); } }
		public int x04_MonitorLeft { get { return Field<int>(0x04); } }
		public int x08_MonitorTop { get { return Field<int>(0x08); } }
		public int x0C_MonitorWidth { get { return Field<int>(0x0C); } }
		public int x10_MonitorHeight { get { return Field<int>(0x10); } }
		public int x14_WorkAreaLeft { get { return Field<int>(0x14); } }
		public int x18_WorkAreaTop { get { return Field<int>(0x18); } }
		public int x1C_WorkAreaRight { get { return Field<int>(0x1C); } }
		public int x20_WorkAreaBottom { get { return Field<int>(0x20); } }
	}
}
