using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.CodeGen.Memory.PatternScanning
{
	internal static class SymbolLocator
	{
		public static SymbolMap FindAll(byte[] data, BufferMemoryReader mem)
		{
			var symbols = new SymbolMap();
			foreach (var pattern in PatternProvider.GetPatterns().Select(a => FlairPattern.Parse(a)))
			{
				foreach (var pair in FindSymbols(pattern, data, mem))
					symbols.AddRange(pair.Key, pair.Value);
			}
			return symbols;
		}

		private static Dictionary<string, List<uint>> FindSymbols(FlairPattern pattern, byte[] data, MemoryReader memory)
		{
			var symbols = new Dictionary<string, List<uint>>();
			foreach (var match in pattern.Matches(data))
			{
				//var translated = 0x00801000 - 0x400 + match;
				//var b = new byte[100];
				//Array.Copy(Data, match, b, 0, 100);

				bool badMatch = false;
				var toBeAdded = new Dictionary<string, uint>();
				foreach (var refName in pattern.ReferenceNames)
				{
					var r = refName;
					var min = uint.MinValue;
					var max = uint.MaxValue;
					if (r.StartsWith(".") && r.Contains(":"))
					{
						var sectionName = r.Split(':')[0];
						var peReader = new PEHeaderReader(data);
						var section = peReader.ImageSectionHeaders.FirstOrDefault(
							a => new string(a.Name.TakeWhile(c => c != 0).ToArray()) == sectionName);
						min = section.VirtualAddress + peReader.OptionalHeader32.ImageBase;
						max = section.VirtualSize + min;
						r = refName.Split(':')[1];
					}
					else if (r.Contains(":")) // Removes methods.. not sure if this should be done.
						continue;

					var value = Read<uint>(pattern, memory, match, refName);
					if (value < min || value > max)
					{
						badMatch = true;
						continue;
					}

					var bits = pattern.LengthOfReference(refName) * 8;
					value = bits == 32 ? value : (value & ~(0xFFFFFFFF << bits));
					var bytes = (bits + 7) / 8;

					if (toBeAdded.ContainsKey(r) && toBeAdded[r] != value)
					{
						badMatch = true;
						continue;
					}
					else
					{
						toBeAdded[r] = value;
					}
				}

				if (badMatch == false)
				{
					pattern.PublicNames.ForEach(a => toBeAdded.Add(a, (uint)match));
					foreach (var pair in toBeAdded)
					{
						var r = pair.Key;
						var symbol = symbols.ContainsKey(r) ? symbols[r] : symbols[r] = new List<uint>();
						symbol.Add(pair.Value);
					}
				}
			}
			return symbols;
		}

		private static T Read<T>(this FlairPattern pattern, MemoryReader reader, int match, string name)
		{
			return reader.Read<T>(pattern.AddressOfReference(name, match));
		}
	}
}
