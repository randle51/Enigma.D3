using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class Player : MemoryObject
	{
		public const int SizeOf = 0x8598; // 1.0.8.16603

		public Player(ProcessMemory memory, int address)
			: base(memory, address) { }

		// 0xB4: Skill Array
		// 0xA04: Passives Array

		public int x0000_Index { get { return Field<int>(0x0000); } }
		public int x0004_AcdId { get { return Field<int>(0x0004); } }
		public int x0008_ActorId { get { return Field<int>(0x0008); } }
		public byte[] x000C { get { return Field<byte>(0x000C, 48); } }
		public int x003C { get { return Field<int>(0x003C); } }
		public byte[] x0040 { get { return Field<byte>(0x0040, 96); } }
		//public byte[] x00A0_HeroState { get { return Field<byte>(0x00A0, 0x4C14); } }
		public HeroState x00A0_HeroState { get { return Field<HeroState>(0x00A0); } }

		public int x0060 { get { return Field<int>(0x0060); } }
		public int x0064 { get { return Field<int>(0x0060); } }
		public int x0068 { get { return Field<int>(0x0060); } }

		public byte[] x4CB4 { get { return Field<byte>(0x4CB4, 9916); } }
		public long x7370 { get { return Field<int>(0x7370); } }
		public long x7378 { get { return Field<long>(0x7378); } }
		public byte[] x7380_PlayerRelatedString { get { return Field<byte>(0x7380, 192); } }
		public long x7440 { get { return Field<long>(0x7440); } }
		public long x7448 { get { return Field<long>(0x7448); } }
		public string PlayerName { get { return Field(0x7450, 49); } }
		public string x7481_Text32 { get { return Field(0x7481, 32); } }
		public byte[] x74A1 { get { return Field<byte>(0x74A1, 55); } }

		public Point3D x74C8_WorldPosition { get { return Field<Point3D>(0x74C8); } }
		public int x74D4_WorldId { get { return Field<int>(0x74D4); } }

		public LinkedList<MemoryObject> x74D8_List { get { return Field<LinkedList<MemoryObject>>(0x74D8); } }
		public int x74E8 { get { return Field<int>(0x74E8); } }
		public LinkedList<MemoryObject> x74EC_List { get { return Field<LinkedList<MemoryObject>>(0x74EC); } }
		public int x74FC { get { return Field<int>(0x74FC); } }
		public int x7500_AcdIdRelated { get { return Field<int>(0x7500); } }
		public byte[] x7504 { get { return Field<byte>(0x7504, 1004); } }
		public PlayerClass x78F0_HeroClass { get { return (PlayerClass)Field<int>(0x78F0); } }
		public byte[] x78F4 { get { return Field<byte>(0x78F4, 4); } }
		public int x78F8_AreaId { get { return Field<int>(0x78F8); } }
		public int x78FC { get { return Field<int>(0x78FC); } }
		public int x7900_PlayerLevel { get { return Field<int>(0x7900); } }
		public int x7904_PlayerParagon { get { return Field<int>(0x7904); } }
		public byte[] x7908 { get { return Field<byte>(0x7908, 4); } }
		public int x7910 { get { return Field<int>(0x7910); } }
		public int x7914 { get { return Field<int>(0x7914); } }
		public int x7918 { get { return Field<int>(0x7918); } }
		public int x791C { get { return Field<int>(0x791C); } }
		public int x7920 { get { return Field<int>(0x7920); } }
		public byte[] x7924 { get { return Field<byte>(0x7924, 148); } }

		public int x8290_ClientWalkPower { get { return Field<int>(0x8290); } }

		//public   CObData_Struct1 x82C0_Struct1;
		public byte[] x8354 { get { return Field<byte>(0x8354, 520); } }
		//public   CObData_Struct0 x855C_Struct0;
		public byte[] x856C { get { return Field<byte>(0x856C, 8); } }
		public int x8574_KickTimer { get { return Field<int>(0x8574); } }
		public int x8578_KickTimer { get { return Field<int>(0x8578); } }
		public byte[] x857C { get { return Field<byte>(0x857C, 32); } }

		public override string ToString()
		{
			return base.ToString() + " { Name = \"" + PlayerName + "\" }";
		}
	}
}
