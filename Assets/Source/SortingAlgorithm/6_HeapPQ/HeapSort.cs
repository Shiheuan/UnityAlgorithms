using System;

namespace Algorithms.Sorting
{
    public class HeapSort : BaseSort
    {
        public static new void sort(IComparable[] a)
        {
            int N = a.Length;
            var b = new IComparable[N + 1];
            for (var i = 0; i < a.Length; i++)
            {
                b[i + 1] = a[i];
            }
            for (int k = N / 2; k >= 1; k--)
            {
                sink(b, k, N);
            }
            while (N > 1)
            {
                exch(b, 1, N--);
                sink(b, 1, N);
            }
            for (var i = 0; i < a.Length; i++)
            {
                a[i] = b[i+1];
            }
        }

        private static void sink(IComparable[] a, int i, int N)
        {
            while (2 * i < N)
            {
                var j = 2 * i;
                if (j < N && less(a[j], a[j + 1])) j++;
                if (!less(a[i], a[j])) break;
                exch(a, i, j);
                i = j;
            }
        }
    }
}


