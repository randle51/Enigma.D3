using Enigma.D3.Explorer.Utilities;
using Enigma.D3.Memory;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Enigma.D3.Explorer.Views
{
	//internal class ReflectionView : ReflectionView<object>
	//{
	//	public ReflectionView(Func<object> getContext, bool includeFields = false, bool skipOffsetCheck = false)
		//	: base(getContext, includeFields, skipOffsetCheck) { }
	//}
	//
	internal class ReflectionView : CustomContentView<object>
	{
		private class Label : RichTextBox
		{
			private Run _header;
			private Run _content;

			public Label()
			{
				_header = new Run() { FontWeight = FontWeights.Bold };
				_content = new Run();
				var para = new Paragraph();
				para.Inlines.Add(_header);
				para.Inlines.Add(_content);
				Document.Blocks.Clear();
				Document.Blocks.Add(para);
				IsReadOnly = true;
				IsReadOnlyCaretVisible = true;
			}

			public string Header { set { _header.Text = value + ": "; } }
			public string Content { set { _content.Text = value; } }
		}

		private readonly Func<object> _getContext;
		private readonly bool _includeFields;
		private readonly bool _skipOffsetCheck;

		public ReflectionView(Func<object> getContext, bool includeFields = false, bool skipOffsetCheck = false)
		{
			if (getContext == null)
				throw new ArgumentNullException("getContext");
			_getContext = getContext;
			_includeFields = includeFields;
			_skipOffsetCheck = skipOffsetCheck;
		}

		protected override object CreateContent()
		{
			if (ContextMenuItems == null)
			{
				ContextMenuItems = new MenuItem[1];
				ContextMenuItems[0] = new MenuItem { Header = "Generate Class" };
				ContextMenuItems[0].Click += (s, e) =>
				{
					var memoryObjectContext = Context as MemoryObject;
					if (memoryObjectContext != null)
					{
						MemoryObjectClassGenerator.GenerateClass(memoryObjectContext);
					}
				};
			}

			var root = new ScrollViewer();
			var panel = new StackPanel();
			root.Content = panel;

			//panel.Children.Add(new TextBox { IsReadOnly = true, Text = "Type: " + Context.GetType().FullName });
			panel.Children.Add(new Label { Header = "Type", Content = Context.GetType().FullName });
			if (Context is MemoryObject)
			{
				//panel.Children.Add(Dynamic(new TextBox() { IsReadOnly = true }, a => { a.Text = "Address: 0x" + ((MemoryObject)Context).Address.ToString("X8"); }));
				panel.Children.Add(Dynamic(new Label { Header = "Address" }, a => a.Content = (Context as MemoryObject).Address.ToString()));
			}
			else
			{
				panel.Children.Add(new Label { Content = Context.ToString() });
			}

			var props = Context.GetType().GetProperties();

			foreach (var prop in props)
			{
				var propName = prop.Name.TrimStart('_');
				string prefix;
				if (!propName.StartsWith("x"))
				{
					if (!_skipOffsetCheck)
						continue;
					prefix = propName;
				}
				else
				{
					var index = propName.IndexOf('_');
					var offset = "[0x" + (index == -1 ? propName.Substring(1) : propName.Substring(1, index - 1)) + "]";
					var name = index == -1 ? "???" : propName.Substring(index + 1);
					prefix = offset + " " + name;
				}

				Func<object, int, string> transform = null;
				if (prop.PropertyType == typeof(int) || prop.PropertyType == typeof(uint))
				{
					transform = (value, address) =>
					{
						var i32 = Convert.ToInt32(value);
						var i32text = (i32 > 0x00800000 || i32 < -0x00800000) ? "0x" + i32.ToString("X8") : i32.ToString();
						if (i32 > 0x00800000 || i32 < -0x00800000)
						{
							i32text += " (float: " + BitConverter.ToSingle(BitConverter.GetBytes(i32), 0) + ")";
							i32text += " (ascii: " + Encoding.ASCII.GetString(BitConverter.GetBytes(i32)) + ")";
						}
						//if (App.SnoDiskEntries.ContainsKey(i32))
						//	i32text += " (" + App.SnoDiskEntries[i32].Type.ToString() + ": " + App.SnoDiskEntries[i32].Name + ")";

						if (i32 == 0x600DF00D)
						{
							i32text += " (GOODFOOD)";
							if (address != 0)
							{
								var mem = (Context as MemoryObject).Memory;
								var back8 = mem.Reader.Read<int>(address - 8);
								if ((back8 & 0x20200) == 0x20200)
								{
									i32text += " (" + MemoryObjectFactory.Create<Allocator>(mem.Reader, address - Allocator.SizeOf + 4).ToString() + ")";
								}
								else
								{
									var back12 = mem.Reader.Read<int>(address - 12);
									if ((back12 & 0x20200) == 0x20200)
									{
										i32text += " (" + MemoryObjectFactory.Create<BasicAllocator>(mem.Reader, address - BasicAllocator.SizeOf + 4).ToString() + ")";
									}
								}
							}
						}
						if (i32 == unchecked((int)0xFEEDFACE))
						{
							i32text += " (FEEDFACE)";
						}

						return i32text;
					};
				}
				else if (prop.PropertyType == typeof(long))
				{
					transform = (value, address) =>
					{
						var i64 = Convert.ToInt64(value);
						return (i64 > 0x00800000 || i64 < -0x00800000) ? "0x" + i64.ToString("X8") : i64.ToString();
					};
				}
				else if (prop.PropertyType == typeof(ulong))
				{
					transform = (value, address) =>
					{
						var ui64 = Convert.ToUInt64(value);
						return (ui64 > 0x00800000) ? "0x" + ui64.ToString("X8") : ui64.ToString();
					};
				}

				int baseAddress = Context is MemoryObject ? (int)(Context as MemoryObject).Address : 0;
				//panel.Children.Add(Dynamic(new TextBox() { IsReadOnly = true }, a =>
				panel.Children.Add(Dynamic(new Label(), a =>
				{
					var value = prop.GetValue(Context);
					var propOffset = GetOffsetFromPropertyName(prop.Name);
					var address = propOffset == -1 ? 0 : baseAddress + propOffset;
					if (transform != null)
						value = transform(value, address);
					a.Header = prefix;
					a.Content = (value ?? "null").ToString();
					a.ToolTip = "Address: 0x" + address.ToString("X8");
				}));
			}

			if (_includeFields)
			{
				foreach (var field in Context.GetType().GetFields())
				{
					panel.Children.Add(Dynamic(new Label(), a =>
					{
						var value = field.GetValue(Context);
						a.Header = field.Name;
						a.Content = (value ?? "null").ToString();
					}));
				}
			}

			return root;
		}
		
		private int GetOffsetFromPropertyName(string name)
		{
			name = name.TrimStart('_');
			var index = name.IndexOf('_');
			var offsetStr = index == -1 ? name.Substring(1) : name.Substring(1, index - 1);
			int offset;
			if (!int.TryParse(offsetStr, System.Globalization.NumberStyles.HexNumber, null, out offset))
				return -1;
			return offset;
		}

		object _previousContext = null;
		protected override object CreateContext()
		{
			var context = _getContext.Invoke();
			//if (context is NetworkMessage)
			//{
			//	if (((NetworkMessage)context).x0C_Data1 == 154)
			//		context = _previousContext ?? context;
			//}
			_previousContext = context;
			return context;
		}
	}
}
