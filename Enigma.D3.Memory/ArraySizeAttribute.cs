using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma
{
	/// <summary>
	/// Used to mark arrays, enumerables or pointers with the number of items for a reflector UI to
	/// display.
	/// </summary>
	public class ArraySizeAttribute : Attribute
	{
		public ArraySizeAttribute(int value)
		{
			if (value < 0)
				throw new ArgumentOutOfRangeException();
			Value = value;
		}

		public int Value { get; set; }
	}
}
