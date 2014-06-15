using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.Wpf;

namespace Enigma.D3.MapHack.Markers
{
	public class MapMarkerOptions : NotifyingObject
	{
		private static readonly Lazy<MapMarkerOptions> _lazyInstance = new Lazy<MapMarkerOptions>(() => new MapMarkerOptions());

		public static MapMarkerOptions Instance { get { return _lazyInstance.Value; } }

		private bool _showWreckables = false;
		private bool _showChests = true;
		private bool _showMonsters = true;

		public bool ShowWreckables { get { return _showWreckables; } set { if (_showWreckables != value) { _showWreckables = value; Refresh("ShowWreckables"); } } }
		public bool ShowChests { get { return _showChests; } set { if (_showChests != value) { _showChests = value; Refresh("ShowChests"); } } }
		public bool ShowMonsters { get { return _showMonsters; } set { if (_showMonsters != value) { _showMonsters = value; Refresh("ShowMonsters"); } } }
	}
}
