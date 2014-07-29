using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.Sno
{
	public class SerializeMemoryObject : MemoryObject
	{
		private int? _baseAddress;

		public int BaseAddress { get { return _baseAddress ?? Address; } }

		new protected T Field<T>(int offset)
		{
			var value = base.Field<T>(offset);
			var sno = value as SerializeMemoryObject;
			if (sno != null)
			{
				sno.SetBaseAddress(BaseAddress);
			}
			return value;
		}

		new protected T[] Field<T>(int offset, int count)
		{
			var array = base.Field<T>(offset, count);
			if (array != null && array.Length > 0 && array[0] is SerializeMemoryObject)
			{
				for (int i = 0; i < array.Length; i++)
				{
					(array[i] as SerializeMemoryObject).SetBaseAddress(BaseAddress);
				}
			}
			return array;
		}

		protected string Deserialize(SerializeData serializeData)
		{
			return Field(serializeData.GetRelativeOffset(this), serializeData.Length);
		}

		protected T[] Deserialize<T>(SerializeData serializeData)
		{
			return Field<T>(serializeData.GetRelativeOffset(this), serializeData.Length / TypeHelper<T>.SizeOf);
		}

		private void SetBaseAddress(int baseAddress)
		{
			_baseAddress = baseAddress;
		}
	}
}
