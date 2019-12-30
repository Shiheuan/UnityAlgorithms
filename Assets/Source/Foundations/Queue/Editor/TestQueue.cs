using System;
using NUnit.Framework;

namespace Algorithms.Foundations
{
    public class TestQueue
    {
        [Test]
        public void Queue_EnDequeue_SomeObject()
        {
            IQueue<object> queue = new Queue<object>();

            var ob = new Object();
            queue.enqueue(ob);
            var res = queue.dequeue();

            Assert.AreSame(ob, res);
        }
    }
}

