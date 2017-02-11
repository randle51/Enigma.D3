using Enigma.D3.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Core
{
	public interface IActor
	{
		int ID { get; }
		string Name { get; }
		Vector3 Position { get; }
	}
}
