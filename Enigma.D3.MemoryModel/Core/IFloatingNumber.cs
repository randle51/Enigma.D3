using Enigma.D3.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Core
{
	public interface IFloatingNumber
	{
		Vector3 WorldPos { get; }
		SNO WorldSNO { get; }
		int Type { get; }
		float Value { get; }
	}
}
