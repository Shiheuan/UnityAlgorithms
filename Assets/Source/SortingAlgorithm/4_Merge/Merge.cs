using System;

namespace Algorithms.Sorting
{
    public class Merge : BaseSort
    {
        protected static IComparable[] aux;

        public static void sort(IComparable[] a)
        {
            aux = new IComparable[a.Length];
            sort(a, 0, a.Length - 1);
        }

        private static void sort(IComparable[] a, int lo, int hi)
        {
            if (hi <= lo) return;
            int mid = lo + (hi - lo) / 2;
            sort(a, lo, mid);
            sort(a, mid + 1, hi);
            merge(a, lo, mid, hi);
        }

        protected static void merge(IComparable[] a, int lo, int mid, int hi)
        {
            int i = lo, j = mid + 1;

            for (int k = lo; k <= hi; k++)
            {
                aux[k] = a[k];
            }

            for (int k = lo; k <= hi; k++)
            {
                if (i > mid) a[k] = aux[j++];
                else if (j > hi) a[k] = aux[i++];
                else if (less(aux[i], aux[j])) a[k] = aux[i++];
                else a[k] = aux[j++];
            }
        }
    }
}

