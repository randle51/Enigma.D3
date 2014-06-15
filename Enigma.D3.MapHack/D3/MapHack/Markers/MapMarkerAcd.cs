using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Media3D;

namespace Enigma.D3.MapHack.Markers
{
	public abstract class MapMarkerAcd : MapMarkerBase
	{
		private static int Validate(ActorCommonData acd)
		{
			if (acd == null)
				throw new ArgumentNullException("acd");
			return acd.Address;
		}

		private readonly ActorCommonData _acd;
		private readonly int _acdId;
		private readonly Func<ActorCommonData, bool> _isValid;

		public MapMarkerAcd(ActorCommonData acd, Func<ActorCommonData, bool> isValid)
			: base(Validate(acd))
		{
			if (isValid == null)
				throw new ArgumentNullException("isValid");

			_acd = acd;
			_acdId = _acd.x000_Id;
			_isValid = isValid;
		}

		protected ActorCommonData Acd { get { return _acd; } }

		public override bool Update(int worldId, Point3D origo)
		{
			if (_acd.x000_Id == -1 || _acd.x000_Id != _acdId)
				return false;
			if (!_isValid(Acd))
				return false;
			if (_acd.x108_WorldId != worldId)
				return false;

			base.X = _acd.x0D0_WorldPosX - origo.X;
			base.Y = _acd.x0D4_WorldPosY - origo.Y;

			return true;
		}
	}
}
