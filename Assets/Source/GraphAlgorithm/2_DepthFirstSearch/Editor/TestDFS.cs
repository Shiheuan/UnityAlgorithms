using NUnit.Framework;

namespace Algorithms.Graph
{
    public class TestDFS
    {
        // todo: read from local file.
        private Graph initGraph()
        {
            var g = new Graph(13);
            g.addEdge(0, 5);
            g.addEdge(4, 3);
            g.addEdge(0, 1);
            g.addEdge(9, 12);
            g.addEdge(6, 4);
            g.addEdge(5, 4);
            g.addEdge(0, 2);
            g.addEdge(11, 12);
            g.addEdge(9, 10);
            g.addEdge(0, 6);
            g.addEdge(7, 8);
            g.addEdge(9, 11);
            g.addEdge(5, 3);
            return g;
        }

        [Test]
        public void DFS_NumofEdges_is13()
        {
            var g = initGraph();
            var res = g.e();
            Assert.AreEqual(res, 13);
        }

        [Test]
        public void DFS_0connect5_true()
        {
            var g = initGraph();
            var dfs = new DepthFirstSearch(g, 0);
            var res = dfs.marked(5);
            Assert.True(res);
        }

        [Test]
        public void DFS_hasCycle_true()
        {
            var g = initGraph();
            var c = new dfsCycle(g);
            var res = c.getHasCycle();
            Assert.True(res);
        }

        [Test]
        public void DFS_isBipartite_false()
        {
            var g = initGraph();
            var c = new dfsTwoColor(g);
            var res = c.isBipartite();
            Assert.False(res);
        }
    }
}

