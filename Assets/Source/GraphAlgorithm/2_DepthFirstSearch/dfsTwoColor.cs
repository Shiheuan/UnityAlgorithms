namespace Algorithms.Graph
{
    public class dfsTwoColor
    {
        private bool[] mark;
        private bool[] color;
        private bool isTwoColorable = true;

        public dfsTwoColor(Graph G)
        {
            mark = new bool[G.v()];
            color = new bool[G.v()];
            for (int s = 0; s < G.v(); s++)
            {
                if (!mark[s])
                    dfs(G, s);
            }
        }

        private void dfs(Graph G, int v)
        {
            mark[v] = true;
            foreach (int w in G.adj(v))
            {
                if (!mark[w])
                {
                    color[w] = !color[v];
                    dfs(G, w);
                }
                else if(color[w] == color[v])
                {
                    isTwoColorable = false; 
                }
            }
        }

        public bool isBipartite()
        {
            return isTwoColorable;
        }
    }
}

