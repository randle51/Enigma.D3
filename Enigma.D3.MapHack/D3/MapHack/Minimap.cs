using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Diagnostics;
using System.Collections.ObjectModel;
using Enigma.Wpf;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows;
using Enigma.D3.Helpers;
using Enigma.D3.Enums;
using System.Windows.Media.Media3D;
using Enigma.D3.MapHack.Markers;

namespace Enigma.D3.MapHack
{
	internal class Minimap : NotifyingObject
	{
		private Canvas _window;
		private Canvas _root;
		private MinimapControl _minimapControl;
		private ObservableCollection<IMapMarker> _minimapItems;

		public Minimap(Canvas overlay)
		{
			_minimapItems = new ObservableCollection<IMapMarker>();

			_root = new Canvas() { Height = 1200.5d };
			_window = overlay;
			_window.Children.Add(_root);
			_window.SizeChanged += (s, e) => UpdateSizeAndPosition();

			_root.Children.Add(_minimapControl = new MinimapControl { DataContext = this });

			UpdateSizeAndPosition();
		}

		public ObservableCollection<IMapMarker> MinimapMarkers { get { return _minimapItems; } }

		private void UpdateSizeAndPosition()
		{
			var uiScale = _window.ActualHeight / 1200d;
			_root.Width = _window.ActualWidth / uiScale;
			_root.RenderTransform = new ScaleTransform(uiScale, uiScale, 0, 0);
		}

		private Dictionary<int, IMapMarker> _minimapItemsDic = new Dictionary<int, IMapMarker>();
		private int _lastFrame;
		private HashSet<int> _ignoredSnoIds = new HashSet<int>();
		private int _firstFreeAcd;
		private ActorCommonData _playerAcd;

		private LocalData _localData;
		private ObjectManager _objectManager;
		private byte[] _acdsBuffer = new byte[0];

		private bool _isLocalActorReady;

		public void Update(Engine engine)
		{
			try
			{
				if (!IsLocalActorValid(engine))
					return;

				if (!IsObjectManagerOnNewFrame(engine))
					return;

				var itemsToAdd = new List<IMapMarker>();

				var acds = ActorCommonData.Container;
				if (acds == null)
				{
					Trace.TraceError("ACDs == null");
				}
				else
				{
					var bufferSizePreDump = _acdsBuffer.Length;

					acds.TakeSnapshot();
					var dump = acds.GetBufferDump(ref _acdsBuffer);

					var bufferSizePostDump = _acdsBuffer.Length;
					if (bufferSizePostDump < bufferSizePreDump)
					{
						_minimapItems.Clear();
						_minimapItemsDic.Clear();
						_playerAcd = null;
						return;
					}

					// Must have a local ACD to base coords on.
					if (_playerAcd == null)
					{
						var playerAcdId = ActorCommonDataHelper.GetLocalAcd().x000_Id;

						foreach (var item in dump)
						{
							var acdId = BitConverter.ToInt32(_acdsBuffer, item.BufferOffset + 0x00);
							if (acdId == playerAcdId)
							{
								_playerAcd = item.Create();
							}
						}

						if (_playerAcd == null)
							return;
					}

					var firstFreeAcd = acds.x114_Free;
					if (firstFreeAcd != _firstFreeAcd)
					{
						foreach (var item in dump)
						{
							if (_minimapItemsDic.ContainsKey(item.Address))
								continue;
							var acd = item.Create();

							int acdId = acd.x000_Id;
							if (acdId == -1)
								continue;

							var actorSnoId = acd.x090_ActorSnoId;
							if (_ignoredSnoIds.Contains(actorSnoId))
								continue;

							if (!_minimapItemsDic.ContainsKey(acd.Address))
							{
								bool ignore;
								var minimapItem = MapMarkerFactory.Create(acd, out ignore);
								if (ignore)
								{
									_ignoredSnoIds.Add(actorSnoId);
								}
								else if (minimapItem != null)
								{
									_minimapItemsDic.Add(acd.Address, minimapItem);
									itemsToAdd.Add(minimapItem);
								}
							}
						}
					}

					_firstFreeAcd = firstFreeAcd;
					acds.FreeSnapshot();
				}

				UpdateUI(itemsToAdd);
			}
			catch (Exception exception)
			{
				OnUpdateException(exception);
			}
		}

		private bool IsLocalActorValid(Engine engine)
		{
			_localData = _localData ?? engine.LocalData;

			byte isNotInGame = (byte)_localData.x04_IsNotInGame;
			//byte isActorCreated = (byte)_localData.x00_IsActorCreated;
			if (isNotInGame == 0xCD) // structure is being updated, everything is cleared with 0xCD ('-')
			{
				if (!_isLocalActorReady)
					return false;
			}
			else
			{
				if (isNotInGame == 0)
				{
					if (!_isLocalActorReady)
					{
						_isLocalActorReady = true;
						OnLocalActorCreated();
					}
				}
				else
				{
					if (_isLocalActorReady)
					{
						_isLocalActorReady = false;
						OnLocalActorDisposed();
					}
					return false;
				}
			}
			return true;
		}

		private bool IsObjectManagerOnNewFrame(Engine engine)
		{
			_objectManager = _objectManager ?? engine.ObjectManager;

			// Don't do anything unless game updated frame.
			int currentFrame = _objectManager.x038_Counter_CurrentFrame;
			if (currentFrame == _lastFrame)
				return false;
			if (currentFrame < _lastFrame)
			{
				// Lesser frame than before = left game probably.
				_playerAcd = null;
				_lastFrame = currentFrame;
				return false;
			}
			_lastFrame = currentFrame;
			return true;
		}

		private void OnUpdateException(Exception exception)
		{
			Trace.WriteLine(exception.Message);
		}

		private void UpdateUI(List<IMapMarker> itemsToAdd)
		{
			var itemsToRemove = new List<IMapMarker>();
			foreach (var mapItem in _minimapItems.Concat(itemsToAdd))
			{
				if (!mapItem.Update(_playerAcd.x108_WorldId, new Point3D
				{
					X = _playerAcd.x0D0_WorldPosX,
					Y = _playerAcd.x0D4_WorldPosY,
					Z = _playerAcd.x0D8_WorldPosZ
				}))
				{
					itemsToRemove.Add(mapItem);
					_minimapItemsDic.Remove(mapItem.Id);
				}
			}

			if (itemsToAdd.Count > 0 || itemsToRemove.Count > 0)
			{
				if (itemsToAdd.Count > 0)
					Trace.WriteLine("Adding " + itemsToAdd.Count + " items...");
				if (itemsToRemove.Count > 0)
					Trace.WriteLine("Removing " + itemsToRemove.Count + " items...");

				Execute.OnUIThread(() =>
				{
					itemsToAdd.ForEach(a => _minimapItems.Add(a));
					itemsToRemove.ForEach(a => _minimapItems.Remove(a));
				});
			}
		}

		private void OnLocalActorCreated()
		{
			Trace.WriteLine("Local Actor Ready");
		}

		private void OnLocalActorDisposed()
		{
			Trace.WriteLine("Local Actor Not Ready");
			if (_minimapItemsDic.Count > 0)
				_minimapItemsDic.Clear();
			if (_minimapItems.Count > 0)
				Execute.OnUIThread(() => _minimapItems.Clear());
		}
	}
}
