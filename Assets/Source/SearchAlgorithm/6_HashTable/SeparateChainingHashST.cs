using System;

namespace Algorithms.Search
{
    public class SeparateChainingHashST<TKey, TValue> where TValue : IComparable
    {
        private int N; // 键值对总数
        private int M; // 散列表的大小
        private SequentialSearchST<TKey, TValue>[] st; // 存放链表对象的数组

        public SeparateChainingHashST() : this(997) { }

        public SeparateChainingHashST(int M)
        {
            this.M = M;
            st = new SequentialSearchST<TKey, TValue>[M];
            for (int i = 0; i < M; i++)
            {
                st[i] = new SequentialSearchST<TKey, TValue>();
            }
        }

        private int hash(TKey key)
        {
            return (key.GetHashCode() & 0x7fffffff) % M;
        }

        public TValue get(TKey key)
        {
            return (TValue) st[hash(key)].get(key);
        }

        public void put(TKey key, TValue val)
        {
            st[hash(key)].put(key, val);
        }

        public int size()
        {
            // need to operate.
            return N;
        }
    }
}

