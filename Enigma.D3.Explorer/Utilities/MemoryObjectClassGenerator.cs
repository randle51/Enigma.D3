using Enigma.D3.Collections;
using Enigma.D3.Helpers;
using Enigma.D3.Memory;
using Enigma.D3.UI;
using Enigma.Memory;
using Enigma.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Enigma.D3.Explorer.Utilities
{
	internal static class MemoryObjectClassGenerator
	{
		public static void GenerateClass(MemoryObject obj)
		{
			var cts = new CancellationTokenSource();
			var ct = cts.Token;

			var dialog = new MemoryObjectClassGeneratorDialog();
			dialog.HeaderText = "Generating class...";
			dialog.StatusText = "";
			dialog.ProgressPercentage = 0;
			dialog.Closed += (s, e) =>
				cts.Cancel();

			var task = new Task<StringBuilder>(() =>
			{
				var type = obj.GetType();
				var size = type.SizeOf();
				string hexFormat = "X" + Math.Max(2, size.ToString("X").Length);
				var sb = new StringBuilder();
				sb.AppendLine(string.Format("public class {0} : MemoryObject", type.Name));
				sb.AppendLine("{");

				int offset = 0;
				while (offset < size && !ct.IsCancellationRequested)
				{
					Execute.OnUIThreadAsync(() =>
					{
						dialog.ProgressPercentage = 100d * offset / size;
						dialog.StatusText = string.Format("Scanning {0} / {1}", offset, size);
					});

					var ctx = new TypeMatchContext(obj, offset);
					if (false ||
						ctx.TryAsList() ||
						ctx.TryAsAllocator() ||
						ctx.TryAsBasicAllocator() ||
						ctx.TryAsMap() ||
						ctx.TryAsVector() ||
						ctx.TryAsZeroInt32() || // Anything that might be valid if first 4 bytes are zero must be above this check!
						ctx.TryAsUIReference() ||
						ctx.TryAsSno() ||
						ctx.TryAsRefString() ||
						ctx.TryAsText() ||
						ctx.TryAsFloat() ||
						ctx.TryAsPointer() ||
						false)
					{
						if (ctx.Name == null)
							ctx.Name = ctx.FieldType;
					}
					else
					{
						ctx.Prefix = "_";
						ctx.FieldType = "int";
						ctx.Name = "";
						ctx.FieldSize = sizeof(int);
						ctx.Comment = ctx.Read<int>(0x00).ToString();
					}

					string line = string.Format("\t/* 0x{5:X8} */ public {0} {1}x{2}{3} {{ get {{ return Read<{0}>(0x{2}); }} }}{4}",
						ctx.FieldType,
						ctx.Prefix,
						ctx.Offset.ToString(hexFormat),
						ctx.Name == string.Empty ? string.Empty : ("_" + ctx.Name + ctx.Postfix),
						string.IsNullOrEmpty(ctx.Comment) ? string.Empty : " // " + ctx.Comment,
						ctx.MemoryObject.Address + ctx.Offset);
					sb.AppendLine(line);

					offset += ctx.FieldSize;
				}
				sb.AppendLine("}");
				return sb;
			}, ct);
			task.ContinueWith(t =>
			{
				var sb = t.Result;
				Execute.OnUIThread(() =>
				{
					dialog.Close();
					var menu = new ContextMenu();
					var item = new MenuItem { Header = "Copy to clipboard" };
					item.Click += (s, e) => Clipboard.SetText(sb.ToString());
					menu.Items.Add(item);
					new Window()
					{
						Content = new ScrollViewer
						{
							Content = new TextBox
							{
								IsReadOnly = true,
								Text = sb.ToString(),
								FontFamily = new FontFamily("Consolas"),
								ContextMenu = menu
							}
						}
					}.ShowDialog();
				});
			});
			task.Start();
			dialog.ShowDialog();
		}

		private class TypeMatchContext
		{
			public TypeMatchContext(MemoryObject obj, int offset)
			{
				MemoryObject = obj;
				Size = obj.GetType().SizeOf();
				Offset = offset;
			}

			public readonly MemoryObject MemoryObject;
			public readonly int Size;
			public readonly int Offset;
			public int FieldSize = 4;
			public string Name;
			public string FieldType = "int";
			public string Postfix;
			public string Prefix;
			public string Comment;
			public int FieldAddress { get { return MemoryObject.Address + Offset; } }
			public string HexFormat { get { return "X" + Math.Max(2, Size.ToString("X").Length); } }

			private bool CanContain(int numberOfBytes)
			{
				return Offset + numberOfBytes <= Size;
			}

			private int GetFieldAddress(MemoryAddress address)
			{
				return address - MemoryObject.Address;
			}

			private bool IsFieldAddress(MemoryAddress address)
			{
				return MemoryObject.Address <= address && address <= MemoryObject.Address + Size;
			}

			private string SafeTypeName(Type type)
			{
				if (!type.IsGenericType)
					return type.Name;

				return type.Name.Split('`')[0] + "<" + string.Join(", ",
					type.GenericTypeArguments.Select(a => SafeTypeName(a)).ToArray()) + ">";
			}

			public void SetType(Type type)
			{
				FieldType = SafeTypeName(type);
				FieldSize = type.SizeOf();
				if (FieldSize == 0)
				{
					if (type.IsSubclassOf(typeof(Ptr)) || type.Equals(typeof(Ptr)))
						FieldSize = MemoryObject.Memory.Reader.PointerSize;
					else FieldSize = 4;
				}
				if (Name == null)
					Name = type.IsPrimitive ? "" : FieldType;
			}

			public TRead Read<TRead>(int offset)
			{
				return MemoryObject.Memory.Reader.Read<TRead>(MemoryObject.Address + Offset + offset);
			}

			public TRead ReadAbsolute<TRead>(int address)
			{
				return MemoryObject.Memory.Reader.Read<TRead>(address);
			}

			public bool TryAsAllocator()
			{
				Allocator allocator;
				if (CanContain(Allocator.SizeOf))
				{
					var magic = Read<int>(0x18);
					if (magic == 0x600DF00D || unchecked(magic == (int)0xFEEDFACE))
					{
						var flags = Read<int>(0x10);
						if ((flags & 0x20200) == 0x20200)
						{
							allocator = Read<Allocator>(0x00);
							SetType(typeof(Allocator));
							Name = FieldType + "_" + allocator.x04_Limit + "x" + allocator.x00_ElementSize + "Bytes";
							return true;
						}
					}
				}
				try
				{
					allocator = Read<Ptr<Allocator>>(0x00).Dereference();
					if (allocator != null)
					{
						if ((allocator.x18_GoodFood == 0x600DF00D ||
							allocator.x18_GoodFood == unchecked((int)0xFEEDFACE)) && (allocator.x10_Flags & 0x20200) == 0x20200)
						{
							SetType(typeof(Ptr<Allocator>));
							Name = "Ptr_" + typeof(Allocator).Name + "_" + allocator.x04_Limit + "x" + allocator.x00_ElementSize + "Bytes";
							if (IsFieldAddress(allocator.Address))
								Comment = "(Field x" + GetFieldAddress(allocator.Address).ToString(HexFormat) + ")";
							return true;
						}
					}
				}
				catch { }

				return false;
			}

			public bool TryAsBasicAllocator()
			{
				if (CanContain(BasicAllocator.SizeOf))
				{
					var magic = Read<int>(0x18);
					if (magic == 0x600DF00D || unchecked(magic == (int)0xFEEDFACE))
					{
						var flags = Read<int>(0x0C);
						if ((flags & 0x20200) == 0x20200)
						{
							var basicAllocator = Read<BasicAllocator>(0x00);
							FieldType = typeof(BasicAllocator).Name;
							Name = FieldType + "_" + basicAllocator.x08_Size + "Bytes";
							FieldSize = BasicAllocator.SizeOf;
							Comment = basicAllocator.ToString();
							return true;
						}
					}
				}
				try
				{
					var basicAllocator = Read<Ptr<BasicAllocator>>(0x00).Dereference();
					if (basicAllocator != null &&
						(basicAllocator.x18_GoodFood == 0x600DF00D ||
						basicAllocator.x18_GoodFood == unchecked((int)0xFEEDFACE)) &&
						(basicAllocator.x0C_Flags & 0x20200) == 0x20200)
					{
						SetType(typeof(Ptr<BasicAllocator>));
						Name = "Ptr_" + typeof(BasicAllocator).Name + "_" + basicAllocator.x08_Size + "Bytes";
						Comment = basicAllocator.ToString();
						return true;
					}
				}
				catch { }
				return false;
			}

			public bool TryAsMap()
			{
				if (CanContain(Map.SizeOf))
				{
					var ptrBucketAllocator = Read<int>(0x08);
					if (ptrBucketAllocator == FieldAddress + 0x48)
					{
						var map = Read<Map>(0x00);
						SetType(typeof(Map));
						Comment = "{ count = " + map.x04_Count + ", entrySize = " + map.x48_EntryAllocator.x00_ElementSize + " }";
						return true;
					}
				}
				try
				{
					var map = Read<Ptr<Map>>(0x00).Dereference();
					if (map != null &&
						map.x10_Buckets.Address == map.Address + 0x48)
					{
						SetType(typeof(Ptr<Map>));
						Name = "Ptr_" + typeof(Map).Name;
						Comment = "{ count = " + map.x04_Count + ", entrySize = " + map.x48_EntryAllocator.x00_ElementSize + " }";
						return true;
					}
				}
				catch { }
				return false;
			}

			public bool TryAsVector()
			{
				if (CanContain(Enigma.D3.Collections.Vector.SizeOf))
				{
					var ptrAllocation = Read<int>(0x00);
					var ptrAllocatorAllocation = Read<int>(0x10);
					if (ptrAllocation != 0 && ptrAllocation == ptrAllocatorAllocation)
					{
						var flags = Read<int>(0x1C);
						var magic = Read<int>(0x28);
						var one = Read<int>(0x30);

						if ((flags & 0x20200) == 0x20200 &&
							(magic == 0x600DF00D || unchecked(magic == (int)0xFEEDFACE)) &&
							(one == 1 || one == 0))
						{
							var vector = Read<Enigma.D3.Collections.Vector>(0x00);
							SetType(typeof(Enigma.D3.Collections.Vector));
							Comment = vector.ToString();
							return true;
						}
					}
				}
				try
				{
					var array = Read<Ptr<Enigma.D3.Collections.Vector>>(0x00).Dereference();
					if ((array.x30 == 1 || array.x30 == 0) &&
						array.x10_Allocator.x18_GoodFood == 0x600DF00D &&
						array.x10_Allocator.x00_Allocation.ValueAddress ==
						array.x00_Data.ValueAddress)
					{
						SetType(typeof(Ptr<Enigma.D3.Collections.Vector>));
						Name = "Ptr_" + typeof(Enigma.D3.Collections.Vector).Name;
						Comment = array.ToString();
						return true;
					}
				}
				catch { }
				return false;
			}

			public bool TryAsList()
			{
				if (CanContain(ListPack.SizeOf))
				{
					var ptrFirst = Read<int>(0x00);
					var ptrLast = Read<int>(0x04);
					var count = Read<int>(0x08);
					var ptrNodeAllocator = Read<int>(0x0C);
					var flag = Read<int>(0x2C);

					bool couldBeList = ptrNodeAllocator == FieldAddress + 0x10 && (flag == 1 || flag == 0);
					if (couldBeList)
					{
						var nodeAllocator = ReadAbsolute<Allocator>(ptrNodeAllocator);
						var itemSize = nodeAllocator.x00_ElementSize - 8;
						bool isList = false;
						if (count == 0 && ptrFirst == 0 && ptrLast == 0)
						{ // Empty list
							isList = true;
						}
						else if (count == 1 && ptrFirst != 0 && ptrLast == ptrFirst)
						{ // Single item list
							try
							{
								var ptrFirstPrev = ReadAbsolute<int>(ptrFirst + itemSize + 0x00);
								var ptrFirstNext = ReadAbsolute<int>(ptrFirst + itemSize + 0x04);
								var ptrLastPrev = ReadAbsolute<int>(ptrLast + itemSize + 0x00);
								var ptrLastNext = ReadAbsolute<int>(ptrLast + itemSize + 0x04);
								isList = ptrFirstPrev == 0 && ptrFirstNext == 0;
								isList &= ptrLastPrev == 0 && ptrLastNext == 0;
							}
							catch { }
						}
						else if (count >= 2 && ptrFirst != 0 && ptrLast != 0)
						{ // Multiple items list
							try
							{
								var ptrFirstPrev = ReadAbsolute<int>(ptrFirst + itemSize + 0x00);
								var ptrFirstNext = ReadAbsolute<int>(ptrFirst + itemSize + 0x04);
								var ptrLastPrev = ReadAbsolute<int>(ptrLast + itemSize + 0x00);
								var ptrLastNext = ReadAbsolute<int>(ptrLast + itemSize + 0x04);
								isList = ptrFirstPrev == 0 && ptrFirstNext != 0;
								isList &= ptrLastPrev != 0 && ptrLastNext == 0;
							}
							catch { }
						}

						if (isList)
						{
							var listPack = Read<ListPack>(0x00);
							SetType(typeof(ListPack));
							Name += "_ItemSize" + itemSize;
							Comment = listPack.ToString();
							return true;
						}
					}
				}
				return false;
			}

			public bool TryAsUIReference()
			{
				if (CanContain(UIReference.SizeOf))
				{
					var uiRef = Read<UIReference>(0x00);
					if (((int)uiRef.x000_Hash == -1 && (int)(uiRef.x000_Hash >> 32) == -1 && uiRef.x008_Name == "None") ||
						HashUtils.Fnv64(Encoding.ASCII.GetBytes(uiRef.x008_Name.ToLower())) == uiRef.x000_Hash)
					{
						FieldType = typeof(UIReference).Name;
						Name = "UIRef";
						Comment = uiRef.x008_Name;
						FieldSize = UIReference.SizeOf;
						return true;
					}
				}
				return false;
			}

			public bool TryAsRefString()
			{
				const int PtrEmptyRefStringData = 0x01A9F788;
				const int PtrEmptyRefStringText = 0x01A9F7A4;

				if (CanContain(RefString.SizeOf))
				{
					try
					{
						var refString = Read<RefString>(0x00);
						var text = "";
						if (refString.x08_Bool == 1)
						{
							if (refString.x00_Data.x04_Length < 0)
								return false;
							text = refString.x00_Data.x14_Text;
						}
						else if (refString.x08_Bool == 0)
						{
							text = refString.x04_PtrText;
						}
						else
						{
							return false;
						}

						bool isEmptyRefString =
							Read<int>(0x00) == PtrEmptyRefStringData ||
							Read<int>(0x04) == PtrEmptyRefStringText;

						if (isEmptyRefString ||
							(text != null && text.Length > 3 && text.Select(a => (byte)a).All(a => 32 <= a && a <= 126)))
						{
							SetType(typeof(RefString));
							Name = "RefString";
							Comment = text;
							return true;
						}
					}
					catch { }
				}
				return false;
			}

			public bool TryAsText()
			{
				var buffer = MemoryObject.Memory.Reader.ReadBytes(MemoryObject.Address + Offset, 4);
				for (int i = 0; i < 4; i++)
				{
					if (!(i > 1 && buffer[i] == 0) && (buffer[i] < 32 || buffer[i] > 126))
						return false;
				}
				FieldType = "string";
				Name = "Text";
				FieldSize = 4;
				Comment = Encoding.ASCII.GetString(buffer, 0, 4).Split('\0')[0];
				return true;
			}

			public bool TryAsPointer()
			{
				var pointer = Read<Ptr>(0x00);
				if (!pointer.IsInvalid)
				{
					FieldType = typeof(Enigma.Memory.Ptr).Name;
					Name = "Ptr";
					Postfix = "_";
					Comment = "0x" + pointer.ValueAddress.ToString("X8");
					if (IsFieldAddress(pointer.ValueAddress))
					{
						Comment += " (Field x" + GetFieldAddress(pointer.ValueAddress).ToString(HexFormat) + ")";
					}
					return true;
				}
				return false;
			}

			public bool TryAsFloat()
			{
				int int32 = Read<int>(0x00);
				if (int32 == 0)
					return false; // No idea if it's an int or float..

				float value = Read<float>(0x00);
				if (!float.IsNaN(value) && !value.ToString().Contains("E"))
				{
					FieldType = "float";
					Comment = value.ToString();
					return true;
				}
				return false;
			}

			public bool TryAsSno()
			{
				return false;
				//int value = Read<int>(0x00);
				//if (App.SnoDiskEntries.ContainsKey(value))
				//{
				//	var entry = App.SnoDiskEntries[value];
				//	Name = entry.Type.ToString() + "SnoId";
				//	Comment = value + " (" + entry.Type + ": " + entry.Name + ")";
				//	return true;
				//}
				//return false;
			}

			public bool TryAsZeroInt32()
			{
				var value = Read<int>(0x00);
				if (value == 0)
				{
					Prefix = "_";
					FieldType = "int";
					Name = "";
					FieldSize = sizeof(int);
					Comment = value.ToString();
					return true;
				}
				return false;
			}
		}
	}
}
