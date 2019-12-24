using System;
using NUnit.Framework;

namespace Algorithms.Foundations
{
    public class TestFixedCapacityStack
    {
        private class FakeGameObject
        {
            public string Name { get; set; }

            public FakeGameObject(string name)
            {
                this.Name = name;
            }
        }
        [Test]
        public void FixedCapacityStack_PushAndPopFakeGameObject_TheSameName()
        {
            IFixedCapacityStack<FakeGameObject> a = new FixedCapacityStack<FakeGameObject>(10);

            a.push(new FakeGameObject("first"));

            var res = a.pop();

            Assert.AreEqual("first", res.Name);
        }

        [Test]
        public void FixedCapacityStack_AddMoreItems_ResultsOverflow()
        {
            IFixedCapacityStack<FakeGameObject> a = new FixedCapacityStack<FakeGameObject>(1);

            a.push(new FakeGameObject("first"));

            Assert.That(()=>a.push(new FakeGameObject("second")),
                Throws.TypeOf<IndexOutOfRangeException>());
        }
    }
}

