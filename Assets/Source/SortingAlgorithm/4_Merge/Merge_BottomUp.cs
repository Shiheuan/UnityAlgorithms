using System;

namespace Algorithms.Sorting
{
    public class Merge_BottomUp : Merge
    {
        //private static IComparable[] aux; // if do this, will null reference.
        
        public static void sort(IComparable[] a)
        {
            int N = a.Length;
            aux = new IComparable[N];
            for (int sz = 1; sz < N; sz = sz+sz)
            {
                for (int lo = 0; lo < N - sz; lo += sz + sz)
                {
                    merge(a, lo, lo + sz - 1, Math.Min(lo + sz + sz - 1, N - 1));
                }
            }
        }

    }
}

