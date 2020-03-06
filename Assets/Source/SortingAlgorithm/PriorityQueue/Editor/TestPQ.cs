using NUnit.Framework;

namespace Algorithms.Sorting
{
    public class TestPQ
    {
        [Test]
        public void swim_add123_MaxIs3()
        {
            var pq = new MaxPriorityQueue<double>(5);
            pq.insert(1);
            pq.insert(2);
            pq.insert(3);
            var res = pq.delMax();
            Assert.AreEqual(res, 3);
        }

        public IndexMinPQ<string> initIndexMinPQ()
        {
            var pq = new IndexMinPQ<string>(9);
            pq.insert(1, "P");
            pq.insert(2, "Q");
            pq.insert(3, "E");
            pq.insert(4, "X");
            pq.insert(5, "A");
            pq.insert(6, "M");
            pq.insert(7, "P");
            pq.insert(8, "L");
            pq.insert(9, "E");

            return pq;
        }

        [Test]
        public void IndexMinPQ_DelMinTwice_Index3()
        {
            var pq = initIndexMinPQ();
            pq.delMin();
            var res = pq.delMin();
            Assert.AreEqual(res, 3);
        }
    }
}

