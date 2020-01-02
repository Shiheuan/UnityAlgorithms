using System;
using System.Diagnostics;

namespace Algorithms.Sorting
{
    public class SortCompare
    {
        public static double time(string alg, IComparable[] a)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            switch (alg)
            {
                case "Insertion":
                    Insertion.sort(a);
                    break;
                case "Selection":
                    Selection.sort(a);
                    break;
                case "Shell":
                    Shell.sort(a);
                    break;
                case "Merge":
                    throw new NotImplementedException();
                case "Quick":
                    throw new NotImplementedException();
                case "Heap":
                    throw new NotImplementedException();
            }
            timer.Stop();
            return timer.ElapsedMilliseconds;
        }

        public static double timeRandomInput(string alg, int N, int T)
        {
            // use alg sort T arrays which have N elements.
            double total = 0.0;
            IComparable[] a = new IComparable[N];
            var rnd = new Random();
            for (int t = 0; t < T; t++)
            {
                for (int i = 0; i < N; i++)
                {
                    a[i] = rnd.NextDouble();
                }

                total += time(alg, a);
            }

            return total;
        }
    }
}

