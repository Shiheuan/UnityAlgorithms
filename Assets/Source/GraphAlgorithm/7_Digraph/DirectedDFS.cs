using System.Collections.Generic;

namespace Algorithms.Graph
{
    public class DirectedDFS
    {
        private bool[] mark;

        public DirectedDFS(Digraph G, int s)
        {
            mark = new bool[G.v()];
            dfs(G, s);
        }

        public DirectedDFS(Digraph G, IEnumerable<int> sources)
        {
            mark = new bool[G.v()];
            foreach (int s in sources)
            {
                if (!mark[s])
                    dfs(G, s);
            }
        }

        private void dfs(Digraph G, int v)
        {
            mark[v] = true;
            foreach (int w in G.adj(v))
            {
                if (!mark[w])
                    dfs(G, w);
            }
        }

        public bool marked(int v)
        {
            return mark[v];
        }
    }
}

