namespace Algorithms.Graph
{
    public class ConnectedComponent
    {
        private bool[] mark;
        private int[] id;
        private int count;

        public ConnectedComponent(Graph G)
        {
            mark = new bool[G.v()];
            id = new int[G.v()];
            for (int s = 0; s < G.v(); s++)
            {
                if (!mark[s])
                {
                    dfs(G, s);
                    count++;
                }
            }
        }

        private void dfs(Graph G, int v)
        {
            mark[v] = true;
            id[v] = count;
            foreach (int w in G.adj(v))
            {
                if (!mark[w])
                {
                    dfs(G, w);
                }
            }
        }

        public bool connected(int v, int w)
        {
            return id[v] == id[w];
        }

        public int getId(int v)
        {
            return id[v];
        }
        
        public int getCount()
        {
            return count;
        }

    }
}

