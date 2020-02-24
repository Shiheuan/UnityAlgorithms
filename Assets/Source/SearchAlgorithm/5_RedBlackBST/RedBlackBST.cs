using System;

namespace Algorithms.Search
{
    public class RedBlackBST<TKey, TValue> where TKey : IComparable
    {
        private static bool RED = true;
        private static bool BLACK = false;
        private Node root;
        private class Node
        {
            internal TKey key;
            internal TValue val;
            internal Node left;
            internal Node right;
            internal int N;
            internal bool color;

            public Node(TKey key, TValue val, int N, bool color)
            {
                this.key = key;
                this.val = val;
                this.N = N;
                this.color = color;
            }
        }

        bool isRed(Node h)
        {
            if (h == null) return false;
            return h.color == RED;
        }

        Node rotateLeft(Node h)
        {
            Node x = h.right;
            h.right = x.left;
            x.left = h;
            x.color = h.color; // original node connect to h, RED or BLACK
            h.color = RED; // now x connect to h, is RED
            x.N = h.N;
            h.N = 1 + size(h.left) + size(h.right);
            return x;
        }

        Node rotateRight(Node h)
        {
            Node x = h.left;
            h.left = x.right;
            x.right = h;
            x.color = h.color;
            h.color = RED;
            x.N = h.N;
            h.N = 1 + size(h.left) + size(h.right);
            return x;
        }

        void flipColors(Node h)
        {
            h.color = RED;
            h.left.color = BLACK;
            h.right.color = BLACK;
        }

        public int size()
        {
            return size(root);
        }
        int size(Node x)
        {
            if (x == null) return 0;
            else return x.N;
        }

        public TValue get(TKey key)
        {
            return get(root, key);
        }

        private TValue get(Node x, TKey key)
        {
            if (x == null) return default(TValue); //null;
            int cmp = key.CompareTo(x.key);
            if (cmp < 0) return get(x.left, key);
            else if (cmp > 0) return get(x.right, key);
            else return x.val;
        }

        public void put(TKey key, TValue val)
        {
            root = put(root, key, val);
            root.color = BLACK;
        }

        Node put(Node h, TKey key, TValue val)
        {
            if (h == null)
                return new Node(key, val, 1, RED);
            int cmp = key.CompareTo(h.key);
            if (cmp < 0)
            {
                h.left = put(h.left, key, val);
            }
            else if (cmp > 0)
            {
                h.right = put(h.right, key, val);
            }
            else
            {
                h.val = val;
            }

            if (isRed(h.right) && !isRed(h.left)) h = rotateLeft(h);
            if (isRed(h.left) && isRed(h.left.left)) h = rotateRight(h);
            if (isRed(h.left) && isRed(h.right)) flipColors(h);

            h.N = size(h.left) + size(h.right) + 1;
            return h;
        }
    }
}

