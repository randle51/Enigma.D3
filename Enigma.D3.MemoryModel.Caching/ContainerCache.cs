using Enigma.D3.MemoryModel.Collections;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Caching
{
    /// <summary>
    /// Represents a snapshot of a container instance and tracks what items are added and removed
    /// between updates.
    /// </summary>
    /// <typeparam name="T">The type of elements in the container.</typeparam>
    public class ContainerCache<T> where T : MemoryObject
    {
        private readonly Container<T> _container;
        private byte[] _previousData = new byte[0];
        private byte[] _currentData = new byte[0];
        private MemorySegment[] _currentSegments;
        private MemorySegment[] _previousSegments;
        private int[] _previousMapping = new int[0];
        private int[] _currentMapping = new int[0];
        private T[] _items = new T[0];

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerCache{T}"/> class that provides
        /// cache and snapshot behaviour around a container instance.
        /// </summary>
        /// <param name="container">The container to provide cache and snapshot behaviour for.</param>
        /// <exception cref="ArgumentNullException">The <paramref name="container"/> parameter cannot be null.</exception>
        public ContainerCache(Container<T> container)
        {
            _container = container ?? throw new ArgumentNullException(nameof(container));
        }

        /// <summary>
        /// Gets the list of new items seen during last update. All items have snapshots taken
        /// using data captured during last update. This list is cleared at the start of each
        /// <see cref="Update"/> operation.
        /// </summary>
        public List<T> NewItems { get; } = new List<T>();

        /// <summary>
        /// Gets the list of items removed during last update. All items have snapshots taken
        /// using data capture during the update before last one. This list is cleared at the start
        /// of each <see cref="Update"/> operation.
        /// </summary>
        public List<T> OldItems { get; } = new List<T>();

        /// <summary>
        /// Gets the list of container items during last update. Length matches the capacity of the
        /// container. All items have snapshots taken using data captured during this update. Free
        /// slots contains the value NULL.
        /// </summary>
        public T[] Items => _items;

        /// <summary>
        /// Update the container buffer and item snapshots. Old (removed) items will be added to
        /// <see cref="OldItems"/> and new items to <see cref="NewItems"/>.
        /// </summary>
        public void Update()
        {
            _container.TakeSnapshot();

            _previousSegments = _currentSegments;

            if (_previousData.Length != _currentData.Length)
                Array.Resize(ref _previousData, _currentData.Length);
            Buffer.BlockCopy(_currentData, 0, _previousData, 0, _currentData.Length);

            _currentSegments = _container.GetAllocatedBytes(ref _currentData);
            if (_currentData.Length != _previousData.Length) // buffer was resized (and replaced), update underlying buffer for all items
            {
                for (int i = 0; i < _items.Length; i++)
                {
                    if (_items[i] == null)
                        continue;

                    _items[i].SetSnapshot(_currentData, i * _container.ItemSize, _container.ItemSize);
                }
            }

            if (_previousMapping.Length != _currentMapping.Length)
                Array.Resize(ref _previousMapping, _currentMapping.Length);
            Buffer.BlockCopy(_currentMapping, 0, _previousMapping, 0, _currentMapping.Length * sizeof(int));


            var count = _currentData.Length / _container.ItemSize;
            var mr = new BufferMemoryReader(_currentData);
            if (_currentMapping.Length != count)
                Array.Resize(ref _currentMapping, count);
            for (int i = 0; i <= _container.MaxIndex; i++)
                _currentMapping[i] = mr.Read<int>(i * _container.ItemSize);
            for (int i = _container.MaxIndex + 1; i < count; i++)
                _currentMapping[i] = -1;

            NewItems.Clear();
            OldItems.Clear();

            if (_items.Length != _container.Capacity)
                Array.Resize(ref _items, _container.Capacity);

            // Compare against previous where there is a value.
            for (int i = 0; i < Math.Min(_previousMapping.Length, _currentMapping.Length); i++)
            {
                if (_currentMapping[i] != _previousMapping[i])
                {
                    if (_previousMapping[i] != -1)
                    {
                        var item = CreatePreviousItem(i);
                        OnItemRemoved(i, item);
                        OldItems.Add(item);
                    }
                    if (_currentMapping[i] != -1 && _currentMapping[i] != 0) // NB: New item starts with ID 0
                    {
                        var item = CreateCurrentItem(i);
                        OnItemAdded(i, item);
                        NewItems.Add(item);
                    }
                }
            }

            // Check expanded area.
            for (int i = _previousMapping.Length; i < _currentMapping.Length; i++)
            {
                if (_currentMapping[i] != -1)
                {
                    var item = CreateCurrentItem(i);
                    OnItemAdded(i, item);
                    NewItems.Add(item);
                }
            }

            // Check reduced area.
            for (int i = _currentMapping.Length; i < _previousMapping.Length; i++)
            {
                if (_previousMapping[i] != -1)
                {
                    var item = CreatePreviousItem(i);
                    OnItemRemoved(i, item);
                    OldItems.Add(item);
                }
            }
        }

        private T CreatePreviousItem(int index)
        {
            var address = TranslateToMemoryAddress(_previousSegments, index * _container.ItemSize);
            var item = _container.Memory.Reader.Read<T>(address);
            item.SetSnapshot(_previousData, index * _container.ItemSize, _container.ItemSize);
            return item;
        }

        private T CreateCurrentItem(int index)
        {
            var address = TranslateToMemoryAddress(_currentSegments, index * _container.ItemSize);
            var item = _container.Memory.Reader.Read<T>(address);
            item.SetSnapshot(_currentData, index * _container.ItemSize, _container.ItemSize);
            return item;
        }

        private static MemoryAddress TranslateToMemoryAddress(MemorySegment[] segments, int offset)
        {
            var i = 0;
            var segment = segments[i];
            var skipped = 0;
            while (offset > (int)segment.Size)
            {
                offset -= (int)segment.Size;
                skipped += (int)segment.Size;
                segment = segments[i + 1];
            }
            return segment.Address + skipped + offset;
        }

        private void OnItemRemoved(int index, T item)
        {
            if (index < _items.Length) // Could be part of the shrink area.
                _items[index] = default(T);
        }

        private void OnItemAdded(int index, T item)
        {
            _items[index] = item;
        }
    }
}
