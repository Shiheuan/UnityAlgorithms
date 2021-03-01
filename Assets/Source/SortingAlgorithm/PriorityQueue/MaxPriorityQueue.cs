using System;
using UnityEngine;

namespace Algorithms.Sorting
{
    public class MaxPriorityQueue<T> where T : IComparable<T>
    {
        private T[] pq;
        private int N;

        public MaxPriorityQueue(int maxN)
        {
            pq = new T[maxN + 1];
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

        public T delMax()
        {
            T max = pq[1];
            exch(1, N--);
            pq[N + 1] = default(T); // null
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
                exch(k, k/2);
                k = k / 2;
            }
        }

        private void sink(int k)
        {
            while (2 * k <= N)
            {
                int j = 2 * k;
                if (j < N && less(j, j + 1))
                {
                    j++;
                }

                if (!less(k, j))
                {
                    break;// end
                }
                exch(j, k);
                k = j;
            }
        }
    }

}

