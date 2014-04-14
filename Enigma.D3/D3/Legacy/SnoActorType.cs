using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public enum SnoActorType : int
	{
		Unspecified = -1,

		Invalid = 0,
		Monster = 1,
		Gizmo = 2,
		ClientEffect = 3,
		ServerProp = 4,
		Environment = 5,
		Critter = 6,
		Player = 7,
		Item = 8,
		AxeSymbol = 9,
		Projectile = 10,
		CustomBrain = 11,

		Sound = 16
	}
}
