using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class BuffManager : MemoryObject
	{
		public const int SizeOf = 0x58; // 1.0.8.16603 : [0x00C63EE0] BuffManager::Create

		public BuffManager(ProcessMemory memory, int address)
			: base(memory, address) { }

		public Allocator x00_BuffAllocator { get { return Field<Allocator>(0x00); } } // <-- Shared by all lists.
		public LinkedList<Buff> x1C_HelpfulBuffs { get { return Field<LinkedList<Buff>>(0x1C); } }
		public int _x2C { get { return Field<int>(0x2C); } }
		public LinkedList<Buff> x30_HarmfulBuffs { get { return Field<LinkedList<Buff>>(0x30); } }
		public int _x40 { get { return Field<int>(0x40); } }
		public LinkedList<Buff> x44_BuffList { get { return Field<LinkedList<Buff>>(0x44); } }
		public int _x54 { get { return Field<int>(0x54); } }
	}
}