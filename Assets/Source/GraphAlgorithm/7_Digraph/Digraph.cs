
using Algorithms.Foundations;

namespace Algorithms.Graph
{
    public class Digraph : IDigraph
    {
        private int V;
        private int E;
        private Bag<object>[] Adj; // change value-base to ref-base. boxing and unboxing maybe can fix this. default(int) is 0, hard to use in fact.

        public Digraph(int V)
        {
            this.V = V;
            this.E = 0;
            Adj = new Bag<object>[V];
            for (int w = 0; w < V; w++)
            {
                Adj[w] = new Bag<object>();
            }
        }

        public void addEdge(int v, int w)
        {
            Adj[v].add(w);
            E++;
        }

        public Bag<object> adj(int v)
        {
            return Adj[v];
        }

        public int v()
        {
            return V;
        }

        public int e()
        {
            return E;
        }

        public IDigraph reverse()
        {
            IDigraph R = new Digraph(V);
            for (int i = 0; i < V; i++)
            {
                foreach (int j in adj(i))
                {
                    R.addEdge(j, i);
                }
            }
            return R;
        }

        public string toString()
        {
            string s = V + " vertices, " + E + " edges\n";
            for (int i = 0; i < V; i++)
            {
                s += i + ": ";
                foreach (var w in Adj[i])
                {
                    s += w + " ";
                }

                s += "\n";
            }

            return s;
        }

    }
}

