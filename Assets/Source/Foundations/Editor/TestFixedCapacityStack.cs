using System;
using NUnit.Framework;
using UnityEngine;

namespace Algorithms.Foundations
{
    public class TestFixedCapacityStack
    {
        [Test]
        public void TestFixedCapacityStackUsage()
        {
            IFixedCapacityStack<GameObject> a;
            a = new FixedCapacityStack<GameObject>(10);
            a.push(new GameObject("first"));
            Assert.AreEqual("first", a.pop().name);
        }

        [Test]
        public void TestFixedCapacityStackOverflow()
        {
            IFixedCapacityStack<GameObject> a;
            a = new FixedCapacityStack<GameObject>(1);
            a.push(new GameObject("first"));
            Assert.That(()=>a.push(new GameObject("second")),
                Throws.TypeOf<IndexOutOfRangeException>());
        }
    }
}

