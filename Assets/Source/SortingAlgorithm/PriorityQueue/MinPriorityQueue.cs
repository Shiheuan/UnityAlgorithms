using System;

namespace Algorithms.Sorting
{
    public class MinPriorityQueue<T> where T : IComparable<T>
    {
        private T[] pq;
        private int N;

        public MinPriorityQueue(int maxN)
        {
            pq = new T[maxN + 1];
        }

        public MinPriorityQueue(): this(4) { }

        public bool isEmpty()
        {
            return N == 0;
        }

        public int size()
        {
            return N;
        }

        public void insert(T v)
        {
            if (N == pq.Length) resize(2 * pq.Length);
            pq[++N] = v;
            swim(N);
        }

        public T delMin()
        {
            T max = pq[1];
            exch(1, N--);
            pq[N + 1] = default(T); // null
            sink(1);
            if (N > 0 && N == pq.Length / 4) resize(pq.Length / 2);
            return max;
        }

        private bool greater(int i, int j)
        {
            return pq[i].CompareTo(pq[j]) > 0;
        }

        private void exch(int i, int j)
        {
            T t = pq[i];
            pq[i] = pq[j];
            pq[j] = t;
        }

        private void swim(int k)
        {
            while (k > 1 && greater(k / 2, k))
            {
                exch(k, k / 2);
                k = k / 2;
            }
        }

        private void sink(int k)
        {
            while (2 * k <= N)
            {
                int j = 2 * k;
                if (j < N && greater(j, j + 1))
                {
                    j++;
                }

                if (!greater(k, j))
                {
                    break;// end
                }
                exch(j, k);
                k = j;
            }
        }

        private void resize(int max)
        {
            T[] temp = new T[max];
            for (int i = 0; i < N; i++)
            {
                temp[i] = pq[i];
            }
            pq = temp;
        }
    }

}

