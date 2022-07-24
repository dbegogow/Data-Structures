namespace AVLTreeImplementation
{
    public class AVLTree<T> : IAVLTree<T> where T : IComparable<T>
    {
        private Node<T> _root;

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(T item)
            => this._root = this.Insert(this._root, item);

        public void Delete(T item)
        {
            throw new NotImplementedException();
        }

        private Node<T> Insert(Node<T> node, T item)
        {
            if (node == null)
            {
                return new Node<T>(item);
            }

            var cmp = item.CompareTo(node.Value);
            if (cmp < 0)
            {
                node.Left = this.Insert(node.Left, item);
            }
            else if (cmp > 0)
            {
                node.Right = this.Insert(node.Right, item);
            }

            this.UpdateHeight(node);

            node = this.Balance(node);

            return node;
        }

        private Node<T> Balance(Node<T> node)
        {
            var balance = this.Height(node.Left) - this.Height(node.Right);
            if (balance > 1)
            {
                var childBalance = this.Height(node.Left.Left) - this.Height(node.Left.Right);
                if (childBalance < 0)
                {
                    node.Left = this.RotateLeft(node.Left);
                }

                node = this.RotateRight(node);
            }
            else if (balance < -1)
            {
                var childBalance = this.Height(node.Right.Left) - this.Height(node.Right.Right);
                if (childBalance > 0)
                {
                    node.Right = this.RotateRight(node.Right);
                }

                node = this.RotateLeft(node);
            }

            return node;
        }

        private Node<T> RotateLeft(Node<T> node)
        {
            var right = node.Right;
            node.Right = right.Left;
            right.Left = node;

            this.UpdateHeight(node);
            this.UpdateHeight(right);

            return right;
        }

        private Node<T> RotateRight(Node<T> node)
        {
            var left = node.Left;
            node.Left = left.Right;
            left.Right = node;

            this.UpdateHeight(node);
            this.UpdateHeight(left);

            return left;
        }

        private void UpdateHeight(Node<T> node)
        {
            if (node != null)
            {
                node.Height = Math.Max(this.Height(node.Left), this.Height(node.Right)) + 1;
            }
        }

        private int Height(Node<T> node)
        {
            if (node == null)
            {
                return 0;
            }

            return node.Height;
        }
    }
}
