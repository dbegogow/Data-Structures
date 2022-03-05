using System.Collections.Generic;

namespace TreeImplementation
{
    public class Tree<T> : ITree<T>
    {
        private readonly List<Tree<T>> _children;

        public Tree(T value)
        {
            this.Value = value;
            this.Parent = null;
            this._children = new List<Tree<T>>();
        }

        public Tree(T value, params Tree<T>[] children)
            : this(value)
        {
            foreach (var child in children)
            {
                child.Parent = this;
                this._children.Add(child);
            }
        }

        public T Value { get; }

        public Tree<T> Parent { get; private set; }

        public IReadOnlyCollection<Tree<T>> Children
            => this._children.AsReadOnly();

        public ICollection<T> OrderBfs()
        {
            throw new System.NotImplementedException();
        }

        public ICollection<T> OrderDfs()
        {
            throw new System.NotImplementedException();
        }

        public void AddChild(T parentKey, Tree<T> child)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveNode(T nodeKey)
        {
            throw new System.NotImplementedException();
        }

        public void Swap(T firstKey, T secondKey)
        {
            throw new System.NotImplementedException();
        }
    }
}
