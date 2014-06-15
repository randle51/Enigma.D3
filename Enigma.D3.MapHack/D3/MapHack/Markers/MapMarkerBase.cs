using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Media3D;
using Enigma.Wpf;

namespace Enigma.D3.MapHack.Markers
{
	public abstract class MapMarkerBase : NotifyingObject, IMapMarker
	{
		private double _x;
		private double _y;
		private object _control;

		public MapMarkerBase(int id)
		{
			Id = id;
		}

		public int Id { get; private set; }

		public double X
		{
			get { return _x; }
			set
			{
				if (_x != value)
				{
					_x = value;
					Refresh("X");
				}
			}
		}

		public double Y
		{
			get { return _y; }
			set
			{
				if (_y != value)
				{
					_y = value;
					Refresh("Y");
				}
			}
		}

		public int ZIndex { get; protected set; }

		public abstract object CreateControl();

		public object Control
		{
			get
			{
				return (_control = _control ?? CreateControl());
			}
		}

		public abstract bool Update(int worldId, Point3D origo);
	}
}
