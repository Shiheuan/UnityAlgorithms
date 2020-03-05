namespace Algorithms.Graph
{
    public class KosarajuCC
    {
        private bool[] mark;
        private int[] id; // strongly connected components' id
        private int count;

        public KosarajuCC(Digraph G)
        {
            mark = new bool[G.v()];
            id = new int[G.v()];
            DepthFirstOrder order = new DepthFirstOrder(G.reverse());
            foreach (int s in order.getReversePost())
            {
                if (!mark[s])
                {
                    dfs(G, s);
                    count++;
                }
            }
        }

        private void dfs(Digraph G, int v)
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

        public bool stronglyConnected(int v, int w)
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

