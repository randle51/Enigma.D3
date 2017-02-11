using Enigma.D3.MemoryModel.TypeSystem;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel64.TypeSystem
{
	public class AttributeDescriptor : MemoryObject, IAttributeDescriptor
	{
		public const int SizeOf = Constants.AttributeDescriptor.SizeOf;

		public int ID
			=> Read<int>(Constants.AttributeDescriptor.ID);

		public Type DataType
			=> Read<int>(Constants.AttributeDescriptor.DataType) == 0 ? typeof(float) : typeof(int);

		public string Name
			=> ReadStringPointer(Constants.AttributeDescriptor.Name, Constants.AttributeDescriptor.NameLength).Dereference();
	}
}
