using System;
using System.Collections.Generic;

namespace Algorithms.Search
{
    public class BinarySearchST<TKey, TValue> where TKey : IComparable
    {
        private TKey[] keys; // sorted
        private TValue[] values; // sorted
        private int N;

        public BinarySearchST(int capacity)
        {
            keys = new TKey[capacity];
            values = new TValue[capacity];
        }

        public int size()
        {
            return N;
        }

        public TValue get(TKey key)
        {
            if (isEmpty())
            {
                return default(TValue); // null
            }

            int i = rank(key);
            if (i < N && keys[i].CompareTo(key) == 0)
            {
                return values[i];
            }
            else
            {
                return default(TValue);
            }
        }

        public void put(TKey key, TValue val)
        {
            // resize.

            int i = rank(key);
            if (i < N && keys[i].CompareTo(key) == 0)
            {
                values[i] = val;
                return;
            }

            for (int j = N; j > i; j--)
            {
                keys[j] = keys[j - 1];
                values[j] = values[j - 1];
            }

            keys[i] = key;
            values[i] = val;
            N++;
        }

        public int rank(TKey key)
        {
            int lo = 0, hi = N - 1;
            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                int cmp = key.CompareTo(keys[mid]);
                if (cmp < 0) hi = mid - 1;
                else if (cmp > 0) lo = mid + 1;
                else return mid;
            }

            return lo;
        }

        public bool isEmpty()
        {
            return size() == 0;
        }

        public TKey min()
        {
            return keys[0];
        }

        public TKey max()
        {
            return keys[N - 1];
        }

        public TKey select(int k)
        {
            return keys[k];
        }

        public TKey ceiling(TKey key)
        {
            int i = rank(key);
            return keys[i];
        }
        public bool contains(TKey key)
        {
            return get(key) != null;
        }

        public IEnumerable<TKey> allkeys()
        {
            return allkeys(min(), max());
        }

        public IEnumerable<TKey> allkeys(TKey lo, TKey hi)
        {
            Queue<TKey> q = new Queue<TKey>();
            for (int i = rank(lo); i < rank(hi); i++)
            {
                q.Enqueue(keys[i]);
            }

            if (contains(hi))
            {
                q.Enqueue(keys[rank(hi)]);
            }

            return q;
        }
    }
}
