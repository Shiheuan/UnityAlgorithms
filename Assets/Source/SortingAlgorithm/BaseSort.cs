using System;

namespace Algorithms.Sorting
{
    public abstract class BaseSort
    {
        public static void sort(IComparable[] a)
        {
            // Todo: achieve sort algorithm.
        }

        public static bool less(IComparable v, IComparable w)
        {
            return v.CompareTo(w) < 0;
        }

        public static void exch(IComparable[] a, int i, int j)
        {
            IComparable t = a[i];
            a[i] = a[j];
            a[j] = t;
        }

        public static void show(IComparable[] a)
        {
            for (var i = 0; i < a.Length; i++)
            {
                UnityEngine.Debug.Log($"{a[i]} ");
            }
        }

        public static bool isSorted(IComparable[] a)
        {
            for (var i = 1; i < a.Length; i++)
            {
                if (less(a[i], a[i - 1])) // ascending order
                {
                    return false;
                }
            }

            return true;
        }
    }
}

