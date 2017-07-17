using Enigma.D3.MemoryModel.Collections;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.Caching
{
    public class ContainerCache<T> where T : MemoryObject
    {
        public int State = 0;
        public Container<T> Container;
        public byte[] CurrentData = new byte[0];
        public int[] CurrentMapping = new int[0];
        public MemorySegment[] CurrentSegments;
        public byte[] PreviousData = new byte[0];
        public int[] PreviousMapping = new int[0];
        public MemorySegment[] PreviousSegments;
        public readonly List<T> NewItems = new List<T>();
        public readonly List<T> OldItems = new List<T>();
        public T[] Items = new T[0];

        public ContainerCache(Container<T> container)
        {
            Container = container ?? throw new ArgumentNullException(nameof(container));
        }

        public event Action<int, T> ItemRemoved;
        public event Action<int, T> ItemAdded;

        public void Update()
        {
            Container.TakeSnapshot();

            PreviousSegments = CurrentSegments;

            if (PreviousData.Length != CurrentData.Length)
                Array.Resize(ref PreviousData, CurrentData.Length);
            Buffer.BlockCopy(CurrentData, 0, PreviousData, 0, CurrentData.Length);

            CurrentSegments = Container.GetAllocatedBytes(ref CurrentData);
            if (CurrentData.Length != PreviousData.Length) // buffer was resized (and replaced), update underlying buffer for all items
            {
                for (int i = 0; i < Items.Length; i++)
                {
                    if (Items[i] == null)
                        continue;

                    Items[i].SetSnapshot(CurrentData, i * Container.ItemSize, Container.ItemSize);
                }
            }

            if (PreviousMapping.Length != CurrentMapping.Length)
                Array.Resize(ref PreviousMapping, CurrentMapping.Length);
            Buffer.BlockCopy(CurrentMapping, 0, PreviousMapping, 0, CurrentMapping.Length * sizeof(int));


            var count = CurrentData.Length / Container.ItemSize;
            var mr = new BufferMemoryReader(CurrentData);
            if (CurrentMapping.Length != count)
                Array.Resize(ref CurrentMapping, count);
            for (int i = 0; i <= Container.MaxIndex; i++)
                CurrentMapping[i] = mr.Read<int>(i * Container.ItemSize);
            for (int i = Container.MaxIndex + 1; i < count; i++)
                CurrentMapping[i] = -1;

            NewItems.Clear();
            OldItems.Clear();

            if (Items.Length != Container.Capacity)
                Array.Resize(ref Items, Container.Capacity);

            // Compare against previous where there is a value.
            for (int i = 0; i < Math.Min(PreviousMapping.Length, CurrentMapping.Length); i++)
            {
                if (CurrentMapping[i] != PreviousMapping[i])
                {
                    if (PreviousMapping[i] != -1)
                    {
                        var address = TranslateToMemoryAddress(PreviousSegments, i * Container.ItemSize);
                        var item = Container.Memory.Reader.Read<T>(address);
                        item.SetSnapshot(PreviousData, i * Container.ItemSize, Container.ItemSize);

                        //var item = MemoryObjectFactory.UnsafeCreate<T>(new BufferMemoryReader(PreviousData, 0, PreviousData.Length, Container.Memory.Reader.PointerSize), i * Container.ItemSize);

                        OnItemRemoved(i, item);
                        OldItems.Add(item);
                    }
                    if (CurrentMapping[i] != -1 && CurrentMapping[i] != 0) // NB: New item starts with ID 0
                    {
                        var address = TranslateToMemoryAddress(CurrentSegments, i * Container.ItemSize);
                        var item = Container.Memory.Reader.Read<T>(address);
                        item.SetSnapshot(CurrentData, i * Container.ItemSize, Container.ItemSize);

                        //var item = MemoryObjectFactory.UnsafeCreate<T>(new BufferMemoryReader(CurrentData, 0, CurrentData.Length, Container.Memory.Reader.PointerSize), i * Container.ItemSize);

                        OnItemAdded(i, item);
                        NewItems.Add(item);
                    }
                }
            }

            // Check expanded area.
            for (int i = PreviousMapping.Length; i < CurrentMapping.Length; i++)
            {
                if (CurrentMapping[i] != -1)
                {
                    var address = TranslateToMemoryAddress(CurrentSegments, i * Container.ItemSize);
                    var item = Container.Memory.Reader.Read<T>(address);
                    item.SetSnapshot(CurrentData, i * Container.ItemSize, Container.ItemSize);

                    //var item = MemoryObjectFactory.UnsafeCreate<T>(new BufferMemoryReader(CurrentData, 0, CurrentData.Length, Container.Memory.Reader.PointerSize), i * Container.ItemSize);

                    OnItemAdded(i, item);
                    NewItems.Add(item);
                }
            }

            // Check reduced area.
            for (int i = CurrentMapping.Length; i < PreviousMapping.Length; i++)
            {
                if (PreviousMapping[i] != -1)
                {
                    var address = TranslateToMemoryAddress(PreviousSegments, i * Container.ItemSize);
                    var item = Container.Memory.Reader.Read<T>(address);
                    item.SetSnapshot(PreviousData, i * Container.ItemSize, Container.ItemSize);

                    //var item = MemoryObjectFactory.UnsafeCreate<T>(new BufferMemoryReader(PreviousData, 0, PreviousData.Length, Container.Memory.Reader.PointerSize), i * Container.ItemSize);

                    OnItemRemoved(i, item);
                    OldItems.Add(item);
                }
            }
        }

        private MemoryAddress TranslateToMemoryAddress(MemorySegment[] segments, int offset)
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
            if (index < Items.Length) // Could be part of the shrink area.
                Items[index] = default(T);
            ItemRemoved?.Invoke(index, item);
        }

        private void OnItemAdded(int index, T item)
        {
            Items[index] = item;
            ItemAdded?.Invoke(index, item);
        }
    }
}
