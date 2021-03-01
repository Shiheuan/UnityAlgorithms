using System;

namespace Algorithms.Sorting
{
    public class Insertion : BaseSort
    {
        public static new void sort(IComparable[] a)
        {
            int N = a.Length;
            for (var i = 1; i < N; i++)
            {
                int j = i;
                var t = a[i];
                for (; j > 0 && less(t, a[j - 1]); j--)
                {
                    // move element
                    a[j] = a[j - 1];
                }

                a[j] = t;
            }
        }
    }
}

