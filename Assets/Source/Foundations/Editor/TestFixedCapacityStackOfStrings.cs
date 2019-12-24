using System;
using NUnit.Framework;

namespace Algorithms.Foundations
{
    public class TestFixedCapacityStackOfStrings
    {
        [Test]
        public void FixedCapacityStackOfStrings_PushAndPopString_SameString()
        {
            IFixedCapacityStringStack stack = new FixedCapacityCapacityStackOfStrings(1);
            stack.push("to");
            var res = stack.pop();

            Assert.AreEqual("to", res);
        }

        [Test]
        //[ExpectedException(typeof(IndexOutOfRangeException))]
        public void FixedCapacityStackOfStrings_AddMoreThanCapacity_ResultsOverflow()
        {
            IFixedCapacityStringStack stack = new FixedCapacityCapacityStackOfStrings(1);
            stack.push("readyToOverflow");

            Assert.That(() => stack.push("overflow"),
                Throws.TypeOf<IndexOutOfRangeException>());
        }
    }

}

