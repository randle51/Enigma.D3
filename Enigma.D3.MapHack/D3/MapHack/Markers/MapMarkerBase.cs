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
        private bool _isVisible;

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
					Refresh(nameof(X));
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
					Refresh(nameof(Y));
				}
			}
		}

		public int ZIndex { get; protected set; }

        public bool IsVisible
        {
            get { return _isVisible; }
            set
            {
                if (_isVisible != value)
                {
                    _isVisible = value;
                    Refresh(nameof(IsVisible));
                }
            }
        }

		public abstract object CreateControl();

		public object Control
		{
			get
			{
				return (_control = _control ?? CreateControl());
			}
		}

		public abstract void Update(int worldId, Point3D origo);
	}
}
