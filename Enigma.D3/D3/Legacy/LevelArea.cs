using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class LevelArea : MemoryObject
	{
		public const int SizeOf = 1144; // = 0x478 (see .text:00A61540 in 1.0.8.16603)

		public LevelArea(ProcessMemory memory, int address)
			: base(memory, address) { }

		public LinkedList<int> x000_ListWithBooleanEnd_AttachmentList { get { return Dereference<LinkedList<int>>(0x000); } } // Has 4 bytes extra data compared to normal list.
		public MapMarkerInfo x004_Ptr_112Bytes_RelatedTo_MapMarkerInfo { get { return Dereference<MapMarkerInfo>(0x004); } }
		public MapMarkerInfo x008_Ptr_112Bytes_RelatedTo_MapMarkerInfo { get { return Dereference<MapMarkerInfo>(0x008); } }
		public int x00C_AnimationFrame { get { return Field<int>(0x00C); } }
		public LinkedList<RevealedScene> x010_RevealedScenes { get { return Field<LinkedList<RevealedScene>>(0x010); } }
		public Allocator x020_ListNodeAllocator_20x64Bytes { get { return Field<Allocator>(0x020); } }
		public int x03C { get { return Field<int>(0x03C); } }
		public float x040_LabelOpacity { get { return Field<float>(0x040); } }
		public int x044_SnoId { get { return Field<int>(0x044); } }
		public int x048_LoadSnoId { get { return Field<int>(0x048); } }
		public int x04C_StateEnum { get { return Field<int>(0x04C); } }
		public int x050_Struct_ { get { return Field<int>(0x050); } }
		public int x054 { get { return Field<int>(0x054); } }
		public int x058 { get { return Field<int>(0x058); } }
		public int x05C { get { return Field<int>(0x05C); } }
		public int x060_Flags_ { get { return Field<int>(0x060); } }
		public int _x064 { get { return Field<int>(0x064); } }
		public UIReference x068_UIReference_MinimapDialogMain { get { return Field<UIReference>(0x068); } }
		public UIReference x270_UIReference_MinimapArrowRegion { get { return Field<UIReference>(0x270); } }


		public class MapMarkerInfo : MemoryObject
		{
			public const int SizeOf = 112;

			public MapMarkerInfo(ProcessMemory memory, int address)
				: base(memory, address) { }

			public Allocator x00_PtrAllocator_FieldX48 { get { return Dereference<Allocator>(0x00); } }
			public int _x04 { get { return Field<int>(0x04); } }
			public int x08_StructStart_Ptr_ { get { return Field<int>(0x08); } }
			public int x0C { get { return Field<int>(0x0C); } }
			public int x10_SizeOrCount { get { return Field<int>(0x10); } } // <-- says how much is in x08
			public int _x14 { get { return Field<int>(0x14); } }
			public int x18 { get { return Field<int>(0x18); } }
			public int x1C { get { return Field<int>(0x1C); } }
			public int x20 { get { return Field<int>(0x20); } }
			public int x24_Flags { get { return Field<int>(0x24); } }
			public int x28 { get { return Field<int>(0x28); } }
			public int x2C { get { return Field<int>(0x2C); } }
			public int x30_GoodFood { get { return Field<int>(0x30); } }
			public int _x34 { get { return Field<int>(0x34); } }
			public int x38 { get { return Field<int>(0x38); } }
			public int _x3C_Ptr { get { return Field<int>(0x3C); } }
			public int x40 { get { return Field<int>(0x40); } }
			public int x44_Count_ { get { return Field<int>(0x44); } }
			public Allocator x48_Allocator_10x68Bytes { get { return Field<Allocator>(0x48); } }
			public int _x64 { get { return Field<int>(0x64); } }
			public int x68_Boolean_ { get { return Field<int>(0x68); } }
			public int _x6C { get { return Field<int>(0x6C); } }
		}

		public class RevealedScene : MemoryObject
		{
			public const int SizeOf = 56;

			public RevealedScene(ProcessMemory memory, int address)
				: base(memory, address) { }

			public int x00_SceneSnoId { get { return Field<int>(0x00); } }
			public int x04_SceneId { get { return Field<int>(0x04); } } // same as Scene.x004
			public int x08_WorldId { get { return Field<int>(0x08); } } // same as Scene.x008
			public int x0C_TextureSnoId { get { return Field<int>(0x0C); } }
			public WorldRect x10_UIRect { get { return Field<WorldRect>(0x10); } }
			public int x20_TextureSnoId { get { return Field<int>(0x20); } }
			public int x24_Ptr_BitmapMask { get { return Field<int>(0x24); } } // Size = x28 * x2C * 4        ==>   Width * Height * 32-bit
			public int x28_Width { get { return Field<int>(0x28); } } // = ffloor((x0C - x04) * 0.66666669)   ==>   UIRect.Width * 2 / 3
			public int x2C_Height { get { return Field<int>(0x2C); } } // = ffloor((x08 - x00) * 0.66666669)  ==>   UIRect.Height * 2 / 3
			public int x30_AnimationFrame { get { return Field<int>(0x30); } } // Last frame when in range? For removing old values.
			public int x34_IsFullyVisible { get { return Field<int>(0x34); } } // Map is discovered from start.

			public int[] GetBitmapMask(out int width, out int height)
			{
				byte[] fieldBuffer = Memory.ReadBytes(Address + 0x24, 3 * sizeof(int));
				int ptr = BitConverter.ToInt32(fieldBuffer, 0);
				width = BitConverter.ToInt32(fieldBuffer, 4);
				height = BitConverter.ToInt32(fieldBuffer, 8);
				byte[] pixelBuffer = Memory.ReadBytes(ptr, width * height * 4);
				int[] pixels = new int[width * height];
				Buffer.BlockCopy(pixelBuffer, 0, pixels, 0, pixelBuffer.Length);
				return pixels;
			}
		}
	}
}
