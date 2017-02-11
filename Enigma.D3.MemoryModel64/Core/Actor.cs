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
	public class Actor : MemoryObject, IActor
	{
		public const int SizeOf = Constants.Actor.SizeOf;

		public int ID
			=> Read<int>(Constants.Actor.ID);

		public string Name
			=> ReadString(Constants.Actor.Name, Constants.Actor.NameLength);

		public Vector3 Position
			=> Read<Vector3>(Constants.Actor.Position);
	}
}
