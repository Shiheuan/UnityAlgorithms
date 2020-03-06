using System;

namespace Algorithms.Sorting
{
    public class IndexMinPQ<T> where T : IComparable<T>
    {
        private int[] pq; // index heap
        private int[] qp; // reverse qp[pq[i]] = pq[qp[i]] = i
        private object[] keys;

        private int N;
        
        public IndexMinPQ(int maxN)
        {
            keys = new object[maxN + 1]; // boxing
            pq = new int[maxN + 1];
            qp = new int[maxN + 1];
            for (int i = 0; i <= maxN; i++)
            {
                qp[i] = -1;
            }
        }

        public void insert(int k, T item)
        {
            if (N == pq.Length - 1) resize(2 * pq.Length);
            N++;
            qp[k] = N;
            pq[N] = k;
            keys[k] = item;
            swim(N);
        }

        private void swim(int key)
        {
            while (key > 1 && greater(key/2, key))
            {
                exch(key, key / 2);
                key = key / 2;
            }
        }

        private void sink(int key)
        {
            while (2 * key <= N)
            {
                int j = 2 * key;
                if (j < N && greater(j, j + 1))
                {
                    j++;
                }
                if (!greater(key, j))
                {
                    break;
                }
                exch(j, key);
                key = j;
            }
        }

        private void exch(int i, int j)
        {
            int t = pq[i];
            pq[i] = pq[j];
            pq[j] = t;

            qp[pq[i]] = i;
            qp[pq[j]] = j;
        }

        private bool greater(int i, int j)
        {
            return ((T)keys[pq[i]]).CompareTo((T)keys[pq[j]]) > 0;
        }

        public void change(int k, T item)
        {
            if (!contains(k)) return;
            keys[k] = item;
        }

        public bool contains(int k)
        {
            return qp[k] != -1;
        }

        public void delete(int k)
        {
            if (!contains(k)) return;
            exch(k, N--);
            sink(k);
            keys[pq[N + 1]] = null;
            qp[pq[N + 1]] = -1;
            if (N > 0 && N == pq.Length / 4) resize(pq.Length / 2);
        }

        public T min()
        {
            return (T)keys[pq[1]];
        }

        public int minIndex()
        {
            return pq[1];
        }

        public int delMin()
        {
            int indexOfMin = pq[1];
            exch(1, N--);
            sink(1);
            keys[pq[N + 1]] = null;
            qp[pq[N + 1]] = -1;
            if (N > 0 && N == pq.Length / 4) resize(pq.Length / 2);
            return indexOfMin;
        }
        
        private void resize(int max)
        {
            var tempkeys = new object[max + 1]; // boxing
            var temppq = new int[max + 1];
            var tempqp = new int[max + 1];
            var i = 0;
            for (i = 0; i <= max; i++)
            {
                tempqp[i] = -1;
            }
            for (i = 0; i <= N; i++)
            {
                tempkeys[i] = keys[i];
                temppq[i] = pq[i];
                tempqp[i] = qp[i];
            }
            keys = tempkeys;
            pq = temppq;
            qp = tempqp;
        }
        public bool isEmpty()
        {
            return N == 0;
        }

        public int size()
        {
            return N;
        }
    }
}

