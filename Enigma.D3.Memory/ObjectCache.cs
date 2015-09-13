using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
	public class ObjectCache<T>
	{
		private static readonly TimeSpan DefaultLifeSpan = TimeSpan.FromMilliseconds(1000d / 60);

		public static implicit operator T(ObjectCache<T> cache) { return cache.Value; }

		private readonly Func<T> _get;
		private readonly TimeSpan _lifeSpan;
		private readonly long _lifeSpanInTicks;
		private T _value;
		private long _expirationTick;

		public bool IsFinalIfNotNull;

		public ObjectCache(Func<T> get)
			: this(get, DefaultLifeSpan) { }

		public ObjectCache(Func<T> get, TimeSpan lifeSpan)
		{
			if (get == null)
				throw new ArgumentNullException("get");
			_get = get;
			_lifeSpan = lifeSpan;
			_lifeSpanInTicks = _lifeSpan.Ticks;
		}

		public T Value
		{
			get
			{
				if (IsFinalIfNotNull && _value != null)
					return _value;

				var tick = Stopwatch.GetTimestamp();
				if (tick > _expirationTick)
				{
					_value = _get();
					_expirationTick = tick + _lifeSpanInTicks;
				}
				return _value;
			}
		}
	}
}
