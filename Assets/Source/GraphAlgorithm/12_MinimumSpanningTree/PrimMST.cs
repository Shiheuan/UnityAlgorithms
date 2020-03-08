using System.Collections;
using Algorithms.Sorting;

namespace Algorithms.Graph
{
    public class PrimMST : IMST
    {
        private bool[] mark;
        private Edge[] edgeTo;
        private double[] distTo;
        private IndexMinPQ<double> pq;

        public PrimMST(EdgeWeightedGraph G)
        {
            edgeTo = new Edge[G.v()];
            distTo = new double[G.v()];
            mark = new bool[G.v()];
            for (int v = 0; v < G.v(); v++)
            {
                distTo[v] = double.MaxValue;
            }
            pq = new IndexMinPQ<double>(4);

            distTo[0] = 0.0;
            pq.insert(0, 0.0);
            while (!pq.isEmpty())
            {
                visit(G, pq.delMin());
            }
        }

        private void visit(EdgeWeightedGraph G, int v)
        {
            mark[v] = true;
            foreach (Edge e in G.adj(v))
            {
                int w = e.other(v);

                if (mark[w]) continue;
                if (e.getWeight() < distTo[w])
                {
                    edgeTo[w] = e;
                    distTo[w] = e.getWeight();
                    if (pq.contains(w)) pq.change(w, distTo[w]);
                    else pq.insert(w, distTo[w]);
                }
            }
        }
        public IEnumerable edges()
        {
            throw new System.NotImplementedException();
        }

        public double weight()
        {
            throw new System.NotImplementedException();
        }
    }
}

