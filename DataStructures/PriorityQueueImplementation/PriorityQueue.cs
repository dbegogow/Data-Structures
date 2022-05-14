namespace PriorityQueueImplementation
{
    public class PriorityQueue<T> : IPriorityQueue<T> where T : IComparable<T>
    {
        private readonly List<T> _items;

        public PriorityQueue()
        {
            this._items = new List<T>();
        }

        public int Size => this._items.Count;

        public T Dequeue()
        {
            var firstElement = this.Peek();
            this.SwapElements(0, this.Size - 1);
            this._items.RemoveAt(this.Size - 1);

            this.HeapifyDown();

            return firstElement;
        }

        public void Insert(T item)
        {
            this._items.Add(item);
            this.HeapifyUp();
        }

        public T Peek()
        {
            this.EnsureNotEmpty();
            return this._items[0];
        }

        private void HeapifyUp()
        {
            var currentIndex = this.Size - 1;
            var parentIndex = this.GetParentIndex(currentIndex);

            while (currentIndex > 0 && this.IsGreater(currentIndex, parentIndex))
            {
                this.SwapElements(currentIndex, parentIndex);
                currentIndex = parentIndex;
                parentIndex = this.GetParentIndex(currentIndex);
            }
        }

        private void HeapifyDown()
        {
            var parentIndex = 0;
            var leftChildIndex = this.GetLeftChildIndex(parentIndex);

            while (this.IsValidIndex(leftChildIndex) && this.IsLesser(parentIndex, leftChildIndex))
            {
                var toSwapWith = leftChildIndex;
                var rightChildIndex = this.GetRightChildIndex(parentIndex);

                if (this.IsValidIndex(rightChildIndex) && this.IsLesser(toSwapWith, rightChildIndex))
                {
                    toSwapWith = rightChildIndex;
                }

                this.SwapElements(toSwapWith, parentIndex);
                parentIndex = toSwapWith;
                leftChildIndex = this.GetLeftChildIndex(parentIndex);
            }
        }

        private int GetParentIndex(int childIndex)
            => (childIndex - 1) / 2;

        private int GetLeftChildIndex(int parentIndex)
            => 2 * parentIndex + 1;

        private int GetRightChildIndex(int parentIndex)
            => 2 * parentIndex + 2;

        private bool IsGreater(int currentIndex, int parentIndex)
            => this._items[currentIndex]
                .CompareTo(this._items[parentIndex]) > 0;

        private bool IsLesser(int parentIndex, int childIndex)
           => this._items[parentIndex]
               .CompareTo(this._items[childIndex]) < 0;

        private void SwapElements(int firstIndex, int secondIndex)
        {
            var prop = this._items[firstIndex];
            this._items[firstIndex] = this._items[secondIndex];
            this._items[secondIndex] = prop;
        }

        private bool IsValidIndex(int index)
            => index < this.Size;

        private void EnsureNotEmpty()
        {
            if (this.Size == 0)
            {
                throw new InvalidOperationException("Empty priority queue");
            }
        }
    }
}
