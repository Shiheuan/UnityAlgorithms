using System;
using NUnit.Framework;

namespace Algorithms.Foundations
{
    public class TestBag
    {
        [Test]
        public void Bag_AddItem_SameAsAdd()
        {
            IBag<object> bag = new Bag<object>();
            var ob = new object();
            bag.add(ob);
            object res = null;
            foreach (var v in bag)
            {
                res = v;
            }
            
            Assert.AreSame(ob, res);
        }
    }
}

