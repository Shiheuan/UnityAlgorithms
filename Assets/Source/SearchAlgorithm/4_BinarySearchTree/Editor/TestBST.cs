using NUnit.Framework;

namespace Algorithms.Search
{
    public class TestBST
    {
        //keys: S E A R C H E X A M P  L  E
        //vals: 0 1 2 3 4 5 6 7 8 9 10 11 12
        private BST<string, int> initST()
        {
            var st = new BST<string, int>();
            st.put("S", 0);
            st.put("E", 1);
            st.put("A", 2);
            st.put("R", 3);
            st.put("C", 4);
            st.put("H", 5);
            st.put("E", 6);
            st.put("X", 7);
            st.put("A", 8);
            st.put("M", 9);
            st.put("P", 10);
            st.put("L", 11);
            st.put("E", 12);
            return st;
        }
        [Test]
        public void BST_size_sizeIs10()
        {
            var st = initST();
            var res = st.size();
            Assert.AreEqual(res, 10);
        }

        [Test]
        public void BST_min_A()
        {
            var st = initST();
            var res = st.min();
            Assert.AreEqual(res, "A");
        }

        [Test]
        public void BST_max_X()
        {
            var st = initST();
            var res = st.max();
            Assert.AreEqual(res, "X");
        }

        [Test]
        public void BST_floorOfD_C()
        {
            var st = initST();
            var res = st.floor("D");
            Assert.AreEqual(res, "C");
        }

        [Test]
        public void BST_selectAt5_L()
        {
            var st = initST();
            var res = st.BSTselect(5);
            Assert.AreEqual(res, "M");
        }

        [Test]
        public void BST_rankOfL_4()
        {
            var st = initST();
            var res = st.rank("L");
            Assert.AreEqual(res, 4);
        }
    }
}
