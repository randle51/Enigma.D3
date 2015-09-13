using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.DataTypes;
using Enigma.Memory;

namespace Enigma.D3
{
	public class SphereNode : MemoryObject
	{
		public const int SizeOf = 0x20;

		public Sphere x00_Sphere { get { return Read<Sphere>(0x00); } }
		public int x10_AcdId { get { return Read<int>(0x10); } }
		public Ptr<SphereNode> x14_Ptr_ParentNode { get { return ReadPointer<SphereNode>(0x14); } }
		public Ptr<SphereNode> x18_Ptr_LeftNode { get { return ReadPointer<SphereNode>(0x18); } }
		public Ptr<SphereNode> x1C_Ptr_RightNode { get { return ReadPointer<SphereNode>(0x1C); } }
	}
}
