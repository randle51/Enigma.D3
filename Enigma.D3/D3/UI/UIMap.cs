using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Helpers;
using Enigma.D3.Memory;
using Enigma.D3.UI.Controls;

namespace Enigma.D3.UI
{
	public static class UIMapExtensions
	{
		public static bool TryGet<T>(this UIMap map, string name, out T value) where T : UXControl
		{
			Pointer ptr = null;
			try
			{
				ptr = map[name];
				value = ptr.Dereference<T>();
				return true;
			}
			catch (KeyNotFoundException)
			{
				value = null;
				return false;
			}
		}
	}

	public class UIMap : MemoryObject, IEnumerable<UIMap.Pair>
	{
		// 2.0.0.20874
		public const int SizeOf = 0x34; // = 52

		public UIMap(MemoryBase memory, int address)
			: base(memory, address) { }

		public Pointer<Pair>[] x00_Buckets { get { return Dereference<Pointer<Pair>>(0x00, x08_Limit); } }
		public int x04 { get { return Field<int>(0x04); } }
		public int x08_Limit { get { return Field<int>(0x08); } }
		public int _x0C { get { return Field<int>(0x0C); } }
		public BasicAllocator x10_DynAllocator { get { return Field<BasicAllocator>(0x10); } }
		public int _x2C { get { return Field<int>(0x2C); } }
		public int x30 { get { return Field<int>(0x30); } }

		public Pointer this[string name]
		{
			get
			{
				return this[HashUtils.Fnv64(Encoding.ASCII.GetBytes(name.ToLower()))];
			}
		}

		public Pointer this[UIReference handle]
		{
			get
			{
				return this[handle.x000_Hash];
			}
		}

		public Pointer this[ulong hash]
		{
			get
			{
				uint index = HashUtils.Fnv32((int)hash) % (uint)x08_Limit;
				var pair = x00_Buckets[index].Value;
				while (pair != null)
				{
					if (pair.x08_Hash == hash)
						return pair.x10_PtrComponent;
					pair = pair.x00_Next;
				}
				throw new KeyNotFoundException();
			}
		}

		public IEnumerator<UIMap.Pair> GetEnumerator()
		{
			int count = x08_Limit;
			if (count > 0)
			{
				var buckets = x00_Buckets;
				if (buckets != null)
				{
					foreach (var bucket in buckets)
					{
						var pair = bucket.Value;
						while (pair != null)
						{
							yield return pair;
							pair = pair.x00_Next;
						}
					}
				}
			}
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}



		public class Pair : MemoryObject
		{
			public const int SizeOf = 0x18; // = 20

			public Pair(MemoryBase memory, int address)
				: base(memory, address) { }

			public Pair x00_Next { get { return Dereference<Pair>(0x00); } }
			public int _x04 { get { return Field<int>(0x04); } } // Alignment?
			public ulong x08_Hash { get { return Field<ulong>(0x08); } }
			public Pointer x10_PtrComponent { get { return Field<Pointer>(0x10); } }
			public int x14 { get { return Field<int>(0x14); } }
		}
	}
}
