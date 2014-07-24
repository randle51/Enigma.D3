using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma
{
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
