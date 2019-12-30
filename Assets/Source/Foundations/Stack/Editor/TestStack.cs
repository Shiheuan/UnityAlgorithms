using System;
using NUnit.Framework;

namespace Algorithms.Foundations
{
    public class TestStack
    {
        [Test]
        public void Stack_PushAndPop_SameObject()
        {
            IStack<Object> a = new Stack<object>();

            var ob = new object();
            a.push(ob);
            var res = a.pop();

            Assert.AreSame(ob, res);
        }

        [Test]
        public void Stack_Push2IterableGetItem_GetFirstAdd()
        {
            IStack<object> a = new Stack<object>();
            var ob = new object();
            a.push(ob);
            a.push(new object());

            object res = null;
            foreach (var o in a)
            {
                res = o;
            }
            
            Assert.AreSame(ob, res);
        }
    }
}

