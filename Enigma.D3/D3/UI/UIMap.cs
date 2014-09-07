using Enigma.Memory;
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
			Ptr ptr = null;
			try
			{
				ptr = map[name];
				value = ptr.Cast<T>().Dereference();
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

		public Ptr<Ptr<Pair>> x00_Ptr_Buckets { get { return ReadPointer<Ptr<Pair>>(0x00); } }
		public int x04 { get { return Read<int>(0x04); } }
		public int x08_Limit { get { return Read<int>(0x08); } }
		public int _x0C { get { return Read<int>(0x0C); } }
		public BasicAllocator x10_DynAllocator { get { return Read<BasicAllocator>(0x10); } }
		public int _x2C { get { return Read<int>(0x2C); } }
		public int x30 { get { return Read<int>(0x30); } }

		public Ptr this[string name]
		{
			get
			{
				return this[HashUtils.Fnv64(Encoding.ASCII.GetBytes(name.ToLower()))];
			}
		}

		public Ptr this[UIReference handle]
		{
			get
			{
				return this[handle.x000_Hash];
			}
		}

		public Ptr this[ulong hash]
		{
			get
			{
				uint index = HashUtils.Fnv32((int)hash) % (uint)x08_Limit;
				var pair = x00_Ptr_Buckets[(int)index].Dereference();
				while (pair != null)
				{
					if (pair.x08_Hash == hash)
						return pair.x10_PtrComponent;
					pair = pair.x00_Ptr_Next.Dereference();
				}
				throw new KeyNotFoundException();
			}
		}

		public IEnumerator<UIMap.Pair> GetEnumerator()
		{
			int count = x08_Limit;
			if (count > 0)
			{
				var buckets = x00_Ptr_Buckets.ToArray(count);
				if (buckets != null)
				{
					foreach (var bucket in buckets)
					{
						var pair = bucket.Dereference();
						while (pair != null)
						{
							yield return pair;
							pair = pair.x00_Ptr_Next.Dereference();
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

			public Ptr<Pair> x00_Ptr_Next { get { return ReadPointer<Pair>(0x00); } }
			public int _x04 { get { return Read<int>(0x04); } } // Alignment?
			public ulong x08_Hash { get { return Read<ulong>(0x08); } }
			public Ptr x10_PtrComponent { get { return Read<Ptr>(0x10); } }
			public int x14 { get { return Read<int>(0x14); } }
		}
	}
}
