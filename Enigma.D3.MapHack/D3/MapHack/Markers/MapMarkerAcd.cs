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
				throw new ArgumentNullException("acd");
			return acd.Address;
		}

		private readonly ACD _acd;
		private readonly int _acdId;
		private readonly Func<ACD, bool> _isValid;

		public MapMarkerAcd(ACD acd, Func<ACD, bool> isValid)
			: base(Validate(acd))
		{
			if (isValid == null)
				throw new ArgumentNullException("isValid");

			_acd = acd;
			_acdId = _acd.ID;
			_isValid = isValid;
		}

		protected ACD Acd { get { return _acd; } }

		public override bool Update(int worldId, Point3D origo)
		{
			if (_acd.ID == -1 || _acd.ID != _acdId)
				return false;
			if (!_isValid(Acd))
				return false;
			if (_acd.WorldSNO != worldId)
				return false;

			base.X = _acd.Position.X - origo.X;
			base.Y = _acd.Position.Y - origo.Y;

			return true;
		}
	}
}
