using System.Collections;
using Algorithms.Foundations;

namespace Algorithms.Graph
{
    public class BreadthFirstPaths : IPath
    {
        private bool[] mark;
        private int[] edgeTo;
        private int start;

        public BreadthFirstPaths(Graph G, int s)
        {
            mark = new bool[G.v()];
            edgeTo = new int[G.v()];
            this.start = s;
            bfs(G, s);
        }

        private void bfs(Graph G, int s)
        {
            Queue<int> q = new Queue<int>();
            mark[s] = true;
            q.enqueue(s);
            while (!q.isEmpty())
            {
                int v = q.dequeue();
                foreach (int w in G.adj(v))
                {
                    if (!mark[w])
                    {
                        edgeTo[w] = v;
                        mark[w] = true;
                        q.enqueue(w);
                    }
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

