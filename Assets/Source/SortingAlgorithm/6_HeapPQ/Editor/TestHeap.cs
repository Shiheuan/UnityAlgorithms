using System;
using NUnit.Framework;

namespace Algorithms.Sorting
{
    public class TestHeap
    {
        [Test]
        public void MaxPQ_InputStringArray_ConstructHeap()
        {
            string[] s = { "S", "O", "R", "T", "E", "X", "A", "M", "P", "L", "E" };
            MaxPQ<string> pq = new MaxPQ<string>(s);
            Assert.AreEqual(pq.max(), "X");
        }

        [Test]
        public void MaxPQ_InputStringArray_DelMaxSink()
        {
            string[] s = { "S", "O", "R", "T", "E", "X", "A", "M", "P", "L", "E" };
            MaxPQ<string> pq = new MaxPQ<string>(s);
            pq.delMax();
            Assert.AreEqual(pq.max(), "T");
        }

        [Test]
        public void HeapSort_InputStringArray_AscendingOrder()
        {
            string[] s = { "S", "O", "R", "T", "E", "X", "A", "M", "P", "L", "E" };
            HeapSort.sort(s);
            UnityEngine.Debug.Log(s);
            Assert.True(BaseSort.isSorted(s));
        }
    }
}

