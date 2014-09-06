using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3
{
	public class AttributeDescriptor : MemoryObject
	{
		// 2.0.0.20874
		public const int SizeOf = 0x28; // = 40

		public int x00_Id { get { return Read<int>(0x00); } }
		public int x04_DefaultValue { get { return Read<int>(0x04); } }
		public ParameterType x08_ParameterType { get { return Read<ParameterType>(0x08); } }
		public int x0C { get { return Read<int>(0x0C); } }
		public int x10_DataType { get { return Read<int>(0x10); } } // 0 = Float, 1 = Int32
		public string x14_Formula { get { return ReadStringPointer(0x14, 256).Dereference(); } }
		public string x18_Formula { get { return ReadStringPointer(0x18, 256).Dereference(); } }
		public string x1C_Name { get { return ReadStringPointer(0x1C, 256).Dereference(); } }
		public int x20 { get { return Read<int>(0x20); } }
		public int x24 { get { return Read<int>(0x24); } }

		public enum ParameterType : int
		{
			DamageType = 0, // SymbolTable @ 0x01802898
			PowerSnoId = 4,
			PowerSnoId2 = 11,
			ResourceType = 10, // SymbolTable @ 0x01802FB8
			TreasureClassSnoId = 14,
			ActorSnoId = 15,
			ConversationSnoId = 16,
			ActorType = 18, // SymbolTable @ 0x01802778
			InventoryLocation = 19, // SymbolTable @ 0x01803BF0
		}
	}
}
