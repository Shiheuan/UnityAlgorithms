using System;

namespace Algorithms.Graph
{
    public class Edge : IComparable<Edge>
    {
        private int v;
        private int w;
        private double weight;

        public Edge(int v, int w, double weight)
        {
            this.v = v;
            this.w = w;
            this.weight = weight;
        }

        public double getWeight()
        {
            return weight;
        }

        public int either()
        {
            return v;
        }

        public int other(int vertex)
        {
            if (vertex == v) return w;
            else if (vertex == w) return v;
            else throw new Exception("Inconsistent edge.");
        }

        public int CompareTo(Edge that)
        {
            if (this.getWeight() < that.getWeight()) return -1;
            else if (this.getWeight() > that.getWeight()) return 1;
            else return 0;
        }

        public string toString()
        {
            return string.Format("%d-%d %.2f", v, w, weight); 
        }
    }
}

