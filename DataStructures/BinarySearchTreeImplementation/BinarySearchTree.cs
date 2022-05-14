using System;
using System.Collections.Generic;

namespace BinarySearchTreeImplementation
{
    public class BinarySearchTree<T> : IBinarySearchTree<T> where T : IComparable<T>
    {
        private Node<T> _root;

        public T Root => this._root.Value;

        public bool Add(T newItem)
        {
            var current = this._root;

            var newItemNode = new Node<T>(newItem);

            if (current == null)
            {
                this._root = newItemNode;
                return true;
            }

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

        public bool Remove(T item)
        {
            if (item == null)
            {
                return false;
            }

            var current = this._root;
            var before = current;

            // 'n' - has no direction (root element), 'l' = left, 'r' = right
            var lastDirection = 'n';

            while (current != null)
            {
                var compareResult = current.Value.CompareTo(item);

                if (compareResult == 0)
                {
                    if (current.Right == null)
                    {
                        if (lastDirection == 'l')
                        {
                            before.Left = current.Left;
                        }
                        else if (lastDirection == 'r')
                        {
                            before.Right = current.Left;
                        }
                        else
                        {
                            this._root = current.Left;
                        }
                    }
                    else if (current.Right.Left == null)
                    {
                        current.Right.Left = current.Left;

                        if (lastDirection == 'l')
                        {
                            before.Left = current.Right;
                        }
                        else if (lastDirection == 'r')
                        {
                            before.Right = current.Right;
                        }
                        else
                        {
                            this._root = current.Right;
                        }
                    }
                    else
                    {
                        var min = current.Right.Left;
                        var minbefore = current.Right;

                        while (min.Left != null)
                        {
                            minbefore = min;
                            min = min.Left;
                        }

                        min.Left = current.Left;
                        min.Right = current.Right;

                        minbefore.Left = null;

                        if (lastDirection == 'l')
                        {
                            before.Left = min;
                        }
                        else if (lastDirection == 'r')
                        {
                            before.Right = min;
                        }
                        else
                        {
                            this._root = min;
                        }
                    }

                    break;
                }

                before = current;

                if (compareResult < 0)
                {
                    current = current.Right;
                    lastDirection = 'r';
                }
                else if (compareResult > 0)
                {
                    current = current.Left;
                    lastDirection = 'l';
                }
            }

            return false;
        }

        public bool Contains(T item)
        {
            var current = this._root;

            while (current != null)
            {
                var compareResult = current.Value.CompareTo(item);

                if (compareResult < 0)
                {
                    current = current.Right;
                }
                else if (compareResult > 0)
                {
                    current = current.Left;
                }
                else
                {
                    return true;
                }
            }

            return false;
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
