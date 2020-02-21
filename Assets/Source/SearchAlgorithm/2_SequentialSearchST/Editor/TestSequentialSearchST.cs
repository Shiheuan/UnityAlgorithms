using NUnit.Framework;

namespace Algorithms.Search
{
    public class TestSequentialSearchST
    {
        [Test]
        public void SequentialSearchST_putTwice_sizeIs2()
        {
            var st = new SequentialSearchST<string, string>();

            st.put("a", "A");
            st.put("b", "B");
            var res = st.size();
            
            Assert.AreEqual(res, 2);
        }

        [Test]
        public void SequentialSearchST_putAndDelete_sizeIs0()
        {
            var st = new SequentialSearchST<string, string>();

            st.put("a", "A");
            st.delete("a");
            var res = st.size();

            Assert.AreEqual(res, 0);
        }
    }
}

