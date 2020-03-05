using NUnit.Framework;
using System.Collections.Generic;

namespace Algorithms.Graph
{
    public class TestDigraph
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
        public void DG_getAdjOf5_4()
        {
            var g = initDG();
            var b = g.adj(5);
            bool res = false;
            foreach (int a in b)
            {
                if (a == 4)
                {
                    res = true;
                }
            }
            Assert.True(res);
        }

        [Test]
        public void DirectedDFS_input2_0to5()
        {
            var g = initDG();
            DirectedDFS d = new DirectedDFS(g, 2);
            string res = "";
            for (int v = 0; v < g.v(); v++)
            {
                if (d.marked(v))
                {
                    res += v;
                    res += " ";
                }
            }
            Assert.AreEqual(res, "0 1 2 3 4 5 ");
        }

        [Test]
        public void DirectedDFS_input1_2_6_output0to6_9to12()
        {
            var g = initDG();
            List<int> source = new List<int>()
            {
                1, 2, 6
            };
            DirectedDFS d = new DirectedDFS(g, source);
            string res = "";
            for (int v = 0; v < g.v(); v++)
            {
                if (d.marked(v))
                {
                    res += v;
                    res += " ";
                }
            }
            Assert.AreEqual(res, "0 1 2 3 4 5 6 9 10 11 12 ");
        }
    }
}

