using Algorithms.Foundations;
using System.Collections;

namespace Algorithms.Graph
{
    public class EdgeWeightedDigraph : IEdgeWeightedDigraph
    {
        private int V;
        private int E;
        private Bag<DirectedEdge>[] Adj;

        public EdgeWeightedDigraph(int V)
        {
            this.V = V;
            this.E = 0;
            Adj = new Bag<DirectedEdge>[V];
            for (int v = 0; v < V; v++)
            {
                Adj[v] = new Bag<DirectedEdge>();
            }
        }

        public void addEdge(DirectedEdge e)
        {
            Adj[e.from()].add(e);
            E++;
        }

        public IEnumerable adj(int v)
        {
            return Adj[v];
        }

        public int e()
        {
            return E;
        }

        public IEnumerable edges()
        {
            Bag<DirectedEdge> bag = new Bag<DirectedEdge>();
            for (int v = 0; v < V; v++)
            {
                foreach (DirectedEdge e in Adj[v])
                {
                    bag.add(e);
                }
            }
            return bag;
        }

        public string toString()
        {
            throw new System.NotImplementedException();
        }

        public int v()
        {
            return V;
        }
    }
}

