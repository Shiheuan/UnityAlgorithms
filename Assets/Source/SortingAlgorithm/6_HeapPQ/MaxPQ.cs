using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
    public class MaxPQ<T> : IMaxPQ<T> where T : IComparable<T> // cannot be constrained in top interface
    {
        private T[] pq; // start at 1
        private int N = 0;

        public MaxPQ(int maxN)
        {
            pq = new T[maxN+1];
        }

        public MaxPQ(T[] a)
        {
            pq = new T[a.Length + 1];
            foreach (var v in a)
            {
                this.insert(v);
            }
        }

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
            pq[++N] = v;
            swim(N);
        }

        public T max()
        {
            return pq[1];
        }

        public T delMax()
        {
            T max = pq[1];
            exch(1, N--);
            pq[N + 1] = default(T); // null or 0
            sink(1);
            return max;
        }

        private bool less(int i, int j)
        {
            return pq[i].CompareTo(pq[j]) < 0;
        }

        private void exch(int i, int j)
        {
            T t = pq[i];
            pq[i] = pq[j];
            pq[j] = t;
        }

        private void swim(int k)
        {
            while (k > 1 && less(k / 2, k))
            {
                exch(k/2, k);
                k = k / 2;
            }
        }

        private void sink(int k)
        {
            while (2 * k <= N)
            {
                var j = 2 * k;
                if (j < N && less(j, j + 1)) j++;
                if (!less(k, j)) break;
                exch(k, j);
                k = j;
            }
        }
    }

}

