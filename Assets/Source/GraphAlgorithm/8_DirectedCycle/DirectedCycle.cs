using Algorithms.Foundations;

namespace Algorithms.Graph
{
    public class DirectedCycle
    {
        private bool[] mark;
        private int[] edgeTo;
        private Stack<object> cycle;    // vertex in cycle.
        private bool[] onStack;         // vertex on recursive call stack

        public DirectedCycle(Digraph G)
        {
            onStack = new bool[G.v()];
            edgeTo = new int[G.v()];
            mark = new bool[G.v()];
            for (int v = 0; v < G.v(); v++)
            {
                if (!mark[v])
                    dfs(G, v);
            }
        }

        private void dfs(Digraph G, int v)
        {
            onStack[v] = true;
            mark[v] = true;
            foreach (int w in G.adj(v))
            {
                if (this.hasCycle()) return;
                else if (!mark[w])
                {
                    edgeTo[w] = v;
                    dfs(G, w);
                }
                else if (onStack[w])
                {
                    cycle = new Stack<object>();
                    for (int x = v; x != w; x = edgeTo[x])
                    {
                        cycle.push(x);
                    }
                    cycle.push(w);
                    cycle.push(v);
                }
            }
            onStack[v] = false;
        }

        public bool hasCycle()
        {
            return cycle != null;
        }

        public Stack<object> getCycle()
        {
            return cycle;
        } 
    }
}
