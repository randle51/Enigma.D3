using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.D3.Collections;
using Enigma.Memory;

namespace Enigma.D3.Assets
{
	public class SnoFilesAsync : MemoryObject
	{
		public const int SizeOf = 0x228;

		public int x000_Ptr { get { return Read<int>(0x000); } }
		public Win32.CriticalSection x004_CriticalSection { get { return Read<Win32.CriticalSection>(0x004); } }
		public Win32.CriticalSection x01C_CriticalSection { get { return Read<Win32.CriticalSection>(0x01C); } }
		public Win32.Handle x034_EventHandle { get { return Read<Win32.Handle>(0x034); } }
		public Win32.Handle x038_EventHandle { get { return Read<Win32.Handle>(0x038); } }
		public ListPack x03C_ListPack_ItemSize40 { get { return Read<ListPack>(0x03C); } } // Enigma.D3.Collections.ListPack Count = 604 { Valid: True, ItemSize: 40, Count: 604}
		public ListPack x06C_ListPack_ItemSize40 { get { return Read<ListPack>(0x06C); } } // Enigma.D3.Collections.ListPack Count = 30 { Valid: True, ItemSize: 40, Count: 30}
		public ListPack x09C_ListPack_ItemSize40 { get { return Read<ListPack>(0x09C); } } // Enigma.D3.Collections.ListPack Count = 1 { Valid: True, ItemSize: 40, Count: 1}
		public ListPack x0CC_ListPack_ItemSize40 { get { return Read<ListPack>(0x0CC); } } // Enigma.D3.Collections.ListPack Count = 0 { Valid: True, ItemSize: 40, Count: 0}
		public Ptr x0FC_Ptr_ { get { return Read<Ptr>(0x0FC); } }
		public Map x100_Map { get { return Read<Map>(0x100); } }
		public ListPack x170_ListPack_ItemSize12 { get { return Read<ListPack>(0x170); } } // Enigma.D3.Collections.ListPack Count = 396 { Valid: True, ItemSize: 12, Count: 396}
		public ListPack x1A0_ListPack_ItemSize12 { get { return Read<ListPack>(0x1A0); } } // Enigma.D3.Collections.ListPack Count = 0 { Valid: True, ItemSize: 12, Count: 0}
		public ListPack x1D0_ListPack_ItemSize12 { get { return Read<ListPack>(0x1D0); } } // Enigma.D3.Collections.ListPack Count = 0 { Valid: True, ItemSize: 12, Count: 0}
		public int x200 { get { return Read<int>(0x200); } }
		public int x204 { get { return Read<int>(0x204); } }
		public int x208 { get { return Read<int>(0x208); } }
		public int x20C { get { return Read<int>(0x20C); } }
		public Ptr x210_Ptr_ { get { return Read<Ptr>(0x210); } }
		public int x214 { get { return Read<int>(0x214); } }
		public int x218 { get { return Read<int>(0x218); } }
		public int x21C_Neg1 { get { return Read<int>(0x21C); } }
		public int x220_Neg1 { get { return Read<int>(0x220); } }
		public int _x224 { get { return Read<int>(0x224); } }
	}
}
