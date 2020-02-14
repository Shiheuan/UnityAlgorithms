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
    }
}

