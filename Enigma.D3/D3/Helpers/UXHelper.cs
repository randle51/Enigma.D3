using Enigma.Memory;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;
using Enigma.D3.UI;
using Enigma.D3.UI.Controls;

namespace Enigma.D3.Helpers
{
	public static class UXHelper
	{
		private static class UXTypeCache<T> where T : UXControl
		{
			static UXTypeCache()
			{
				VTableAddress = typeof(T).GetUXVTableAddress();
			}

			public static readonly int VTableAddress;
		}

		private static readonly Type[] _controlTypes;
		private static readonly Dictionary<Type, HashSet<int>> _vtablesCache;

		static UXHelper()
		{
			_controlTypes = typeof(UXControl).Assembly.GetTypes().Where(a => a.IsUXControlType()).ToArray();
			_vtablesCache = new Dictionary<Type, HashSet<int>>();
		}

		public static bool IsUXControlType(this Type type)
		{
			return type.IsSubclassOf(typeof(UXControl)) || type.Equals(typeof(UXControl));
		}

		public static int GetUXVTableAddress(this Type type)
		{
			if (type.IsUXControlType())
			{
				var field = type.GetField("VTable",
					System.Reflection.BindingFlags.FlattenHierarchy |
					System.Reflection.BindingFlags.Static |
					System.Reflection.BindingFlags.Public);
				if (field == null)
					throw new InvalidOperationException("Could not find static 'VTable' on type '" + type.FullName + "'");
				return field.IsLiteral ? (int)field.GetRawConstantValue() : (int)field.GetValue(null);
			}
			return 0;
		}

		public static UXControl GetControl(string name)
		{
			return GetControlFromPointer(GetControlPointer(name));
		}

		public static UXControl GetControl(UIReference handle)
		{
			return GetControlFromPointer(GetControlPointer(handle));
		}

		public static UXControl GetControl(ulong hash)
		{
			return GetControlFromPointer(GetControlPointer(hash));
		}

		private static UXControl GetControlFromPointer(Ptr ptr)
		{
			if (ptr == null)
				return null;

			var vtable = ptr.Cast<int>().Dereference();
			var type = GetControlTypeFromVTable(vtable);
			return (UXControl)MemoryObjectFactory.UnsafeCreate(type, ptr.Memory.Reader, ptr.ValueAddress);
		}

		public static T GetControl<T>(string name) where T : UXControl
		{
			return GetIfNotNull(
				GetControlPointer(name),
				ptr => ptr.Cast<T>().Dereference());
		}

		public static T GetControl<T>(UIReference handle) where T : UXControl
		{
			return GetIfNotNull(
				GetControlPointer(handle),
				ptr => ptr.Cast<T>().Dereference().EnsureValidType());
		}

		public static T GetControl<T>(ulong hash) where T : UXControl
		{
			return GetIfNotNull(
				GetControlPointer(hash),
				ptr => ptr.Cast<T>().Dereference().EnsureValidType());
		}

		public static T EnsureValidType<T>(this T control) where T : UXControl
		{
			if (!GetVTables<T>().Contains(control.x000_VTable))
				throw new InvalidCastException();
			return control;
		}

		public static Ptr GetControlPointer(string name)
		{
			return GetIfNotNull(GetUIMap(), map => map[name]);
		}

		public static Ptr GetControlPointer(ulong hash)
		{
			return GetIfNotNull(GetUIMap(), map => map[hash]);
		}

		public static Ptr GetControlPointer(UIReference handle)
		{
			return GetIfNotNull(GetUIMap(), map => map[handle]);
		}

		public static IEnumerable<Ptr> EnumerateControlPointers()
		{
			var map = GetUIMap();
			if (map == null)
				return Enumerable.Empty<Ptr>();
			return map.Select(a => a.x10_PtrComponent).Where(a => a != null);
		}

		public static IEnumerable<UXControl> Enumerate()
		{
			var map = GetUIMap();
			if (map == null)
				yield break;// Enumerable.Empty<UIControl>();
			foreach (var entry in map)
			{
				if (entry.x10_PtrComponent.ValueAddress != 0)
				{
					var control = entry.x10_PtrComponent.Cast<UXControl>().Dereference();
					if (control.x020_Self.x000_Hash == entry.x08_Hash)
						yield return control;
					else
					{
						;
					}
				}
			}
		}

		public static IEnumerable<T> Enumerate<T>(bool checkBaseTypes = false) where T : UXControl
		{
			return EnumerateByVTable<T>(UXTypeCache<T>.VTableAddress, checkBaseTypes);
		}

		private static IEnumerable<T> EnumerateByVTable<T>(int vtable, bool checkBaseTypes = false) where T : UXControl
		{
			var map = GetUIMap();
			if (map == null)
				yield break;// Enumerable.Empty<UIControl>();

			foreach (var entry in map)
			{
				if (entry.x10_PtrComponent.ValueAddress != 0)
				{
					var uxVTable = entry.x10_PtrComponent.Cast<UXControl>().Dereference().x000_VTable;
					var uxType = GetControlTypeFromVTable(uxVTable);
					if (uxType == typeof(T) || (checkBaseTypes && typeof(T).IsSubclassOf(uxType)))
					{
						var control = entry.x10_PtrComponent.Cast<T>().Dereference();
						if (control.x020_Self.x000_Hash == entry.x08_Hash)
						{
							yield return control;
						}
						else
						{
							;
						}
					}
				}
			}
		}

		private static HashSet<int> GetVTables<T>() where T : UXControl
		{
			return GetVTables(typeof(T));
		}

		private static HashSet<int> GetVTables(Type type)
		{
			HashSet<int> vtables;
			if (_vtablesCache.TryGetValue(type, out vtables))
				return vtables;

			vtables = new HashSet<int>();
			while (type != typeof(UXControl))
			{
				var vtable = (int)type.GetField("VTable").GetRawConstantValue();
				vtables.Add(vtable);
				type = type.BaseType;
			}
			vtables.Add(UXControl.VTable);
			return vtables;
		}

		public static Type GetControlTypeFromVTable(int vtable)
		{
			return GetControlTypes().SingleOrDefault(a => (int)a.GetField("VTable").GetRawConstantValue() == vtable);
		}

		public static Type[] GetControlTypes()
		{
			return _controlTypes;
		}

		public static bool IsVisible(this UXControl control)
		{
			return control != null && (control.x014_Flags & 4) != 0;
		}

		public static T Cast<T>(this UXControl control) where T : UXControl
		{
			if (!GetVTables(typeof(T)).Contains(control.x000_VTable))
				throw new InvalidCastException();
			return MemoryObjectFactory.Create<T>(control.Memory.Reader, control.Address);
		}

		public static UIMap GetUIMap()
		{
			return Engine.TryGet(engine => engine.ObjectManager.x9A4_UI.x0000_Controls.x10_Map);
		}

		private static TResult GetIfNotNull<T, TResult>(T input, Func<T, TResult> getter)
		{
			if (input == null)
				return default(TResult);
			return getter.Invoke(input);
		}

		public static IEnumerable Enumerate(Type type, bool allowSubClasses = false)
		{
			if (!typeof(UXControl).IsAssignableFrom(type))
				throw new ArgumentException("Invalid type.");
			var vtable = (int)type.GetField("VTable").GetRawConstantValue();

			var map = GetUIMap();
			if (map == null)
				yield break;// Enumerable.Empty<UIControl>();

			foreach (var entry in map)
			{
				if (entry.x10_PtrComponent.ValueAddress != 0)
				{
					var ctrl_vtable = entry.x10_PtrComponent.Cast<UXControl>().Dereference().x000_VTable;
					var ctrl_type = GetControlTypeFromVTable(ctrl_vtable);
					if (ctrl_type == null)
					{
						continue;
					}
					if (ctrl_type == type || (allowSubClasses && ctrl_type.IsSubclassOf(type)))
					{
						var control = entry.x10_PtrComponent.Cast<UXControl>().Dereference();
						if (control.x020_Self.x000_Hash == entry.x08_Hash)
						{
							yield return entry.x10_PtrComponent.Cast<int>().Dereference();
						}
						else
						{
							;
						}
					}
				}
			}
		}
	}
}
