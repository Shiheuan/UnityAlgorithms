using System;

namespace Algorithms.Sorting
{
    public class Insertion : BaseSort
    {
        public static void sort(IComparable[] a)
        {
            int N = a.Length;
            for (var i = 1; i < N; i++)
            {
                for (var j = i; j > 0 && less(a[j], a[j - 1]); j--)
                {
                    // exchange every step.
                    exch(a, j, j-1);
                }
            }
        }
    }
}

