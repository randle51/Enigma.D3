using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class UIManager : MemoryObject
	{
		public const int SizeOf = 0x2708; // 1.0.8.16603 : [008F6D50] UIManager::Create

		public UIManager(ProcessMemory memory, int address)
			: base(memory, address) { }

		public UIReference x0008_MouseDown { get { return Field<UIReference>(0x0008); } }
		public UIReference x0210_Focused { get { return Field<UIReference>(0x0210); } }
		public UIReference x0418_UIReference { get { return Field<UIReference>(0x0418); } }
		public UIReference x0620_ContextMenu { get { return Field<UIReference>(0x0620); } }
		public UIReference x0828_LastClicked { get { return Field<UIReference>(0x0828); } }
		public UIReference x0A30_MouseOver { get { return Field<UIReference>(0x0A30); } }
	}
}
