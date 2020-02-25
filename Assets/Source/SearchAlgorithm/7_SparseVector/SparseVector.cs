using UnityEditor.UIElements;

namespace Algorithms.Search
{
    public class SparseVector
    {
        private LinearProbingHashST<int, double> st;

        public SparseVector()
        {
            st = new LinearProbingHashST<int, double>();
        }

        public int size()
        {
            return st.size();
        }

        public void put(int i, double x)
        {
            st.put(i, x);
        }

        public double get(int i)
        {
            if (!st.contains(i)) return default;
            else return st.get(i);
        }

        public double dot(double[] that)
        {
            double sum = 0.0;
            foreach (var k in st.allKeys())
            {
                sum += that[k] * this.get(k);
            }

            return sum;
        }
    }

}

