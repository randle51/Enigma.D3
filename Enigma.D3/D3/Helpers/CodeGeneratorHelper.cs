using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.Helpers
{
	public static class CodeGeneratorHelper
	{
		public static string GetSnoGroupFields()
		{
			StringBuilder sb = new StringBuilder();
			var snoGroups = Engine.Current.SnoGroups;
			int index = 0;
			var snoGroup = snoGroups[index];
			while (snoGroup != null)
			{
				string name = snoGroup.x1C_Name;
				sb.Append("public SnoGroup<MemoryObject> ").Append(name).Append("SnoGroup { get { return SnoGroups[").Append(index).Append("]; } }");
				sb.AppendLine();
				snoGroup = snoGroups[++index];
			}
			return sb.ToString();
		}

		public static string GetSnoGroupTypes()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("public enum SnoGroupType");
			sb.AppendLine("{");
			foreach (var g in Engine.Current.SnoGroups.Where(a => a != null).OrderBy(a => a.x3C_SnoGroupId))
			{
				sb.Append("\t").Append(g.x1C_Name).Append(" = ").Append((int)g.x3C_SnoGroupId).Append(",").AppendLine();
			}
			sb.AppendLine("}");
			return sb.ToString();
		}

		public static string GetSnoGroupDump()
		{
			return GetCascadingDump(Engine.Current.SnoGroups);
		}

		public static string GetDump<T>(IEnumerable<T> values)
		{
			var sb = new StringBuilder();
			var properties = typeof(T).GetProperties();
			sb.AppendLine(string.Join("\t", properties.Select(a => a.Name)));
			foreach (var item in values.Where(a => a != null))
			{
				sb.AppendLine(string.Join("\t", properties.Select(a => a.GetValue(item, null))));
			}
			return sb.ToString();
		}

		public static string GetDumpVertical<T>(T[] array, bool stack)
		{
			var sb = new StringBuilder();
			var properties = typeof(T).GetProperties();
			if (stack == false)
			{
				for (int i = 0; i < properties.Length; i++)
				{
					var property = properties[i];
					sb.AppendLine(property.Name + "\t" + string.Join("\t", array.Select(a => property.GetValue(a, null).ToString())));
				}
			}
			else
			{
				for (int n = 0; n < array.Length; n++)
				{
					for (int i = 0; i < properties.Length; i++)
					{
						var property = properties[i];
						sb.AppendLine("[" + n + "]." + property.Name + ": " + property.GetValue(array[n], null));
					}
				}
			}
			return sb.ToString();
		}

		public static string GetCascadingDump<T>(T[] array)
		{
			var sb = new StringBuilder();
			sb.AppendLine(string.Join("\t", GetPropertyNames(typeof(T))));
			foreach (var item in array)
			{
				sb.AppendLine(string.Join("\t", GetPropertyValues(item)));
			}
			return sb.ToString();
		}

		private static IEnumerable<string> GetPropertyNames(Type type)
		{
			var list = new List<string>();
			GetPropertyNames(type, null, list);
			return list;
		}

		private static void GetPropertyNames(Type type, string path, List<string> list)
		{
			foreach (var property in type.GetProperties())
			{
				if (property.PropertyType.IsSubclassOf(typeof(MemoryObject)) &&
					!typeof(System.Collections.IEnumerable).IsAssignableFrom(property.PropertyType))
				{
					GetPropertyNames(property.PropertyType, (path != null ? path + "." : "") + property.Name, list);
				}
				else
				{
					list.Add((path != null ? path + "." : "") + property.Name);
				}
			}
		}

		private static IEnumerable<object> GetPropertyValues(object instance)
		{
			if (instance == null)
				return new object[] { };

			var list = new List<object>();
			GetPropertyValues(instance.GetType(), instance, list);
			return list;
		}

		private static void GetPropertyValues(Type type, object instance, List<object> list)
		{
			foreach (var property in type.GetProperties())
			{
				if (property.PropertyType.IsSubclassOf(typeof(MemoryObject)) &&
					!typeof(System.Collections.IEnumerable).IsAssignableFrom(property.PropertyType))
				{
					GetPropertyValues(property.PropertyType, property.GetValue(instance, null), list);
				}
				else
				{
					list.Add(property.GetValue(instance, null));
				}
			}
		}

		public static string GetDump(System.Collections.IEnumerable enumerable, Type type)
		{
			var sb = new StringBuilder();
			var properties = type.GetProperties();
			sb.AppendLine(string.Join("\t", properties.Select(a => a.Name)));
			foreach (var item in enumerable)
			{
				if (item == null)
					continue;
				sb.AppendLine(string.Join("\t", properties.Select(a => a.GetValue(item, null))));
			}
			return sb.ToString();
		}
	}
}
