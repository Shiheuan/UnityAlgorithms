using Algorithms.Sorting;
using Algorithms.Foundations;
using System.Collections;

namespace Algorithms.Graph
{
    public class KruskalMST : IMST
    {
        private Queue<Edge> mst;

        public KruskalMST(EdgeWeightedGraph G)
        {
            mst = new Queue<Edge>();
            MinPriorityQueue<Edge> pq = new MinPriorityQueue<Edge>();
            foreach (Edge e in G.edges())
            {
                pq.insert(e);
            }
            UF uf = new UF(G.v());

            while (!pq.isEmpty() && mst.size() < G.v() - 1)
            {
                Edge e = pq.delMin();
                int v = e.either(), w = e.other(v);
                if (uf.connected(v, w)) continue;
                uf.union(v, w);
                mst.enqueue(e);
            }
        }

        public IEnumerable edges()
        {
            return mst;
        }

        public double weight()
        {
            throw new System.NotImplementedException();
        }
    }
}
