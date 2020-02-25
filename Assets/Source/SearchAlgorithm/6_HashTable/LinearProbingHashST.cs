using System.Collections.Generic;

namespace Algorithms.Search
{
    public class LinearProbingHashST<TKey, TValue>
    {
        private int N;
        private int M = 16;
        private TKey[] keys;
        private TValue[] vals;

        public LinearProbingHashST()
        {
            keys = new TKey[M];
            vals = new TValue[M];
        }

        public LinearProbingHashST(int cap)
        {
            keys = new TKey[cap];
            vals = new TValue[cap];
            M = cap;
        }

        private int hash(TKey key)
        {
            return (key.GetHashCode() & 0x7fffffff) % M;
        }

        private void resize(int cap)
        {
            LinearProbingHashST<TKey, TValue> t;
            t = new LinearProbingHashST<TKey, TValue>(cap);
            for (int i = 0; i < M; i++)
            {
                if(keys[i] != null)
                {
                    t.put(keys[i], vals[i]);
                }
            }

            keys = t.keys;
            vals = t.vals;
            M = t.M;
        }

        public void put(TKey key, TValue val)
        {
            if (N >= M / 2) resize(2 * M);
            int i;
            for (i = hash(key); keys[i] != null; i = (i + 1) % M)
            {
                if (keys[i].Equals(key))
                {
                    vals[i] = val;
                    return;
                }
            }

            keys[i] = key;
            vals[i] = val;
            N++;
        }

        public TValue get(TKey key)
        {
            for (int i = hash(key); keys[i] != null; i = (i + 1) % M)
            {
                if (keys[i].Equals(key))
                    return vals[i];
            }

            return default(TValue);
        }

        public bool contains(TKey key)
        {
            return get(key) != null;
        }

        public void delete(TKey key)
        {
            if (!contains(key)) return;
            int i = hash(key);
            while (!key.Equals(keys[i]))
            {
                i = (i + 1) % M;
            }

            keys[i] = default(TKey);//null;
            vals[i] = default(TValue); //null;
            i = (i + 1) % M;
            while (keys[i] != null)
            {
                TKey keyToRedo = keys[i];
                TValue valToRedo = vals[i];
                keys[i] = default(TKey);//null;
                vals[i] = default(TValue); //null;
                N--;
                put(keyToRedo, valToRedo);
                i = (i + 1) % M;
            }

            N--;
            if (N > 0 && N == M/8) resize(M/2);
        }

        public int size()
        {
            return N;
        }

        public IEnumerable<TKey> allKeys()
        {
            Queue<TKey> queue = new Queue<TKey>();
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i] != null)
                    queue.Enqueue(keys[i]);
            }
            return queue;
        }
    }
}

