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

            return node;
        }
    }
}
