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
using Enigma.D3.Enums;
using System.Windows.Media.Media3D;
using Enigma.D3.MapHack.Markers;
using Enigma.D3.MemoryModel;
using Enigma.D3.MemoryModel.Core;
using Enigma.D3.ApplicationModel;
using Enigma.Memory;

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
        private ACD _playerAcd;

        private LocalData _localData;
        private ObjectManager _objectManager;
        private ContainerObserver<ACD> _acdsObserver;

        private bool _isLocalActorReady;

        public void Update(MemoryContext ctx)
        {
            try
            {
                if (!IsLocalActorValid(ctx))
                    return;

                if (!IsObjectManagerOnNewFrame(ctx))
                    return;

                var itemsToAdd = new List<IMapMarker>();

                _acdsObserver = _acdsObserver ?? new ContainerObserver<ACD>(ctx.DataSegment.ObjectManager.ACDManager.ActorCommonData);
                _acdsObserver.Update();

                var monsters = _acdsObserver.NewItems.Where(x => x.ActorType == ActorType.Monster).ToArray();

                // TODO
                //if (isNewgame)
                //{
                //    _minimapItems.Clear();
                //    _minimapItemsDic.Clear();
                //    _playerAcd = null;
                //    return;
                //}

                // Must have a local ACD to base coords on.
                if (_playerAcd == null)
                {
                    var playerAcdId = ctx.DataSegment.ObjectManager.PlayerDataManager[
                        ctx.DataSegment.ObjectManager.Player.LocalPlayerIndex].ACDID;

                    var index = Array.IndexOf(_acdsObserver.CurrentMapping, playerAcdId);
                    if (index != -1)
                        _playerAcd = MemoryObjectFactory.UnsafeCreate<ACD>(new BufferMemoryReader(_acdsObserver.CurrentData), index * _acdsObserver.Container.ItemSize);
                    
                    if (_playerAcd == null)
                        return;
                }

                foreach (var acd in _acdsObserver.NewItems)
                {
                    var actorSnoId = acd.ActorSNO;
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

                UpdateUI(itemsToAdd);
            }
            catch (Exception exception)
            {
                OnUpdateException(exception);
            }
        }

        private bool IsLocalActorValid(MemoryContext ctx)
        {
            _localData = _localData ?? ctx.DataSegment.LocalData;
            _localData.TakeSnapshot();

            if (_localData.Read<byte>(0) == 0xCD) // structure is being updated, everything is cleared with 0xCD ('-')
            {
                if (!_isLocalActorReady)
                    return false;
            }
            else
            {
                if (!_localData.IsStartUpGame)
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

        private bool IsObjectManagerOnNewFrame(MemoryContext ctx)
        {
            _objectManager = _objectManager ?? ctx.DataSegment.ObjectManager;

            // Don't do anything unless game updated frame.
            int currentFrame = _objectManager.RenderTick;
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
                if (!mapItem.Update(_playerAcd.WorldSNO, new Point3D
                {
                    X = _playerAcd.Position.X,
                    Y = _playerAcd.Position.Y,
                    Z = _playerAcd.Position.Z
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
            _acdsObserver = null;
        }
    }
}
