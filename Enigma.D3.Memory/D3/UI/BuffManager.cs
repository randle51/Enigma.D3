using Enigma.Memory;
using System;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.UI
{
	public partial class BuffManager : MemoryObject
	{
		// 2.0.4.23119
		public const int SizeOf = 0x6C; // 108

		public Allocator x00_Allocator_10x2640Bytes_Buff { get { return Read<Allocator>(0x00); } }
		public LinkedList<Buff> x1C_Buffs { get { return Read<LinkedList<Buff>>(0x1C); } }
		public int _x2C { get { return Read<int>(0x2C); } }
		public LinkedList<Buff> x30_Debuffs { get { return Read<LinkedList<Buff>>(0x30); } }
		public int _x40 { get { return Read<int>(0x40); } }
		public LinkedList<Buff> x44_BuffList { get { return Read<LinkedList<Buff>>(0x44); } }
		public int _x54 { get { return Read<int>(0x54); } }
		public LinkedList<Buff> x58_BuffList { get { return Read<LinkedList<Buff>>(0x58); } }
		public int _x68 { get { return Read<int>(0x68); } }
	}

	public partial class BuffManager
	{
		public static BuffManager Instance { get { return Engine.TryGet(engine => engine.BuffManager); } }

		public static bool IsBuffActive(int powerSnoId)
		{
			return Instance?.x1C_Buffs.Any(buff => buff.x000_PowerSnoId == powerSnoId) ?? false;
		}

		public static bool IsDebuffActive(int powerSnoId)
		{
			return Instance?.x30_Debuffs.Any(debuff => debuff.x000_PowerSnoId == powerSnoId) ?? false;
		}
	}
}
