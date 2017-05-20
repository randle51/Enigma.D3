using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Media.Media3D;
using Enigma.Wpf;

namespace Enigma.D3.MapHack.Markers
{
	public interface IMapMarker : INotifyPropertyChanged
	{
		double X { get; }

		double Y { get; }

		int ZIndex { get; }

		object CreateControl();

		void Update(int worldId, Point3D origo);

		int Id { get; }
	}
}
