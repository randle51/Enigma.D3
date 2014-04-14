using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class ErrorManager : MemoryObject
	{
		// See [0x01051920] for assignments. This structure is used to build an error report that
		// is then sent to Blizzard (by mail if being an employee, otherwise using BlizzardError).

		public const int SizeOf = 0x986C; // 1.0.8.16603 : [0x01089D10]

		public ErrorManager(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x0000_UserType { get { return Field<int>(0x0000); } } // <-- 0 = NormalUser, 3 = BlizzardUser
		public int x0004 { get { return Field<int>(0x0004); } }
		public byte[] x0008_260Byte { get { return Field<byte>(0x0008, 260); } }
		public byte[] x010C_1KB { get { return Field<byte>(0x010C, 1024); } }
		public byte[] x050C_8KB { get { return Field<byte>(0x050C, 8192); } }
		public byte[] x250C_16KB { get { return Field<byte>(0x250C, 16384); } }
		public byte[] x650C_8KB { get { return Field<byte>(0x650C, 8192); } }
		public byte[] x850C_128Byte { get { return Field<byte>(0x850C, 128); } }
		public byte[] x858C_1KB { get { return Field<byte>(0x858C, 1024); } }
		public string[] x898C_Lines { get { return Field(0x898C, 260, 7); } }
		public int x90A8_UsedLines { get { return Field<int>(0x90A8); } }
		public byte[] x90AC_128Byte { get { return Field<byte>(0x90AC, 128); } }
		public byte[] x912C_1KB { get { return Field<byte>(0x912C, 1024); } }
		public string x952C_LauncherFilePath { get { return Field(0x952C, 260); } }
		public byte[] x9630_260Byte { get { return Field<byte>(0x9630, 260); } }
		public int x9734 { get { return Field<int>(0x9734); } }
		public byte[] x9738_260Byte { get { return Field<byte>(0x9738, 260); } }
		public int x983C { get { return Field<int>(0x983C); } }
		public int x9840 { get { return Field<int>(0x9840); } }
		public int x9844 { get { return Field<int>(0x9844); } }
		public int _x9848 { get { return Field<int>(0x9848); } }
		public string x984C_CodeBranch { get { return Field(0x984C, 32); } }
	}
}
