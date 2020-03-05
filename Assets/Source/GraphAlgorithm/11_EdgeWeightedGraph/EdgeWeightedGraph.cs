using Algorithms.Foundations;
using System.Collections;

namespace Algorithms.Graph
{
    public class EdgeWeightedGraph
    {
        private int V;
        private int E;
        private Bag<Edge>[] Adj;

        public EdgeWeightedGraph(int V)
        {
            this.V = V;
            this.E = 0;
            Adj = new Bag<Edge>[V];
            for (int i = 0; i < V; i++)
            {
                Adj[i] = new Bag<Edge>();
            }
        }

        public int v()
        {
            return V;
        }

        public int e()
        {
            return E;
        }

        public void addEdge(Edge e)
        {
            int v = e.either(), w = e.other(v);
            Adj[v].add(e);
            Adj[w].add(e);
            E++;
        }

        public IEnumerable adj(int v)
        {
            return Adj[v];
        }

        public IEnumerable edges()
        {
            Bag<Edge> b = new Bag<Edge>();
            for (int v = 0; v < V; v++)
            {
                foreach (Edge e in Adj[v])
                {
                    if (e.other(v) > v) // the diffrent vertex
                        b.add(e);
                }
            }
            return b;
        }
    }
}

