using System.Collections.Specialized;
using NUnit.Framework;

namespace Algorithms.Foundations
{
    public class TestResizingArrayStack
    {
        private class FakeObject
        {
            public string Name { get; set; }

            public FakeObject(string name)
            {
                this.Name = name;
            }

            public FakeObject()
            {

            }
        }
        [Test]
        public void TestResizingArrayStack_ResizingFrom1_SizeTo2()
        {
            IResizingArrayStack<FakeObject> a = new ResizingArrayStack<FakeObject>(1);
            
            a.push(new FakeObject());
            a.push(new FakeObject());
            
            Assert.AreEqual(2, a.capacity());
        }

        [Test]
        public void TestResizingArrayStack_PopToEmpty_SameSize()
        {
            IResizingArrayStack<FakeObject> a = new ResizingArrayStack<FakeObject>(4);

            a.push(new FakeObject());
            a.pop();

            Assert.AreEqual(4, a.capacity());
        }

        [Test]
        public void TestResizingArrayStack_PushAndPop_SameItemName()
        {
            IResizingArrayStack<FakeObject> a = new ResizingArrayStack<FakeObject>(1);

            a.push(new FakeObject("a1"));
            var res = a.pop();

            Assert.AreEqual("a1", res.Name);
        }
        
    }

}

