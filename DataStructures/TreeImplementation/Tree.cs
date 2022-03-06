using System;
using System.Linq;
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

        public T Value { get; private set; }

        public Tree<T> Parent { get; private set; }

        public IReadOnlyCollection<Tree<T>> Children
            => this._children.AsReadOnly();

        public ICollection<T> OrderBfs()
        {
            var result = new List<T>();
            var queue = new Queue<Tree<T>>();

            queue.Enqueue(this);

            while (queue.Count > 0)
            {
                var subtree = queue.Dequeue();
                result.Add(subtree.Value);

                foreach (var child in subtree.Children)
                {
                    queue.Enqueue(child);
                }
            }

            return result;
        }

        public ICollection<T> OrderDfs()
        {
            var result = new List<T>();

            this.Dfs(this, result);
            return result;
        }

        public void AddChild(T parentKey, Tree<T> child)
        {
            var parentSubtree = this.FindBfs(parentKey);
            this.CheckEmptyNode(parentSubtree);
            parentSubtree._children.Add(child);
        }

        public void RemoveNode(T nodeKey)
        {
            var removedNode = this.FindBfs(nodeKey);
            this.CheckEmptyNode(removedNode);

            var parentRemovedNode = removedNode.Parent;

            if (parentRemovedNode == null)
            {
                this.Value = default;
                this._children.Clear();
                return;
            }

            var parentRemovedNodeChildren = parentRemovedNode._children;
            parentRemovedNodeChildren.Remove(removedNode);
        }

        public void Swap(T firstKey, T secondKey)
        {
            var firstNode = this.FindBfs(firstKey);
            var secondNode = this.FindBfs(secondKey);

            if (firstNode == null || secondNode == null)
            {
                throw new ArgumentException();
            }

            var firstNodeParent = firstNode.Parent;
            var firstNodeChildren = firstNode.Children.ToList();

            var secondNodeParent = secondNode.Parent;
            var secondNodeChildren = secondNode.Children.ToList();


            ChangeNode(secondKey, firstNode, secondNodeParent, secondNodeChildren);
            ChangeNode(firstKey, secondNode, firstNodeParent, firstNodeChildren);
        }

        private void Dfs(Tree<T> subtree, List<T> result)
        {
            foreach (var child in subtree.Children)
            {
                this.Dfs(child, result);
            }

            result.Add(subtree.Value);
        }

        private Tree<T> FindBfs(T value)
        {
            var queue = new Queue<Tree<T>>();

            queue.Enqueue(this);

            while (queue.Count > 0)
            {
                var subtree = queue.Dequeue();

                if (subtree.Value.Equals(value))
                {
                    return subtree;
                }

                foreach (var child in subtree.Children)
                {
                    queue.Enqueue(child);
                }
            }

            return null;
        }

        private Tree<T> FindDfs(T value, Tree<T> subtree)
        {
            foreach (var child in subtree.Children)
            {
                var current = this.FindDfs(value, child);

                if (current != null && current.Value.Equals(value))
                {
                    return current;
                }
            }

            if (subtree.Value.Equals(value))
            {
                return subtree;
            }

            return null;
        }

        private static void ChangeNode(T secondKey, Tree<T> firstNode, Tree<T> secondNodeParent, List<Tree<T>> secondNodeChildren)
        {
            firstNode.Value = secondKey;
            firstNode.Parent = secondNodeParent;
            firstNode._children.Clear();

            foreach (var child in secondNodeChildren)
            {
                firstNode._children.Add(child);
            }
        }

        private void CheckEmptyNode(Tree<T> parentSubtree)
        {
            if (parentSubtree == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
