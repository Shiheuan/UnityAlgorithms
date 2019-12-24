using System;
using NUnit.Framework;

namespace Algorithms.Foundations
{
    public class TestFixedCapacityStackOfStrings
    {
        [Test]
        public void FixedCapacityStackOfStringsUsage()
        {
            IFixedCapacityStringStack stack = new FixedCapacityCapacityStackOfStrings(100);
            stack.push("to");
            Assert.AreEqual("to", stack.pop());
            stack.push("be");
            stack.push("or");
            stack.push("not");
            stack.push("to");
            stack.push("be");
            Assert.AreEqual("be",stack.pop());
            Assert.AreEqual("to", stack.pop());
            Assert.AreEqual(3, stack.size());
            Assert.AreEqual(false, stack.isEmpty());
        }

        [Test]
        //[ExpectedException(typeof(IndexOutOfRangeException))]
        public void FixedCapacityStackOfStringsOverflow()
        {
            IFixedCapacityStringStack stack = new FixedCapacityCapacityStackOfStrings(1);
            stack.push("readyToOverflow");
            Assert.That(() => stack.push("overflow"),
                Throws.TypeOf<IndexOutOfRangeException>());
        }
    }

}

