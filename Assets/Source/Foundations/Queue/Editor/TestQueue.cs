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

        [Test]
        public void Queue_Enqueue2IterableGetItem_GetLastAdd()
        {
            IQueue<object> a = new Queue<object>();
            var ob = new object();
            a.enqueue(new object());
            a.enqueue(ob);

            object res = null;
            foreach (var o in a)
            {
                res = o;
            }

            Assert.AreSame(res, ob);
        }
    }
}

