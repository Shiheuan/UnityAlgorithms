namespace Algorithms.Graph
{
    public class DepthFirstSearch : ISearch
    {
        private bool[] mark;
        private int N;

        public DepthFirstSearch(Graph G, int s)
        {
            mark = new bool[G.v()];
            dfs(G, s);
        }

        private void dfs(Graph G, int v)
        {
            mark[v] = true;
            N++;
            foreach (int w in G.adj(v))
            {
                if (!mark[w]) dfs(G, w);
            }
        }

        public bool marked(int v)
        {
            return mark[v];
        }

        public int count()
        {
            return N;
        }
    }
}

