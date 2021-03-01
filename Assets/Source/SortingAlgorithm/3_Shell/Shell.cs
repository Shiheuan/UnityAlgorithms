using System;

namespace Algorithms.Sorting
{
    public class Shell : BaseSort
    {
        public static new void sort(IComparable[] a)
        {
            int N = a.Length;
            int h = 1;
            while (h < N / 3)
            {
                h = h * 3 + 1;
            }

            while (h >= 1)
            {
                for (int i = h; i < N; i++)
                {
                    for (int j = i; j >= h && less(a[j], a[j - h]); j -= h)
                    {
                        exch(a, j, j - h);
                    }
                }

                h = h / 3;
            }
        }
    }
}

