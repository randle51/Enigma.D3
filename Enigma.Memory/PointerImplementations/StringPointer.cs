using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Memory
{
	public class StringPointer : Ptr<string>
	{
		public StringPointer(IMemory memory, MemoryAddress value)
			: this(memory, value, 512) { }

		public StringPointer(IMemory memory, MemoryAddress value, int maxLength)
			: this(memory, value, maxLength, Encoding.UTF8) { }

		public StringPointer(IMemory memory, MemoryAddress value, int maxLength, Encoding encoding)
			: base(memory, value)
		{
			if (maxLength < 0)
				throw new ArgumentOutOfRangeException("maxLength");
			if (encoding == null)
				throw new ArgumentNullException("encoding");

			MaxLength = maxLength;
			Encoding = encoding;
		}

		public int MaxLength { get; private set; }

		public Encoding Encoding { get; private set; }

		public override string this[int index]
		{
			get
			{
				if (IsInvalid)
					return default(string);

				return Memory.Reader.ReadString(
					ValueAddress + index * MaxLength,
					MaxLength,
					Encoding);
			}
		}

		public override string Dereference()
		{
			if (IsInvalid)
				return default(string);

			return Memory.Reader.ReadString(ValueAddress, MaxLength);
		}

		public override string[] ToArray(int count)
		{
			if (IsInvalid)
				return default(string[]);

			var array = new string[count];
			for (int i = 0; i < count; i++)
			{
				array[i] = this[i];
			}
			return array;
		}
	}
}
