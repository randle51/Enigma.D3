using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class SoundPreferences : MemoryObject
	{
		public const int SizeOf = 0x40; // 1.0.8.16603 : [008FFA20]

		public SoundPreferences(ProcessMemory memory, int address)
			: base(memory, address) { }

		// See field names at [0x01477A34] (1.0.8.16603).
		// Remaining names: MuteEffects, MuteAmbient and MuteVoice, unknown order.
		public float x00_MasterVolume { get { return Field<float>(0x00); } }
		public float x04_EffectVolume { get { return Field<float>(0x04); } }
		public float x08_MusicVolume { get { return Field<float>(0x08); } }
		public float x0C_NarrationVolume { get { return Field<float>(0x0C); } }
		public float x10_AmbientVolume { get { return Field<float>(0x10); } }
		public int x14_ChannelsToUse { get { return Field<int>(0x14); } }
		public int x18_SoundDriver { get { return Field<int>(0x18); } }
		public SpeakerMode x1C_SpeakerMode { get { return (SpeakerMode)Field<int>(0x1C); } }
		public bool x20_ReverseSpeakers { get { return Field<bool>(0x20); } }
		public bool x24_QuestSubtitlesEnabled { get { return Field<bool>(0x24); } }
		public bool x28_CinematicSubtitlesEnabled { get { return Field<bool>(0x28); } }
		public bool x2C_MuteSound { get { return Field<bool>(0x2C); } }
		public int _x30 { get { return Field<int>(0x30); } }
		public bool x34_MuteMusic { get { return Field<bool>(0x34); } }
		public int _x38 { get { return Field<int>(0x38); } }
		public int _x3C { get { return Field<int>(0x3C); } }
	}
}
