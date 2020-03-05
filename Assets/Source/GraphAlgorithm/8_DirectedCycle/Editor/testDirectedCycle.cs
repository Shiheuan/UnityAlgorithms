using NUnit.Framework;

namespace Algorithms.Graph
{
    public class testDirectedCycle
    {
        private Digraph initDG()
        {
            Digraph g = new Digraph(13);
            g.addEdge(4, 2);
            g.addEdge(2, 3);
            g.addEdge(3, 2);
            g.addEdge(6, 0);
            g.addEdge(0, 1);
            g.addEdge(2, 0);
            g.addEdge(11, 12);
            g.addEdge(12, 9);
            g.addEdge(9, 10);
            g.addEdge(9, 11);
            g.addEdge(8, 9);
            g.addEdge(10, 12);
            g.addEdge(11, 4);
            g.addEdge(4, 3);
            g.addEdge(3, 5);
            g.addEdge(7, 8);
            g.addEdge(8, 7);
            g.addEdge(5, 4);
            g.addEdge(0, 5);
            g.addEdge(6, 4);
            g.addEdge(6, 9);
            g.addEdge(7, 6);
            return g;
        }

        [Test]
        public void DirectedCycle_hasCycle_true()
        {
            var g = initDG();
            var dc = new DirectedCycle(g);
            var res = dc.hasCycle();
            Assert.True(res);
        }
    }
}

