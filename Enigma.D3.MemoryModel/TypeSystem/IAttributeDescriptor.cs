using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.TypeSystem
{
	public interface IAttributeDescriptor
	{
		int ID { get; }
		Type DataType { get; }
		string Name { get; }
	}
}
