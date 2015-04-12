using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Memory
{
	public static class ProcessExtensions
	{
		public static Version GetFileVersion(this Process process)
		{
			var fileVersionInfo = process.MainModule.FileVersionInfo;
			return new Version(
				fileVersionInfo.FileMajorPart,
				fileVersionInfo.FileMinorPart,
				fileVersionInfo.FileBuildPart,
				fileVersionInfo.FilePrivatePart);
		}

		public static bool IsLargeAddressAware(this Process process)
		{
			// Source:
			// http://stackoverflow.com/questions/9054469/how-to-check-if-exe-is-set-as-largeaddressaware

			const int IMAGE_FILE_LARGE_ADDRESS_AWARE = 0x20;

			using (var file = File.Open(process.MainModule.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			using (var reader = new BinaryReader(file))
			{
				if (reader.ReadInt16() != 0x5A4D)
					return false; // No MZ header.
			
				file.Position = 0x3C;
				var peHeaderLocation = reader.ReadInt32();
			
				file.Position = peHeaderLocation;
				if (reader.ReadInt32() != 0x4550)
					return false; // No PE header.
			
				file.Position += 0x12;
				return (reader.ReadInt16() & IMAGE_FILE_LARGE_ADDRESS_AWARE) != 0;
			}
		}

		public static bool Is64BitProcess(this Process process)
		{
			if (!Environment.Is64BitOperatingSystem)
				return false;

			bool is32BitOn64Bit;
			if (!Win32.IsWow64Process(process.Handle, out is32BitOn64Bit))
				throw new Win32Exception();
			return !is32BitOn64Bit;
		}

		public static DateTime RetrieveLinkerTimestamp(this Process process)
		{
			using (var reader = new FileMemoryReader(process.MainModule.FileName))
			{
				if (reader.Read<short>(0x00) != 0x5A4D)
					throw new InvalidDataException("No MZ header.");
				int peHeaderLocation = reader.Read<int>(0x3C);
				int unixTimestamp = reader.Read<int>(peHeaderLocation + 0x08);
				return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(unixTimestamp);
			}
		}

		private static class Win32
		{
			[DllImport("Kernel32.dll", SetLastError = true)]
			public static extern bool IsWow64Process(IntPtr processHandle, out bool value);
		}
	}
}
