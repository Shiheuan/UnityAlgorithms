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
    }
}

