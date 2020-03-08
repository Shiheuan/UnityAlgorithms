namespace Algorithms.Graph
{
    public class DirectedEdge : IDirectedEdge
    {
        private int v;
        private int w;
        private double weight;

        public DirectedEdge(int v, int w, double weight)
        {
            this.v = v;
            this.w = w;
            this.weight = weight;
        }
        
        public int from()
        {
            return v;
        }

        public int to()
        {
            return w;
        }

        public string toString()
        {
            return string.Format("%d->%d %.2f", v, w, weight);
        }

        public double getWeight()
        {
            return weight;
        }

    }
}

