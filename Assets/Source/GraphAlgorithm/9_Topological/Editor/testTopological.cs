using NUnit.Framework;

namespace Algorithms.Graph
{
    public class testTopological
    {
        private Digraph initDG()
        {
            Digraph g = new Digraph(13);
            g.addEdge(2, 3);
            g.addEdge(0, 6);
            g.addEdge(0, 1);
            g.addEdge(2, 0);
            g.addEdge(11, 12);
            g.addEdge(9, 12);
            g.addEdge(9, 10);
            g.addEdge(9, 11);
            g.addEdge(3, 5);
            g.addEdge(8, 7);
            g.addEdge(5, 4);
            g.addEdge(0, 5);
            g.addEdge(6, 4);
            g.addEdge(6, 9);
            g.addEdge(7, 6);
            return g;
        }

        [Test]
        public void Topological_getSort_first8()
        {
            var g = initDG();
            var top = new Topological(g);
            var order = new int[g.v()];
            var i = 0;
            foreach (int v in top.getOrder())
            {
                order[i++] = v;
            }
            var res = order[0];
            Assert.AreEqual(res, 8);
        }
    }
}

