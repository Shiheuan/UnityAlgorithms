using System.Collections;

namespace Algorithms.Graph
{
    public class Topological
    {
        private IEnumerable order;

        public Topological(Digraph G)
        {
            DirectedCycle cycleFinder = new DirectedCycle(G);
            if (!cycleFinder.hasCycle())
            {
                DepthFirstOrder dfs = new DepthFirstOrder(G);
                order = dfs.getReversePost();
            }
        }

        public IEnumerable getOrder()
        {
            return order;
        }

        public bool isDAG()
        {
            return order != null;
        }
    }
}

