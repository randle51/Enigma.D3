using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Legacy
{
	public class Environment : MemoryObject
	{
		public const int SizeOf = 0xAD30; // 1.0.8.16603 : [010482A0] Environment::Create

		public Environment(ProcessMemory memory, int address)
			: base(memory, address) { }

		public int x0000_HideMainWindowMethod { get { return Field<int>(0x0000); } } // bool *__cdecl (Action<bool>)
		public int x0004_Method { get { return Field<int>(0x0004); } }
		public int x0008_Method { get { return Field<int>(0x0008); } }
		public int x000C_Method_GetGameId { get { return Field<int>(0x000C); } }
		public int x0010_Method_OnTerminateProcess { get { return Field<int>(0x0010); } }
		public int x0014_Method { get { return Field<int>(0x0014); } }
		public int x0018_Method { get { return Field<int>(0x0018); } }
		public int x001C_Method { get { return Field<int>(0x001C); } }
		public int _x0020 { get { return Field<int>(0x0020); } }
		public int x0024_Method_IsCapsLockOn { get { return Field<int>(0x0024); } }
		public string x0028_StringBuffer4096 { get { return Field(0x0028, 4096); } }
		public OSInfo x1028_OSInfo { get { return Field<OSInfo>(0x1028); } }
		public string x1278_GameTitle { get { return Field(0x1278, 260); } }
		public int x137C { get { return Field<int>(0x137C); } }
		public int _x1380 { get { return Field<int>(0x1380); } }
		public int _x1384 { get { return Field<int>(0x1384); } }
		public int _x1388 { get { return Field<int>(0x1388); } }
		public int _x138C { get { return Field<int>(0x138C); } }
		public int _x1390 { get { return Field<int>(0x1390); } }
		public int _x1394 { get { return Field<int>(0x1394); } }
		public int _x1398 { get { return Field<int>(0x1398); } }
		public int _x139C { get { return Field<int>(0x139C); } }
		public int _x13A0 { get { return Field<int>(0x13A0); } }
		public int _x13A4 { get { return Field<int>(0x13A4); } }
		public int _x13A8 { get { return Field<int>(0x13A8); } }
		public int _x13AC { get { return Field<int>(0x13AC); } }
		public int _x13B0 { get { return Field<int>(0x13B0); } }
		public int _x13B4 { get { return Field<int>(0x13B4); } }
		public int _x13B8 { get { return Field<int>(0x13B8); } }
		public int _x13BC { get { return Field<int>(0x13BC); } }
		public int _x13C0 { get { return Field<int>(0x13C0); } }
		public int _x13C4 { get { return Field<int>(0x13C4); } }
		public int _x13C8 { get { return Field<int>(0x13C8); } }
		public int _x13CC { get { return Field<int>(0x13CC); } }
		public int _x13D0 { get { return Field<int>(0x13D0); } }
		public int _x13D4 { get { return Field<int>(0x13D4); } }
		public int _x13D8 { get { return Field<int>(0x13D8); } }
		public int _x13DC { get { return Field<int>(0x13DC); } }
		public int _x13E0 { get { return Field<int>(0x13E0); } }
		public int _x13E4 { get { return Field<int>(0x13E4); } }
		public int _x13E8 { get { return Field<int>(0x13E8); } }
		public int _x13EC { get { return Field<int>(0x13EC); } }
		public int _x13F0 { get { return Field<int>(0x13F0); } }
		public int _x13F4 { get { return Field<int>(0x13F4); } }
		public int _x13F8 { get { return Field<int>(0x13F8); } }
		public int _x13FC { get { return Field<int>(0x13FC); } }
		public int _x1400 { get { return Field<int>(0x1400); } }
		public int _x1404 { get { return Field<int>(0x1404); } }
		public int _x1408 { get { return Field<int>(0x1408); } }
		public int _x140C { get { return Field<int>(0x140C); } }
		public int _x1410 { get { return Field<int>(0x1410); } }
		public int _x1414 { get { return Field<int>(0x1414); } }
		public int _x1418 { get { return Field<int>(0x1418); } }
		public int _x141C { get { return Field<int>(0x141C); } }
		public int _x1420 { get { return Field<int>(0x1420); } }
		public int _x1424 { get { return Field<int>(0x1424); } }
		public int _x1428 { get { return Field<int>(0x1428); } }
		public int _x142C { get { return Field<int>(0x142C); } }
		public int _x1430 { get { return Field<int>(0x1430); } }
		public int _x1434 { get { return Field<int>(0x1434); } }
		public int _x1438 { get { return Field<int>(0x1438); } }
		public int _x143C { get { return Field<int>(0x143C); } }
		public int _x1440 { get { return Field<int>(0x1440); } }
		public int _x1444 { get { return Field<int>(0x1444); } }
		public int _x1448 { get { return Field<int>(0x1448); } }
		public int _x144C { get { return Field<int>(0x144C); } }
		public int _x1450 { get { return Field<int>(0x1450); } }
		public int _x1454 { get { return Field<int>(0x1454); } }
		public int _x1458 { get { return Field<int>(0x1458); } }
		public int _x145C { get { return Field<int>(0x145C); } }
		public int _x1460 { get { return Field<int>(0x1460); } }
		public int _x1464 { get { return Field<int>(0x1464); } }
		public int _x1468 { get { return Field<int>(0x1468); } }
		public int _x146C { get { return Field<int>(0x146C); } }
		public int _x1470 { get { return Field<int>(0x1470); } }
		public int _x1474 { get { return Field<int>(0x1474); } }
		public int _x1478 { get { return Field<int>(0x1478); } }
		public int _x147C { get { return Field<int>(0x147C); } }
		public int x1480_IsShowingMessageBox { get { return Field<int>(0x1480); } }
		public int x1484 { get { return Field<int>(0x1484); } }
		public int x1488_IsRunningTestMode { get { return Field<int>(0x1488); } } // cmd -test {}
		public int x148C { get { return Field<int>(0x148C); } }
		public int x1490 { get { return Field<int>(0x1490); } }
		public int x1494_ProjectId_ { get { return Field<int>(0x1494); } }
		public int x1498 { get { return Field<int>(0x1498); } }
		public int _x149C { get { return Field<int>(0x149C); } }
		public long x14A0_PerformanceCounter { get { return Field<long>(0x14A0); } }
		public int x14A8 { get { return Field<int>(0x14A8); } }
		public int x14AC_MainWindowHandle { get { return Field<int>(0x14AC); } }
		public int x14B0_ErrorReportIndex { get { return Field<int>(0x14B0); } }
		public int x14B4 { get { return Field<int>(0x14B4); } }
		public int x14B8_Bool_ { get { return Field<int>(0x14B8); } }
		public ErrorManager x14BC_ErrorManager { get { return Field<ErrorManager>(0x14BC); } }
		public int xAD28 { get { return Field<int>(0xAD28); } }
		public int _xAD2C { get { return Field<int>(0xAD2C); } }
	}
}
