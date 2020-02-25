using System.Collections.Generic;
using Algorithms.Foundations;

namespace Algorithms.Graph
{
    public class Graph : IGraph
    {
        private int V;          //顶点数目，只能赋值一次
        private int E;          //边的数目
        private Bag<int>[] Adj; //邻接表

        public Graph(int V)
        {
            this.V = V;
            this.E = 0;
            Adj = new Bag<int>[V];
            for (int i = 0; i < V; i++)
            {
                Adj[i] = new Bag<int>();
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

        public void addEdge(int v, int w)
        {
            Adj[v].add(w);
            Adj[w].add(v);
            E++;
        }

        public Bag<int> adj(int v)       
        {
            // convert Bag<int> to IEnumerable<int>
            return Adj[v];
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

        public static int degree(Graph G, int v)
        {
            int degree = 0;
            foreach (int w in G.adj(v))
            {
                degree++;
            }

            return degree;
        }

        public static int maxDegree(Graph G)
        {
            int max = 0;
            for (int i = 0; i < G.v(); i++)
            {
                if (degree(G, i) > max)
                {
                    max = degree(G, i);
                }
            }

            return max;
        }

        public static double avgDegree(Graph G)
        {
            return 2.0 * G.e() / G.v();
        }

        public static int numberOfSelfLoops(Graph G)
        {
            int count = 0;
            for (int i = 0; i < G.v(); i++)
            {
                foreach (int j in G.adj(i))
                {
                    if (i == j) count++;
                }
            }

            return count / 2;
        }
    }
}

