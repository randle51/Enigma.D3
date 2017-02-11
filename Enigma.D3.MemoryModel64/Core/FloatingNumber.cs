using Enigma.D3.DataTypes;
using Enigma.D3.MemoryModel.Core;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel64.Core
{
	public class FloatingNumber : MemoryObject, IFloatingNumber
	{
		public const int SizeOf = Constants.FloatingNumber.SizeOf;

		public Vector3 WorldPos => Read<Vector3>(Constants.FloatingNumber.WorldPos);
		public SNO WorldSNO => Read<SNO>(Constants.FloatingNumber.WorldSNO);
		// 0x18 RefString
		public int Type => Read<int>(Constants.FloatingNumber.Type);
		public float Value => Read<float>(Constants.FloatingNumber.Value);
	}
}
