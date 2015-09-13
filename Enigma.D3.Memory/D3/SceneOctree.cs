using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.Memory;

namespace Enigma.D3
{
	public class SceneOctree : MemoryObject
	{
		public const int SizeOf = 0xA8;

		public string x00_Name { get { return ReadString(0x00, 64); } }
		public int x40 { get { return Read<int>(0x40); } }
		public int _x44 { get { return Read<int>(0x44); } }
		public int x48 { get { return Read<int>(0x48); } }
		public int _x4C { get { return Read<int>(0x4C); } }
		public float x50 { get { return Read<float>(0x50); } }
		public int _x54 { get { return Read<int>(0x54); } }
		public int _x58 { get { return Read<int>(0x58); } }
		public int _x5C { get { return Read<int>(0x5C); } }
		public int _x60 { get { return Read<int>(0x60); } }
		public int _x64 { get { return Read<int>(0x64); } }
		public int _x68 { get { return Read<int>(0x68); } }
		public int _x6C { get { return Read<int>(0x6C); } }
		public int _x70 { get { return Read<int>(0x70); } }
		public int _x74 { get { return Read<int>(0x74); } }
		public int _x78 { get { return Read<int>(0x78); } }
		public int _x7C { get { return Read<int>(0x7C); } }
		public int _x80 { get { return Read<int>(0x80); } }
		public int _x84 { get { return Read<int>(0x84); } }
		public int _x88 { get { return Read<int>(0x88); } }
		public int x8C { get { return Read<int>(0x8C); } }
		public Ptr<ListPack> x90_PtrListPack { get { return ReadPointer<ListPack>(0x90); } }
		public int x94 { get { return Read<int>(0x94); } }
		public int x98 { get { return Read<int>(0x98); } }
		public int _x9C { get { return Read<int>(0x9C); } }
		public int xA0 { get { return Read<int>(0xA0); } }
		public int xA4 { get { return Read<int>(0xA4); } }
	}
}
