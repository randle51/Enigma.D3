using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class ObjectManager : MemoryObject
	{
		public const int SizeOf = 0x9C0; // 1.0.8.16603 : [00E8EAC0] ObjectManager::Create

		public ObjectManager(ProcessMemory memory, int address)
			: base(memory, address) { }

		public bool IsInGame { get { return Field<bool>(0x058); } } // <-- This is actually x040.x018_IsInGame

		public int x000 { get { return Field<int>(0x000); } }
		public int x004 { get { return Field<int>(0x004); } }
		public int x008 { get { return Field<int>(0x008); } }
		public int x00C { get { return Field<int>(0x00C); } }
		public int x010 { get { return Field<int>(0x010); } }
		public int x014 { get { return Field<int>(0x014); } }
		public int x018 { get { return Field<int>(0x018); } }
		public int x01C { get { return Field<int>(0x01C); } }
		public int x020 { get { return Field<int>(0x020); } }
		public int x024 { get { return Field<int>(0x024); } }
		public int x028 { get { return Field<int>(0x028); } }
		public int x02C { get { return Field<int>(0x02C); } }
		public int x030 { get { return Field<int>(0x030); } }
		public int x034 { get { return Field<int>(0x034); } }
		public int x038_CurrentFrame { get { return Field<int>(0x038); } }
		public int x03C { get { return Field<int>(0x03C); } }
		public GameGlobals x040_CurrentGameGlobals { get { return Field<GameGlobals>(0x040); } }
		public GameGlobals x3F0_TemporaryGameGlobals { get { return Field<GameGlobals>(0x3F0); } }
		public int x7A0 { get { return Field<int>(0x7A0); } }
		public NetStat x7A4_NetStat { get { return Dereference<NetStat>(0x7A4); } }
		public Structure7A8 x7A8 { get { return Dereference<Structure7A8>(0x7A8); } }
		public int x7AC { get { return Field<int>(0x7AC); } }
		public Storage x7B0_Storage { get { return Field<Storage>(0x7B0); } }
		public int x8E8 { get { return Field<int>(0x8E8); } }
		public int x8EC_Physics_Ptr908Bytes { get { return Field<int>(0x8EC); } }
		public int x8F0_Billboards__Ptr124Bytes { get { return Field<int>(0x8F0); } }
		public ExpandableContainer<MemoryObject> x8F4_Lights { get { return Dereference<ExpandableContainer<MemoryObject>>(0x8F4); } }
		public ExpandableContainer<MemoryObject> x8F8_Cutscenes { get { return Dereference<ExpandableContainer<MemoryObject>>(0x8F8); } }
		public int x8FC_Struct_RelatedTo_Lights { get { return Field<int>(0x8FC); } }
		public ExpandableContainer<Actor> x900_Actors { get { return Dereference<ExpandableContainer<Actor>>(0x900); } }
		public int x904_RelatedTo_Actors_Ptr15144Bytes { get { return Field<int>(0x904); } }
		public int x908_Cloth_Ptr24Bytes { get { return Field<int>(0x908); } }
		public int x90C_Explosion_Ptr40972Bytes { get { return Field<int>(0x90C); } }
		public int x910 { get { return Field<int>(0x910); } }
		public int x914_Trails_Ptr12Bytes { get { return Field<int>(0x914); } }
		public int x918_Rope_Ptr16Bytes { get { return Field<int>(0x918); } }
		public ExpandableContainer<MemoryObject> x91C_ParticleSystems { get { return Dereference<ExpandableContainer<MemoryObject>>(0x91C); } }
		public int x920_Particles_Ptr220Bytes { get { return Field<int>(0x920); } }
		public int x924_Cinematography_Ptr252Bytes { get { return Field<int>(0x924); } }
		public ExpandableContainer<MemoryObject> x928_AmbientSounds { get { return Dereference<ExpandableContainer<MemoryObject>>(0x928); } }
		public int x92C_Weather_Ptr11712Bytes { get { return Field<int>(0x92C); } }
		public Container<MemoryObject> x930_Attachments { get { return Dereference<Pointer<Container<MemoryObject>>>(0x930).Value; } } // Container**
		public int x934_ParentObjects_Ptr288Bytes { get { return Field<int>(0x934); } }
		public ExpandableContainer<MemoryObject> x938_DelayedRMessages { get { return Dereference<Pointer<ExpandableContainer<MemoryObject>>>(0x938).Value; } } // ExpandableContainer**
		public int x93C_DebugText_Ptr56Bytes { get { return Field<int>(0x93C); } }
		public int x940 { get { return Field<int>(0x940); } }
		public Container<Scene> x944_Scenes { get { return Dereference<Container<Scene>>(0x944); } }
		public int x948_RelatedTo_Scenes_Ptr1232Bytes { get { return Field<int>(0x948); } }
		public int x94C_ClientOrServerSceneOctree_Ptr4Bytes { get { return Field<int>(0x94C); } }
		public int x950_Ptr { get { return Field<int>(0x950); } }
		public int x954_Ptr352Bytes { get { return Field<int>(0x954); } }
		public int x958_Ptr12Bytes { get { return Field<int>(0x958); } }
		public int x95C { get { return Field<int>(0x95C); } }
		public int x960_Sky_Ptr4100Bytes { get { return Field<int>(0x960); } }
		public int x964_Wind_Ptr64Bytes { get { return Field<int>(0x964); } }
		public int x968 { get { return Field<int>(0x968); } }
		public int x96C_Sprites_Ptr1480Bytes { get { return Field<int>(0x96C); } }
		public int x970_SubObjectGfx_Ptr272Bytes { get { return Field<int>(0x970); } }
		public UIManager x974_UIManager { get { return Dereference<UIManager>(0x974); } }
		public int x978_CameraManager_Ptr4492Bytes { get { return Field<int>(0x978); } }
		public Container<World> x97C_Worlds { get { return Dereference<Container<World>>(0x97C); } }
		public int x980_RelatedTo_Worlds_Ptr88Bytes { get { return Field<int>(0x980); } }
		public Structure984 x984 { get { return Dereference<Structure984>(0x984); } }
		public int x988_PlayerInput { get { return Field<int>(0x988); } }
		public int x98C_PostFX_Ptr984Bytes { get { return Field<int>(0x98C); } }
		public int x990_RelatedTo_Cutscenes_Ptr64Bytes { get { return Field<int>(0x990); } }
		public int x994_Prefetch_Ptr976Bytes { get { return Field<int>(0x994); } }
		public Structure988 x998 { get { return Field<Structure988>(0x998); } }
		public int x99C { get { return Field<int>(0x99C); } }
		public int x9A0_Shake_Ptr32Bytes { get { return Field<int>(0x9A0); } }
		public Container<MemoryObject> x9A4_EffectGroup { get { return Dereference<Pointer<Container<MemoryObject>>>(0x9A4).Value; } } // Container**
		public ExpandableContainer<MemoryObject> x9A8_ComplexEffect { get { return Dereference<Pointer<ExpandableContainer<MemoryObject>>>(0x9A8).Value; } } // ExpandableContainer**
		public Allocator x9AC_TextAnim_Allocator272x1024 { get { return Dereference<Allocator>(0x9AC); } }
		public int x9B0_TimedEvents_Ptr48Bytes { get { return Field<int>(0x9B0); } }
		public int x9B4_ActTransitions_Ptr4Bytes { get { return Field<int>(0x9B4); } }
		public Allocator x9B8_ActorMovement_Allocator516x1024 { get { return Dereference<Allocator>(0x9B8); } }
		public int x9BC { get { return Field<int>(0x9BC); } }



		public class Structure7A8 : MemoryObject
		{
			public const int SizeOf = 0xF0; /// 1.0.8.16603 : [009752A0]

			public Structure7A8(ProcessMemory memory, int address)
				: base(memory, address) { }

			public int x00_Flags { get { return Field<int>(0x00); } }
			// 0x004 (0b0000 0000 0100) = Seen in Lobby
			// 0x014 (0b0000 0001 0100) = In game, normal state
			// 0x214 (0b0010 0011 0100) = In game, paused
			// ------------------------------------------------
			// 0x0D4 (0b0000 1101 0100) = Seen during load
			// 0x054 (0b0000 0101 0100) = Seen during load
			public int x04_GameTick { get { return Field<int>(0x04); } }
			public int x08 { get { return Field<int>(0x08); } } // Seems to be related to animation frame. This is probably "current".
			public int x0C { get { return Field<int>(0x0C); } } // Seems to be related to animation frame. This is probably "last".
			public int _x10 { get { return Field<int>(0x10); } }
			public int _x14 { get { return Field<int>(0x14); } }
			public float x18_LatencyNumber { get { return Field<float>(0x18); } } // = CObjectManagerX984::GetAverageLatency() * 60.0 * 0.001 * 0.5
			public int x1C { get { return Field<int>(0x1C); } }
			public int _x20 { get { return Field<int>(0x20); } }
			public int _x24 { get { return Field<int>(0x24); } }
			public int _x28 { get { return Field<int>(0x28); } }
			public int _x2C { get { return Field<int>(0x2C); } }
			public int x30_WorldSnoId { get { return Field<int>(0x30); } }
			public int x34_SWorldId { get { return Field<int>(0x34); } } // World.x00_Id
			public int x38_WorldId { get { return Field<int>(0x38); } } // World.x08_Id
			public int _x3C { get { return Field<int>(0x3C); } }
			public int _x40 { get { return Field<int>(0x40); } }
			public int _x44 { get { return Field<int>(0x44); } }
			public int _x48 { get { return Field<int>(0x48); } }
			public int _x4C { get { return Field<int>(0x4C); } }
			public int _x50 { get { return Field<int>(0x50); } }
			public int x54_LoadStage { get { return Field<int>(0x54); } } // Seems to go from 10 to 0 when loading, 0 = Loaded.
			public int _x58 { get { return Field<int>(0x58); } }
			public int _x5C { get { return Field<int>(0x5C); } }
			public int _x60 { get { return Field<int>(0x60); } }
			public int _x64 { get { return Field<int>(0x64); } }
			public int _x68 { get { return Field<int>(0x68); } }
			public int _x6C { get { return Field<int>(0x6C); } }
			public int _x70 { get { return Field<int>(0x70); } }
			public int _x74 { get { return Field<int>(0x74); } }
			public int _x78 { get { return Field<int>(0x78); } }
			public int _x7C { get { return Field<int>(0x7C); } }
			public int _x80 { get { return Field<int>(0x80); } }
			public int _x84 { get { return Field<int>(0x84); } }
			public int _x88 { get { return Field<int>(0x88); } }
			public int _x8C { get { return Field<int>(0x8C); } }
			public int _x90 { get { return Field<int>(0x90); } }
			public int _x94 { get { return Field<int>(0x94); } }
			public int _x98 { get { return Field<int>(0x98); } }
			public int _x9C { get { return Field<int>(0x9C); } }
			public int _xA0 { get { return Field<int>(0xA0); } }
			public int _xA4 { get { return Field<int>(0xA4); } }
			public int _xA8 { get { return Field<int>(0xA8); } }
			public int _xAC { get { return Field<int>(0xAC); } }
			public int _xB0 { get { return Field<int>(0xB0); } }
			public int _xB4 { get { return Field<int>(0xB4); } }
			public int _xB8 { get { return Field<int>(0xB8); } }
			public int _xBC { get { return Field<int>(0xBC); } }
			public int _xC0 { get { return Field<int>(0xC0); } }
			public int _xC4 { get { return Field<int>(0xC4); } }
			public int xC8_LevelAreaSnoId { get { return Field<int>(0xC8); } }
			public int _xCC { get { return Field<int>(0xCC); } }
			public int _xD0 { get { return Field<int>(0xD0); } }
			public int _xD4 { get { return Field<int>(0xD4); } }
			public int _xD8 { get { return Field<int>(0xD8); } }
			public int _xDC { get { return Field<int>(0xDC); } }
			public int _xE0 { get { return Field<int>(0xE0); } }
			public int _xE4 { get { return Field<int>(0xE4); } }
			public int _xE8 { get { return Field<int>(0xE8); } }
			public int _xEC { get { return Field<int>(0xEC); } }
			public int _xF0 { get { return Field<int>(0xF0); } }

			// Helpers
			public float Latency { get { return x18_LatencyNumber / 0.03f; } } // Reversing formula to get latency.
		}

		public class Structure984 : MemoryObject
		{
			// NOTE: Size unknown.

			public Structure984(ProcessMemory memory, int address)
				: base(memory, address) { }

			public int x00000_PlayerIndex { get { return Field<int>(0x00000); } }

			public float _x00130_ItemLabelXLeft { get { return Field<float>(0x00130); } }
			public float _x00134_ItemLabelYTop { get { return Field<float>(0x00134); } }
			public float _x00138_ItemLabelXRight { get { return Field<float>(0x00138); } }
			public float _x0013C_ItemLabelYBottom { get { return Field<float>(0x0013C); } }
			public int _x00140_ItemLabelIsWithinViewport { get { return Field<int>(0x00140); } }
			public int _x00144 { get { return Field<int>(0x00144); } }
			public int _x00148 { get { return Field<int>(0x00148); } }
			public int _x0014C { get { return Field<int>(0x0014C); } }
			public int _x00150 { get { return Field<int>(0x00150); } }
			public int _x00154 { get { return Field<int>(0x00154); } }
			public int _x00158 { get { return Field<int>(0x00158); } }
			public int _x0015C { get { return Field<int>(0x0015C); } }
			public int _x00160 { get { return Field<int>(0x00160); } }
			public int _x00164 { get { return Field<int>(0x00164); } }
			public int _x00168 { get { return Field<int>(0x00168); } }
			public int _x0016C { get { return Field<int>(0x0016C); } }
			public int _x00170 { get { return Field<int>(0x00170); } }
			public int _x00174 { get { return Field<int>(0x00174); } }
			public int _x00178 { get { return Field<int>(0x00178); } }
			public int _x0017C { get { return Field<int>(0x0017C); } }


			public int x19820_NumberOfGroundLabels { get { return Field<int>(0x19820); } }
			public int _x19824 { get { return Field<int>(0x19824); } }
			public int _x19828 { get { return Field<int>(0x19828); } }
			public int _x1982C { get { return Field<int>(0x1982C); } }
			public int _x19830 { get { return Field<int>(0x19830); } }
			public int _x19834 { get { return Field<int>(0x19834); } }
			public int _x19838 { get { return Field<int>(0x19838); } }
			public int _x1983C { get { return Field<int>(0x1983C); } }
			public int _x19840 { get { return Field<int>(0x19840); } }
			public int _x19844 { get { return Field<int>(0x19844); } }
			public int _x19848 { get { return Field<int>(0x19848); } }
			public int _x1984C { get { return Field<int>(0x1984C); } }
			public int _x19850 { get { return Field<int>(0x19850); } }
			public int _x19854 { get { return Field<int>(0x19854); } }
			public int _x19858 { get { return Field<int>(0x19858); } }
			public int _x1985C { get { return Field<int>(0x1985C); } }
			public int _x19860 { get { return Field<int>(0x19860); } }
			public int _x19864 { get { return Field<int>(0x19864); } }
			public int _x19868 { get { return Field<int>(0x19868); } }
			public int _x1986C { get { return Field<int>(0x1986C); } }
			public int _x19870 { get { return Field<int>(0x19870); } }
			public int _x19874 { get { return Field<int>(0x19874); } }
			public int _x19878 { get { return Field<int>(0x19878); } }
			public int _x1987C { get { return Field<int>(0x1987C); } }
			public int _x19880 { get { return Field<int>(0x19880); } }


			public int x198D4_LastPongTimestamp { get { return Field<int>(0x198D4); } }
			public int x198D8_LastPongSequence { get { return Field<int>(0x198D8); } }
			public int x198DC { get { return Field<int>(0x198DC); } }
			public int x198E0_LatencyBufferStart { get { return Field<int>(0x198E0); } }
			public int x198E4_LatencyBufferEnd { get { return Field<int>(0x198E4); } }
			public int x198E8_LatencyBufferSize { get { return Field<int>(0x198E8); } }
			public int[] x198EC_LatencyBuffer { get { return Field<int>(0x198EC, 6); } }
			/* Array Fields */
			public int x198EC_LatencyBuffer_0 { get { return Field<int>(0x198EC + 0); } }
			public int x198EC_LatencyBuffer_1 { get { return Field<int>(0x198EC + 4); } }
			public int x198EC_LatencyBuffer_2 { get { return Field<int>(0x198EC + 8); } }
			public int x198EC_LatencyBuffer_3 { get { return Field<int>(0x198EC + 12); } }
			public int x198EC_LatencyBuffer_4 { get { return Field<int>(0x198EC + 16); } }
			public int x198EC_LatencyBuffer_5 { get { return Field<int>(0x198EC + 20); } }
			/* End */


			// Helpers
			public double AverageLatency { get { return GetAverageLatency(); } }
			public double LatestLatencySample { get { return GetLatestLatencySample(); } }
			public double OldestLatencySample { get { return GetOldestLatencySample(); } }

			public double GetAverageLatency()
			{
				double latency = 0.0d;
				int count = x198E8_LatencyBufferSize;
				if (count > 0)
				{
					int current = x198E0_LatencyBufferStart;
					var samples = x198EC_LatencyBuffer;
					for (int offset = 0; offset < count; offset++)
					{
						latency += samples[(current + offset) % samples.Length];
					}
					latency = latency / count;
				}
				return latency;
			}

			public double GetAverageLatencyByCheating()
			{
				// We're cheating a bit by always using all 6 values. This will give wrong latency
				// the first couple of seconds since some values could be either 0 or from a
				// previous game instance. UI shows average of only the 5 latest instead of all 6
				// so there will be a slight difference.

				return x198EC_LatencyBuffer.Average();
			}

			public double GetLatestLatencySample()
			{
				int index = x198E4_LatencyBufferEnd - 1;
				if (index == -1)
					index = 5;
				return x198EC_LatencyBuffer[index];
			}

			public double GetOldestLatencySample()
			{
				if (x198E8_LatencyBufferSize < 5) // Special case when circle isn't full.
					return x198EC_LatencyBuffer[0];

				int index = x198E0_LatencyBufferStart - 1;
				if (index == -1)
					index = 5;
				return x198EC_LatencyBuffer[index];
			}
		}

		public class Structure988 : MemoryObject
		{
			public const int SizeOf = 0x54; // 1.0.8.16603 - Not confirmed

			public Structure988(ProcessMemory memory, int address)
				: base(memory, address) { }

			public int x00_0 { get { return Field<int>(0x00); } }
			public int x04_0 { get { return Field<int>(0x04); } }
			public int x08_0 { get { return Field<int>(0x08); } }
			public int x0C_ret_sub_1065480 { get { return Field<int>(0x0C); } }
			public int x10 { get { return Field<int>(0x10); } }
			public int x14_ret_sub_EADEB0_370 { get { return Field<int>(0x14); } }
			public int x18_neg1 { get { return Field<int>(0x18); } }
			public int x1C_global_16D828C { get { return Field<int>(0x1C); } }
			public int x20_global_16D8290 { get { return Field<int>(0x20); } }
			public int x24_0 { get { return Field<int>(0x24); } }
			public int x28_0 { get { return Field<int>(0x28); } }
			public int x2C_0 { get { return Field<int>(0x2C); } }
			public int x30_neg1 { get { return Field<int>(0x30); } }
			public int x34_neg1 { get { return Field<int>(0x34); } }
			public int x38_neg1 { get { return Field<int>(0x38); } }
			public int x3C_neg1 { get { return Field<int>(0x3C); } }
			public int x40_neg1 { get { return Field<int>(0x40); } }
			public int x44 { get { return Field<int>(0x44); } }
			public int x48_neg1 { get { return Field<int>(0x48); } }
			public int x4C_neg1 { get { return Field<int>(0x4C); } }
			public int x50_0 { get { return Field<int>(0x50); } }
			public int x54_0 { get { return Field<int>(0x54); } }
		}
	}
}
