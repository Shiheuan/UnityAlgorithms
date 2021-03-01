using System;

namespace Algorithms.Sorting
{
    public class Selection : BaseSort
    {
        public static new void sort(IComparable[] a)
        {
            int N = a.Length;
            for (var i = 0; i < N; i++)
            {
                int min = i;
                for (var j = i + 1; j < N; j++)
                {
                    if (less(a[j], a[min]))
                    {
                        min = j;
                    }
                }
                exch(a, i, min);
            }
        }
    }
}

