using System;
using NUnit.Framework;

namespace Algorithms.Sorting
{
    public class TestHeap
    {
        [Test]
        public void sort_InputStringArray_ConstructHeap()
        {
            string[] s = { "S", "O", "R", "T", "E", "X", "A", "M", "P", "L", "E" };
            MaxPQ<string> pq = new MaxPQ<string>(s);
            Assert.AreEqual(pq.max(), "X");
        }

        [Test]
        public void sort_InputStringArray_DelMaxSink()
        {
            string[] s = { "S", "O", "R", "T", "E", "X", "A", "M", "P", "L", "E" };
            MaxPQ<string> pq = new MaxPQ<string>(s);
            pq.delMax();
            Assert.AreEqual(pq.max(), "T");
        }
    }
}

