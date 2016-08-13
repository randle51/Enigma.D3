using Enigma.D3;
using Enigma.D3.Explorer.Utilities;
using Enigma.D3.Explorer.Views;
using Enigma.Memory;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Enigma.D3.Explorer
{
	internal partial class MainWindow : Window
	{
		private Dictionary<string, ItemsControl> _mapping = new Dictionary<string, ItemsControl>();

		public MainWindow()
		{
			InitializeComponent();

			CreateReflectionRoot("Engine", () => Engine.Current);
			CreateReflectionRoot("LocalACD", () => ActorCommonData.Local);
			CreateReflectionRoot("LocalActor", () => Actor.Local);
		}

		private void CreateReflectionRoot<T>(string name, Func<T> getter)
		{
			var path = new List<Tuple<string, Type>>();
			path.Add(new Tuple<string, Type>(name, typeof(T)));
			AddView(name, new ReflectionView(() => getter.Invoke(), false, true));
			CreateReflectionViews(path, () => getter.Invoke(), typeof(T));
		}

		private void CreateReflectionViews(List<Tuple<string, Type>> path, Func<object> getter, Type type)
		{
			var root = string.Join(".", path.Select(x => x.Item1));
			foreach (var property in type.GetProperties())
			{
				var mType = property.PropertyType;
				var mInfo = property as MemberInfo;

				if (mType.IsGenericPointer())
					VisitGenericPointer(path, getter, root, property);

				if (mType.IsArray)
				{
					VisitArray(path, getter, root, property);
					continue;
				}

				if (mType.IsEnumerable())
					VisitEnumerable(path, getter, root, property);

				if (mType == type || mType.IsPrimitive || !mType.IsMemoryObjectType())
					continue; // Ignore primitives and non memory objects.

				if (mInfo.DeclaringType == typeof(MemoryObject))
					continue; // Ignore base properties on memory objects.

				if (property.GetIndexParameters().Length > 0)
					continue; // Ignore indexers.

				AddView(root + "." + mInfo.Name, new ReflectionView(() => property.GetValue(getter.Invoke())));
				if (mType.IsMemoryObjectType() && !path.Any(x => x.Item2 == mType))
				{
					path.Add(new Tuple<string, Type>(mInfo.Name, mType));
					CreateReflectionViews(path, () => property.GetValue(getter.Invoke()), mType);
					path.RemoveAt(path.Count - 1);
				}
			}
		}

		private void VisitGenericPointer(List<Tuple<string, Type>> path, Func<object> getter, string root, PropertyInfo property)
		{
			var mType = property.PropertyType;
			var mInfo = property as MemberInfo;

			var p = "*";
			var valueType = mType.GenericTypeArguments[0];
			var valueGetter = ((Func<object>)(() =>
			{
				var ptr = property.GetValue(getter.Invoke());
				var value = ptr.GetType().GetMethod(nameof(Ptr<object>.Dereference)).Invoke(ptr, null);
				while (value is Ptr && value.GetType().IsGenericType)
				{
					value = value.GetType().GetMethod(nameof(Ptr<object>.Dereference)).Invoke(value, null);
				}
				return value;
			}));

			while (valueType.IsGenericPointer())
			{
				p += "*";
				valueType = valueType.GenericTypeArguments[0];
			}

			AddView(root + "." + mInfo.Name + p, new ReflectionView(valueGetter));
			if (valueType.IsMemoryPointerType() || (valueType.IsMemoryObjectType() && !path.Any(x => x.Item2 == valueType)))
			{
				path.Add(new Tuple<string, Type>(mInfo.Name + p, valueType));
				CreateReflectionViews(path, valueGetter, valueType);
				path.RemoveAt(path.Count - 1);
			}
		}

		private void VisitArray(List<Tuple<string, Type>> path, Func<object> getter, string root, PropertyInfo property)
		{
			var mType = property.PropertyType;
			var mInfo = property as MemberInfo;

			AddView(root + "." + mInfo.Name, new ReflectionView(() => property.GetValue(getter.Invoke())));

			var arraySize = mInfo.GetCustomAttribute<ArraySizeAttribute>();
			if (arraySize != null)
			{
				var elementType = mType.GetElementType();
				for (int i = 0; i < arraySize.Value; i++)
				{
					var arrayProperty = property;
					var index = i;
					var elementGetter = ((Func<object>)(() =>
					{
						var array = arrayProperty.GetValue(getter.Invoke()) as Array;
						var element = array.GetValue(index);
						return element;
					}));
					AddView(root + "." + mInfo.Name + ".[" + i + "]", new ReflectionView(elementGetter));
					if (elementType.IsMemoryObjectType() && !path.Any(x => x.Item2 == elementType))
					{
						path.Add(new Tuple<string, Type>(mInfo.Name + ".[" + i + "]", elementType));
						CreateReflectionViews(path, elementGetter, elementType);
						path.RemoveAt(path.Count - 1);
					}
				}
			}
		}

		private void VisitEnumerable(List<Tuple<string, Type>> path, Func<object> getter, string root, PropertyInfo property)
		{
			var mType = property.PropertyType;
			var mInfo = property as MemberInfo;

			var enumerableType = mType.GetEnumerableType(); // IEnumerable<T>
			if (enumerableType != null)
			{
				var arraySize = mInfo.GetCustomAttribute<ArraySizeAttribute>();
				if (arraySize != null)
				{
					var elementType = enumerableType.GenericTypeArguments[0];
					for (int i = 0; i < arraySize.Value; i++)
					{
						var arrayProperty = property;
						var index = i;
						var elementGetter = ((Func<object>)(() =>
						{
							var enumerable = arrayProperty.GetValue(getter.Invoke()) as IEnumerable;
							var element = enumerable.Cast<object>().ElementAt(index);
							return element;
						}));
						AddView(root + "." + mInfo.Name + ".[" + i + "]", new ReflectionView(elementGetter));
						if (elementType.IsMemoryObjectType() && !path.Any(x => x.Item2 == elementType))
						{
							path.Add(new Tuple<string, Type>(mInfo.Name + ".[" + i + "]", elementType));
							CreateReflectionViews(path, elementGetter, elementType);
							path.RemoveAt(path.Count - 1);
						}
					}
				}
			}
		}

		private void AddView(string path, IView view)
		{
			var parts = path.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
			var node = GetTreeParent(parts);

			var item = default(TreeViewItem);
			var bindToNode = true;
			if (_mapping.ContainsKey(path))
			{
				item = _mapping[path] as TreeViewItem;
				if (item.Tag != null)
					throw new InvalidOperationException($"Path {path} has already been added.");
				bindToNode = false;
			}
			else
			{
				item = new TreeViewItem();
			}

			item.Header = parts.Last();
			item.Tag = view;
			item.Selected += OnViewSelected;
			item.Unselected += OnViewUnselected;
			if (bindToNode)
			{
				node.Items.Add(item);
				_mapping.Add(path, item);
			}
		}

		private ItemsControl GetTreeParent(string[] parts)
		{
			ItemsControl parent = ViewSelector;
			for (int i = 1; i < parts.Length; i++)
			{
				string path = string.Join(".", parts.Take(i));
				if (!_mapping.ContainsKey(path))
				{
					var item = new TreeViewItem();
					item.Header = parts[i - 1];
					parent.Items.Add(item);
					_mapping.Add(path, item);
				}
				parent = _mapping[path];
			}
			return parent;
		}

		private void OnViewSelected(object sender, RoutedEventArgs e)
		{
			var item = sender as TreeViewItem;
			var view = item.Tag as IView;

			view.Enter();
			if (view.ContextMenuItems?.Length > 0)
			{
				if (item.ContextMenu == null)
				{
					item.ContextMenu = new ContextMenu();
				}
				item.ContextMenu.ItemsSource = view.ContextMenuItems;
			}
			ViewPresenter.Content = view.Content;
			e.Handled = true;
		}

		private void OnViewUnselected(object sender, RoutedEventArgs e)
		{
			var item = sender as TreeViewItem;
			var view = item.Tag as IView;

			view.Leave();
			ViewPresenter.Content = null;
			e.Handled = true;
		}


		#region Commands

		private void OnCreateMiniDumpClicked(object sender, RoutedEventArgs e)
		{
			var memory = Engine.Current == null ? null : Engine.Current.Memory.Reader as ProcessMemoryReader;
			if (memory != null)
			{
				var dialog = new SaveFileDialog();
				dialog.Filter = "MiniDump Files|*.dmp";
				dialog.FileName = memory.Process.ProcessName + "-" + memory.Process.GetFileVersion() + "-" + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".dmp";
				if (dialog.ShowDialog() == true)
				{
					memory.CreateMiniDump(dialog.FileName, true);
				}
			}
		}

		private void OnAttachToMiniDumpClicked(object sender, RoutedEventArgs e)
		{
			var dialog = new OpenFileDialog();
			dialog.Filter = "MiniDump Files|*.dmp";
			if (dialog.ShowDialog() == true)
			{
				App.AttachMiniDump(dialog.FileName);
			}
		}

		private void OnAttachToProcessClicked(object sender, RoutedEventArgs e)
		{
			App.BeginAttachEngine();
		}

		#endregion
	}
}
