namespace AVLTreeImplementation
{
    public class AVLTree<T> : IAVLTree<T> where T : IComparable<T>
    {
        private Node<T> _root;

        public bool Contains(T item)
        {
            var node = this.Search(this._root, item);
            return node != null;
        }

        public void Insert(T item)
            => this._root = this.Insert(this._root, item);

        public void Delete(T item)
        {
            if (this.Contains(item))
            {
                this._root = this.Remove(this._root, item);

                this.UpdateHeight(this._root);
            }
        }

        private Node<T> Remove(Node<T> node, T item)
        {
            if (node == null)
            {
                return null;
            }

            int cmp = item.CompareTo(node.Value);
            if (cmp < 0)
            {
                node.Left = this.Remove(node.Left, item);

                this.UpdateHeight(node);
            }
            else if (cmp > 0)
            {
                node.Right = this.Remove(node.Right, item);

                this.UpdateHeight(node);
            }

            if (cmp == 0)
            {
                if (node.Left == null
                    && node.Right == null)
                {
                    return null;
                }

                if (node.Left != null
                    && node.Right == null)
                {
                    return node.Left;
                }

                if (node.Left == null
                    && node.Right != null)
                {
                    return node.Right;
                }

                if (node.Left.Height > node.Right.Height)
                {
                    var replacement = this.Greatest(node.Left);
                    node.Value = replacement.Value;
                    node.Left = this.Remove(node.Left, replacement.Value);

                    this.UpdateHeight(node.Left);
                    this.UpdateHeight(node);
                }
                else
                {
                    var replacement = this.Smallest(node.Right);
                    node.Value = replacement.Value;
                    node.Right = this.Remove(node.Right, replacement.Value);

                    this.UpdateHeight(node.Right);
                    this.UpdateHeight(node);
                }
            }

            return this.Balance(node);
        }

        private Node<T> Smallest(Node<T> node)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Left != null)
            {
                return this.Smallest(node.Left);
            }
            else
            {
                return node;
            }
        }

        private Node<T> Greatest(Node<T> node)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Right != null)
            {
                return this.Greatest(node.Right);
            }
            else
            {
                return node;
            }
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

        private Node<T> Search(Node<T> node, T item)
        {
            if (node == null)
            {
                return null;
            }

            var cmp = item.CompareTo(node.Value);
            if (cmp < 0)
            {
                return this.Search(node.Left, item);
            }
            else if (cmp > 0)
            {
                return this.Search(node.Right, item);
            }

            return node;
        }
    }
}
