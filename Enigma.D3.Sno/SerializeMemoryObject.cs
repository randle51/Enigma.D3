using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	public class SerializeMemoryObject : MemoryObject
	{
		private int? _serializeBaseAddress;

		public int SerializeBaseAddress { get { return _serializeBaseAddress ?? Address; } }

		protected T Field<T>(int offset)
		{
			var value = base.Read<T>(offset);
			var sno = value as SerializeMemoryObject;
			if (sno != null)
			{
				sno.SetBaseAddress(Address);
			}
			return value;
		}

		protected T[] Field<T>(int offset, int count)
		{
			var array = base.Read<T>(offset, count);
			if (array != null && array.Length > 0 && array[0] is SerializeMemoryObject)
			{
				for (int i = 0; i < array.Length; i++)
				{
					(array[i] as SerializeMemoryObject).SetBaseAddress(SerializeBaseAddress);
				}
			}
			return array;
		}

		protected string DeserializeString(SerializeData serializeData)
		{
			return ReadString(serializeData.GetRelativeOffset(this), serializeData.Length);
		}

		protected T[] Deserialize<T>(SerializeData serializeData)
		{
			return Field<T>(serializeData.GetRelativeOffset(this), serializeData.Length / TypeHelper<T>.SizeOf);
		}

		private void SetBaseAddress(int baseAddress)
		{
			_serializeBaseAddress = baseAddress;
		}
	}
}
