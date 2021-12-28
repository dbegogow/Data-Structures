using System;
using System.Collections;
using System.Collections.Generic;

namespace ListImplementation
{
    public class List<T> : IList<T>
    {
        private const int DefaultCapacity = 4;

        private T[] _items;

        public List()
            => this._items = new T[DefaultCapacity];

        public List(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            this._items = new T[capacity];
        }

        public List(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException();
            }

            if (collection is ICollection<T> collectionAsICollection)
            {
                var count = collectionAsICollection.Count;

                if (count == 0)
                {
                    this._items = new T[0];
                }
                else
                {
                    this._items = new T[count];
                    this.Count = count;
                    collectionAsICollection.CopyTo(this._items, 0);
                }
            }
            else
            {
                this.Count = 0;

                using IEnumerator<T> collectionEnumerator = collection.GetEnumerator();

                while (collectionEnumerator.MoveNext())
                {
                    this.Add(collectionEnumerator.Current);
                }
            }
        }

        public int Count { get; private set; }

        public bool IsReadOnly
            => false;

        public T this[int index]
        {
            get
            {
                if (!this.IsValidIndex(index))
                {
                    throw new IndexOutOfRangeException();
                }

                return this._items[index];
            }
            set
            {
                if (!this.IsValidIndex(index))
                {
                    throw new IndexOutOfRangeException();
                }

                this._items[index] = value;
            }
        }

        public bool Contains(T item)
        {
            if (item == null)
            {
                return false;
            }

            for (int i = 0; i < this.Count; i++)
            {
                var currentItem = this._items[i];

                if (currentItem.Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                var currentItem = this._items[i];

                if (currentItem.Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Add(T item)
        {
            if (this._items.Length == this.Count)
            {
                this.ResizeItemsArr();
            }

            this._items[this.Count] = item;

            this.Count++;
        }

        public void Insert(int index, T item)
        {
            if (!this.IsValidIndex(index))
            {
                throw new IndexOutOfRangeException();
            }

            if (this._items.Length == this.Count)
            {
                this.ResizeItemsArr();
            }

            for (int i = this.Count; i > index; i--)
            {
                this._items[i] = this._items[i - 1];
            }

            this._items[index] = item;
            this.Count++;
        }

        public bool Remove(T item)
        {
            var index = this.IndexOf(item);

            if (index == -1)
            {
                return false;
            }

            this.RemoveAt(index);

            return true;
        }

        public void RemoveAt(int index)
        {
            if (!this.IsValidIndex(index))
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i < this.Count - 1; i++)
            {
                this._items[i] = this._items[i + 1];
            }

            this.Count--;
        }

        public void Clear()
        {
            this._items = new T[DefaultCapacity];
            this.Count = 0;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Array.Copy(this._items, array, this.Count);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                var currentItem = this._items[i];
                yield return currentItem;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private bool IsValidIndex(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                return false;
            }

            return true;
        }

        private void ResizeItemsArr()
        {
            var newItemsArr = new T[this.Count * 2];
            this._items.CopyTo(newItemsArr, 0);
            this._items = newItemsArr;
        }
    }
}
