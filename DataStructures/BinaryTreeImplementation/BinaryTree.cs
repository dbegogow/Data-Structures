using System;
using System.Collections.Generic;

namespace BinaryTreeImplementation
{
    public class BinaryTree<T> : IBinaryTree<T> where T : IComparable<T>
    {
        private Node<T> _root;

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
            throw new System.NotImplementedException();
        }
    }
}
