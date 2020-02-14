using System;

namespace Algorithms.Sorting
{
    public class Quick : BaseSort
    {
        public static void sort(IComparable[] a)
        {
            shuffle(a);
            sort(a, 0, a.Length - 1);
        }

        private static void sort(IComparable[] a, int lo, int hi)
        {
            if (hi <= lo) return;
            int j = partition(a, lo, hi);
            sort(a, lo, j-1);
            sort(a, j+1, hi);
        }

        private static int partition(IComparable[] a, int lo, int hi)
        {
            int i = lo, j = hi + 1;
            IComparable v = a[lo];
            while (true)
            {
                while(less(a[++i], v)) // find first 'le' than v
                    if (i == hi)
                        break;
                while(less(v, a[--j])) // find first 'ge' than v
                    if (j == lo)
                        break;
                if (i >= j) break;
                exch(a, i, j);
            }
            exch(a, lo, j); // same as 'i'
            return j;
        }

        private static void shuffle(IComparable[] a)
        {

        }
    }

}

