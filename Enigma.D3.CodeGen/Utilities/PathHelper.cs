﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.CodeGen.Utilities
{
	internal static class PathHelper
	{
		public static string GetRelativePathFrom(this FileSystemInfo to, FileSystemInfo from)
		{
			return from.GetRelativePathTo(to);
		}

		public static string GetRelativePathTo(this FileSystemInfo from, FileSystemInfo to)
		{
			Func<FileSystemInfo, string> getPath = fsi =>
			{
				var d = fsi as DirectoryInfo;
				return d == null ? fsi.FullName : d.FullName.TrimEnd('\\') + "\\";
			};

			var fromPath = getPath(from);
			var toPath = getPath(to);

			var fromUri = new Uri(fromPath);
			var toUri = new Uri(toPath);

			var relativeUri = fromUri.MakeRelativeUri(toUri);
			var relativePath = Uri.UnescapeDataString(relativeUri.ToString());

			return relativePath.Replace('/', Path.DirectorySeparatorChar);
		}
	}
}
