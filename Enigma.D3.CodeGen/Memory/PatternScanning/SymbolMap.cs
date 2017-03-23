using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.CodeGen.Memory.PatternScanning
{
	internal class SymbolMap
	{
		private readonly Dictionary<string, List<uint>> _map = new Dictionary<string, List<uint>>();

		public void Add(string key, uint item)
		{
			CreateKey(key);
			_map[key].Add(item);
		}

		public void AddRange(string key, IEnumerable<uint> collection)
		{
			CreateKey(key);
			_map[key].AddRange(collection);
		}
		
		public uint BestMatch(string key)
		{
			if (!_map.ContainsKey(key))
				return 0;

			if (_map[key].Distinct().Count() > 1)
				return 0;

			return _map[key][0];
		}

		public IEnumerable<uint> Matches(string key) => _map.ContainsKey(key) ? _map[key] : Enumerable.Empty<uint>();

		private void CreateKey(string key)
		{
			if (_map.ContainsKey(key) == false)
				_map[key] = new List<uint>();
		}

		public void Override(string key, uint value)
		{
			CreateKey(key);
			_map[key].Clear();
			_map[key].Add(value);
		}
	}
}
