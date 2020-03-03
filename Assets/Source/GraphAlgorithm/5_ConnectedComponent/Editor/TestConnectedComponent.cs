using NUnit.Framework;

namespace Algorithms.Graph
{
    public class TestConnectedComponent
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
        public void CC_is11and12Connected_true()
        {
            var g = initGraph();
            var c = new ConnectedComponent(g);
            var res = c.connected(11, 12);
            Assert.IsTrue(res);
        }

        [Test]
        public void CC_count_is3()
        {
            var g = initGraph();
            var c = new ConnectedComponent(g);
            var res = c.getCount();
            Assert.AreEqual(res, 3);
        }
    }
}

