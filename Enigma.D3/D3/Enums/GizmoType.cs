using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Enums
{
	public enum GizmoType
	{
		Invalid = -1,
		Door = 0,
		Chest = 1,
		Portal = 2,
		Waypoint = 4,
		Item = 5, // Not included in Symbols
		Checkpoint = 7,
		Sign = 8,
		HealingWell = 9,
		PowerUp = 10,
		TownPortal = 11,
		HearthPortal = 12,
		Headstone = 18,
		PortalDestination = 20,
		BreakableChest = 23,
		SharedStash = 25,
		Spawner = 28,
		PageOfFatePortal = 33,
		Trigger = 44,
		SecretPortal = 47,
		DestroyableObject = 48,
		BreakableDoor = 56,
		Switch = 57,
		PressurePlate = 58,
		Gate = 59,
		DestroySelfWhenNear = 60,
		ActTransitionObject = 62,
		ReformingDestroyableObject = 63,
		Banner = 64,
		LoreChest = 65,
		BossPortal = 66,
		PlacedLoot = 67,
		SavePoint = 68,
		ReturnPointPortal = 69,
		DungeonPortal = 70,
		IdentifyAll = 71,
		ReturnPortal = 75,
		RecreateGameWithParty = 76,
		Mailbox = 77,
		LootRunSwitch = 78,
		PoolOfReflection = 79
	}
}
