using System;
using System.Collections.Generic;

namespace BinaryTreeImplementation
{
    public class BinaryTree<T> : IBinaryTree<T> where T : IComparable<T>
    {
        private Node<T> _root;

        public T Root => this._root.Value;

        public bool Add(T newItem)
        {
            var current = this._root;

            if (current == null)
            {
                this._root = new Node<T>(newItem);
                return true;
            }

            var newItemNode = new Node<T>(newItem);

            while (current != null)
            {
                var currentValue = current.Value;
                var compareResult = currentValue.CompareTo(newItem);

                if (compareResult < 0)
                {
                    if (current.Right == null)
                    {
                        current.Right = newItemNode;
                        break;
                    }

                    current = current.Right;
                }
                else if (compareResult > 0)
                {
                    if (current.Left == null)
                    {
                        current.Left = newItemNode;
                        break;
                    }

                    current = current.Left;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public IEnumerable<T> InOrder()
        {
            var items = new List<T>();

            this.InOrder(this._root, items);

            return items;
        }

        public IEnumerable<T> PreOrder()
        {
            var items = new List<T>();

            this.PreOrder(this._root, items);

            return items;
        }

        private void InOrder(Node<T> current, List<T> items)
        {
            if (current != null)
            {
                this.InOrder(current.Left, items);
                items.Add(current.Value);
                this.InOrder(current.Right, items);
            }
        }

        private void PreOrder(Node<T> current, List<T> items)
        {
            if (current != null)
            {
                items.Add(current.Value);
                this.PreOrder(current.Left, items);
                this.PreOrder(current.Right, items);
            }
        }
    }
}
