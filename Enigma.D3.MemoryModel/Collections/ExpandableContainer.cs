using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Collections
{
	// TODO: Other offsets for 32-bit?
	public class ExpandableContainer<T> : Container<T>
	{
		public new const int SizeOf = 0x170;

		public override IAllocator Allocator => Read<_Allocator>(0x120);
		private class _Allocator : MemoryObject, IAllocator
		{
			public const int SizeOf = 0x2C;

			public Ptr<Ptr<T>> Items => Read<Ptr<Ptr<T>>>(0x00);
			public int BlockAllocations => Read<int>(0x08);
			public int x0C => Read<int>(0x0C); // Padding?

			// Could be new struct start
			public Ptr x10 => Read<Ptr>(0x10); // Array of block pointers
			public int Size => Read<int>(0x18);
			public int Flags => Read<int>(0x1C);
			public Ptr VT => Read<Ptr>(0x20);
			public int GoodFood => Read<int>(0x28);
		}
		public int x14C => Read<int>(0x14C); // Padding? Is part of _Allocator?
		public int x150 => Read<int>(0x150);
		public int x154 => Read<int>(0x154);
		public Ptr x158 => Read<Ptr>(0x158); // 0 (NULL).
		public int Limit => Read<int>(0x160);
		public int MaxLimit => Read<int>(0x164);
		public int Bits => Read<int>(0x168);
		public int x16C => Read<int>(0x16C); // Padding?

		public override T this[int index]
		{
			get
			{
				var blockSize = 1 << Bits;
				var blockNumber = index / blockSize;
				var blockOffset = index % blockSize;
				return (Allocator as _Allocator).Items[blockNumber][blockOffset];
			}
		}

		public override IEnumerator<T> GetEnumerator()
		{
			short maxIndex = (short)MaxIndex;
			if (maxIndex < 0)
				yield break;

			int blockSize = 1 << Bits;
			int blockCount = (maxIndex / blockSize) + 1;

			var blocks = (Allocator as _Allocator).Items.ToArray(blockCount);

			var remaining = maxIndex + 1;
			foreach (var block in blocks)
			{
				var items = block.ToArray(Math.Min(remaining, blockSize));
				foreach (var item in items)
					yield return item;
				remaining -= items.Length;
			}
		}
	}
}
