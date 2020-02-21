namespace Algorithms.Search
{
    public class SequentialSearchST<TKey, TValue>
    {
        private Node first;
        private int N;

        private class Node
        {
            internal TKey key;
            internal TValue value;
            internal Node next;

            public Node(TKey key, TValue value, Node next)
            {
                this.key = key;
                this.value = value;
                this.next = next;
            }
        }

        public TValue get(TKey key)
        {
            for (Node x = first; x != null; x = x.next)
            {
                if (key.Equals(x.key))
                {
                    return x.value;
                }
            }

            return default(TValue); // null
        }

        public void put(TKey key, TValue value)
        {
            if (value == null) return;
            for (Node x = first; x != null; x = x.next)
            {
                if (key.Equals(x.key))
                {
                    x.value = value;
                    return;
                }
            }
            first = new Node(key, value, first);
            N++;
        }

        public void delete(TKey key)
        {
            // put(key, null); // delayed delete
            Node temp = first;
            for (Node x = first; x != null; x = x.next)
            {
                if (x.key.Equals(key))
                {
                    temp = x.next;
                    N--;
                    return;
                }

                temp = x.next;
            }
        }
        public bool contains(TKey key)
        {
            return get(key) != null;
        }

        public bool isEmpty()
        {
            return size() == 0;
        }

        public int size()
        {
            return N;
        }
    }
}

