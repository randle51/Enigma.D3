using Enigma.D3.MemoryModel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Media3D;

namespace Enigma.D3.MapHack.Markers
{
	public abstract class MapMarkerAcd : MapMarkerBase
	{
		private static int Validate(ACD acd)
		{
			if (acd == null)
				throw new ArgumentNullException(nameof(acd));
			return acd.Address;
		}

		private readonly ACD _acd;
		private readonly int _acdId;
		private readonly Func<ACD, bool> _isVisible;

		public MapMarkerAcd(ACD acd, Func<ACD, bool> isVisible)
			: base(Validate(acd))
		{
			if (isVisible == null)
				throw new ArgumentNullException(nameof(isVisible));

			_acd = acd;
			_acdId = _acd.ID;
			_isVisible = isVisible;
		}

		protected ACD Acd { get { return _acd; } }

		public override void Update(int worldId, Point3D origo)
		{
            if (IsVisible = _isVisible(Acd) && _acd.SWorldID == worldId)
            {
                X = _acd.Position.X - origo.X;
                Y = _acd.Position.Y - origo.Y;
            }
        }
	}
}
