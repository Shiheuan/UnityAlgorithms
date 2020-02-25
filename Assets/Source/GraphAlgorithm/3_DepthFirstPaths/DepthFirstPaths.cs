using System.Collections;
using Algorithms.Foundations;

namespace Algorithms.Graph
{
    public class DepthFirstPaths : IPath
    {
        private bool[] mark;
        private int[] edgeTo;
        private int start;

        public DepthFirstPaths(Graph G, int s)
        {
            mark = new bool[G.v()];
            edgeTo = new int[G.v()];
            this.start = s;
            dfs(G, s);
        }

        private void dfs(Graph G, int v)
        {
            mark[v] = true;
            foreach (int w in G.adj(v))
            {
                if (!mark[w])
                {
                    edgeTo[w] = v;
                    dfs(G, w);
                }
            }
        }

        public bool hasPathTo(int v)
        {
            return mark[v];
        }

        public IEnumerable pathTo(int v)
        {
            if (!hasPathTo(v)) return null;
            Stack<int> path = new Stack<int>();
            for (int x = v; x != start; x = edgeTo[x])
            {
                path.push(x);
            }
            path.push(start);
            return path;
        }
    }
}

