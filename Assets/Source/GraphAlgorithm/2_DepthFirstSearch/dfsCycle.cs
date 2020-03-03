namespace Algorithms.Graph
{
    public class dfsCycle
    {
        private bool[] mark;
        private bool hasCycle;
        
        public dfsCycle(Graph G)
        {
            mark = new bool[G.v()];
            for (int s = 0; s < G.v(); s++)
            {
                if (!mark[s])
                    dfs(G, s, s);
            }
        }

        private void dfs(Graph G, int v, int u)
        {
            mark[v] = true;
            foreach (int w in G.adj(v))
            {
                if (!mark[w])
                    dfs(G, w, v);
                else if (w != u)
                    hasCycle = true;
            }
        }

        public bool getHasCycle()
        {
            return hasCycle;
        }

    }
}


