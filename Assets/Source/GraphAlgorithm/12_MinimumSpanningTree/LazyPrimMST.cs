using Algorithms.Foundations;
using Algorithms.Sorting;
using System.Collections;

namespace Algorithms.Graph
{
    public class LazyPrimMST : IMST
    {
        private bool[] mark;
        private Queue<Edge> mst;
        private MinPriorityQueue<Edge> pq;

        public LazyPrimMST(EdgeWeightedGraph G)
        {
            pq = new MinPriorityQueue<Edge>();
            mark = new bool[G.v()];
            mst = new Queue<Edge>();

            visit(G, 0); // assume Graph is connected.
            while (!pq.isEmpty())
            {
                Edge e = pq.delMin();
                int v = e.either(), w = e.other(v);
                if (mark[v] && mark[w]) continue;
                mst.enqueue(e);
                if (!mark[v]) visit(G, v);
                if (!mark[w]) visit(G, w);
            }
        }

        private void visit(EdgeWeightedGraph G, int v)
        {
            mark[v] = true;
            foreach (Edge e in G.adj(v))
            {
                if (!mark[e.other(v)])
                    pq.insert(e);
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

