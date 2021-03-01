using System;

namespace Algorithms.Sorting
{
    public class Quick3Way : BaseSort
    {
        public static new void sort(IComparable[] a)
        {
            shuffle(a);
            sort(a, 0, a.Length - 1);
        }

        private static void shuffle(IComparable[] a)
        {

        }

        public static void sort(IComparable[] a, int lo, int hi)
        {
            if (hi <= lo) return;
            int lt = lo, i = lo + 1, gt = hi;
            IComparable v = a[lo];
            while (i <= gt)
            {
                int cmp = a[i].CompareTo(v);
                if (cmp < 0) exch(a, lt++, i++);
                else if (cmp > 0) exch(a, i, gt--);
                else i++;
            }
            sort(a, lo, lt-1);
            sort(a, gt + 1, hi);
        }
    }
}

