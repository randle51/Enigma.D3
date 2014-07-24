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
		private static readonly Type[] _controlTypes;
		private static readonly Dictionary<Type, HashSet<int>> _vtablesCache;

		static UXHelper()
		{
			_controlTypes = typeof(UXControl).Assembly.GetTypes().Where(a => a.IsUXControlType()).ToArray();
			_vtablesCache = new Dictionary<Type, HashSet<int>>();
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

		private static UXControl GetControlFromPointer(Pointer ptr)
		{
			if (ptr == null)
				return null;
			var vtable = ptr.Dereference<int>();
			var type = GetControlTypeFromVTable(vtable);
			return (UXControl)MemoryObject.UnsafeCreate(type, ptr.Memory, ptr.Read<int>());
		}

		public static T GetControl<T>(string name) where T : UXControl
		{
			return GetIfNotNull(
				GetControlPointer(name),
				ptr => ptr.Dereference<T>());
		}

		public static T GetControl<T>(UIReference handle) where T : UXControl
		{
			return GetIfNotNull(
				GetControlPointer(handle),
				ptr => ptr.Dereference<T>().EnsureValidType());
		}

		public static T GetControl<T>(ulong hash) where T : UXControl
		{
			return GetIfNotNull(
				GetControlPointer(hash),
				ptr => ptr.Dereference<T>().EnsureValidType());
		}

		public static T EnsureValidType<T>(this T control) where T : UXControl
		{
			if (!GetVTables<T>().Contains(control.x000_VTable))
				throw new InvalidCastException();
			return control;
		}

		public static Pointer GetControlPointer(string name)
		{
			return GetIfNotNull(GetUIMap(), map => map[name]);
		}

		public static Pointer GetControlPointer(ulong hash)
		{
			return GetIfNotNull(GetUIMap(), map => map[hash]);
		}

		public static Pointer GetControlPointer(UIReference handle)
		{
			return GetIfNotNull(GetUIMap(), map => map[handle]);
		}

		public static IEnumerable<Pointer> EnumerateControlPointers()
		{
			var map = GetUIMap();
			if (map == null)
				return Enumerable.Empty<Pointer>();
			return map.Select(a => a.x10_PtrComponent).Where(a => a != null);
		}

		public static IEnumerable<UXControl> Enumerate()
		{
			var map = GetUIMap();
			if (map == null)
				yield break;// Enumerable.Empty<UIControl>();
			foreach (var entry in map)
			{
				if (entry.x10_PtrComponent.Address != 0)
				{
					var control = entry.x10_PtrComponent.Dereference<UXControl>();
					if (control.x030_Self.x000_Hash == entry.x08_Hash)
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
			return EnumerateByVTable<T>(TypeHelper<T>.UXVTableAddress, checkBaseTypes);
		}

		private static IEnumerable<T> EnumerateByVTable<T>(int vtable, bool checkBaseTypes = false) where T : UXControl
		{
			var map = GetUIMap();
			if (map == null)
				yield break;// Enumerable.Empty<UIControl>();

			foreach (var entry in map)
			{
				if (entry.x10_PtrComponent.Address != 0)
				{
					var uxVTable = entry.x10_PtrComponent.Dereference<UXControl>().x000_VTable;
					var uxType = GetControlTypeFromVTable(uxVTable);
					if (uxType == typeof(T) || (checkBaseTypes && typeof(T).IsSubclassOf(uxType)))
					{
						var control = entry.x10_PtrComponent.Dereference<T>();
						if (control.x030_Self.x000_Hash == entry.x08_Hash)
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
			return control != null && (control.x024_Flags & 4) != 0;
		}

		public static T Cast<T>(this UXControl control) where T : UXControl
		{
			if (!GetVTables(typeof(T)).Contains(control.x000_VTable))
				throw new InvalidCastException();
			return MemoryObject.Create<T>(control.Memory, control.Address);
		}

		public static UIMap GetUIMap()
		{
			return Engine.TryGet(engine => engine.ObjectManager.x984_UI.x0000_Controls.x10_Map);
		}

		private static TResult GetIfNotNull<T, TResult>(T input, Func<T, TResult> getter)
			where T : MemoryObject
			where TResult : MemoryObject
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
				if (entry.x10_PtrComponent.Address != 0)
				{
					var ctrl_vtable = entry.x10_PtrComponent.Dereference<UXControl>().x000_VTable;
					var ctrl_type = GetControlTypeFromVTable(ctrl_vtable);
					if (ctrl_type == null)
					{
						continue;
					}
					if (ctrl_type == type || (allowSubClasses && ctrl_type.IsSubclassOf(type)))
					{
						var control = entry.x10_PtrComponent.Dereference<UXControl>();
						if (control.x030_Self.x000_Hash == entry.x08_Hash)
						{
							yield return MemoryObject.UnsafeCreate(type, Engine.Current.Memory, entry.x10_PtrComponent.Read<int>());
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
