using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Preferences
{
	public class SoundPreferences : MemoryObject
	{
		// 2.0.0.20874
		public const int SizeOf = 0x4C; // = 76

		public SoundPreferences(MemoryBase memory, int address)
			: base(memory, address) { }

		public float x00_MasterVolume { get { return Field<float>(0x00); } }  // default = 1, min = 0, max = 1
		public float x04_EffectVolume { get { return Field<float>(0x04); } }  // default = 0.8, min = 0, max = 1
		public float x08_MusicVolume { get { return Field<float>(0x08); } }  // default = 0.8, min = 0, max = 1
		public float x0C_NarrationVolume { get { return Field<float>(0x0C); } }  // default = 0.8, min = 0, max = 1
		public float x10_AmbientVolume { get { return Field<float>(0x10); } }  // default = 0.8, min = 0, max = 1
		// x14 is not used
		public int x18_ChannelsToUse { get { return Field<int>(0x18); } }  // default = 32, min = 16, max = 128
		public int x1C_SoundDriver { get { return Field<int>(0x1C); } }  // default = 0
		public int x20_SpeakerMode { get { return Field<int>(0x20); } }  // default = 0, min = 0, max = 7
		public int x24_ReverseSpeakers { get { return Field<int>(0x24); } }  // default = 0, min = 0, max = 1
		public int x28_QuestSubtitlesEnabled { get { return Field<int>(0x28); } }  // default = 0, min = 0, max = 1
		public int x2C_CinematicsSubtitlesEnabled { get { return Field<int>(0x2C); } }  // default = 0, min = 0, max = 1
		public int x30_MuteSound { get { return Field<int>(0x30); } }  // default = 0, min = 0, max = 1
		public int x34_MuteEffects { get { return Field<int>(0x34); } }  // default = 0, min = 0, max = 1
		public int x38_MuteMusic { get { return Field<int>(0x38); } }  // default = 0, min = 0, max = 1
		public int x3C_MuteVoice { get { return Field<int>(0x3C); } }  // default = 0, min = 0, max = 1
		public int x40_MuteAmbient { get { return Field<int>(0x40); } }  // default = 0, min = 0, max = 1
		// x44 is not used
		public int x48_PlayInBackground { get { return Field<int>(0x48); } }  // default = 0, min = 0, max = 1
	}
}
